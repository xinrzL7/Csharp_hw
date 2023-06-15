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

namespace asmnt_Homepage
{
    public partial class frmHomePage : Form
    {
        public frmHomePage()
        {
            InitializeComponent();
        }
        //todo 視窗會重新開啟不會重疊，多次點擊只會出現一次
        //擋到控制項要有滾輪--sc2panel的autoscroll設定True
        //控制項隨著視窗改變大小--Anchor設定right/left/top

        //已完成
        private void btnHello_Click(object sender, EventArgs e)
        {
            sc2.Panel2.Controls.Clear();
            //將以下觸發視窗的程式碼寫在關掉後才不會一打開就被關掉
            frmHello hello = new frmHello();
            hello.TopLevel = false;  // 表單為最上層
            sc2.Panel2.Controls.Add(hello);  // 表單出現在視窗內，配合toplevel=false
            hello.Show();
        }
        
        
        //todo 要修方法、加tryparse
        private void btnLoan_Click(object sender, EventArgs e)
        {
            sc2.Panel2.Controls.Clear();
            frmLoan loan = new frmLoan();
            loan.TopLevel = false;
            sc2.Panel2.Controls.Add(loan);
            loan.Show();
        }
        
        //已完成
        private void btnPOS_Click(object sender, EventArgs e)
        {
            sc2.Panel2.Controls.Clear();
            frmPOS pos = new frmPOS();
            pos.TopLevel = false;
            sc2.Panel2.Controls.Add(pos);
            pos.Show();
        }

        //已完成
        private void btnStudentStruct_Click(object sender, EventArgs e)
        {
            sc2.Panel2.Controls.Clear();
            frmStudentStruct stuStr = new frmStudentStruct();
            stuStr.TopLevel = false;
            sc2.Panel2.Controls.Add(stuStr);
            stuStr.Show();

        }

        //todo 改成自己設計的
        private void btnPaint_Click(object sender, EventArgs e)
        {
            sc2.Panel2.Controls.Clear();
            try
            {
                // 指定小畫家的檔名
                string paintFileName = "mspaint.exe";

                // 從系統環境變數中取得路徑
                string systemPath = Environment.GetEnvironmentVariable("PATH");

                // 依序搜尋每個路徑
                string[] paths = systemPath.Split(';');
                foreach (string path in paths)
                {
                    string paintPath = System.IO.Path.Combine(path, paintFileName);

                    if (System.IO.File.Exists(paintPath))
                    {
                        // 找到小畫家的路徑，啟動應用程式
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

        //todo 進行中
        private void btnGuess_Click(object sender, EventArgs e)
        {
            sc2.Panel2.Controls.Clear();
            frmGuess guess = new frmGuess();
            guess.TopLevel = false;
            sc2.Panel2.Controls.Add(guess);
            guess.Show();
        }

        //已完成
        private void btnCalculator_Click(object sender, EventArgs e)
        {
            sc2.Panel2.Controls.Clear();
            frmCalculator calc = new frmCalculator();
            calc.TopLevel = false;
            sc2.Panel2.Controls.Add(calc);
            calc.Show();
        }

        private void btnNotepad_Click(object sender, EventArgs e)
        {
            sc2.Panel2.Controls.Clear();
            frmNotepad notepad = new frmNotepad();
            notepad.Show();
        }

        private void btnScreenSaver_Click(object sender, EventArgs e)
        {
            sc2.Panel2.Controls.Clear();
            frmScreenSaver ss  = new frmScreenSaver();
            ss.Show();
        }

        private void btnXOgame_Click(object sender, EventArgs e)
        {
            sc2.Panel2.Controls.Clear();
            frmXOgame xo = new frmXOgame();
            xo.TopLevel = false;
            sc2.Panel2.Controls.Add(xo);
            xo.Show();
        }

        private void btnPicViewer_Click(object sender, EventArgs e)
        {
            sc2.Panel2.Controls.Clear();
            frmPicViewer picViewer = new frmPicViewer();
            picViewer.TopLevel = false;
            sc2.Panel2.Controls.Add(picViewer);
            picViewer.Show();
         }
    }
}
