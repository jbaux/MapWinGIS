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
            AppSettings.Instance.ShowOpenStreetMaps = chbOpenStreetMap.Checked;
            AppSettings.Save();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            AppSettings.Instance.ShowShapeAreaWhileEditing = chbShapeArea.Checked;
            AppSettings.Save();
        }
    }
}
