namespace asmnt_Homepage
{
    partial class frmPOS
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
            this.panMenu = new System.Windows.Forms.Panel();
            this.btnWine = new System.Windows.Forms.Button();
            this.btnWhisky = new System.Windows.Forms.Button();
            this.btnTequila = new System.Windows.Forms.Button();
            this.btnBeer = new System.Windows.Forms.Button();
            this.labMenu = new System.Windows.Forms.Label();
            this.panPrice = new System.Windows.Forms.Panel();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.labPrice = new System.Windows.Forms.Label();
            this.panList = new System.Windows.Forms.Panel();
            this.txtList = new System.Windows.Forms.TextBox();
            this.btnClearList = new System.Windows.Forms.Button();
            this.labList = new System.Windows.Forms.Label();
            this.panPay = new System.Windows.Forms.Panel();
            this.labDiscount = new System.Windows.Forms.Label();
            this.btnCreditCard = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.labPay = new System.Windows.Forms.Label();
            this.panMenu.SuspendLayout();
            this.panPrice.SuspendLayout();
            this.panList.SuspendLayout();
            this.panPay.SuspendLayout();
            this.SuspendLayout();
            // 
            // panMenu
            // 
            this.panMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panMenu.Controls.Add(this.btnWine);
            this.panMenu.Controls.Add(this.btnWhisky);
            this.panMenu.Controls.Add(this.btnTequila);
            this.panMenu.Controls.Add(this.btnBeer);
            this.panMenu.Controls.Add(this.labMenu);
            this.panMenu.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panMenu.Location = new System.Drawing.Point(6, 12);
            this.panMenu.Name = "panMenu";
            this.panMenu.Size = new System.Drawing.Size(224, 302);
            this.panMenu.TabIndex = 0;
            // 
            // btnWine
            // 
            this.btnWine.BackColor = System.Drawing.Color.GhostWhite;
            this.btnWine.BackgroundImage = global::asmnt_Homepage.Properties.Resources.wine;
            this.btnWine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWine.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnWine.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnWine.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnWine.Location = new System.Drawing.Point(111, 170);
            this.btnWine.Name = "btnWine";
            this.btnWine.Size = new System.Drawing.Size(101, 121);
            this.btnWine.TabIndex = 4;
            this.btnWine.Text = "紅酒\r\nWine\r\nNT 320";
            this.btnWine.UseVisualStyleBackColor = false;
            this.btnWine.Click += new System.EventHandler(this.btnWine_Click);
            // 
            // btnWhisky
            // 
            this.btnWhisky.BackColor = System.Drawing.Color.GhostWhite;
            this.btnWhisky.BackgroundImage = global::asmnt_Homepage.Properties.Resources.whisky;
            this.btnWhisky.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWhisky.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnWhisky.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnWhisky.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnWhisky.Location = new System.Drawing.Point(7, 170);
            this.btnWhisky.Name = "btnWhisky";
            this.btnWhisky.Size = new System.Drawing.Size(101, 121);
            this.btnWhisky.TabIndex = 3;
            this.btnWhisky.Text = "威士忌\r\nWhisky\r\nNT 350";
            this.btnWhisky.UseVisualStyleBackColor = false;
            this.btnWhisky.Click += new System.EventHandler(this.btnWhisky_Click);
            // 
            // btnTequila
            // 
            this.btnTequila.BackColor = System.Drawing.Color.GhostWhite;
            this.btnTequila.BackgroundImage = global::asmnt_Homepage.Properties.Resources.tequila;
            this.btnTequila.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTequila.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTequila.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTequila.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTequila.Location = new System.Drawing.Point(111, 43);
            this.btnTequila.Name = "btnTequila";
            this.btnTequila.Size = new System.Drawing.Size(101, 121);
            this.btnTequila.TabIndex = 2;
            this.btnTequila.Text = "龍舌蘭\r\nTequila\r\nNT 180";
            this.btnTequila.UseVisualStyleBackColor = false;
            this.btnTequila.Click += new System.EventHandler(this.btnTequila_Click);
            // 
            // btnBeer
            // 
            this.btnBeer.BackColor = System.Drawing.Color.GhostWhite;
            this.btnBeer.BackgroundImage = global::asmnt_Homepage.Properties.Resources.beer;
            this.btnBeer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBeer.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBeer.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBeer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBeer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBeer.Location = new System.Drawing.Point(7, 43);
            this.btnBeer.Name = "btnBeer";
            this.btnBeer.Size = new System.Drawing.Size(101, 121);
            this.btnBeer.TabIndex = 1;
            this.btnBeer.Text = "啤酒\r\nBeer\r\nNT 120";
            this.btnBeer.UseVisualStyleBackColor = false;
            this.btnBeer.Click += new System.EventHandler(this.btnBeer_Click);
            // 
            // labMenu
            // 
            this.labMenu.AutoSize = true;
            this.labMenu.BackColor = System.Drawing.Color.LightGray;
            this.labMenu.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMenu.ForeColor = System.Drawing.Color.Maroon;
            this.labMenu.Location = new System.Drawing.Point(5, 9);
            this.labMenu.Name = "labMenu";
            this.labMenu.Size = new System.Drawing.Size(48, 24);
            this.labMenu.TabIndex = 0;
            this.labMenu.Text = "酒單";
            // 
            // panPrice
            // 
            this.panPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panPrice.Controls.Add(this.txtPrice);
            this.panPrice.Controls.Add(this.labPrice);
            this.panPrice.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panPrice.Location = new System.Drawing.Point(241, 12);
            this.panPrice.Name = "panPrice";
            this.panPrice.Size = new System.Drawing.Size(213, 131);
            this.panPrice.TabIndex = 1;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.DarkRed;
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPrice.ForeColor = System.Drawing.Color.White;
            this.txtPrice.Location = new System.Drawing.Point(3, 66);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(205, 32);
            this.txtPrice.TabIndex = 1;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labPrice
            // 
            this.labPrice.AutoSize = true;
            this.labPrice.BackColor = System.Drawing.Color.LightGray;
            this.labPrice.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPrice.ForeColor = System.Drawing.Color.Maroon;
            this.labPrice.Location = new System.Drawing.Point(3, 9);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(67, 24);
            this.labPrice.TabIndex = 0;
            this.labPrice.Text = "總金額";
            // 
            // panList
            // 
            this.panList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panList.Controls.Add(this.txtList);
            this.panList.Controls.Add(this.btnClearList);
            this.panList.Controls.Add(this.labList);
            this.panList.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panList.Location = new System.Drawing.Point(466, 12);
            this.panList.Name = "panList";
            this.panList.Size = new System.Drawing.Size(233, 302);
            this.panList.TabIndex = 2;
            // 
            // txtList
            // 
            this.txtList.BackColor = System.Drawing.Color.GhostWhite;
            this.txtList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtList.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtList.ForeColor = System.Drawing.Color.Black;
            this.txtList.Location = new System.Drawing.Point(9, 43);
            this.txtList.Margin = new System.Windows.Forms.Padding(2);
            this.txtList.Multiline = true;
            this.txtList.Name = "txtList";
            this.txtList.Size = new System.Drawing.Size(213, 212);
            this.txtList.TabIndex = 6;
            this.txtList.Text = "尚未點餐";
            this.txtList.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnClearList
            // 
            this.btnClearList.BackColor = System.Drawing.Color.Linen;
            this.btnClearList.FlatAppearance.BorderSize = 0;
            this.btnClearList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnClearList.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClearList.ForeColor = System.Drawing.Color.IndianRed;
            this.btnClearList.Location = new System.Drawing.Point(116, 260);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(106, 37);
            this.btnClearList.TabIndex = 5;
            this.btnClearList.Text = "清除清單";
            this.btnClearList.UseVisualStyleBackColor = false;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // labList
            // 
            this.labList.AutoSize = true;
            this.labList.BackColor = System.Drawing.Color.LightGray;
            this.labList.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labList.ForeColor = System.Drawing.Color.Maroon;
            this.labList.Location = new System.Drawing.Point(5, 9);
            this.labList.Name = "labList";
            this.labList.Size = new System.Drawing.Size(86, 24);
            this.labList.TabIndex = 0;
            this.labList.Text = "購物清單";
            // 
            // panPay
            // 
            this.panPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panPay.Controls.Add(this.labDiscount);
            this.panPay.Controls.Add(this.btnCreditCard);
            this.panPay.Controls.Add(this.btnCash);
            this.panPay.Controls.Add(this.labPay);
            this.panPay.ForeColor = System.Drawing.Color.Transparent;
            this.panPay.Location = new System.Drawing.Point(241, 149);
            this.panPay.Name = "panPay";
            this.panPay.Size = new System.Drawing.Size(213, 165);
            this.panPay.TabIndex = 3;
            // 
            // labDiscount
            // 
            this.labDiscount.AutoSize = true;
            this.labDiscount.BackColor = System.Drawing.Color.Transparent;
            this.labDiscount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labDiscount.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labDiscount.Location = new System.Drawing.Point(71, 140);
            this.labDiscount.Name = "labDiscount";
            this.labDiscount.Size = new System.Drawing.Size(137, 20);
            this.labDiscount.TabIndex = 2;
            this.labDiscount.Text = "信用卡享九折優惠";
            // 
            // btnCreditCard
            // 
            this.btnCreditCard.BackColor = System.Drawing.Color.Linen;
            this.btnCreditCard.FlatAppearance.BorderSize = 0;
            this.btnCreditCard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnCreditCard.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCreditCard.ForeColor = System.Drawing.Color.IndianRed;
            this.btnCreditCard.Location = new System.Drawing.Point(112, 71);
            this.btnCreditCard.Name = "btnCreditCard";
            this.btnCreditCard.Size = new System.Drawing.Size(96, 43);
            this.btnCreditCard.TabIndex = 4;
            this.btnCreditCard.Text = "信用卡";
            this.btnCreditCard.UseVisualStyleBackColor = false;
            this.btnCreditCard.Click += new System.EventHandler(this.btnCreditCard_Click);
            // 
            // btnCash
            // 
            this.btnCash.BackColor = System.Drawing.Color.Linen;
            this.btnCash.FlatAppearance.BorderSize = 0;
            this.btnCash.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnCash.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCash.ForeColor = System.Drawing.Color.IndianRed;
            this.btnCash.Location = new System.Drawing.Point(3, 71);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(96, 43);
            this.btnCash.TabIndex = 1;
            this.btnCash.Text = "現金";
            this.btnCash.UseVisualStyleBackColor = false;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // labPay
            // 
            this.labPay.AutoSize = true;
            this.labPay.BackColor = System.Drawing.Color.LightGray;
            this.labPay.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPay.ForeColor = System.Drawing.Color.Maroon;
            this.labPay.Location = new System.Drawing.Point(3, 16);
            this.labPay.Name = "labPay";
            this.labPay.Size = new System.Drawing.Size(86, 24);
            this.labPay.TabIndex = 0;
            this.labPay.Text = "付款方式";
            this.labPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(707, 327);
            this.Controls.Add(this.panPay);
            this.Controls.Add(this.panList);
            this.Controls.Add(this.panPrice);
            this.Controls.Add(this.panMenu);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "frmPOS";
            this.Text = "bar POS";
            this.panMenu.ResumeLayout(false);
            this.panMenu.PerformLayout();
            this.panPrice.ResumeLayout(false);
            this.panPrice.PerformLayout();
            this.panList.ResumeLayout(false);
            this.panList.PerformLayout();
            this.panPay.ResumeLayout(false);
            this.panPay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panMenu;
        private System.Windows.Forms.Button btnBeer;
        private System.Windows.Forms.Label labMenu;
        private System.Windows.Forms.Panel panPrice;
        private System.Windows.Forms.Label labPrice;
        private System.Windows.Forms.Panel panList;
        private System.Windows.Forms.Label labList;
        private System.Windows.Forms.Panel panPay;
        private System.Windows.Forms.Label labPay;
        private System.Windows.Forms.Button btnWine;
        private System.Windows.Forms.Button btnWhisky;
        private System.Windows.Forms.Button btnTequila;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label labDiscount;
        private System.Windows.Forms.Button btnCreditCard;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.TextBox txtList;
    }
}