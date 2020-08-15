namespace MWLite.GUI.Forms
{
    partial class PreferencesForm
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
            this.chbOpenStreetMap = new System.Windows.Forms.CheckBox();
            this.chbShapeArea = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chbOpenStreetMap
            // 
            this.chbOpenStreetMap.AutoSize = true;
            this.chbOpenStreetMap.Location = new System.Drawing.Point(22, 23);
            this.chbOpenStreetMap.Name = "chbOpenStreetMap";
            this.chbOpenStreetMap.Size = new System.Drawing.Size(183, 21);
            this.chbOpenStreetMap.TabIndex = 0;
            this.chbOpenStreetMap.Text = "Display open street map";
            this.chbOpenStreetMap.UseVisualStyleBackColor = true;
            this.chbOpenStreetMap.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chbShapeArea
            // 
            this.chbShapeArea.AutoSize = true;
            this.chbShapeArea.Location = new System.Drawing.Point(22, 50);
            this.chbShapeArea.Name = "chbShapeArea";
            this.chbShapeArea.Size = new System.Drawing.Size(242, 21);
            this.chbShapeArea.TabIndex = 1;
            this.chbShapeArea.Text = "Display area when editing shapes";
            this.chbShapeArea.UseVisualStyleBackColor = true;
            this.chbShapeArea.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // PreferencesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 302);
            this.Controls.Add(this.chbShapeArea);
            this.Controls.Add(this.chbOpenStreetMap);
            this.Name = "PreferencesForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Preferences";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbOpenStreetMap;
        private System.Windows.Forms.CheckBox chbShapeArea;
    }
}