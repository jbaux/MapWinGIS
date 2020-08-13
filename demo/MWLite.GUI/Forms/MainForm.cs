using AxMapWinGIS;
using MWLite.Symbology.LegendControl;
using MapWinGIS;
using MWLite.Core;
using MWLite.GUI.Classes;
using MWLite.GUI.Helpers;
using MWLite.GUI.MapLegend;
using MWLite.GUI.Properties;
using MWLite.ShapeEditor;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace MWLite.GUI.Forms
{
    public partial class MainForm : DockContent, IMapApp
    {
        private const string WINDOW_TITLE = "Piano Player";
        private readonly AppDispatcher _dispatcher = new AppDispatcher();
        private static MainForm _form = null;
        private MapForm _mapForm = null;
        private LegendDockForm _legendForm = null;
        private MapCallback _callback = null;
        private readonly EventHandler _projSelectChanged = null;
        private readonly ItemCheckEventHandler _projCheckChanged = null;
        private readonly System.Windows.Forms.Timer _autosaveTimer = null;

        public MainForm()
        {
            InitializeComponent();

            _projSelectChanged = new EventHandler(ProjectList_SelectedValueChanged);
            _projCheckChanged = new ItemCheckEventHandler(ProjectList_CheckChanged);
            _autosaveTimer = new System.Windows.Forms.Timer();

            _callback = new MapCallback(statusStrip1, progressBar1, lblProgressMessage);

            _form = this;

            Init();
        }

        #region Initialization

        private void Init()
        {
            InitDockLayout();

            PluginHelper.Init(this);

            ToolStripManager.LoadSettings(this);

            InitLegend();

            InitMenus();

            RefreshUI();

            var gs = new GlobalSettings();
            gs.ApplicationCallback = _callback;

            Shown += (s, e) => Map.Focus();

            FormClosing += MainForm_FormClosing;

            if (string.IsNullOrWhiteSpace(AppSettings.Instance.MapFoldersPath))
            {
                if (!DisplayMapFoldersDialog())
                {
                    Environment.Exit(0);
                }
            }
            string lastProjectPath = AppSettings.Instance.LastProject;

            RefreshProjectList(mapFoldersPath: AppSettings.Instance.MapFoldersPath,  currentProjectPath: lastProjectPath);

            var project = App.Project;
            project.ProjectChanged += (s, e) => {
                if (!project.IsEmpty)
                {
                    App.Map.GrabProjectionFromData = true;
                    
                    // Begin each project with the vector shape file ready for editing.
                    int handle = -1;
                    foreach (var l in App.Legend.Layers)
                    {
                        if (l.Type == Symbology.Classes.eLayerType.PolygonShapefile)
                        {
                            handle = l.Handle;
                        }
                    }
                    App.Legend.SelectedLayer = handle;
                    if (handle != -1)
                    {
                        Shapefile sf = App.Map.get_Shapefile(handle);
                        
                        ColourShapesByOwner(sf);
                        
                        // Begin each project with shape editing enabled, as this is the primary use for the app.
                        sf.InteractiveEditing = true;

                        App.Map.Redraw(); // ensure categories are displayed correctly on first load
                    }

                    // When opening a new map, change the state to in-progress.
                    if (MapState.New == FetchMapState(project.GetPath()))
                    {
                        string projDir = System.IO.Path.GetDirectoryName(project.GetPath());
                        string filePath = System.IO.Path.Combine(projDir, "state");
                        using (var stream = new System.IO.FileStream(filePath, System.IO.FileMode.Create))
                        {
                            stream.WriteByte((byte)'p');
                        }
                        // TODO: instead of refreshing the entire queue, just update the current project
                        RefreshProjectList(AppSettings.Instance.MapFoldersPath, App.Project.GetPath());
                    }

                    AppSettings.Instance.LastProject = project.GetPath();
                    AppSettings.Save(); // TODO: this is a blocking operation and shouldn't be done on the main thread.
                }
                RefreshUI();
            };

            project.Load(lastProjectPath);

            _autosaveTimer.Tick += new EventHandler(AutosaveTick);
            _autosaveTimer.Interval = 5 * 60 * 1000; // 5 minutes
            _autosaveTimer.Start();
        }

        private void ColourShapesByOwner(Shapefile sf)
        {
            sf.DefaultDrawingOptions.FillType = tkFillType.ftStandard;

            Table t = sf.Table;
            int fieldIndex = t.FieldIndexByName["owner"];
            if (fieldIndex == -1)
            {
                bool successEdit = sf.StartEditingTable();
                Debug.Assert(successEdit);
                if (successEdit)
                {
                    fieldIndex = sf.EditAddField("owner", FieldType.INTEGER_FIELD, Precision:0, Width:9);
                    Debug.Assert(fieldIndex != -1);
                    sf.StopEditingShapes(ApplyChanges:false, StopEditTable:true, cBack:null);
                }
            }

            // TODO: don't destroy and re-create categories every time.
            sf.Categories.Clear();
            bool success = sf.Categories.Generate(fieldIndex, tkClassificationType.ctUniqueValues, numClasses:0);  // numClasses is ignored when ctUniqueValues is used.⌈
            Debug.Assert(success);
            sf.Categories.ApplyExpressions();

            // TODO: fix this better
            if (sf.Categories.Count > 1)
            {
                var scheme = new ColorScheme();
                var AI = (uint)ColorTranslator.ToOle(Color.FromArgb(red:192, green:0, blue:255));
                var human = (uint)ColorTranslator.ToOle(Color.FromArgb(red:251, green:176, blue:64));
                scheme.SetColors(AI, human);
                sf.Categories.ApplyColorScheme3(tkColorSchemeType.ctSchemeGraduated, scheme, tkShapeElements.shElementFill, CategoryStartIndex:0, CategoryEndIndex:1);
            }
        }

        private void AutosaveTick(Object s, EventArgs e)
        {
            if (!App.Project.IsEmpty)
            {
                App.Project.Save();
            }
        }

        internal void SelectMapsFolder()
        {
            if (DisplayMapFoldersDialog())
            {
                RefreshProjectList(mapFoldersPath: AppSettings.Instance.MapFoldersPath,  currentProjectPath: "");
            }
        }

        public static bool DisplayMapFoldersDialog()
        {
            var dlg = new FolderBrowserDialog{
                ShowNewFolderButton=false,
                Description="Please select your maps folder. This is usually  w:\\my drive\\username\\",
                SelectedPath=AppSettings.Instance.MapFoldersPath,
                };
            if (DialogResult.OK == dlg.ShowDialog())
            {
                AppSettings.Instance.MapFoldersPath = dlg.SelectedPath;
                return true;
            }
            return false;
        }

        private void RefreshProjectList(string mapFoldersPath, string currentProjectPath)
        {
            IEnumerable<string> projectPaths = System.IO.Directory.EnumerateFiles(
                path: mapFoldersPath,
                searchPattern: "*.mwxml",
                searchOption: System.IO.SearchOption.AllDirectories);
            CheckedListBox projectListControl = _legendForm.Projects;
            projectListControl.ItemCheck -= _projCheckChanged; // Avoid incorrectly changing project completion states
            projectListControl.SelectedValueChanged -= _projSelectChanged; // Avoid triggering a project change
            projectListControl.DisplayMember = "DisplayName";
            projectListControl.ValueMember = "Path";
            var items = projectListControl.Items;
            items.Clear();
            foreach (string p in projectPaths)
            {
                var x = new ProjectDesc(p);
                var state = CheckState.Unchecked;
                MapState s = FetchMapState(p);
                if (s == MapState.Complete)
                {
                    state = CheckState.Checked;
                }
                if (s == MapState.New)
                {
                    x.DisplayName = $"New    {x.DisplayName}";
                }
                items.Add(x, state);
            }

            int? index = null;
            if (!string.IsNullOrWhiteSpace(currentProjectPath))
            {
                int i = 0;
                string normalisedCurrentProjectPath = System.IO.Path.GetFullPath(currentProjectPath);
                foreach (string p in projectPaths)
                {
                    if (normalisedCurrentProjectPath == System.IO.Path.GetFullPath(p))
                    {
                        index = i;
                        break;
                    }
                    i++;
                }
            }

            if (index.HasValue)
            {
                projectListControl.SetSelected(index.Value, true);
            }
            else
            {
                projectListControl.ClearSelected();
            }

            projectListControl.SelectedValueChanged += _projSelectChanged;
            projectListControl.ItemCheck += _projCheckChanged;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string lastProject = App.Project.GetPath();

            if (!App.Map.ShapeEditor.SaveChanges())
            {
                e.Cancel = true;
                return;
            }

            if (!App.Project.TryClose())
            {
                e.Cancel = true;
                return;
            }
            
            AppSettings.Instance.LastProject = lastProject;
            AppSettings.Save();

            ToolStripManager.SaveSettings(this);
        }

        private void InitLegend()
        {
            Legend.Map = Map.GetOcx() as Map;
            Legend.AssignOrphanLayersToNewGroup(ProjectBase.DEFAULT_GROUP_NAME);
            Legend.LayerSelected += (handle) =>
            {
                RefreshUI();
            };
        }

        private void InitMenus()
        {
            Dispatcher.InitMenu(mnuFile.DropDownItems);
            Dispatcher.InitMenu(mnuSelections.DropDownItems);
            Dispatcher.InitMenu(_mainToolStrip.Items);
            Dispatcher.InitMenu(mnuHelp.DropDownItems);
        }

        private void InitDockLayout()
        {
            _legendForm = new LegendDockForm();
            _legendForm.Show(dockPanel1, DockState.DockRight);
            _legendForm.CloseButton = false;

            _mapForm = new MapForm();
            _mapForm.Show(dockPanel1, DockState.Document);
            _mapForm.SelectionChanged += (s, e) => RefreshUI();
            _mapForm.CloseButton = false;
            _mapForm.CloseButtonVisible = false;

            // TODO: delete the donation form

            _mapForm.Activate();

           
        }

        #endregion
       
        #region Properties

        public static MainForm Instance
        {
            get { return _form; }
        }

        internal AppDispatcher Dispatcher
        {
            get { return _dispatcher; }
        }

        public MapForm MapForm
        {
            get { return _mapForm; }
        }

        #endregion

        #region IMapApp interface

        public IProject Project
        {
            get { return App.Project; }
        }

        public void RunCommand(AppCommand command)
        {
            _dispatcher.Run(command);
        }

        public Legend Legend
        {
            get { return _legendForm.Legend; }
        }

        public AxMap Map
        {
            get { return _mapForm.Map; }
        }

        public void LoadMapState(string filename)
        {
            _mapForm.LoadMapState(filename);
        }

        public void AddMenu(ToolStripMenuItem menu, int index)
        {
            MainMenuStrip.Items.Insert(index, menu);
        }

        public void AddToolbar(ToolStrip toolbar)
        {
            toolStripContainer1.TopToolStripPanel.Join(toolbar, _mainToolStrip.Left + _mainToolStrip.Width, 0);
        }

        public void RefreshUI()
        {
            string title = WINDOW_TITLE;
            if (!App.Project.IsEmpty)
                 title += " – " + App.Project.GetPath();
            Text = title;

            var cursorMode = Map.CursorMode;
            toolZoomIn.Checked = cursorMode == tkCursorMode.cmZoomIn;
            toolZoomOut.Checked = cursorMode == tkCursorMode.cmZoomOut;
            toolPan.Checked = cursorMode == tkCursorMode.cmPan;
            toolSelect.Checked = cursorMode == tkCursorMode.cmSelection;

            if (cursorMode != tkCursorMode.cmIdentify)
            {
                MapForm.HideTooltip();
            }

            bool hasShapefile = false;
            int layerHandle = App.Legend.SelectedLayer;
            bool hasLayer = layerHandle != -1;
            if (hasLayer)
            {
                var sf = App.Map.get_Shapefile(layerHandle);
                if (sf != null)
                {
                    statusSelectedCount.Text = string.Format("Shapes: {0}; selected: {1}", sf.NumShapes, sf.NumSelected);
                    toolClearSelection.Enabled = sf.NumSelected > 0;
                    toolZoomToSelected.Enabled = sf.NumSelected > 0;
                    hasShapefile = true;
                }
            }

            if (!hasShapefile)
            {
                statusSelectedCount.Text = "";
                toolClearSelection.Enabled = false;
                toolZoomToSelected.Enabled = false;
            }

            Editor.RefreshUI();

            Map.Focus();
        }

        private void ProjectList_SelectedValueChanged(object sender, EventArgs e)
        {
            var control = (CheckedListBox)sender;
            var projectDesc = (ProjectDesc)control.SelectedItem;
            string selectedProjectPath = projectDesc.Path;
            if (App.Project.IsEmpty
                || System.IO.Path.GetFullPath(App.Project.GetPath()) != System.IO.Path.GetFullPath(selectedProjectPath))
            {
                if (App.Project.TryClose())
                {
                    App.Project.Load(selectedProjectPath);
                }
            }
        }

        
        private void ProjectList_CheckChanged(object sender, ItemCheckEventArgs e)
        {
            if (e.CurrentValue != e.NewValue && e.NewValue != CheckState.Indeterminate)
            {
                var control = (CheckedListBox)sender;
                var item = (ProjectDesc)control.Items[e.Index];
                string name = item.DisplayName;
                string confirmMsg;
                if (e.NewValue == CheckState.Checked)
                {
                    confirmMsg = $"Complete {name}?";
                }
                else
                {
                    confirmMsg = $"Remove the completion of {name}?";
                }

                if (DialogResult.Yes == Core.UI.MessageHelper.Ask(confirmMsg))
                {
                    MarkMapComplete(item.Path, e.NewValue == CheckState.Checked);
                }
                else
                {
                    // Revert the checkbox back to its previous state.

                    int index = e.Index; // Make a private copy of the state, in case the control properties change.
                    CheckState cs = e.CurrentValue;
                    // Don't change the check state until after ProjectList_CheckChanged has returned.
                    BeginInvoke((MethodInvoker)delegate
                    {
                        control.ItemCheck -= _projCheckChanged; // Avoid re-entering ProjectList_CheckChanged
                        control.SetItemCheckState(index, cs);
                        control.ItemCheck += _projCheckChanged;
                    });
                }
            }
        }

        internal void MarkMapComplete(string projectPath, bool complete)
        {
            string projDir = System.IO.Path.GetDirectoryName(projectPath);
            string filePath = System.IO.Path.Combine(projDir, "state");
            using (var stream = new System.IO.FileStream(filePath, System.IO.FileMode.Create))
            {
                stream.WriteByte(complete ? (byte)'c' : (byte)'p');
            }
            RefreshProjectList(AppSettings.Instance.MapFoldersPath, App.Project.GetPath());
        }

        internal enum MapState
        {
            Complete,
            InProgress,
            New,
            Unknown,
        }
        internal MapState FetchMapState(string projectPath)
        {
            string filePath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(projectPath), "state");
            if (!System.IO.File.Exists(filePath))
            {
                return MapState.New;
            }
            char c = '\0';
            using (var stream = new System.IO.FileStream(filePath, System.IO.FileMode.Open))
            {
                c = (char)stream.ReadByte();
                if (c == 'c')
                {
                    return MapState.Complete;
                }
                else if (c == 'n')
                {
                    return MapState.New;
                }
                else if (c == 'p')
                {
                    return MapState.InProgress;
                }
            }

            Debug.Fail($"FetchMapState: unknown state: {c}");
            // Recover from the unknown state problem by returning to "new"
            System.IO.File.Delete(filePath);
            return MapState.New;
        }

        #endregion
    }
}
