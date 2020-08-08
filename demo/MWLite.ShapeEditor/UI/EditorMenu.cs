using System;
using System.Windows.Forms;
using MapWinGIS;
using MWLite.ShapeEditor.Helpers;

namespace MWLite.ShapeEditor.UI
{
    public partial class EditorMenu : UserControl
    {
        public EditorMenu()
        {
            InitializeComponent();
            InitShapeEditorOptions();
        }

        private AxMapWinGIS.AxMap Map
        {
            get { return App.Instance.Map;  }
        }

        public ToolStripMenuItem EditMenu
        {
            get { return mnuEdit; }
        }

        public ToolStripMenuItem ShapesEditMenu
        {
            get { return mnuShapesEdit; }
        }

        private void InitShapeEditorOptions()
        {
            mnuEdit.DropDownOpening += mnuShapeEditor_DropDownOpening;
        }

        void mnuShapeEditor_DropDownOpening(object sender, EventArgs e)
        {
            var list = new[] {mnuCopy, mnuPaste, mnuCut, mnuUndo, mnuRedo};
            foreach (var item in list)
            {
                item.Enabled = StateHelper.GetEnabled(item);
            }
        }
    }
}
