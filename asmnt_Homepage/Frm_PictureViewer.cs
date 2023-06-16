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

        picViewer1 pv1 = new picViewer1();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pv1.imageShow(pictureBox1.Image);
            pv1.ShowDialog();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pv1.imageShow(pictureBox2.Image);
            pv1.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pv1.imageShow(pictureBox3.Image);
            pv1.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pv1.imageShow(pictureBox4.Image);
            pv1.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pv1.imageShow(pictureBox5.Image);
            pv1.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pv1.imageShow(pictureBox6.Image);
            pv1.ShowDialog();
        }
    }
}
