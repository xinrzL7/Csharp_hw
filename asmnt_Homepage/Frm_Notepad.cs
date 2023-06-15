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

namespace asmnt_Homepage
{
    public partial class frmNotepad : Form
    {
        public frmNotepad()
        {
            InitializeComponent();
        }

        void SaveFileMethod() 
        {
            SaveFileDialog note = new SaveFileDialog();
            string filePath = this.Text;
            if (!string.IsNullOrEmpty(filePath))
            {
                richTextBox1.SaveFile(filePath, RichTextBoxStreamType.PlainText);
            }
            else
            {
                note.Title = "Save";
                note.Filter = "Text Document(*.txt)|*.txt|All Files(*.*)|*.*";
                if (note.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SaveFile(note.FileName, RichTextBoxStreamType.PlainText);
                }
                this.Text = note.FileName;
            }
        }
        void OpenFileMethod() 
        {
            OpenFileDialog note = new OpenFileDialog();
            note.Title = "Open";
            note.Filter = "Text Document(*.txt)|*.txt|All Files(*.*)|*.*";
            if (note.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(note.FileName, RichTextBoxStreamType.PlainText);
            }
            this.Text = note.FileName;
        }
        void NewFileMethod() 
        {
            richTextBox1.Clear();
        }
        void CutMethod() 
        {
            richTextBox1.Cut();
        }
        void CopyMethod() 
        {
            richTextBox1.Copy();
        }
        void PasteMethod() 
        {
            richTextBox1.Paste();
        }

        //新增
        private void newNToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NewFileMethod();
        }
        private void newtoolStripButton_Click(object sender, EventArgs e)
        {
            NewFileMethod();
        }

        //開檔案
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileMethod();
        }
        private void opentoolStripButton2_Click(object sender, EventArgs e)
        {
            OpenFileMethod();
        }

        //直接儲存現有檔案
        private void saveSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileMethod();
        }
        private void savetoolStripButton3_Click(object sender, EventArgs e)
        {
            SaveFileMethod();
        }


        //另存新檔
        private void anotherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog note = new SaveFileDialog();
            note.Title = "Save";
            note.Filter = "Text Document(*.txt)|*.txt|All Files(*.*)|*.*";
            if (note.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(note.FileName, RichTextBoxStreamType.PlainText);
            }
            this.Text = note.FileName;
        }

        //關掉
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        //恢復
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }
        //剪貼複製
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CutMethod();
        }
        private void cuttoolStripButton5_Click(object sender, EventArgs e)
        {
            CutMethod();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
               CopyMethod();
        }
        private void copytoolStripButton6_Click(object sender, EventArgs e)
        {
            CopyMethod();
        }
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasteMethod();  
        }
        private void pastetoolStripButton7_Click(object sender, EventArgs e)
        {
            PasteMethod();
        }
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fnt = new FontDialog();
            if (fnt.ShowDialog() == DialogResult.OK) 
                richTextBox1.Font = fnt.Font;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog fnt = new ColorDialog();
            if (fnt.ShowDialog() == DialogResult.OK)
                richTextBox1.ForeColor = fnt.Color;
        }

        //大寫字母
        private void toUpperUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedtxt = richTextBox1.SelectedText;
            richTextBox1.SelectedText = selectedtxt.ToUpper();
        }
        //小寫字母
        private void toLowerLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedtxt = richTextBox1.SelectedText;
            richTextBox1.SelectedText = selectedtxt.ToLower();
        }
        //取消自動換行
        private void wordwrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.WordWrap = false;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Green;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor= Color.Blue;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor=Color.Black;
        }

        //顯示時間：上午/下午 時分秒
        private void timerDatetime_Tick(object sender, EventArgs e)
        {
            labTimer.Text = DateTime.Now.ToString("tt hh:mm:ss",new System.Globalization.CultureInfo("zh-TW"));
        }

        private void infotoolStripButton8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("C#作業 Notepad","關於");
        }
    }
}
