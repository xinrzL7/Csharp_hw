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
    public partial class frmPicViewer : Form
    {
        public frmPicViewer()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            picViewer1 pv1 = new picViewer1();
            pv1.Show();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            picViewer2 pv2 = new picViewer2();
            pv2.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            picViewer3 pv3 = new picViewer3();
            pv3.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            picViewer4 pv4 = new picViewer4();
            pv4.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            picViewer5 pv5 = new picViewer5();
            pv5.Show();
        }
    }
}
