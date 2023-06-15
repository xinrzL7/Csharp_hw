namespace asmnt_Homepage
{
    partial class frmLoan
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
            this.txtLoan = new System.Windows.Forms.TextBox();
            this.labLoan = new System.Windows.Forms.Label();
            this.labPeriod = new System.Windows.Forms.Label();
            this.labRate = new System.Windows.Forms.Label();
            this.labDownPay = new System.Windows.Forms.Label();
            this.txtPeriod = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtDownPay = new System.Windows.Forms.TextBox();
            this.btnPMT = new System.Windows.Forms.Button();
            this.btnTotalPay = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLoan
            // 
            this.txtLoan.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtLoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLoan.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoan.ForeColor = System.Drawing.Color.DimGray;
            this.txtLoan.Location = new System.Drawing.Point(163, 39);
            this.txtLoan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLoan.Name = "txtLoan";
            this.txtLoan.Size = new System.Drawing.Size(111, 25);
            this.txtLoan.TabIndex = 0;
            this.txtLoan.Text = "0";
            this.txtLoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labLoan
            // 
            this.labLoan.AutoSize = true;
            this.labLoan.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labLoan.ForeColor = System.Drawing.Color.GhostWhite;
            this.labLoan.Location = new System.Drawing.Point(46, 42);
            this.labLoan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labLoan.Name = "labLoan";
            this.labLoan.Size = new System.Drawing.Size(117, 26);
            this.labLoan.TabIndex = 1;
            this.labLoan.Text = "貸款金額：";
            this.labLoan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labPeriod
            // 
            this.labPeriod.AutoSize = true;
            this.labPeriod.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPeriod.ForeColor = System.Drawing.Color.GhostWhite;
            this.labPeriod.Location = new System.Drawing.Point(46, 92);
            this.labPeriod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labPeriod.Name = "labPeriod";
            this.labPeriod.Size = new System.Drawing.Size(110, 26);
            this.labPeriod.TabIndex = 2;
            this.labPeriod.Text = "期限(年)：";
            this.labPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labRate
            // 
            this.labRate.AutoSize = true;
            this.labRate.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labRate.ForeColor = System.Drawing.Color.GhostWhite;
            this.labRate.Location = new System.Drawing.Point(46, 140);
            this.labRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labRate.Name = "labRate";
            this.labRate.Size = new System.Drawing.Size(108, 26);
            this.labRate.TabIndex = 3;
            this.labRate.Text = "利率(%)：";
            this.labRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labDownPay
            // 
            this.labDownPay.AutoSize = true;
            this.labDownPay.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labDownPay.ForeColor = System.Drawing.Color.GhostWhite;
            this.labDownPay.Location = new System.Drawing.Point(46, 191);
            this.labDownPay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labDownPay.Name = "labDownPay";
            this.labDownPay.Size = new System.Drawing.Size(96, 26);
            this.labDownPay.TabIndex = 4;
            this.labDownPay.Text = "頭期款：";
            this.labDownPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPeriod
            // 
            this.txtPeriod.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtPeriod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPeriod.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeriod.ForeColor = System.Drawing.Color.DimGray;
            this.txtPeriod.Location = new System.Drawing.Point(163, 89);
            this.txtPeriod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Size = new System.Drawing.Size(111, 25);
            this.txtPeriod.TabIndex = 5;
            this.txtPeriod.Text = "0";
            this.txtPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRate
            // 
            this.txtRate.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.ForeColor = System.Drawing.Color.DimGray;
            this.txtRate.Location = new System.Drawing.Point(163, 137);
            this.txtRate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(111, 25);
            this.txtRate.TabIndex = 6;
            this.txtRate.Text = "0";
            this.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDownPay
            // 
            this.txtDownPay.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtDownPay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDownPay.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDownPay.ForeColor = System.Drawing.Color.DimGray;
            this.txtDownPay.Location = new System.Drawing.Point(163, 188);
            this.txtDownPay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDownPay.Name = "txtDownPay";
            this.txtDownPay.Size = new System.Drawing.Size(111, 25);
            this.txtDownPay.TabIndex = 7;
            this.txtDownPay.Text = "0";
            this.txtDownPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPMT
            // 
            this.btnPMT.BackColor = System.Drawing.Color.AliceBlue;
            this.btnPMT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPMT.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnPMT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPMT.FlatAppearance.BorderSize = 0;
            this.btnPMT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPMT.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPMT.ForeColor = System.Drawing.Color.SlateGray;
            this.btnPMT.Location = new System.Drawing.Point(51, 237);
            this.btnPMT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPMT.Name = "btnPMT";
            this.btnPMT.Size = new System.Drawing.Size(105, 36);
            this.btnPMT.TabIndex = 8;
            this.btnPMT.Text = "PMT(月付)";
            this.btnPMT.UseVisualStyleBackColor = false;
            this.btnPMT.Click += new System.EventHandler(this.btnPMT_Click);
            // 
            // btnTotalPay
            // 
            this.btnTotalPay.BackColor = System.Drawing.Color.AliceBlue;
            this.btnTotalPay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTotalPay.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnTotalPay.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTotalPay.FlatAppearance.BorderSize = 0;
            this.btnTotalPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotalPay.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTotalPay.ForeColor = System.Drawing.Color.SlateGray;
            this.btnTotalPay.Location = new System.Drawing.Point(169, 237);
            this.btnTotalPay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTotalPay.Name = "btnTotalPay";
            this.btnTotalPay.Size = new System.Drawing.Size(105, 36);
            this.btnTotalPay.TabIndex = 9;
            this.btnTotalPay.Text = "總付款";
            this.btnTotalPay.UseVisualStyleBackColor = false;
            this.btnTotalPay.Click += new System.EventHandler(this.btnTotalPay_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.AliceBlue;
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.SlateGray;
            this.btnReport.Location = new System.Drawing.Point(0, 294);
            this.btnReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(325, 36);
            this.btnReport.TabIndex = 10;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // frmLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(325, 330);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnTotalPay);
            this.Controls.Add(this.btnPMT);
            this.Controls.Add(this.txtDownPay);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtPeriod);
            this.Controls.Add(this.labDownPay);
            this.Controls.Add(this.labRate);
            this.Controls.Add(this.labPeriod);
            this.Controls.Add(this.labLoan);
            this.Controls.Add(this.txtLoan);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmLoan";
            this.Text = "貸款金額計算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLoan;
        private System.Windows.Forms.Label labLoan;
        private System.Windows.Forms.Label labPeriod;
        private System.Windows.Forms.Label labRate;
        private System.Windows.Forms.Label labDownPay;
        private System.Windows.Forms.TextBox txtPeriod;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtDownPay;
        private System.Windows.Forms.Button btnPMT;
        private System.Windows.Forms.Button btnTotalPay;
        private System.Windows.Forms.Button btnReport;
    }
}