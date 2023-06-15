using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asmnt_Homepage
{
    public partial class frmXOgame : Form
    {
        public frmXOgame()
        {
            InitializeComponent();
            //快捷鍵R
            this.KeyDown += (sender, e) =>
            {
                if (e.KeyData == Keys.R)
                    btnReset_Click(sender, e);
            };
            //快捷鍵esc
            this.KeyDown += (sender, e) =>
            {
                if (e.KeyData == Keys.Escape)
                    btnEsc_Click(sender, e);
            };
        }
        int nr = 0;

        
        private void btn_Click(object sender, EventArgs e)
        {
            nr++;
            Button b = (Button)sender;
            if (nr % 2 != 0)
            {
                b.Text = "X";
            }
            else 
            {
                b.Text = "O";
            }
            b.Enabled = false;

            if ((btn1.Text == btn2.Text && btn2.Text == btn3.Text && btn1.Enabled == false) ||
            (btn4.Text == btn5.Text && btn5.Text == btn6.Text && btn4.Enabled == false) ||
            (btn7.Text == btn8.Text && btn8.Text == btn9.Text && btn7.Enabled == false) ||
            (btn1.Text == btn4.Text && btn4.Text == btn7.Text && btn1.Enabled == false) ||
            (btn2.Text == btn5.Text && btn5.Text == btn8.Text && btn2.Enabled == false) ||
            (btn3.Text == btn6.Text && btn6.Text == btn9.Text && btn3.Enabled == false) ||
            (btn1.Text == btn5.Text && btn5.Text == btn9.Text && btn1.Enabled == false) ||
            (btn3.Text == btn5.Text && btn5.Text == btn7.Text && btn3.Enabled == false))
            {
                if (nr % 2 != 0)
                {
                    ResetMethod();
                    MessageBox.Show("X wins.");
                }
                else
                {
                    ResetMethod();
                    MessageBox.Show("O wins.");
                }
            }
            else if (nr == 9) 
            {
                ResetMethod();
                MessageBox.Show("Drew :(.");
            }
        }
        public void ResetMethod()
        {
            foreach (Control item in Controls)
            {
                if (item != btnReset && item != btnEsc && item != labXO)
                {
                    item.Text = "";
                    item.Enabled = true;
                }
            }
            nr = 0;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetMethod();
        }

        private void btnEsc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
