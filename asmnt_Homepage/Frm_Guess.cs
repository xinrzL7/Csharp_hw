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
        public int gsAnswer;
        public void  GenerateNumber()
        {
            Random random = new Random();
            gsAnswer = random.Next(1, 101);
        }
        
        public frmGuess()
        {
            InitializeComponent();
            GenerateNumber();
        }
        private void btnAnswer_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"The answer is {gsAnswer}.");
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            frmInputBox inputbox = new frmInputBox();
            inputbox.Show();
        }
    }
}
