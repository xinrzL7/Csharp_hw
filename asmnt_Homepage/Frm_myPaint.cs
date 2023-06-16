using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace asmnt_Homepage
{
    public partial class frmmyPaint : Form
    {
        Graphics g;
        int x = -1;
        int y = -1;
        bool draw = false;
        Pen pen;

        public frmmyPaint()
        {
            InitializeComponent();
            g = pnlCanvas.CreateGraphics();
            
            pen = new Pen(Color.Black, 1);  //預設顏色粗細
            //筆畫變順
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }
        
        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog clr = new ColorDialog();
            if (clr.ShowDialog() == DialogResult.OK) 
                txtColor.BackColor = clr.Color;
            pen.Color = clr.Color;
        }
        

        private void pnlCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            draw = true;
            x = e.X;
            y = e.Y;
            pnlCanvas.Cursor = Cursors.Cross;
        }

        private void pnlCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw && x != -1 && y !=-1) 
            {
                g.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }
        }

        private void pnlCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;
            x = -1;
            y = -1;
            pnlCanvas.Cursor = Cursors.Default;
        }

        private void tbarSize_Scroll(object sender, EventArgs e)
        {
            pen.Width = tbarSize.Value;
           
            labSize.Text = pen.Width.ToString();
        }
    }
}

