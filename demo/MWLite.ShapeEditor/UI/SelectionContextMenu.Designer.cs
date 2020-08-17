﻿namespace MWLite.ShapeEditor.UI
{
    partial class SelectionContextMenu
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxSelectByRectangle = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxClearSelection = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxSplitShapes = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMergeShapes = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxRotateShapes = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMoveShapes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxCut = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxRemoveShapes = new System.Windows.Forms.ToolStripMenuItem();
            this.markAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMarkAsAI = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMarkAsHuman = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxSelectByRectangle,
            this.ctxClearSelection,
            this.toolStripSeparator2,
            this.ctxSplitShapes,
            this.ctxMergeShapes,
            this.ctxRotateShapes,
            this.ctxMoveShapes,
            this.toolStripSeparator3,
            this.ctxCopy,
            this.ctxCut,
            this.ctxPaste,
            this.toolStripSeparator1,
            this.ctxRemoveShapes,
            this.markAsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 314);
            // 
            // ctxSelectByRectangle
            // 
            this.ctxSelectByRectangle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ctxSelectByRectangle.Name = "ctxSelectByRectangle";
            this.ctxSelectByRectangle.Size = new System.Drawing.Size(210, 24);
            this.ctxSelectByRectangle.Text = "Select by rectangle";
            // 
            // ctxClearSelection
            // 
            this.ctxClearSelection.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ctxClearSelection.Name = "ctxClearSelection";
            this.ctxClearSelection.Size = new System.Drawing.Size(210, 24);
            this.ctxClearSelection.Text = "Clear selection";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(207, 6);
            // 
            // ctxSplitShapes
            // 
            this.ctxSplitShapes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ctxSplitShapes.Name = "ctxSplitShapes";
            this.ctxSplitShapes.Size = new System.Drawing.Size(210, 24);
            this.ctxSplitShapes.Text = "Split multi-part";
            // 
            // ctxMergeShapes
            // 
            this.ctxMergeShapes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ctxMergeShapes.Name = "ctxMergeShapes";
            this.ctxMergeShapes.Size = new System.Drawing.Size(210, 24);
            this.ctxMergeShapes.Text = "Join";
            // 
            // ctxRotateShapes
            // 
            this.ctxRotateShapes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ctxRotateShapes.Name = "ctxRotateShapes";
            this.ctxRotateShapes.Size = new System.Drawing.Size(210, 24);
            this.ctxRotateShapes.Text = "Rotate";
            // 
            // ctxMoveShapes
            // 
            this.ctxMoveShapes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ctxMoveShapes.Name = "ctxMoveShapes";
            this.ctxMoveShapes.Size = new System.Drawing.Size(210, 24);
            this.ctxMoveShapes.Text = "Move";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(207, 6);
            // 
            // ctxCopy
            // 
            this.ctxCopy.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ctxCopy.Name = "ctxCopy";
            this.ctxCopy.Size = new System.Drawing.Size(210, 24);
            this.ctxCopy.Text = "Copy";
            // 
            // ctxCut
            // 
            this.ctxCut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ctxCut.Name = "ctxCut";
            this.ctxCut.Size = new System.Drawing.Size(210, 24);
            this.ctxCut.Text = "Cut";
            // 
            // ctxPaste
            // 
            this.ctxPaste.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ctxPaste.Name = "ctxPaste";
            this.ctxPaste.Size = new System.Drawing.Size(210, 24);
            this.ctxPaste.Text = "Paste";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(207, 6);
            // 
            // ctxRemoveShapes
            // 
            this.ctxRemoveShapes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ctxRemoveShapes.Name = "ctxRemoveShapes";
            this.ctxRemoveShapes.Size = new System.Drawing.Size(210, 24);
            this.ctxRemoveShapes.Text = "Delete";
            // 
            // markAsToolStripMenuItem
            // 
            this.markAsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxMarkAsAI,
            this.ctxMarkAsHuman});
            this.markAsToolStripMenuItem.Name = "markAsToolStripMenuItem";
            this.markAsToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.markAsToolStripMenuItem.Text = "Change AI/human";
            this.markAsToolStripMenuItem.Click += new System.EventHandler(this.markAsToolStripMenuItem_Click);
            // 
            // ctxMarkAsAI
            // 
            this.ctxMarkAsAI.Name = "ctxMarkAsAI";
            this.ctxMarkAsAI.Size = new System.Drawing.Size(216, 26);
            this.ctxMarkAsAI.Text = "AI";
            // 
            // ctxMarkAsHuman
            // 
            this.ctxMarkAsHuman.Name = "ctxMarkAsHuman";
            this.ctxMarkAsHuman.Size = new System.Drawing.Size(216, 26);
            this.ctxMarkAsHuman.Text = "Human";
            // 
            // SelectionContextMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SelectionContextMenu";
            this.Size = new System.Drawing.Size(200, 224);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ctxSplitShapes;
        private System.Windows.Forms.ToolStripMenuItem ctxMergeShapes;
        private System.Windows.Forms.ToolStripMenuItem ctxRotateShapes;
        private System.Windows.Forms.ToolStripMenuItem ctxMoveShapes;
        private System.Windows.Forms.ToolStripMenuItem ctxRemoveShapes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem ctxCopy;
        private System.Windows.Forms.ToolStripMenuItem ctxPaste;
        private System.Windows.Forms.ToolStripMenuItem ctxCut;
        private System.Windows.Forms.ToolStripMenuItem ctxSelectByRectangle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ctxClearSelection;
        private System.Windows.Forms.ToolStripMenuItem markAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ctxMarkAsAI;
        private System.Windows.Forms.ToolStripMenuItem ctxMarkAsHuman;
    }
}
