namespace asmnt_Homepage
{
    partial class frmHomePage
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.sc1 = new System.Windows.Forms.SplitContainer();
            this.labCsharp = new System.Windows.Forms.Label();
            this.sc2 = new System.Windows.Forms.SplitContainer();
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnPicViewer = new System.Windows.Forms.Button();
            this.btnPaint = new System.Windows.Forms.Button();
            this.btnNotepad = new System.Windows.Forms.Button();
            this.btnScreenSaver = new System.Windows.Forms.Button();
            this.btnXOgame = new System.Windows.Forms.Button();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.btnStudentStruct = new System.Windows.Forms.Button();
            this.btnPOS = new System.Windows.Forms.Button();
            this.btnLoan = new System.Windows.Forms.Button();
            this.btnHello = new System.Windows.Forms.Button();
            this.btnmyPaint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sc1)).BeginInit();
            this.sc1.Panel1.SuspendLayout();
            this.sc1.Panel2.SuspendLayout();
            this.sc1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sc2)).BeginInit();
            this.sc2.Panel1.SuspendLayout();
            this.sc2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sc1
            // 
            this.sc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc1.Location = new System.Drawing.Point(0, 0);
            this.sc1.Name = "sc1";
            this.sc1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sc1.Panel1
            // 
            this.sc1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.sc1.Panel1.BackgroundImage = global::asmnt_Homepage.Properties.Resources.flower_graygreen;
            this.sc1.Panel1.Controls.Add(this.labCsharp);
            // 
            // sc1.Panel2
            // 
            this.sc1.Panel2.AutoScroll = true;
            this.sc1.Panel2.BackColor = System.Drawing.Color.Azure;
            this.sc1.Panel2.Controls.Add(this.sc2);
            this.sc1.Size = new System.Drawing.Size(1157, 723);
            this.sc1.SplitterDistance = 143;
            this.sc1.TabIndex = 0;
            // 
            // labCsharp
            // 
            this.labCsharp.AutoSize = true;
            this.labCsharp.BackColor = System.Drawing.Color.Transparent;
            this.labCsharp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labCsharp.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labCsharp.ForeColor = System.Drawing.Color.Ivory;
            this.labCsharp.Location = new System.Drawing.Point(0, 82);
            this.labCsharp.Name = "labCsharp";
            this.labCsharp.Size = new System.Drawing.Size(186, 61);
            this.labCsharp.TabIndex = 0;
            this.labCsharp.Text = "C#作業";
            this.labCsharp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sc2
            // 
            this.sc2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sc2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.sc2.Location = new System.Drawing.Point(0, 0);
            this.sc2.Name = "sc2";
            // 
            // sc2.Panel1
            // 
            this.sc2.Panel1.AutoScroll = true;
            this.sc2.Panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.sc2.Panel1.Controls.Add(this.btnmyPaint);
            this.sc2.Panel1.Controls.Add(this.btnGuess);
            this.sc2.Panel1.Controls.Add(this.btnPicViewer);
            this.sc2.Panel1.Controls.Add(this.btnPaint);
            this.sc2.Panel1.Controls.Add(this.btnNotepad);
            this.sc2.Panel1.Controls.Add(this.btnScreenSaver);
            this.sc2.Panel1.Controls.Add(this.btnXOgame);
            this.sc2.Panel1.Controls.Add(this.btnCalculator);
            this.sc2.Panel1.Controls.Add(this.btnStudentStruct);
            this.sc2.Panel1.Controls.Add(this.btnPOS);
            this.sc2.Panel1.Controls.Add(this.btnLoan);
            this.sc2.Panel1.Controls.Add(this.btnHello);
            this.sc2.Panel1.ForeColor = System.Drawing.Color.Beige;
            // 
            // sc2.Panel2
            // 
            this.sc2.Panel2.BackColor = System.Drawing.Color.MintCream;
            this.sc2.Panel2.BackgroundImage = global::asmnt_Homepage.Properties.Resources.wallpaper_lien2;
            this.sc2.Size = new System.Drawing.Size(1157, 576);
            this.sc2.SplitterDistance = 255;
            this.sc2.TabIndex = 0;
            // 
            // btnGuess
            // 
            this.btnGuess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuess.BackColor = System.Drawing.Color.Transparent;
            this.btnGuess.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGuess.FlatAppearance.BorderSize = 0;
            this.btnGuess.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGuess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.btnGuess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuess.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuess.ForeColor = System.Drawing.Color.Ivory;
            this.btnGuess.Location = new System.Drawing.Point(21, 455);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(207, 35);
            this.btnGuess.TabIndex = 15;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = false;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // btnPicViewer
            // 
            this.btnPicViewer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPicViewer.BackColor = System.Drawing.Color.Transparent;
            this.btnPicViewer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPicViewer.FlatAppearance.BorderSize = 0;
            this.btnPicViewer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPicViewer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.btnPicViewer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPicViewer.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPicViewer.ForeColor = System.Drawing.Color.Ivory;
            this.btnPicViewer.Location = new System.Drawing.Point(21, 414);
            this.btnPicViewer.Name = "btnPicViewer";
            this.btnPicViewer.Size = new System.Drawing.Size(207, 35);
            this.btnPicViewer.TabIndex = 14;
            this.btnPicViewer.Text = "Picture Viewer";
            this.btnPicViewer.UseVisualStyleBackColor = false;
            this.btnPicViewer.Click += new System.EventHandler(this.btnPicViewer_Click);
            // 
            // btnPaint
            // 
            this.btnPaint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPaint.BackColor = System.Drawing.Color.Transparent;
            this.btnPaint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPaint.FlatAppearance.BorderSize = 0;
            this.btnPaint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPaint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.btnPaint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaint.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaint.ForeColor = System.Drawing.Color.Ivory;
            this.btnPaint.Location = new System.Drawing.Point(21, 332);
            this.btnPaint.Name = "btnPaint";
            this.btnPaint.Size = new System.Drawing.Size(207, 35);
            this.btnPaint.TabIndex = 8;
            this.btnPaint.Text = "Paint";
            this.btnPaint.UseVisualStyleBackColor = false;
            this.btnPaint.Click += new System.EventHandler(this.btnPaint_Click);
            // 
            // btnNotepad
            // 
            this.btnNotepad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNotepad.BackColor = System.Drawing.Color.Transparent;
            this.btnNotepad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNotepad.FlatAppearance.BorderSize = 0;
            this.btnNotepad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNotepad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.btnNotepad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotepad.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotepad.ForeColor = System.Drawing.Color.Ivory;
            this.btnNotepad.Location = new System.Drawing.Point(21, 291);
            this.btnNotepad.Name = "btnNotepad";
            this.btnNotepad.Size = new System.Drawing.Size(207, 35);
            this.btnNotepad.TabIndex = 13;
            this.btnNotepad.Text = "Notepad";
            this.btnNotepad.UseVisualStyleBackColor = false;
            this.btnNotepad.Click += new System.EventHandler(this.btnNotepad_Click);
            // 
            // btnScreenSaver
            // 
            this.btnScreenSaver.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScreenSaver.BackColor = System.Drawing.Color.Transparent;
            this.btnScreenSaver.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnScreenSaver.FlatAppearance.BorderSize = 0;
            this.btnScreenSaver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnScreenSaver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.btnScreenSaver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScreenSaver.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScreenSaver.ForeColor = System.Drawing.Color.Ivory;
            this.btnScreenSaver.Location = new System.Drawing.Point(21, 250);
            this.btnScreenSaver.Name = "btnScreenSaver";
            this.btnScreenSaver.Size = new System.Drawing.Size(207, 35);
            this.btnScreenSaver.TabIndex = 12;
            this.btnScreenSaver.Text = "Screen Saver";
            this.btnScreenSaver.UseVisualStyleBackColor = false;
            this.btnScreenSaver.Click += new System.EventHandler(this.btnScreenSaver_Click);
            // 
            // btnXOgame
            // 
            this.btnXOgame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXOgame.BackColor = System.Drawing.Color.Transparent;
            this.btnXOgame.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnXOgame.FlatAppearance.BorderSize = 0;
            this.btnXOgame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnXOgame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.btnXOgame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXOgame.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXOgame.ForeColor = System.Drawing.Color.Ivory;
            this.btnXOgame.Location = new System.Drawing.Point(21, 209);
            this.btnXOgame.Name = "btnXOgame";
            this.btnXOgame.Size = new System.Drawing.Size(207, 35);
            this.btnXOgame.TabIndex = 11;
            this.btnXOgame.Text = "XO Game";
            this.btnXOgame.UseVisualStyleBackColor = false;
            this.btnXOgame.Click += new System.EventHandler(this.btnXOgame_Click);
            // 
            // btnCalculator
            // 
            this.btnCalculator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalculator.BackColor = System.Drawing.Color.Transparent;
            this.btnCalculator.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCalculator.FlatAppearance.BorderSize = 0;
            this.btnCalculator.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCalculator.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.btnCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculator.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculator.ForeColor = System.Drawing.Color.Ivory;
            this.btnCalculator.Location = new System.Drawing.Point(21, 168);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(207, 35);
            this.btnCalculator.TabIndex = 9;
            this.btnCalculator.Text = "My Calculator";
            this.btnCalculator.UseVisualStyleBackColor = false;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // btnStudentStruct
            // 
            this.btnStudentStruct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStudentStruct.BackColor = System.Drawing.Color.Transparent;
            this.btnStudentStruct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStudentStruct.FlatAppearance.BorderSize = 0;
            this.btnStudentStruct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnStudentStruct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.btnStudentStruct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentStruct.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentStruct.ForeColor = System.Drawing.Color.Ivory;
            this.btnStudentStruct.Location = new System.Drawing.Point(21, 127);
            this.btnStudentStruct.Name = "btnStudentStruct";
            this.btnStudentStruct.Size = new System.Drawing.Size(207, 35);
            this.btnStudentStruct.TabIndex = 4;
            this.btnStudentStruct.Text = "Student struct form";
            this.btnStudentStruct.UseVisualStyleBackColor = false;
            this.btnStudentStruct.Click += new System.EventHandler(this.btnStudentStruct_Click);
            // 
            // btnPOS
            // 
            this.btnPOS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPOS.BackColor = System.Drawing.Color.Transparent;
            this.btnPOS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPOS.FlatAppearance.BorderSize = 0;
            this.btnPOS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPOS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.btnPOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPOS.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPOS.ForeColor = System.Drawing.Color.Ivory;
            this.btnPOS.Location = new System.Drawing.Point(21, 90);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Size = new System.Drawing.Size(207, 35);
            this.btnPOS.TabIndex = 3;
            this.btnPOS.Text = "POS";
            this.btnPOS.UseVisualStyleBackColor = false;
            this.btnPOS.Click += new System.EventHandler(this.btnPOS_Click);
            // 
            // btnLoan
            // 
            this.btnLoan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoan.BackColor = System.Drawing.Color.Transparent;
            this.btnLoan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLoan.FlatAppearance.BorderSize = 0;
            this.btnLoan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLoan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.btnLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoan.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoan.ForeColor = System.Drawing.Color.Ivory;
            this.btnLoan.Location = new System.Drawing.Point(21, 52);
            this.btnLoan.Name = "btnLoan";
            this.btnLoan.Size = new System.Drawing.Size(207, 35);
            this.btnLoan.TabIndex = 2;
            this.btnLoan.Text = "Loan";
            this.btnLoan.UseVisualStyleBackColor = false;
            this.btnLoan.Click += new System.EventHandler(this.btnLoan_Click);
            // 
            // btnHello
            // 
            this.btnHello.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHello.BackColor = System.Drawing.Color.Transparent;
            this.btnHello.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHello.FlatAppearance.BorderSize = 0;
            this.btnHello.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHello.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.btnHello.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHello.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHello.ForeColor = System.Drawing.Color.Ivory;
            this.btnHello.Location = new System.Drawing.Point(21, 14);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(207, 35);
            this.btnHello.TabIndex = 1;
            this.btnHello.Text = "Hello";
            this.btnHello.UseVisualStyleBackColor = false;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // btnmyPaint
            // 
            this.btnmyPaint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmyPaint.BackColor = System.Drawing.Color.Transparent;
            this.btnmyPaint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnmyPaint.FlatAppearance.BorderSize = 0;
            this.btnmyPaint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnmyPaint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan;
            this.btnmyPaint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmyPaint.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmyPaint.ForeColor = System.Drawing.Color.Ivory;
            this.btnmyPaint.Location = new System.Drawing.Point(21, 373);
            this.btnmyPaint.Name = "btnmyPaint";
            this.btnmyPaint.Size = new System.Drawing.Size(207, 35);
            this.btnmyPaint.TabIndex = 16;
            this.btnmyPaint.Text = "myPaint";
            this.btnmyPaint.UseVisualStyleBackColor = false;
            this.btnmyPaint.Click += new System.EventHandler(this.btnmyPaint_Click);
            // 
            // frmHomePage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1157, 723);
            this.Controls.Add(this.sc1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ForeColor = System.Drawing.Color.Beige;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmHomePage";
            this.Text = "HomePage";
            this.sc1.Panel1.ResumeLayout(false);
            this.sc1.Panel1.PerformLayout();
            this.sc1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc1)).EndInit();
            this.sc1.ResumeLayout(false);
            this.sc2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc2)).EndInit();
            this.sc2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer sc1;
        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.Button btnLoan;
        private System.Windows.Forms.SplitContainer sc2;
        private System.Windows.Forms.Label labCsharp;
        private System.Windows.Forms.Button btnCalculator;
        private System.Windows.Forms.Button btnPaint;
        private System.Windows.Forms.Button btnStudentStruct;
        private System.Windows.Forms.Button btnPOS;
        private System.Windows.Forms.Button btnNotepad;
        private System.Windows.Forms.Button btnScreenSaver;
        private System.Windows.Forms.Button btnXOgame;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnPicViewer;
        private System.Windows.Forms.Button btnmyPaint;
    }
}

