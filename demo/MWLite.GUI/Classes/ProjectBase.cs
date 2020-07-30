using System;
using System.IO;
using System.Windows.Forms;
using MWLite.Core;
using MWLite.Core.UI;
using MWLite.GUI.Forms;
using MWLite.GUI.Helpers;

namespace MWLite.GUI.Classes
{
    internal class ProjectBase
    {
        internal static string DEFAULT_GROUP_NAME = "Data Layers";

        public event EventHandler<EventArgs> ProjectChanged;

        protected virtual void OnProjectChanged()
        {
            ProjectChanged?.Invoke(this, new EventArgs());
        }

        internal ProjectBase()
        {
            SetEmptyProject();
        }

        protected string Filename { get; set; }

        private void SetEmptyProject()
        {
            Filename = "";
            OnProjectChanged();
        }

        protected ProjectState State
        {
            get
            {
                if (App.Map.GeoProjection.IsEmpty && App.Map.NumLayers == 0) return ProjectState.Empty;
                
                if (string.IsNullOrWhiteSpace(Filename)) return ProjectState.NotSaved;
                try
                {
                    using (var r = new StreamReader(Filename))
                    {
                        string oldState = r.ReadToEnd();
                        string state = App.Map.SerializeMapState(true, Filename);
                        return state.ToLower() != oldState.ToLower() ? ProjectState.HasChanges : ProjectState.NoChanges;
                    }
                }
                catch
                {
                    return ProjectState.NotSaved;
                }
            }
        }

        protected bool TryCloseProject()
        {
            var state = State;
            switch (state)
            {
                case ProjectState.NotSaved:
                case ProjectState.HasChanges:
                    SaveCurrentProject();
                    break;
                case ProjectState.NoChanges:
                case ProjectState.Empty:
                    break;
            }
            SetEmptyProject();
            return true;
        }

        protected bool SaveCurrentProject()
        {
            string filename = Filename;
            bool newProject = State == ProjectState.NotSaved;
            if (newProject)
            {
                if (!FileHelper.ShowSaveDialog(MainForm.Instance, FileType.Project, ref filename))
                    return false;
            }
           SaveInternal(filename);
           
            if (newProject)
                OnProjectChanged();

            return true;
        }

        protected void SaveProjectAs()
        {
            string filename = Filename;
            if (!FileHelper.ShowSaveDialog(MainForm.Instance, FileType.Project, ref filename))
                return;
            SaveInternal(filename);
            OnProjectChanged();
        }

        private void SaveInternal(string filename)
        {
            var map = App.Map;
            bool savedMapState = map.SaveMapState(filename, relativePaths:true, overwrite:true);
            if (!savedMapState)
            {
                MessageHelper.Warn("Failed to save the map.");
                return;
            }
            Filename = filename;

            var saveFailLayerNames = new System.Collections.Generic.List<string>();
            int layerCount = map.NumLayers;
            for (int i = 0; i < layerCount; i++)
            {
                int layerHandle = map.get_LayerHandle(i);
                MapWinGIS.Shapefile sf = map.get_Shapefile(layerHandle);
                if (sf != null && sf.InteractiveEditing)
                {
                    if (!sf.Save(cBack: null))
                    {
                        saveFailLayerNames.Add(sf.Filename);
                    }
                }
            }

            if (saveFailLayerNames.Count != 0)
            {
                string msg = "Failed to save the layers: ";
                foreach (string name in saveFailLayerNames)
                {
                    msg += $"'{name}'  ";
                }
                MessageHelper.Warn(msg);
            }
        }

        protected void LoadProject(string filename)
        {
            if (string.IsNullOrWhiteSpace(filename)) return;

            if (!File.Exists(filename))
            {
                MessageHelper.Info("The last project file wasn't found: " + filename);
                return;
            }

            App.LoadMapState(filename);
            App.Legend.AssignOrphanLayersToNewGroup(DEFAULT_GROUP_NAME);
            Filename = filename;

            OnProjectChanged();
        }
    }
}
