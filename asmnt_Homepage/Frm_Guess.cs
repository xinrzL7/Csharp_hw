using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace asmnt_Homepage
{
    public partial class frmGuess : Form
    {
        public frmGuess()
        {
            InitializeComponent();
        }


        

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            frmInputBox inputbox = new frmInputBox();
            inputbox.GenerateNumber();  //代表每次開啟視窗都會隨機產生一個數字當謎底
            MessageBox.Show($"Answer: {inputbox.AnswerNumber}");
        }

        //todo 沒辦法在輸入的數字<1或>100時跳出警告
        //todo 沒辦法依照inputbox傳回的值限制範圍也沒有跳出警告
        private void btnGuess_Click(object sender, EventArgs e)
        {
            frmInputBox inputbox = new frmInputBox();
            inputbox.ShowDialog();
        }
    }
}
