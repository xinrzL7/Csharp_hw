using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Runtime.InteropServices;

namespace asmnt_Homepage
{
    public partial class frmHomePage : Form
    {
        public frmHomePage()
        {
            InitializeComponent();
        }

        //擋到控制項要有滾輪--sc2panel的autoscroll設定True
        //控制項隨著視窗改變大小--Anchor設定right/left/top
        
        //按鈕觸發後變色
        public void btnColor(Button btn) 
        {
            foreach (Control item in sc2.Panel1.Controls)
            {
                if (item is Button && item != btn)
                    item.BackColor = Color.Transparent;
                else
                    item.BackColor = Color.Tan;
            }
        }

        //視窗開啟
        public void formOpen(Button btn, Form frm) 
        {
            sc2.Panel2.Controls.Clear();
            btnColor(btn);
            frm.TopLevel = false;
            sc2.Panel2.Controls.Add(frm);
            frm.Show();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            frmHello hello = new frmHello();
            formOpen(btnHello, hello);
        }
        
        private void btnLoan_Click(object sender, EventArgs e)
        {
            frmLoan loan = new frmLoan();   
            formOpen(btnLoan, loan);
        }
        
        private void btnPOS_Click(object sender, EventArgs e)
        {
            frmPOS pos = new frmPOS();
            formOpen(btnPOS, pos);
        }

        private void btnStudentStruct_Click(object sender, EventArgs e)
        {
            frmStudentStruct stuStruct = new frmStudentStruct();
            formOpen(btnStudentStruct, stuStruct);
        }

        private void btnPaint_Click(object sender, EventArgs e)
        {
            sc2.Panel2.Controls.Clear();
            btnColor(btnPaint);
            try
            {
                //小畫家檔名
                string paintFileName = "mspaint.exe";

                //從系統環境變數中取得路徑
                string systemPath = Environment.GetEnvironmentVariable("PATH");

                //搜尋每個路徑
                string[] paths = systemPath.Split(';');
                foreach (string path in paths)
                {
                    string paintPath = System.IO.Path.Combine(path, paintFileName);

                    if (System.IO.File.Exists(paintPath))
                    {
                        Process.Start(paintPath);
                        return;
                    }
                }
                MessageBox.Show("找不到小畫家的路徑");
            }
            catch (Exception ex)
            {
                MessageBox.Show("無法啟動小畫家：" + ex.Message);
            }
        }
        
        private void btnGuess_Click(object sender, EventArgs e)
        {
            frmGuess guess = new frmGuess();
            formOpen(btnGuess, guess);
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            frmCalculator calc = new frmCalculator();
            formOpen(btnCalculator, calc);
        }

        private void btnNotepad_Click(object sender, EventArgs e)
        {
            sc2.Panel2.Controls.Clear();
            btnColor(btnNotepad);
            frmNotepad notepad = new frmNotepad();
            notepad.Show();
        }

        private void btnScreenSaver_Click(object sender, EventArgs e)
        {
            sc2.Panel2.Controls.Clear();
            btnColor(btnScreenSaver);
            frmScreenSaver ss  = new frmScreenSaver();
            ss.Show();
        }

        private void btnXOgame_Click(object sender, EventArgs e)
        {
            frmXOgame xo = new frmXOgame();
            formOpen(btnXOgame, xo);
        }

        private void btnPicViewer_Click(object sender, EventArgs e)
        {
            frmPicViewer picViewer = new frmPicViewer();
            formOpen(btnPicViewer, picViewer);
        }

        private void btnmyPaint_Click(object sender, EventArgs e)
        {
            frmmyPaint mp = new frmmyPaint();
            formOpen(btnmyPaint, mp);
        }
    }
}
