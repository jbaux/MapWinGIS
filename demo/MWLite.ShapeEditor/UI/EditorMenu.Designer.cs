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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuShapeEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.moveShapesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateShapesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eraseByShapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitByLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuShapeEditor,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(304, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuShapeEditor
            // 
            this.mnuShapeEditor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUndo,
            this.mnuRedo,
            this.toolStripSeparator2,
            this.mnuCopy,
            this.mnuCut,
            this.mnuPaste});
            this.mnuShapeEditor.Name = "mnuShapeEditor";
            this.mnuShapeEditor.Size = new System.Drawing.Size(47, 24);
            this.mnuShapeEditor.Text = "Edit";
            // 
            // mnuUndo
            // 
            this.mnuUndo.Image = global::MWLite.ShapeEditor.Properties.Resources.undo;
            this.mnuUndo.Name = "mnuUndo";
            this.mnuUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.mnuUndo.Size = new System.Drawing.Size(210, 26);
            this.mnuUndo.Text = "Undo";
            // 
            // mnuRedo
            // 
            this.mnuRedo.Image = global::MWLite.ShapeEditor.Properties.Resources.redo;
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
            // mnuCopy
            // 
            this.mnuCopy.Image = global::MWLite.ShapeEditor.Properties.Resources.edit_copy;
            this.mnuCopy.Name = "mnuCopy";
            this.mnuCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mnuCopy.Size = new System.Drawing.Size(210, 26);
            this.mnuCopy.Text = "Copy";
            // 
            // mnuCut
            // 
            this.mnuCut.Image = global::MWLite.ShapeEditor.Properties.Resources.edit_cut;
            this.mnuCut.Name = "mnuCut";
            this.mnuCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mnuCut.Size = new System.Drawing.Size(210, 26);
            this.mnuCut.Text = "Cut";
            // 
            // mnuPaste
            // 
            this.mnuPaste.Image = global::MWLite.ShapeEditor.Properties.Resources.edit_paste;
            this.mnuPaste.Name = "mnuPaste";
            this.mnuPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.mnuPaste.Size = new System.Drawing.Size(210, 26);
            this.mnuPaste.Text = "Paste";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.moveShapesToolStripMenuItem,
            this.rotateShapesToolStripMenuItem,
            this.eraseByShapeToolStripMenuItem,
            this.splitByLineToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(68, 24);
            this.toolStripMenuItem1.Text = "Shapes";
            // 
            // moveShapesToolStripMenuItem
            // 
            this.moveShapesToolStripMenuItem.Name = "moveShapesToolStripMenuItem";
            this.moveShapesToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.moveShapesToolStripMenuItem.Text = "Move";
            // 
            // rotateShapesToolStripMenuItem
            // 
            this.rotateShapesToolStripMenuItem.Name = "rotateShapesToolStripMenuItem";
            this.rotateShapesToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.rotateShapesToolStripMenuItem.Text = "Rotate";
            // 
            // eraseByShapeToolStripMenuItem
            // 
            this.eraseByShapeToolStripMenuItem.Name = "eraseByShapeToolStripMenuItem";
            this.eraseByShapeToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.eraseByShapeToolStripMenuItem.Text = "Erase by shape";
            // 
            // splitByLineToolStripMenuItem
            // 
            this.splitByLineToolStripMenuItem.Name = "splitByLineToolStripMenuItem";
            this.splitByLineToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.splitByLineToolStripMenuItem.Text = "Split by line";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // EditorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditorMenu";
            this.Size = new System.Drawing.Size(304, 185);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuShapeEditor;
        private System.Windows.Forms.ToolStripMenuItem mnuUndo;
        private System.Windows.Forms.ToolStripMenuItem mnuRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuCopy;
        private System.Windows.Forms.ToolStripMenuItem mnuCut;
        private System.Windows.Forms.ToolStripMenuItem mnuPaste;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveShapesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateShapesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eraseByShapeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem splitByLineToolStripMenuItem;
    }
}
