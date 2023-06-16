using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace asmnt_Homepage
{
    public partial class frmStudentStruct : Form
    {
        public frmStudentStruct()
        {
            InitializeComponent();
        }
        //todo ReadOnly：true，enable：false，txtbox顯示的是灰字
        //todo 改成集合?
        stuStruct stu;
        string stuStructResult = "";
        private void btnSave_Click(object sender, EventArgs e)
        {
            stu.Name = txtName.Text;
            stuStructResult = $"姓名：{stu.Name}";
            //國文
            if (int.TryParse(txtCN.Text, out stu.CN))
            {
                stuStructResult += $"{Environment.NewLine}國文：{stu.CN}";
            }
            else 
            {
                MessageBox.Show("國文成績請輸入整數！");
                txtCN.Clear();
                txtCN.Focus();
            }
            //英文
            if (int.TryParse(txtEN.Text, out stu.EN))
            {
                stuStructResult += $"{Environment.NewLine}英文：{stu.EN} ";
            }
            else
            {
                MessageBox.Show("英文成績請輸入整數！");
                txtEN.Clear();
                txtEN.Focus();
            }
            //數學
            if (int.TryParse(txtMA.Text, out stu.MA))
            {
                stuStructResult += $"{Environment.NewLine}數學：{stu.MA} ";
            }
            else
            {
                MessageBox.Show("數學成績請輸入整數！");
                txtMA.Clear();
                txtMA.Focus();
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            //txtAllGrades.ForeColor = Color.Black; 字一樣是灰的
            txtAllGrades.Text = stuStructResult;
        }

        private void btnHighLow_Click(object sender, EventArgs e)
        {
            stu.CN = int.Parse(txtCN.Text);
            stu.EN = int.Parse(txtEN.Text);
            stu.MA = int.Parse(txtMA.Text);

            //轉換成陣列取值
            int [] scores= {stu.CN, stu.EN, stu.MA };
            string[] subjects = { "國文","英文","數學" };
            int MaxScore = scores.Max(); //最高分
            int MinScore = scores.Min(); //最低分
            string HighestSubject = subjects[Array.IndexOf(scores, MaxScore)];
            string LowestSubject = subjects[Array.IndexOf(scores, MinScore)];

            txtHighLow.Text = $"最高科目成績為：{HighestSubject}{MaxScore}分" +
                $"\r\n最低分科目成績為：{LowestSubject}{MinScore}分";
        }

        
    }
}
