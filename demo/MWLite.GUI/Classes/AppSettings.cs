using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using MWLite.Core.UI;
using MWLite.GUI.Helpers;

namespace MWLite.GUI.Classes
{
    [Serializable]
    public class AppSettings
    {
        public AppSettings()
        {
            BingApiKey = "";
            LastProject = "";
            ShowTooltip = true;
            MapFoldersPath = "w:\\my drive\\";
            ShowShapeAreaWhileEditing = false;
            ShowOpenStreetMaps = false;
        }

        public bool ShowTooltip { get; set; }
        public string LastProject { get; set;}
        public string BingApiKey { get; set; }
        public string MapFoldersPath { get; set; }
        public bool ShowShapeAreaWhileEditing { get; set; }
        public bool ShowOpenStreetMaps { get; set; }

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

        public static AppSettings Instance
        {
            get
            {
                if (_settings == null)
                {
                    Deserialize();
                    if (_settings == null) _settings = new AppSettings();
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
