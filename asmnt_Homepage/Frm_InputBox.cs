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
        frmGuess g;
        public frmInputBox(frmGuess g)
        {
            InitializeComponent();
            this.g = g;
        }
        frmGuess gs = new frmGuess();
        int ibAnswer;
        int ibInput;
        int MaxNumber=100;
        int MinNumber=1;
        string Hint = "";

        private void btnEnter_Click(object sender, EventArgs e)
        {
            ibAnswer = gs.gsAnswer;
            
            if (int.TryParse(txtInput.Text, out ibInput))
            {
                if (ibInput <= 100 && ibInput >=1)
                {
                    if (ibInput != ibAnswer)
                    {
                        if (ibInput < ibAnswer)
                        {
                            if(ibInput > MinNumber)
                            {
                                MinNumber = ibInput;
                                Hint = $"Too small. \nInput a number between {MinNumber} and {MaxNumber}.";
                                g.GuessRange = Hint;
                            }
                            else
                                MessageBox.Show($"Too small. \nInput a number between {MinNumber} and {MaxNumber}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (ibInput > ibAnswer)
                        {
                            if (ibInput < MaxNumber) 
                            {
                                MaxNumber = ibInput;
                                Hint = $"Too large. \nInput a number between {MinNumber} and {MaxNumber}.";
                                g.GuessRange = Hint;
                            }
                            else
                                MessageBox.Show($"Input a number between {MinNumber} and {MaxNumber}!!!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Congradulations. You got {ibInput}.");
                        gs.GenerateNumber();
                    }
                }
                else
                    MessageBox.Show("Please input a number between 1 and 100!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("請輸入整數");
        }

        //按下後就重新開始遊戲
        private void btnCencel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
