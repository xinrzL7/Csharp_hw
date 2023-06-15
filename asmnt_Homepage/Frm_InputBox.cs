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
    public partial class frmInputBox : Form
    {
        public frmInputBox()
        {
            InitializeComponent();
        }
        public int AnswerNumber;
        public int GuessNumber;
        public int MaxNumber = 100;
        public int MinNumber = 1;
        public  void GenerateNumber()
        {
            Random random = new Random();
            AnswerNumber = random.Next(1, 101);
        }
        frmGuess gs =  new frmGuess();
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out GuessNumber))
            {
                if (GuessNumber <= 100 || GuessNumber >= 1)
                {
                    if (GuessNumber != AnswerNumber)
                    {
                        if (GuessNumber < AnswerNumber)
                        {
                            MinNumber = GuessNumber;
                            //gs.GuessRange =
                                //$"Too small. Select a number between {GuessNumber} and {MaxNumber}";
                        }
                        else if (GuessNumber > AnswerNumber) 
                        {
                            MaxNumber = AnswerNumber;
                            //gs.GuessRange = 
                                //$"Too large. Select a number between {MinNumber} to {GuessNumber}";
                        }
                    }
                    else
                    { 
                        MessageBox.Show($"Congradulations. You're right, the answer is {GuessNumber}."); 
                        GenerateNumber();
                    }
                }

                else
                    MessageBox.Show("請輸入範圍1-100內的數字");
            }
            else
                MessageBox.Show("請輸入整數");
            this.Close();
        }
    }
}
