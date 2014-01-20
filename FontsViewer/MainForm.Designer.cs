namespace FontsViewer
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this._btnLoadMore = new System.Windows.Forms.Button();
            this._topPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this._btnBigger = new System.Windows.Forms.Button();
            this._btnSmaller = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this._fontSize = new System.Windows.Forms.TextBox();
            this._tbString = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._btnPositive = new System.Windows.Forms.Button();
            this._btnInput = new System.Windows.Forms.Button();
            this._btnNegative = new System.Windows.Forms.Button();
            this._btnToLower = new System.Windows.Forms.Button();
            this._btnToUpper = new System.Windows.Forms.Button();
            this._bottomPanel = new System.Windows.Forms.Panel();
            this._fontsView = new FontsViewer.FontsControl();
            this._topPanel.SuspendLayout();
            this._bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _btnLoadMore
            // 
            this._btnLoadMore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._btnLoadMore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnLoadMore.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this._btnLoadMore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this._btnLoadMore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this._btnLoadMore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnLoadMore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._btnLoadMore.ForeColor = System.Drawing.Color.Silver;
            this._btnLoadMore.Location = new System.Drawing.Point(224, 6);
            this._btnLoadMore.Name = "_btnLoadMore";
            this._btnLoadMore.Size = new System.Drawing.Size(116, 29);
            this._btnLoadMore.TabIndex = 1;
            this._btnLoadMore.Text = "load fonts";
            this._btnLoadMore.UseVisualStyleBackColor = false;
            // 
            // _topPanel
            // 
            this._topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._topPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._topPanel.Controls.Add(this.label6);
            this._topPanel.Controls.Add(this._btnBigger);
            this._topPanel.Controls.Add(this._btnSmaller);
            this._topPanel.Controls.Add(this.label4);
            this._topPanel.Controls.Add(this._fontSize);
            this._topPanel.Controls.Add(this._tbString);
            this._topPanel.Controls.Add(this.label3);
            this._topPanel.Controls.Add(this.label2);
            this._topPanel.Controls.Add(this.label1);
            this._topPanel.Controls.Add(this._btnPositive);
            this._topPanel.Controls.Add(this._btnInput);
            this._topPanel.Controls.Add(this._btnNegative);
            this._topPanel.Controls.Add(this._btnToLower);
            this._topPanel.Controls.Add(this._btnToUpper);
            this._topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this._topPanel.Location = new System.Drawing.Point(0, 0);
            this._topPanel.Name = "_topPanel";
            this._topPanel.Size = new System.Drawing.Size(562, 39);
            this._topPanel.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(491, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "/";
            // 
            // _btnBigger
            // 
            this._btnBigger.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._btnBigger.BackColor = System.Drawing.Color.Transparent;
            this._btnBigger.FlatAppearance.BorderSize = 0;
            this._btnBigger.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._btnBigger.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._btnBigger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnBigger.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._btnBigger.ForeColor = System.Drawing.Color.Silver;
            this._btnBigger.Location = new System.Drawing.Point(498, 8);
            this._btnBigger.Name = "_btnBigger";
            this._btnBigger.Size = new System.Drawing.Size(50, 23);
            this._btnBigger.TabIndex = 4;
            this._btnBigger.Text = "bigger";
            this._btnBigger.UseVisualStyleBackColor = false;
            // 
            // _btnSmaller
            // 
            this._btnSmaller.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._btnSmaller.BackColor = System.Drawing.Color.Transparent;
            this._btnSmaller.FlatAppearance.BorderSize = 0;
            this._btnSmaller.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._btnSmaller.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._btnSmaller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnSmaller.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._btnSmaller.ForeColor = System.Drawing.Color.Silver;
            this._btnSmaller.Location = new System.Drawing.Point(444, 8);
            this._btnSmaller.Name = "_btnSmaller";
            this._btnSmaller.Size = new System.Drawing.Size(54, 23);
            this._btnSmaller.TabIndex = 3;
            this._btnSmaller.Text = "smaller";
            this._btnSmaller.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(353, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "font size:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _fontSize
            // 
            this._fontSize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._fontSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._fontSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._fontSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._fontSize.ForeColor = System.Drawing.Color.Silver;
            this._fontSize.Location = new System.Drawing.Point(414, 13);
            this._fontSize.MaxLength = 3;
            this._fontSize.Name = "_fontSize";
            this._fontSize.Size = new System.Drawing.Size(24, 13);
            this._fontSize.TabIndex = 7;
            this._fontSize.Text = "19";
            // 
            // _tbString
            // 
            this._tbString.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._tbString.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._tbString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._tbString.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._tbString.Location = new System.Drawing.Point(215, 3);
            this._tbString.Name = "_tbString";
            this._tbString.Size = new System.Drawing.Size(132, 29);
            this._tbString.TabIndex = 0;
            this._tbString.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(177, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "/";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(151, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "/";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(59, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "/";
            // 
            // _btnPositive
            // 
            this._btnPositive.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._btnPositive.BackColor = System.Drawing.Color.Transparent;
            this._btnPositive.FlatAppearance.BorderSize = 0;
            this._btnPositive.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this._btnPositive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._btnPositive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._btnPositive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnPositive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._btnPositive.ForeColor = System.Drawing.Color.Silver;
            this._btnPositive.Location = new System.Drawing.Point(8, 8);
            this._btnPositive.Margin = new System.Windows.Forms.Padding(0);
            this._btnPositive.Name = "_btnPositive";
            this._btnPositive.Size = new System.Drawing.Size(60, 23);
            this._btnPositive.TabIndex = 3;
            this._btnPositive.Text = "positive";
            this._btnPositive.UseVisualStyleBackColor = false;
            // 
            // _btnInput
            // 
            this._btnInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._btnInput.BackColor = System.Drawing.Color.Transparent;
            this._btnInput.FlatAppearance.BorderSize = 0;
            this._btnInput.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this._btnInput.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._btnInput.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._btnInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._btnInput.ForeColor = System.Drawing.Color.Silver;
            this._btnInput.Location = new System.Drawing.Point(155, 8);
            this._btnInput.Margin = new System.Windows.Forms.Padding(0);
            this._btnInput.Name = "_btnInput";
            this._btnInput.Size = new System.Drawing.Size(32, 23);
            this._btnInput.TabIndex = 5;
            this._btnInput.Text = "Aa";
            this._btnInput.UseVisualStyleBackColor = false;
            // 
            // _btnNegative
            // 
            this._btnNegative.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._btnNegative.BackColor = System.Drawing.Color.Transparent;
            this._btnNegative.FlatAppearance.BorderSize = 0;
            this._btnNegative.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this._btnNegative.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._btnNegative.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._btnNegative.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnNegative.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._btnNegative.ForeColor = System.Drawing.Color.Silver;
            this._btnNegative.Location = new System.Drawing.Point(64, 8);
            this._btnNegative.Margin = new System.Windows.Forms.Padding(0);
            this._btnNegative.Name = "_btnNegative";
            this._btnNegative.Size = new System.Drawing.Size(66, 23);
            this._btnNegative.TabIndex = 5;
            this._btnNegative.Text = "negative";
            this._btnNegative.UseVisualStyleBackColor = false;
            // 
            // _btnToLower
            // 
            this._btnToLower.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._btnToLower.BackColor = System.Drawing.Color.Transparent;
            this._btnToLower.FlatAppearance.BorderSize = 0;
            this._btnToLower.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this._btnToLower.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._btnToLower.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._btnToLower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnToLower.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._btnToLower.ForeColor = System.Drawing.Color.Silver;
            this._btnToLower.Location = new System.Drawing.Point(130, 8);
            this._btnToLower.Margin = new System.Windows.Forms.Padding(0);
            this._btnToLower.Name = "_btnToLower";
            this._btnToLower.Size = new System.Drawing.Size(29, 23);
            this._btnToLower.TabIndex = 4;
            this._btnToLower.Text = "aa";
            this._btnToLower.UseVisualStyleBackColor = false;
            // 
            // _btnToUpper
            // 
            this._btnToUpper.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._btnToUpper.BackColor = System.Drawing.Color.Transparent;
            this._btnToUpper.FlatAppearance.BorderSize = 0;
            this._btnToUpper.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this._btnToUpper.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._btnToUpper.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._btnToUpper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnToUpper.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._btnToUpper.ForeColor = System.Drawing.Color.Silver;
            this._btnToUpper.Location = new System.Drawing.Point(181, 8);
            this._btnToUpper.Margin = new System.Windows.Forms.Padding(0);
            this._btnToUpper.Name = "_btnToUpper";
            this._btnToUpper.Size = new System.Drawing.Size(31, 23);
            this._btnToUpper.TabIndex = 6;
            this._btnToUpper.Text = "AA";
            this._btnToUpper.UseVisualStyleBackColor = false;
            // 
            // _bottomPanel
            // 
            this._bottomPanel.Controls.Add(this._btnLoadMore);
            this._bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._bottomPanel.Location = new System.Drawing.Point(0, 435);
            this._bottomPanel.Name = "_bottomPanel";
            this._bottomPanel.Size = new System.Drawing.Size(562, 43);
            this._bottomPanel.TabIndex = 10;
            // 
            // _fontsView
            // 
            this._fontsView.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._fontsView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._fontsView.Location = new System.Drawing.Point(0, 39);
            this._fontsView.Name = "_fontsView";
            this._fontsView.Size = new System.Drawing.Size(562, 396);
            this._fontsView.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(562, 478);
            this.Controls.Add(this._fontsView);
            this.Controls.Add(this._bottomPanel);
            this.Controls.Add(this._topPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Просмотр шрифтов";
            this._topPanel.ResumeLayout(false);
            this._topPanel.PerformLayout();
            this._bottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _btnLoadMore;
        private System.Windows.Forms.Panel _topPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _tbString;
        private System.Windows.Forms.Button _btnPositive;
        private System.Windows.Forms.Button _btnNegative;
        private System.Windows.Forms.Button _btnSmaller;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _fontSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button _btnInput;
        private System.Windows.Forms.Button _btnToLower;
        private System.Windows.Forms.Button _btnToUpper;
        private System.Windows.Forms.Button _btnBigger;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel _bottomPanel;
        private FontsControl _fontsView;
    }
}

