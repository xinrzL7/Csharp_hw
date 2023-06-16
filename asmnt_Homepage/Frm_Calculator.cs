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
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        double Num1;
        double Num2;
        double Result;

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out Num1) && double.TryParse(txtNum2.Text, out Num2))
            {
                Result =Num1 + Num2;
                txtResult.Text = Result.ToString();
            }
            else
            {
                MessageBox.Show("請輸入數字！");
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out Num1) && double.TryParse(txtNum2.Text, out Num2))
            {
                Result = Num1 - Num2;
                txtResult.Text = Result.ToString();
            }
            else
            {
                MessageBox.Show("請輸入數字！");
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out Num1) && double.TryParse(txtNum2.Text, out Num2))
            {
                Result = Num1 * Num2;
                txtResult.Text = Result.ToString();
            }
            else
            {
                MessageBox.Show("請輸入數字！");
            }
        }

        private void btnDivided_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out Num1) && double.TryParse(txtNum2.Text, out Num2))
            {
                Result = Num1 / Num2;
                txtResult.Text = Result.ToString();
            }
            else
            {
                MessageBox.Show("請輸入數字！");
            }
        }

       
    }
}
