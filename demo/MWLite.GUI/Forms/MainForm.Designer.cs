using System.ComponentModel;
using System.Windows.Forms;

namespace MWLite.GUI.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            WeifenLuo.WinFormsUI.Docking.DockPanelSkin dockPanelSkin1 = new WeifenLuo.WinFormsUI.Docking.DockPanelSkin();
            WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin autoHideStripSkin1 = new WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin();
            WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient1 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient1 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin dockPaneStripSkin1 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin();
            WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient dockPaneStripGradient1 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient2 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient2 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient3 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient dockPaneStripToolWindowGradient1 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient4 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient5 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient3 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient6 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient7 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this._mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolZoomIn = new System.Windows.Forms.ToolStripButton();
            this.toolZoomOut = new System.Windows.Forms.ToolStripButton();
            this.toolPan = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolSelect = new System.Windows.Forms.ToolStripButton();
            this.toolZoomToSelected = new System.Windows.Forms.ToolStripButton();
            this.toolZoomToLayer = new System.Windows.Forms.ToolStripButton();
            this.toolClearSelection = new System.Windows.Forms.ToolStripButton();
            this._menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSelectMapsFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveProject = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCloseApp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSelections = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClearSelection = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNavigate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuZoomIn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuZoomOut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuZoomToLayer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusSelectedCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblProgressMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripPanel1 = new System.Windows.Forms.ToolStripPanel();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.dockPanel1 = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.mnuZoomToSelected = new System.Windows.Forms.ToolStripMenuItem();
            this._mainToolStrip.SuspendLayout();
            this._menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _mainToolStrip
            // 
            this._mainToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this._mainToolStrip.ImageScalingSize = new System.Drawing.Size(38, 38);
            this._mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolZoomIn,
            this.toolZoomOut,
            this.toolPan,
            this.toolStripSeparator10,
            this.toolSelect,
            this.toolZoomToSelected,
            this.toolZoomToLayer,
            this.toolClearSelection});
            this._mainToolStrip.Location = new System.Drawing.Point(3, 0);
            this._mainToolStrip.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this._mainToolStrip.Name = "_mainToolStrip";
            this._mainToolStrip.Padding = new System.Windows.Forms.Padding(0);
            this._mainToolStrip.Size = new System.Drawing.Size(329, 55);
            this._mainToolStrip.TabIndex = 0;
            this._mainToolStrip.Text = "toolStrip1";
            // 
            // toolZoomIn
            // 
            this.toolZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolZoomIn.Image = global::Resources.GlobalResources._01noun_Zoom_In_2758630;
            this.toolZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolZoomIn.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.toolZoomIn.Name = "toolZoomIn";
            this.toolZoomIn.Padding = new System.Windows.Forms.Padding(5);
            this.toolZoomIn.Size = new System.Drawing.Size(52, 53);
            this.toolZoomIn.Text = "Zoom in (+ key)";
            // 
            // toolZoomOut
            // 
            this.toolZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolZoomOut.Image = global::Resources.GlobalResources._02noun_Zoom_Out_2758617;
            this.toolZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolZoomOut.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.toolZoomOut.Name = "toolZoomOut";
            this.toolZoomOut.Padding = new System.Windows.Forms.Padding(5);
            this.toolZoomOut.Size = new System.Drawing.Size(52, 53);
            this.toolZoomOut.Text = "Zoom out (- key)";
            // 
            // toolPan
            // 
            this.toolPan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolPan.Image = global::Resources.GlobalResources._04noun_Hand_640765;
            this.toolPan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPan.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.toolPan.Name = "toolPan";
            this.toolPan.Padding = new System.Windows.Forms.Padding(5);
            this.toolPan.Size = new System.Drawing.Size(52, 53);
            this.toolPan.Text = "Pan (Hold space key)";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 55);
            // 
            // toolSelect
            // 
            this.toolSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSelect.Image = global::Resources.GlobalResources._05noun_sent_2557483;
            this.toolSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSelect.Name = "toolSelect";
            this.toolSelect.Padding = new System.Windows.Forms.Padding(5);
            this.toolSelect.Size = new System.Drawing.Size(52, 52);
            this.toolSelect.Text = "Select by rectangle (A)";
            // 
            // toolZoomToSelected
            // 
            this.toolZoomToSelected.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolZoomToSelected.Image = global::Resources.GlobalResources._06noun_minimize_2758631;
            this.toolZoomToSelected.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolZoomToSelected.Name = "toolZoomToSelected";
            this.toolZoomToSelected.Padding = new System.Windows.Forms.Padding(5);
            this.toolZoomToSelected.Size = new System.Drawing.Size(52, 52);
            this.toolZoomToSelected.Text = "Zoom To Selected (Ctrl+=)";
            // 
            // toolZoomToLayer
            // 
            this.toolZoomToLayer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolZoomToLayer.Image = global::Resources.GlobalResources._03noun_Log_Out_2458064;
            this.toolZoomToLayer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolZoomToLayer.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.toolZoomToLayer.Name = "toolZoomToLayer";
            this.toolZoomToLayer.Padding = new System.Windows.Forms.Padding(5);
            this.toolZoomToLayer.Size = new System.Drawing.Size(52, 53);
            this.toolZoomToLayer.Text = "Zoom to max extents (Home key)";
            // 
            // toolClearSelection
            // 
            this.toolClearSelection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolClearSelection.Image = global::Resources.GlobalResources._07noun_Delete_2458056;
            this.toolClearSelection.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolClearSelection.Name = "toolClearSelection";
            this.toolClearSelection.Padding = new System.Windows.Forms.Padding(5);
            this.toolClearSelection.Size = new System.Drawing.Size(52, 52);
            this.toolClearSelection.Text = "Clear Selection (Ctrl+Backspace)";
            this.toolClearSelection.Visible = false;
            // 
            // _menuStrip1
            // 
            this._menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuSelections,
            this.mnuNavigate,
            this.mnuHelp});
            this._menuStrip1.Location = new System.Drawing.Point(0, 0);
            this._menuStrip1.Name = "_menuStrip1";
            this._menuStrip1.Size = new System.Drawing.Size(1010, 28);
            this._menuStrip1.TabIndex = 2;
            this._menuStrip1.Text = "_menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSelectMapsFolder,
            this.mnuSaveProject,
            this.toolStripSeparator2,
            this.mnuCloseApp});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(44, 24);
            this.mnuFile.Text = "File";
            // 
            // mnuSelectMapsFolder
            // 
            this.mnuSelectMapsFolder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuSelectMapsFolder.Name = "mnuSelectMapsFolder";
            this.mnuSelectMapsFolder.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuSelectMapsFolder.Size = new System.Drawing.Size(261, 26);
            this.mnuSelectMapsFolder.Text = "Select maps folder";
            // 
            // mnuSaveProject
            // 
            this.mnuSaveProject.Name = "mnuSaveProject";
            this.mnuSaveProject.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuSaveProject.Size = new System.Drawing.Size(261, 26);
            this.mnuSaveProject.Text = "Save changes";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(258, 6);
            // 
            // mnuCloseApp
            // 
            this.mnuCloseApp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuCloseApp.Name = "mnuCloseApp";
            this.mnuCloseApp.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuCloseApp.Size = new System.Drawing.Size(261, 26);
            this.mnuCloseApp.Text = "Exit";
            // 
            // mnuSelections
            // 
            this.mnuSelections.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSelect,
            this.mnuClearSelection});
            this.mnuSelections.Name = "mnuSelections";
            this.mnuSelections.Size = new System.Drawing.Size(61, 24);
            this.mnuSelections.Text = "Select";
            // 
            // mnuSelect
            // 
            this.mnuSelect.Name = "mnuSelect";
            this.mnuSelect.ShortcutKeyDisplayString = "A";
            this.mnuSelect.Size = new System.Drawing.Size(229, 26);
            this.mnuSelect.Text = "Select by rectangle";
            // 
            // mnuClearSelection
            // 
            this.mnuClearSelection.Name = "mnuClearSelection";
            this.mnuClearSelection.ShortcutKeyDisplayString = "";
            this.mnuClearSelection.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.mnuClearSelection.Size = new System.Drawing.Size(261, 26);
            this.mnuClearSelection.Text = "Clear selection";
            // 
            // mnuNavigate
            // 
            this.mnuNavigate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuZoomIn,
            this.mnuZoomOut,
            this.mnuZoomToSelected,
            this.mnuZoomToLayer,
            this.mnuPan});
            this.mnuNavigate.Name = "mnuNavigate";
            this.mnuNavigate.Size = new System.Drawing.Size(81, 24);
            this.mnuNavigate.Text = "Navigate";
            // 
            // mnuZoomIn
            // 
            this.mnuZoomIn.Name = "mnuZoomIn";
            this.mnuZoomIn.ShortcutKeyDisplayString = "+";
            this.mnuZoomIn.Size = new System.Drawing.Size(275, 26);
            this.mnuZoomIn.Text = "Zoom in";
            // 
            // mnuZoomOut
            // 
            this.mnuZoomOut.Name = "mnuZoomOut";
            this.mnuZoomOut.ShortcutKeyDisplayString = "-";
            this.mnuZoomOut.Size = new System.Drawing.Size(275, 26);
            this.mnuZoomOut.Text = "Zoom out";
            // 
            // mnuZoomToLayer
            // 
            this.mnuZoomToLayer.Name = "mnuZoomToLayer";
            this.mnuZoomToLayer.ShortcutKeyDisplayString = "Home";
            this.mnuZoomToLayer.Size = new System.Drawing.Size(275, 26);
            this.mnuZoomToLayer.Text = "Zoom to max extents";
            // 
            // mnuPan
            // 
            this.mnuPan.Name = "mnuPan";
            this.mnuPan.ShortcutKeyDisplayString = "Space+Click drag";
            this.mnuPan.Size = new System.Drawing.Size(275, 26);
            this.mnuPan.Text = "Pan";
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(53, 24);
            this.mnuHelp.Text = "Help";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(125, 26);
            this.mnuAbout.Text = "About";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusSelectedCount,
            this.lblProgressMessage,
            this.progressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 589);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1010, 25);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusSelectedCount
            // 
            this.statusSelectedCount.Name = "statusSelectedCount";
            this.statusSelectedCount.Size = new System.Drawing.Size(995, 20);
            this.statusSelectedCount.Spring = true;
            this.statusSelectedCount.Text = "Selected: 0";
            this.statusSelectedCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProgressMessage
            // 
            this.lblProgressMessage.Name = "lblProgressMessage";
            this.lblProgressMessage.Size = new System.Drawing.Size(0, 20);
            // 
            // progressBar1
            // 
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 19);
            this.progressBar1.Visible = false;
            // 
            // toolStripPanel1
            // 
            this.toolStripPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolStripPanel1.Location = new System.Drawing.Point(0, 28);
            this.toolStripPanel1.MaximumSize = new System.Drawing.Size(0, 40);
            this.toolStripPanel1.Name = "toolStripPanel1";
            this.toolStripPanel1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.toolStripPanel1.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.toolStripPanel1.Size = new System.Drawing.Size(1010, 0);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dockPanel1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1010, 506);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 28);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1010, 561);
            this.toolStripContainer1.TabIndex = 5;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this._mainToolStrip);
            // 
            // dockPanel1
            // 
            this.dockPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel1.DockBackColor = System.Drawing.SystemColors.Control;
            this.dockPanel1.DocumentStyle = WeifenLuo.WinFormsUI.Docking.DocumentStyle.DockingSdi;
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.Size = new System.Drawing.Size(1010, 506);
            dockPanelGradient1.EndColor = System.Drawing.SystemColors.ControlLight;
            dockPanelGradient1.StartColor = System.Drawing.SystemColors.ControlLight;
            autoHideStripSkin1.DockStripGradient = dockPanelGradient1;
            tabGradient1.EndColor = System.Drawing.SystemColors.Control;
            tabGradient1.StartColor = System.Drawing.SystemColors.Control;
            tabGradient1.TextColor = System.Drawing.SystemColors.ControlDarkDark;
            autoHideStripSkin1.TabGradient = tabGradient1;
            autoHideStripSkin1.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            dockPanelSkin1.AutoHideStripSkin = autoHideStripSkin1;
            tabGradient2.EndColor = System.Drawing.SystemColors.ControlLightLight;
            tabGradient2.StartColor = System.Drawing.SystemColors.ControlLightLight;
            tabGradient2.TextColor = System.Drawing.SystemColors.ControlText;
            dockPaneStripGradient1.ActiveTabGradient = tabGradient2;
            dockPanelGradient2.EndColor = System.Drawing.SystemColors.Control;
            dockPanelGradient2.StartColor = System.Drawing.SystemColors.Control;
            dockPaneStripGradient1.DockStripGradient = dockPanelGradient2;
            tabGradient3.EndColor = System.Drawing.SystemColors.ControlLight;
            tabGradient3.StartColor = System.Drawing.SystemColors.ControlLight;
            tabGradient3.TextColor = System.Drawing.SystemColors.ControlText;
            dockPaneStripGradient1.InactiveTabGradient = tabGradient3;
            dockPaneStripSkin1.DocumentGradient = dockPaneStripGradient1;
            dockPaneStripSkin1.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            tabGradient4.EndColor = System.Drawing.SystemColors.ActiveCaption;
            tabGradient4.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            tabGradient4.StartColor = System.Drawing.SystemColors.GradientActiveCaption;
            tabGradient4.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            dockPaneStripToolWindowGradient1.ActiveCaptionGradient = tabGradient4;
            tabGradient5.EndColor = System.Drawing.SystemColors.Control;
            tabGradient5.StartColor = System.Drawing.SystemColors.Control;
            tabGradient5.TextColor = System.Drawing.SystemColors.ControlText;
            dockPaneStripToolWindowGradient1.ActiveTabGradient = tabGradient5;
            dockPanelGradient3.EndColor = System.Drawing.SystemColors.ControlLight;
            dockPanelGradient3.StartColor = System.Drawing.SystemColors.ControlLight;
            dockPaneStripToolWindowGradient1.DockStripGradient = dockPanelGradient3;
            tabGradient6.EndColor = System.Drawing.SystemColors.GradientInactiveCaption;
            tabGradient6.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            tabGradient6.StartColor = System.Drawing.SystemColors.GradientInactiveCaption;
            tabGradient6.TextColor = System.Drawing.SystemColors.ControlText;
            dockPaneStripToolWindowGradient1.InactiveCaptionGradient = tabGradient6;
            tabGradient7.EndColor = System.Drawing.Color.Transparent;
            tabGradient7.StartColor = System.Drawing.Color.Transparent;
            tabGradient7.TextColor = System.Drawing.SystemColors.ControlDarkDark;
            dockPaneStripToolWindowGradient1.InactiveTabGradient = tabGradient7;
            dockPaneStripSkin1.ToolWindowGradient = dockPaneStripToolWindowGradient1;
            dockPanelSkin1.DockPaneStripSkin = dockPaneStripSkin1;
            this.dockPanel1.Skin = dockPanelSkin1;
            this.dockPanel1.TabIndex = 0;
            // 
            // mnuZoomToSelected
            // 
            this.mnuZoomToSelected.Name = "mnuZoomToSelected";
            this.mnuZoomToSelected.ShortcutKeyDisplayString = "Ctrl+=";
            this.mnuZoomToSelected.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
            this.mnuZoomToSelected.Size = new System.Drawing.Size(275, 26);
            this.mnuZoomToSelected.Text = "Zoom to selected";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1010, 614);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStripPanel1);
            this.Controls.Add(this._menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this._menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this._mainToolStrip.ResumeLayout(false);
            this._mainToolStrip.PerformLayout();
            this._menuStrip1.ResumeLayout(false);
            this._menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip _mainToolStrip;
        private MenuStrip _menuStrip1;
        private ToolStripMenuItem mnuFile;
        private StatusStrip statusStrip1;
        private ToolStripButton toolZoomIn;
        private ToolStripButton toolZoomOut;
        private ToolStripButton toolPan;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripPanel toolStripPanel1;
        private ToolStripContainer toolStripContainer1;
        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel1;
        private ToolStripProgressBar progressBar1;
        private ToolStripStatusLabel lblProgressMessage;
        private ToolStripStatusLabel statusSelectedCount;
        private ToolStripButton toolClearSelection;
        private ToolStripButton toolZoomToSelected;
        private ToolStripMenuItem mnuCloseApp;
        private ToolStripMenuItem mnuSelectMapsFolder;
        private ToolStripSeparator toolStripSeparator10;
        private ToolStripButton toolSelect;
        private ToolStripMenuItem mnuSelections;
        private ToolStripMenuItem mnuSelect;
        private ToolStripMenuItem mnuClearSelection;
        private ToolStripMenuItem mnuNavigate;
        private ToolStripMenuItem mnuZoomIn;
        private ToolStripMenuItem mnuZoomOut;
        private ToolStripMenuItem mnuZoomToLayer;
        private ToolStripMenuItem mnuPan;
        private ToolStripMenuItem mnuSaveProject;
        private ToolStripMenuItem mnuHelp;
        private ToolStripMenuItem mnuAbout;
        private ToolStripButton toolZoomToLayer;
        private ToolStripMenuItem mnuZoomToSelected;
    }
}

