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
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tbarSize)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnColor.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnColor.ForeColor = System.Drawing.Color.Black;
            this.btnColor.Location = new System.Drawing.Point(898, 31);
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
            this.tbarSize.Location = new System.Drawing.Point(926, 174);
            this.tbarSize.Maximum = 100;
            this.tbarSize.Minimum = 1;
            this.tbarSize.Name = "tbarSize";
            this.tbarSize.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbarSize.Size = new System.Drawing.Size(69, 212);
            this.tbarSize.TabIndex = 1;
            this.tbarSize.TickFrequency = 5;
            this.tbarSize.Value = 1;
            this.tbarSize.Scroll += new System.EventHandler(this.tbarSize_Scroll);
            // 
            // txtColor
            // 
            this.txtColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtColor.Location = new System.Drawing.Point(898, 76);
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
            this.labSize.ForeColor = System.Drawing.Color.Black;
            this.labSize.Location = new System.Drawing.Point(934, 389);
            this.labSize.Name = "labSize";
            this.labSize.Size = new System.Drawing.Size(27, 30);
            this.labSize.TabIndex = 3;
            this.labSize.Text = "1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnColor);
            this.panel1.Controls.Add(this.txtColor);
            this.panel1.Controls.Add(this.labSize);
            this.panel1.Controls.Add(this.tbarSize);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1059, 498);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // frmmyPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1059, 498);
            this.Controls.Add(this.panel1);
            this.Name = "frmmyPaint";
            this.Text = "myPaint";
            ((System.ComponentModel.ISupportInitialize)(this.tbarSize)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.TrackBar tbarSize;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label labSize;
        private System.Windows.Forms.Panel panel1;
    }
}