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
        int PenSize;
        //private Bitmap drawingBitmap;
        //private Graphics drawingGraphics;
        public frmmyPaint()
        {
            InitializeComponent();
            //tbarSize.ValueChanged += TrackBar_ValueChanged;
            //// 建立圖像緩衝區和相應的繪圖物件
            //drawingBitmap = new Bitmap(ClientSize.Width, ClientSize.Height);
            //drawingGraphics = Graphics.FromImage(drawingBitmap);
        }
        private void TrackBar_ValueChanged(object sender, EventArgs e)
        {
            //PenSize = tbarSize.Value;
            //labSize.Text = tbarSize.Value.ToString();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog clr = new ColorDialog();
            if (clr.ShowDialog() == DialogResult.OK) 
                txtColor.BackColor = clr.Color;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            //// 在視窗的繪製事件中將圖像緩衝區的內容繪製到視窗上
            //e.Graphics.DrawImage(drawingBitmap, 0, 0);
        }
        //protected override void OnMouseMove(MouseEventArgs e)
        //{
        //    在滑鼠移動時繪製畫筆
        //    if (e.Button == MouseButtons.Left)
        //    {
        //        using (Pen pen = new Pen(Color.Black, PenSize))
        //        {
        //            drawingGraphics.DrawEllipse(pen, e.X, e.Y, PenSize, PenSize);
        //        }

        //        // 重新繪製視窗，以顯示更新的筆劃
        //        Invalidate();
        //    }

        //    base.OnMouseMove(e);
        //}
    }
}

