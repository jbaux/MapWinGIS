namespace MWLite.ShapeEditor.UI
{
    partial class EditorMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPreferences = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuShapesEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddShape = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditShape = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMoveShapes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRotateShapes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemoveShapes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEraseByPolygon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSplitByPolyline = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEdit,
            this.mnuShapesEdit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(304, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUndo,
            this.mnuRedo,
            this.toolStripSeparator2,
            this.mnuCut,
            this.mnuCopy,
            this.mnuPaste,
            this.mnuPreferences});
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(47, 24);
            this.mnuEdit.Text = "Edit";
            // 
            // mnuUndo
            // 
            this.mnuUndo.Image = global::Resources.GlobalResources._16noun_Undo_2458027;
            this.mnuUndo.Name = "mnuUndo";
            this.mnuUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.mnuUndo.Size = new System.Drawing.Size(210, 26);
            this.mnuUndo.Text = "Undo";
            // 
            // mnuRedo
            // 
            this.mnuRedo.Image = global::Resources.GlobalResources._17noun_redo_2458031;
            this.mnuRedo.Name = "mnuRedo";
            this.mnuRedo.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.mnuRedo.Size = new System.Drawing.Size(210, 26);
            this.mnuRedo.Text = "Redo";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(207, 6);
            // 
            // mnuCut
            // 
            this.mnuCut.Image = ((System.Drawing.Image)(resources.GetObject("mnuCut.Image")));
            this.mnuCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuCut.Name = "mnuCut";
            this.mnuCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mnuCut.Size = new System.Drawing.Size(210, 26);
            this.mnuCut.Text = "Cu&t";
            // 
            // mnuCopy
            // 
            this.mnuCopy.Image = ((System.Drawing.Image)(resources.GetObject("mnuCopy.Image")));
            this.mnuCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuCopy.Name = "mnuCopy";
            this.mnuCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mnuCopy.Size = new System.Drawing.Size(210, 26);
            this.mnuCopy.Text = "&Copy";
            // 
            // mnuPaste
            // 
            this.mnuPaste.Image = ((System.Drawing.Image)(resources.GetObject("mnuPaste.Image")));
            this.mnuPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuPaste.Name = "mnuPaste";
            this.mnuPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.mnuPaste.Size = new System.Drawing.Size(210, 26);
            this.mnuPaste.Text = "&Paste";
            // 
            // mnuPreferences
            // 
            this.mnuPreferences.Name = "mnuPreferences";
            this.mnuPreferences.Size = new System.Drawing.Size(210, 26);
            this.mnuPreferences.Text = "Preferences";
            // 
            // mnuShapesEdit
            // 
            this.mnuShapesEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddShape,
            this.mnuEditShape,
            this.mnuMoveShapes,
            this.mnuRotateShapes,
            this.mnuRemoveShapes,
            this.mnuEraseByPolygon,
            this.mnuSplitByPolyline});
            this.mnuShapesEdit.Name = "mnuShapesEdit";
            this.mnuShapesEdit.Size = new System.Drawing.Size(68, 24);
            this.mnuShapesEdit.Text = "Shapes";
            // 
            // mnuAddShape
            // 
            this.mnuAddShape.Name = "mnuAddShape";
            this.mnuAddShape.ShortcutKeyDisplayString = "D";
            this.mnuAddShape.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.mnuAddShape.Size = new System.Drawing.Size(275, 26);
            this.mnuAddShape.Text = "Draw";
            // 
            // mnuEditShape
            // 
            this.mnuEditShape.Name = "mnuEditShape";
            this.mnuEditShape.ShortcutKeyDisplayString = "E";
            this.mnuEditShape.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.mnuEditShape.Size = new System.Drawing.Size(275, 26);
            this.mnuEditShape.Text = "Edit";
            // 
            // mnuMoveShapes
            // 
            this.mnuMoveShapes.Name = "mnuMoveShapes";
            this.mnuMoveShapes.ShortcutKeyDisplayString = "M";
            this.mnuMoveShapes.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.mnuMoveShapes.Size = new System.Drawing.Size(275, 26);
            this.mnuMoveShapes.Text = "Move";
            // 
            // mnuRotateShapes
            // 
            this.mnuRotateShapes.Name = "mnuRotateShapes";
            this.mnuRotateShapes.ShortcutKeyDisplayString = "R";
            this.mnuRotateShapes.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.mnuRotateShapes.Size = new System.Drawing.Size(275, 26);
            this.mnuRotateShapes.Text = "Rotate";
            // 
            // mnuRemoveShapes
            // 
            this.mnuRemoveShapes.Name = "mnuRemoveShapes";
            this.mnuRemoveShapes.ShortcutKeyDisplayString = "Delete";
            this.mnuRemoveShapes.Size = new System.Drawing.Size(275, 26);
            this.mnuRemoveShapes.Text = "Delete selected";
            // 
            // mnuEraseByPolygon
            // 
            this.mnuEraseByPolygon.Name = "mnuEraseByPolygon";
            this.mnuEraseByPolygon.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.mnuEraseByPolygon.Size = new System.Drawing.Size(275, 26);
            this.mnuEraseByPolygon.Text = "Erase by shape";
            // 
            // mnuSplitByPolyline
            // 
            this.mnuSplitByPolyline.Name = "mnuSplitByPolyline";
            this.mnuSplitByPolyline.ShortcutKeyDisplayString = "S";
            this.mnuSplitByPolyline.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuSplitByPolyline.Size = new System.Drawing.Size(275, 26);
            this.mnuSplitByPolyline.Text = "Split by polyline";
            // 
            // EditorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditorMenu";
            this.Size = new System.Drawing.Size(304, 185);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuUndo;
        private System.Windows.Forms.ToolStripMenuItem mnuRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuShapesEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuAddShape;
        private System.Windows.Forms.ToolStripMenuItem mnuEditShape;
        private System.Windows.Forms.ToolStripMenuItem mnuMoveShapes;
        private System.Windows.Forms.ToolStripMenuItem mnuRotateShapes;
        private System.Windows.Forms.ToolStripMenuItem mnuEraseByPolygon;
        private System.Windows.Forms.ToolStripMenuItem mnuSplitByPolyline;
        private System.Windows.Forms.ToolStripMenuItem mnuRemoveShapes;
        private System.Windows.Forms.ToolStripMenuItem mnuCut;
        private System.Windows.Forms.ToolStripMenuItem mnuCopy;
        private System.Windows.Forms.ToolStripMenuItem mnuPaste;
        private System.Windows.Forms.ToolStripMenuItem mnuPreferences;
    }
}
