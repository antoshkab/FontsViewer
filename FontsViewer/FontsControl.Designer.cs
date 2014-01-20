namespace FontsViewer
{
    partial class FontsControl
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
            this._flpControl = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // _flpControl
            // 
            this._flpControl.AutoScroll = true;
            this._flpControl.AutoSize = true;
            this._flpControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._flpControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flpControl.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this._flpControl.Location = new System.Drawing.Point(0, 0);
            this._flpControl.Name = "_flpControl";
            this._flpControl.Size = new System.Drawing.Size(217, 108);
            this._flpControl.TabIndex = 0;
            // 
            // FontsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._flpControl);
            this.Name = "FontsControl";
            this.Size = new System.Drawing.Size(217, 108);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel _flpControl;

    }
}
