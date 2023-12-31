﻿namespace asmnt_Homepage
{
    partial class frmInputBox
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
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnCencel = new System.Windows.Forms.Button();
            this.labPrompt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.LightCyan;
            this.btnEnter.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.ForeColor = System.Drawing.Color.Teal;
            this.btnEnter.Location = new System.Drawing.Point(230, 86);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(62, 29);
            this.btnEnter.TabIndex = 0;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.Color.LightCyan;
            this.txtInput.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.ForeColor = System.Drawing.Color.Teal;
            this.txtInput.Location = new System.Drawing.Point(11, 86);
            this.txtInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(216, 30);
            this.txtInput.TabIndex = 1;
            // 
            // btnCencel
            // 
            this.btnCencel.BackColor = System.Drawing.Color.LightCyan;
            this.btnCencel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCencel.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCencel.ForeColor = System.Drawing.Color.Teal;
            this.btnCencel.Location = new System.Drawing.Point(296, 86);
            this.btnCencel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCencel.Name = "btnCencel";
            this.btnCencel.Size = new System.Drawing.Size(77, 29);
            this.btnCencel.TabIndex = 2;
            this.btnCencel.Text = "Cancel";
            this.btnCencel.UseVisualStyleBackColor = false;
            this.btnCencel.Click += new System.EventHandler(this.btnCencel_Click);
            // 
            // labPrompt
            // 
            this.labPrompt.AutoEllipsis = true;
            this.labPrompt.AutoSize = true;
            this.labPrompt.BackColor = System.Drawing.Color.Transparent;
            this.labPrompt.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPrompt.ForeColor = System.Drawing.Color.Teal;
            this.labPrompt.Location = new System.Drawing.Point(8, 23);
            this.labPrompt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labPrompt.Name = "labPrompt";
            this.labPrompt.Size = new System.Drawing.Size(240, 23);
            this.labPrompt.TabIndex = 3;
            this.labPrompt.Text = "Please input a number.";
            // 
            // frmInputBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(381, 123);
            this.Controls.Add(this.labPrompt);
            this.Controls.Add(this.btnCencel);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnEnter);
            this.Font = new System.Drawing.Font("Century", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmInputBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnCencel;
        private System.Windows.Forms.Label labPrompt;
    }
}