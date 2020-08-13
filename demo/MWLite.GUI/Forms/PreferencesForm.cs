using MapWinGIS;
using System;
using System.Windows.Forms;

namespace MWLite.GUI.Forms
{
    public partial class PreferencesForm : Form
    {
        public PreferencesForm()
        {
            InitializeComponent();
            checkBox1.Checked = App.Map.TileProvider != tkTileProvider.ProviderNone;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            AxMapWinGIS.AxMap map = App.Map;
            map.TileProvider = checkBox1.Checked ? tkTileProvider.OpenStreetMap : tkTileProvider.ProviderNone;
            map.Redraw();
        }
    }
}
