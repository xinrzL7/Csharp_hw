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
            this.pnlCanvas = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tbarSize)).BeginInit();
            this.pnlCanvas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnColor
            // 
            this.btnColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnColor.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnColor.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnColor.Location = new System.Drawing.Point(689, 20);
            this.btnColor.Margin = new System.Windows.Forms.Padding(2);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(81, 44);
            this.btnColor.TabIndex = 0;
            this.btnColor.Text = "顏色";
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // tbarSize
            // 
            this.tbarSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbarSize.LargeChange = 1;
            this.tbarSize.Location = new System.Drawing.Point(725, 137);
            this.tbarSize.Margin = new System.Windows.Forms.Padding(2);
            this.tbarSize.Maximum = 100;
            this.tbarSize.Minimum = 1;
            this.tbarSize.Name = "tbarSize";
            this.tbarSize.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbarSize.Size = new System.Drawing.Size(45, 141);
            this.tbarSize.TabIndex = 1;
            this.tbarSize.TickFrequency = 5;
            this.tbarSize.Value = 1;
            this.tbarSize.Scroll += new System.EventHandler(this.tbarSize_Scroll);
            // 
            // txtColor
            // 
            this.txtColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtColor.Location = new System.Drawing.Point(689, 80);
            this.txtColor.Margin = new System.Windows.Forms.Padding(2);
            this.txtColor.Multiline = true;
            this.txtColor.Name = "txtColor";
            this.txtColor.ReadOnly = true;
            this.txtColor.Size = new System.Drawing.Size(81, 44);
            this.txtColor.TabIndex = 2;
            // 
            // labSize
            // 
            this.labSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labSize.AutoSize = true;
            this.labSize.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labSize.ForeColor = System.Drawing.Color.Black;
            this.labSize.Location = new System.Drawing.Point(731, 280);
            this.labSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labSize.Name = "labSize";
            this.labSize.Size = new System.Drawing.Size(18, 20);
            this.labSize.TabIndex = 3;
            this.labSize.Text = "1";
            this.labSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlCanvas
            // 
            this.pnlCanvas.BackColor = System.Drawing.Color.White;
            this.pnlCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCanvas.Controls.Add(this.btnColor);
            this.pnlCanvas.Controls.Add(this.txtColor);
            this.pnlCanvas.Controls.Add(this.labSize);
            this.pnlCanvas.Controls.Add(this.tbarSize);
            this.pnlCanvas.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pnlCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCanvas.Location = new System.Drawing.Point(0, 0);
            this.pnlCanvas.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCanvas.Name = "pnlCanvas";
            this.pnlCanvas.Size = new System.Drawing.Size(783, 464);
            this.pnlCanvas.TabIndex = 4;
            this.pnlCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlCanvas_MouseDown);
            this.pnlCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlCanvas_MouseMove);
            this.pnlCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlCanvas_MouseUp);
            // 
            // frmmyPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(783, 464);
            this.Controls.Add(this.pnlCanvas);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmmyPaint";
            this.Text = "小畫家";
            ((System.ComponentModel.ISupportInitialize)(this.tbarSize)).EndInit();
            this.pnlCanvas.ResumeLayout(false);
            this.pnlCanvas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.TrackBar tbarSize;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label labSize;
        private System.Windows.Forms.Panel pnlCanvas;
    }
}