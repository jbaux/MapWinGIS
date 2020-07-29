﻿using MWLite.Symbology.LegendControl;
namespace MWLite.GUI.MapLegend
{
    partial class LegendDockForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ctxZoomToLayer = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxLabels = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxCalculateArea = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxSaveLayerStyle = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxLoadLayerStyle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxPostGis = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxImportOgrLayer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxRemoveLayer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.legend1 = new MWLite.Symbology.LegendControl.Legend();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctxZoomToLayer
            // 
            this.ctxZoomToLayer.Name = "ctxZoomToLayer";
            this.ctxZoomToLayer.Size = new System.Drawing.Size(181, 24);
            this.ctxZoomToLayer.Text = "Zoom to layer";
            // 
            // ctxLabels
            // 
            this.ctxLabels.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ctxLabels.Name = "ctxLabels";
            this.ctxLabels.Size = new System.Drawing.Size(181, 24);
            this.ctxLabels.Text = "Labels";
            // 
            // ctxProperties
            // 
            this.ctxProperties.Name = "ctxProperties";
            this.ctxProperties.Size = new System.Drawing.Size(181, 24);
            this.ctxProperties.Text = "Properties";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxLabels,
            this.ctxZoomToLayer,
            this.toolStripSeparator5,
            this.ctxCalculateArea,
            this.toolStripSeparator4,
            this.ctxSaveLayerStyle,
            this.ctxLoadLayerStyle,
            this.toolStripSeparator2,
            this.ctxPostGis,
            this.toolStripSeparator1,
            this.ctxRemoveLayer,
            this.toolStripSeparator3,
            this.ctxProperties});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(182, 226);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(178, 6);
            // 
            // ctxCalculateArea
            // 
            this.ctxCalculateArea.Name = "ctxCalculateArea";
            this.ctxCalculateArea.Size = new System.Drawing.Size(181, 24);
            this.ctxCalculateArea.Text = "Calculate area";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(178, 6);
            // 
            // ctxSaveLayerStyle
            // 
            this.ctxSaveLayerStyle.Name = "ctxSaveLayerStyle";
            this.ctxSaveLayerStyle.Size = new System.Drawing.Size(181, 24);
            this.ctxSaveLayerStyle.Text = "Save layer style";
            // 
            // ctxLoadLayerStyle
            // 
            this.ctxLoadLayerStyle.Name = "ctxLoadLayerStyle";
            this.ctxLoadLayerStyle.Size = new System.Drawing.Size(181, 24);
            this.ctxLoadLayerStyle.Text = "Load layer style";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(178, 6);
            // 
            // ctxPostGis
            // 
            this.ctxPostGis.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxImportOgrLayer});
            this.ctxPostGis.Name = "ctxPostGis";
            this.ctxPostGis.Size = new System.Drawing.Size(181, 24);
            this.ctxPostGis.Text = "PostGIS";
            // 
            // ctxImportOgrLayer
            // 
            this.ctxImportOgrLayer.Name = "ctxImportOgrLayer";
            this.ctxImportOgrLayer.Size = new System.Drawing.Size(138, 26);
            this.ctxImportOgrLayer.Text = "Import...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // ctxRemoveLayer
            // 
            this.ctxRemoveLayer.Name = "ctxRemoveLayer";
            this.ctxRemoveLayer.Size = new System.Drawing.Size(181, 24);
            this.ctxRemoveLayer.Text = "Remove layer";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(178, 6);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.legend1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.checkedListBox1);
            this.splitContainer1.Size = new System.Drawing.Size(331, 358);
            this.splitContainer1.SplitterDistance = 167;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 4;
            // 
            // legend1
            // 
            this.legend1.BackColor = System.Drawing.Color.White;
            this.legend1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.legend1.Location = new System.Drawing.Point(0, 0);
            this.legend1.Map = null;
            this.legend1.Name = "legend1";
            this.legend1.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.legend1.SelectedLayer = -1;
            this.legend1.ShowGroupFolders = true;
            this.legend1.ShowLabels = false;
            this.legend1.Size = new System.Drawing.Size(331, 167);
            this.legend1.TabIndex = 3;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(0, 0);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(331, 185);
            this.checkedListBox1.TabIndex = 5;
            // 
            // LegendDockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(331, 358);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "LegendDockForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Legend";
            this.contextMenuStrip1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem ctxZoomToLayer;
        private System.Windows.Forms.ToolStripMenuItem ctxLabels;
        private System.Windows.Forms.ToolStripMenuItem ctxProperties;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ctxPostGis;
        private System.Windows.Forms.ToolStripMenuItem ctxImportOgrLayer;
        private System.Windows.Forms.ToolStripMenuItem ctxSaveLayerStyle;
        private System.Windows.Forms.ToolStripMenuItem ctxRemoveLayer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem ctxLoadLayerStyle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem ctxCalculateArea;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Legend legend1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}