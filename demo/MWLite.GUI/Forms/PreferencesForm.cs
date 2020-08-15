using MapWinGIS;
using MWLite.GUI.Classes;
using System;
using System.Windows.Forms;

namespace MWLite.GUI.Forms
{
    public partial class PreferencesForm : Form
    {
        public PreferencesForm()
        {
            InitializeComponent();
            chbOpenStreetMap.Checked = AppSettings.Instance.ShowOpenStreetMaps;
            chbShapeArea.Checked = AppSettings.Instance.ShowShapeAreaWhileEditing;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool value = chbOpenStreetMap.Checked;
            AxMapWinGIS.AxMap map = App.Map;
            map.TileProvider = value ? tkTileProvider.OpenStreetMap : tkTileProvider.ProviderNone;
            map.Redraw();
            AppSettings.Instance.ShowOpenStreetMaps = value;
            AppSettings.Save();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            bool value = chbShapeArea.Checked;
            AxMapWinGIS.AxMap map = App.Map;
            map.ShapeEditor.ShowArea = value;
            map.Redraw();
            AppSettings.Instance.ShowShapeAreaWhileEditing = value;
            AppSettings.Save();
        }
    }
}
