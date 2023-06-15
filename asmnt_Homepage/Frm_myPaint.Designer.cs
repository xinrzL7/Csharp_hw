namespace asmnt_Homepage
{
    partial class frmmyPaint
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
            this.btnColor = new System.Windows.Forms.Button();
            this.tbarSize = new System.Windows.Forms.TrackBar();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.labSize = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbarSize)).BeginInit();
            this.SuspendLayout();
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnColor.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnColor.Location = new System.Drawing.Point(614, 27);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(120, 39);
            this.btnColor.TabIndex = 0;
            this.btnColor.Text = "顏色";
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // tbarSize
            // 
            this.tbarSize.LargeChange = 1;
            this.tbarSize.Location = new System.Drawing.Point(642, 154);
            this.tbarSize.Maximum = 100;
            this.tbarSize.Minimum = 1;
            this.tbarSize.Name = "tbarSize";
            this.tbarSize.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbarSize.Size = new System.Drawing.Size(69, 212);
            this.tbarSize.TabIndex = 1;
            this.tbarSize.TickFrequency = 5;
            this.tbarSize.Value = 1;
            // 
            // txtColor
            // 
            this.txtColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtColor.Location = new System.Drawing.Point(614, 83);
            this.txtColor.Multiline = true;
            this.txtColor.Name = "txtColor";
            this.txtColor.ReadOnly = true;
            this.txtColor.Size = new System.Drawing.Size(120, 65);
            this.txtColor.TabIndex = 2;
            // 
            // labSize
            // 
            this.labSize.AutoSize = true;
            this.labSize.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labSize.Location = new System.Drawing.Point(646, 369);
            this.labSize.Name = "labSize";
            this.labSize.Size = new System.Drawing.Size(27, 30);
            this.labSize.TabIndex = 3;
            this.labSize.Text = "1";
            // 
            // frmmyPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(763, 445);
            this.Controls.Add(this.labSize);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.tbarSize);
            this.Controls.Add(this.btnColor);
            this.Name = "frmmyPaint";
            this.Text = "myPaint";
            ((System.ComponentModel.ISupportInitialize)(this.tbarSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.TrackBar tbarSize;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label labSize;
    }
}