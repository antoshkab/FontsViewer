namespace FontsViewer
{
    partial class Picture
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
            this._image = new System.Windows.Forms.PictureBox();
            this._fontName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._image)).BeginInit();
            this.SuspendLayout();
            // 
            // _image
            // 
            this._image.Dock = System.Windows.Forms.DockStyle.Fill;
            this._image.Location = new System.Drawing.Point(0, 0);
            this._image.Name = "_image";
            this._image.Size = new System.Drawing.Size(407, 211);
            this._image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this._image.TabIndex = 0;
            this._image.TabStop = false;
            // 
            // _fontName
            // 
            this._fontName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._fontName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._fontName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._fontName.Location = new System.Drawing.Point(0, 211);
            this._fontName.Name = "_fontName";
            this._fontName.Size = new System.Drawing.Size(407, 23);
            this._fontName.TabIndex = 1;
            this._fontName.Text = "label1";
            this._fontName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Picture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this._image);
            this.Controls.Add(this._fontName);
            this.Name = "Picture";
            this.Size = new System.Drawing.Size(407, 234);
            ((System.ComponentModel.ISupportInitialize)(this._image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox _image;
        private System.Windows.Forms.Label _fontName;
    }
}
