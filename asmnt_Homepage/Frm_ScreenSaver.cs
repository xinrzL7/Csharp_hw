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
    public partial class frmScreenSaver : Form
    {
         Point lastMousePosition;
        int moveX=5, moveY=5;

        public frmScreenSaver()
        {
            InitializeComponent();
            this.lastMousePosition = Cursor.Position;
            this.timeTime.Tick += timeTime_Tick;
        }
        //圖片移動方向
        private void timeTime_Tick(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X + moveX, pictureBox1.Location.Y + moveY);
            if (pictureBox1.Right >= ClientSize.Width || pictureBox1.Left <= 0)
            {
                moveX = -moveX; // 水平
            }
            if (pictureBox1.Bottom >= ClientSize.Height || pictureBox1.Top <= 0)
            {
                moveY = -moveY; // 垂直
            }
        }
        // 檢查滑鼠是否移動，如果有則關閉程式
        protected override void OnMouseMove(MouseEventArgs e)
        {
            //base.OnMouseMove(e);
            if (Math.Abs(Cursor.Position.X - this.lastMousePosition.X) > 10 || Math.Abs(Cursor.Position.Y - this.lastMousePosition.Y) > 10)
            {
                Close();
            }
        }
    }
}
