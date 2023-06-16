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
    public partial class frmLoanReport : Form
    {
        public frmLoanReport()
        {
            InitializeComponent();
        } 
        /* 取得表單Loan的值*/
        private void frmLoanReport_Load(object sender, EventArgs e)
        {
            txtRepLoan.Text = frmLoan.RepLoan.ToString();
            txtRepPeriod.Text = frmLoan.RepPeriod.ToString();
            txtRepRate.Text = frmLoan.RepRate.ToString();
            txtRepPMT.Text = frmLoan.RepPMT.ToString();
            txtRepTotalPay.Text = frmLoan.RepTotalPay.ToString();
        }
     }
}

