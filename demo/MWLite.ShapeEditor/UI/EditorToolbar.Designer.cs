namespace MWLite.ShapeEditor.UI
{
    partial class EditorToolbar
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolUndoCount = new System.Windows.Forms.ToolStripLabel();
            this._editToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolRedo = new System.Windows.Forms.ToolStripButton();
            this.toolUndo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolAddShape = new System.Windows.Forms.ToolStripButton();
            this.toolEditShape = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator25 = new System.Windows.Forms.ToolStripSeparator();
            this.toolMergeShapes = new System.Windows.Forms.ToolStripButton();
            this.toolMoveShapes = new System.Windows.Forms.ToolStripButton();
            this.toolRotateShapes = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator28 = new System.Windows.Forms.ToolStripSeparator();
            this.toolPolygonOperation = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolEraseByPolygon2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolClipByPolygon = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSplitByPolygon = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSplitByPolyline = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator23 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolRemoveShapes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolEraseByPolygon = new System.Windows.Forms.ToolStripMenuItem();
            this._editToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolUndoCount
            // 
            this.toolUndoCount.Name = "toolUndoCount";
            this.toolUndoCount.Padding = new System.Windows.Forms.Padding(5);
            this.toolUndoCount.Size = new System.Drawing.Size(41, 52);
            this.toolUndoCount.Text = "0/0";
            // 
            // _editToolStrip
            // 
            this._editToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this._editToolStrip.ImageScalingSize = new System.Drawing.Size(38, 38);
            this._editToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolUndo,
            this.toolUndoCount,
            this.toolRedo,
            this.toolStripSeparator2,
            this.toolSave,
            this.toolStripSeparator1,
            this.toolAddShape,
            this.toolEditShape,
            this.toolStripSeparator25,
            this.toolMergeShapes,
            this.toolSplitByPolyline,
            this.toolStripSeparator28,
            this.toolMoveShapes,
            this.toolRotateShapes,
            this.toolStripDropDownButton1,
            this.toolPolygonOperation,
            this.toolStripSeparator23});
            this._editToolStrip.Location = new System.Drawing.Point(0, 0);
            this._editToolStrip.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this._editToolStrip.Name = "_editToolStrip";
            this._editToolStrip.Padding = new System.Windows.Forms.Padding(0);
            this._editToolStrip.Size = new System.Drawing.Size(703, 55);
            this._editToolStrip.TabIndex = 2;
            // 
            // toolRedo
            // 
            this.toolRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolRedo.Image = global::Resources.GlobalResources._17noun_redo_2458031;
            this.toolRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolRedo.Name = "toolRedo";
            this.toolRedo.Padding = new System.Windows.Forms.Padding(5);
            this.toolRedo.Size = new System.Drawing.Size(52, 52);
            this.toolRedo.Text = "Redo (Ctrl+Shift+Z)";
            // 
            // toolUndo
            // 
            this.toolUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolUndo.Image = global::Resources.GlobalResources._16noun_Undo_2458027;
            this.toolUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolUndo.Name = "toolUndo";
            this.toolUndo.Padding = new System.Windows.Forms.Padding(5);
            this.toolUndo.Size = new System.Drawing.Size(52, 52);
            this.toolUndo.Text = "Undo (Ctrl+Z)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 55);
            // 
            // toolSave
            // 
            this.toolSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSave.Image = global::Resources.GlobalResources._08noun_Save_2585853;
            this.toolSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSave.Name = "toolSave";
            this.toolSave.Padding = new System.Windows.Forms.Padding(5);
            this.toolSave.Size = new System.Drawing.Size(52, 52);
            this.toolSave.Text = "Save (Ctrl+S)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 55);
            // 
            // toolAddShape
            // 
            this.toolAddShape.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolAddShape.Image = global::Resources.GlobalResources._09noun_Add_Anchor_Point_Tool_764914;
            this.toolAddShape.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAddShape.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.toolAddShape.Name = "toolAddShape";
            this.toolAddShape.Padding = new System.Windows.Forms.Padding(5);
            this.toolAddShape.Size = new System.Drawing.Size(52, 53);
            this.toolAddShape.Text = "Add shape (Ctrl+N)";
            // 
            // toolEditShape
            // 
            this.toolEditShape.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolEditShape.Image = global::Resources.GlobalResources._10noun_transform_2758635;
            this.toolEditShape.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolEditShape.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.toolEditShape.Name = "toolEditShape";
            this.toolEditShape.Padding = new System.Windows.Forms.Padding(5);
            this.toolEditShape.Size = new System.Drawing.Size(52, 53);
            this.toolEditShape.Text = "Edit shape points (Ctrl+E)";
            // 
            // toolStripSeparator25
            // 
            this.toolStripSeparator25.Name = "toolStripSeparator25";
            this.toolStripSeparator25.Size = new System.Drawing.Size(6, 55);
            // 
            // toolMergeShapes
            // 
            this.toolMergeShapes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolMergeShapes.Image = global::Resources.GlobalResources._11noun_merge_2758598;
            this.toolMergeShapes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolMergeShapes.Name = "toolMergeShapes";
            this.toolMergeShapes.Padding = new System.Windows.Forms.Padding(5);
            this.toolMergeShapes.Size = new System.Drawing.Size(52, 52);
            this.toolMergeShapes.Text = "Merge Shapes";
            // 
            // toolMoveShapes
            // 
            this.toolMoveShapes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolMoveShapes.Image = global::Resources.GlobalResources._12noun_Arrow_2458053;
            this.toolMoveShapes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolMoveShapes.Name = "toolMoveShapes";
            this.toolMoveShapes.Padding = new System.Windows.Forms.Padding(5);
            this.toolMoveShapes.Size = new System.Drawing.Size(52, 52);
            this.toolMoveShapes.Text = "Move shapes (Ctrl+M)";
            // 
            // toolRotateShapes
            // 
            this.toolRotateShapes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolRotateShapes.Image = global::Resources.GlobalResources._13noun_Refresh_2458028;
            this.toolRotateShapes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolRotateShapes.Name = "toolRotateShapes";
            this.toolRotateShapes.Padding = new System.Windows.Forms.Padding(5);
            this.toolRotateShapes.Size = new System.Drawing.Size(52, 52);
            this.toolRotateShapes.Text = "Rotate shapes";
            // 
            // toolStripSeparator28
            // 
            this.toolStripSeparator28.Name = "toolStripSeparator28";
            this.toolStripSeparator28.Size = new System.Drawing.Size(6, 55);
            // 
            // toolPolygonOperation
            // 
            this.toolPolygonOperation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolPolygonOperation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolEraseByPolygon2,
            this.toolClipByPolygon,
            this.toolSplitByPolygon});
            this.toolPolygonOperation.Image = global::Resources.GlobalResources._14noun_eraser_2758606;
            this.toolPolygonOperation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPolygonOperation.Name = "toolPolygonOperation";
            this.toolPolygonOperation.Padding = new System.Windows.Forms.Padding(5);
            this.toolPolygonOperation.Size = new System.Drawing.Size(62, 52);
            this.toolPolygonOperation.Text = "Polygon Overlay";
            this.toolPolygonOperation.Visible = false;
            // 
            // toolEraseByPolygon2
            // 
            this.toolEraseByPolygon2.Name = "toolEraseByPolygon2";
            this.toolEraseByPolygon2.Size = new System.Drawing.Size(216, 26);
            this.toolEraseByPolygon2.Text = "Erase By Polygon";
            // 
            // toolClipByPolygon
            // 
            this.toolClipByPolygon.Name = "toolClipByPolygon";
            this.toolClipByPolygon.Size = new System.Drawing.Size(216, 26);
            this.toolClipByPolygon.Text = "Clip By Polygon";
            // 
            // toolSplitByPolygon
            // 
            this.toolSplitByPolygon.Name = "toolSplitByPolygon";
            this.toolSplitByPolygon.Size = new System.Drawing.Size(216, 26);
            this.toolSplitByPolygon.Text = "Split By Polygon";
            // 
            // toolSplitByPolyline
            // 
            this.toolSplitByPolyline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSplitByPolyline.Image = global::Resources.GlobalResources._15noun_Split_Tool_2758633;
            this.toolSplitByPolyline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSplitByPolyline.Name = "toolSplitByPolyline";
            this.toolSplitByPolyline.Padding = new System.Windows.Forms.Padding(5);
            this.toolSplitByPolyline.Size = new System.Drawing.Size(52, 52);
            this.toolSplitByPolyline.Text = "Split by polyline (Ctrl + \\)";
            // 
            // toolStripSeparator23
            // 
            this.toolStripSeparator23.Name = "toolStripSeparator23";
            this.toolStripSeparator23.Size = new System.Drawing.Size(6, 55);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolRemoveShapes,
            this.toolEraseByPolygon});
            this.toolStripDropDownButton1.Image = global::Resources.GlobalResources._07noun_Delete_2458056;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(52, 52);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // toolRemoveShapes
            // 
            this.toolRemoveShapes.Image = global::Resources.GlobalResources._07noun_Delete_2458056;
            this.toolRemoveShapes.Name = "toolRemoveShapes";
            this.toolRemoveShapes.Size = new System.Drawing.Size(234, 44);
            this.toolRemoveShapes.Text = "Delete shapes";
            // 
            // toolEraseByPolygon
            // 
            this.toolEraseByPolygon.Image = global::Resources.GlobalResources._14noun_eraser_2758606;
            this.toolEraseByPolygon.Name = "toolEraseByPolygon";
            this.toolEraseByPolygon.Size = new System.Drawing.Size(234, 44);
            this.toolEraseByPolygon.Text = "Erase by shape";
            // 
            // EditorToolbar
            // 
            this.Controls.Add(this._editToolStrip);
            this.Name = "EditorToolbar";
            this.Size = new System.Drawing.Size(1102, 55);
            this._editToolStrip.ResumeLayout(false);
            this._editToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripButton toolAddShape;
        private System.Windows.Forms.ToolStripButton toolMergeShapes;
        private System.Windows.Forms.ToolStripButton toolRotateShapes;
        private System.Windows.Forms.ToolStripButton toolEditShape;
        private System.Windows.Forms.ToolStripButton toolUndo;
        private System.Windows.Forms.ToolStripLabel toolUndoCount;
        private System.Windows.Forms.ToolStripButton toolRedo;
        private System.Windows.Forms.ToolStrip _editToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator23;
        private System.Windows.Forms.ToolStripButton toolMoveShapes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator25;
        private System.Windows.Forms.ToolStripButton toolSplitByPolyline;
        private System.Windows.Forms.ToolStripDropDownButton toolPolygonOperation;
        private System.Windows.Forms.ToolStripMenuItem toolEraseByPolygon2;
        private System.Windows.Forms.ToolStripMenuItem toolClipByPolygon;
        private System.Windows.Forms.ToolStripMenuItem toolSplitByPolygon;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator28;
        private System.Windows.Forms.ToolStripButton toolSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem toolRemoveShapes;
        private System.Windows.Forms.ToolStripMenuItem toolEraseByPolygon;
    }
}
