using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace asmnt_Homepage
{
    public partial class frmHello : Form
    {
        public frmHello()
        {
            InitializeComponent();
        }
        HelloHi hh = new HelloHi();
        private void btnHello_Click(object sender, EventArgs e)
        {
            hh.Name = txtName.Text;
            hh.enName = txtenName.Text;
            hh.Gender = txtGender.Text;
            hh.Sign = txtSign.Text;
            
            MessageBox.Show($"Hello, I'm {hh.Name}." +
                $"\nMy English name is {hh.enName}."+
                $"\nMy gender is {hh.Gender}."+
                $"\nMy zodiac sign is {hh.Sign}."+
                $"\nNice to meet you.");
        }

        private void btnHi_Click(object sender, EventArgs e)
        {
            hh.Name = txtName.Text;
            hh.enName = txtenName.Text;
            hh.Gender = txtGender.Text;
            hh.Sign = txtSign.Text;

            MessageBox.Show($"Hi, I'm {hh.Name}." +
                $"\nMy English name is {hh.enName}." +
                $"\nMy gender is {hh.Gender}." +
                $"\nMy zodiac sign is {hh.Sign}." +
                $"\nNice to meet you.");
        }
    }
}
