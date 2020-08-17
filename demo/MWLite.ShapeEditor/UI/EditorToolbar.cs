﻿using System.Linq;
using System.Windows.Forms;
using MapWinGIS;

namespace MWLite.ShapeEditor.UI
{
    public partial class EditorToolbar : UserControl
    {
        public EditorToolbar()
        {
            InitializeComponent();
        }

        public ToolStrip Toolbar
        {
            get { return _editToolStrip; }
        }

        public void RefreshUI()
        {
            int layerHandle = App.Instance.Legend.SelectedLayer;
            bool hasLayer = layerHandle != -1;
            var sf = App.Instance.Map.get_Shapefile(layerHandle);
            bool hasShapefile = sf != null;

            //toolSplitShapes.Enabled = false;
            toolMergeShapes.Enabled = false;
            toolRotateShapes.Enabled = false;

            bool editing = false;
            if (hasShapefile)
            {
                editing = sf.InteractiveEditing;
                int numSelected = sf.NumSelected;
                //toolSplitShapes.Enabled = numSelected > 0;
                toolMergeShapes.Enabled = numSelected > 1;
                toolRotateShapes.Enabled = numSelected > 0;
            }

            var map = App.Instance.Map;
            toolAddShape.Checked = map.CursorMode == tkCursorMode.cmAddShape;
            toolEditShape.Checked = map.CursorMode == tkCursorMode.cmEditShape;
            toolMoveShapes.Checked = map.CursorMode == tkCursorMode.cmMoveShapes;
            toolRotateShapes.Checked = map.CursorMode == tkCursorMode.cmRotateShapes;
            toolSplitByPolyline.Checked = map.CursorMode == tkCursorMode.cmSplitByPolyline;
            toolEraseByPolygon2.Checked = map.CursorMode == tkCursorMode.cmEraseByPolygon;
            toolClipByPolygon.Checked = map.CursorMode == tkCursorMode.cmClipByPolygon;
            toolSplitByPolygon.Checked = map.CursorMode == tkCursorMode.cmSplitByPolygon;
           
            toolUndoCount.Text = string.Format("{0}\\{1}", map.UndoList.UndoCount, map.UndoList.TotalLength);

            toolMergeShapes.Enabled = false;
            //toolSplitShapes.Enabled = false;
            if (sf != null && sf.InteractiveEditing)
            {
                int selectedCount = sf.NumSelected;
                toolMergeShapes.Enabled = selectedCount > 1;
                //toolSplitShapes.Enabled = selectedCount > 0;
                toolMoveShapes.Enabled = selectedCount > 0;
                toolRotateShapes.Enabled = selectedCount > 0;
            }

            var list = new[] { toolUndo, toolRedo };
            foreach (var item in list)
            {
                item.Enabled = StateHelper.GetEnabled(item);
            }
        }

        #region Highlight the delete button and drop-down together
        private void toolRemoveShapes2_MouseHover(object sender, System.EventArgs e)
        {
            dropdownDeleteErase.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
        }

        private void toolRemoveShapes2_MouseLeave(object sender, System.EventArgs e)
        {
            dropdownDeleteErase.BackColor = System.Drawing.SystemColors.Control;
        }

        private void toolRemoveShapes2_MouseEnter(object sender, System.EventArgs e)
        {
            dropdownDeleteErase.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
        }

        private void dropdownDeleteErase_MouseEnter(object sender, System.EventArgs e)
        {
            toolRemoveShapes2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
        }

        private void dropdownDeleteErase_MouseLeave(object sender, System.EventArgs e)
        {
            toolRemoveShapes2.BackColor = System.Drawing.SystemColors.Control;
        }
        #endregion
    }
}
