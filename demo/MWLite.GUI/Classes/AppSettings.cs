using MWLite.Core.UI;
using MWLite.GUI.Helpers;
using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace MWLite.GUI.Classes
{
    [Serializable]
    public class AppSettings : INotifyPropertyChanged
    {
        public AppSettings()
        {
            BingApiKey = "";
            LastProject = "";
            MapFoldersPath = "w:\\my drive\\";
            ShowShapeAreaWhileEditing = false;
            ShowOpenStreetMaps = false;
        }

        private bool _showTooltip;
        public bool ShowTooltip
        {
            get => _showTooltip;
            set
            {
                if (value != _showTooltip)
                {
                    _showTooltip = value;
                    OnPropertyChange();
                }
            }
        }

        private string _lastProject;
        public string LastProject
        {
            get => _lastProject;
            set
            {
                if (value != _lastProject)
                {
                    _lastProject = value;
                    OnPropertyChange();
                }
            }
        }

        private string _bingApiKey;
        public string BingApiKey
        {
            get => _bingApiKey;
            set
            {
                if (value != _bingApiKey)
                {
                    _bingApiKey = value;
                    OnPropertyChange();
                }
            }
        }

        private string _mapFoldersPath;
        public string MapFoldersPath
        {
            get => _mapFoldersPath;
            set
            {
                if (value != _mapFoldersPath)
                {
                    _mapFoldersPath = value;
                    OnPropertyChange();
                }
            }
        }

        private bool _showShapeAreaWhileEditing;
        public bool ShowShapeAreaWhileEditing
        {
            get => _showShapeAreaWhileEditing;
            set
            {
                if (value != _showShapeAreaWhileEditing)
                {
                    _showShapeAreaWhileEditing = value;
                    OnPropertyChange();
                }
            }
        }
        
        private bool _showOpenStreetMaps;
        public bool ShowOpenStreetMaps
        {
            get => _showOpenStreetMaps;
            set
            {
                if (value != _showOpenStreetMaps)
                {
                    _showOpenStreetMaps = value;
                    OnPropertyChange();
                }
            }
        }

        public void Validate()
        {
            // If the map folders path is invalid, remove it all together to avoid further problems.
            try
            {
                var unused = System.IO.Path.GetFullPath(MapFoldersPath);
            }
            catch
            {
                MapFoldersPath = string.Empty;
            }
            if (!System.IO.Directory.Exists(MapFoldersPath))
            {
                MapFoldersPath = string.Empty;
            }

            try
            {
                var unused = System.IO.Path.GetFullPath(LastProject);
            }
            catch
            {
                LastProject = string.Empty;
            }
            if (!System.IO.File.Exists(LastProject))
            {
                LastProject = string.Empty;
            }
        }

        private static AppSettings _settings;

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChange([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public static AppSettings Instance
        {
            get
            {
                if (_settings == null)
                {
                    Deserialize();
                    if (_settings == null)
                    {
                        _settings = new AppSettings();
                    }

                    _settings.Validate();
                }
                return _settings;
            }
        }

        private static void Deserialize()
        {
            if (File.Exists(PathHelper.GetSettingsPath()))
            {
                var ser = new XmlSerializer(typeof(AppSettings));
                using (var stream = new FileStream(PathHelper.GetSettingsPath(), FileMode.Open))
                {
                    _settings = ser.Deserialize(stream) as AppSettings;
                }
            }
        }

        public static void Save()
        {
            try
            {
                var sett = Instance;
                if (_settings != null)
                {
                    var ser = new XmlSerializer(typeof(AppSettings));
                    using (var stream = new FileStream(PathHelper.GetSettingsPath(), FileMode.Create))
                    {
                        ser.Serialize(stream, _settings);
                        stream.Flush();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageHelper.Info("Failed to save app settings: " + ex.Message);
            }
        }
    }
}
