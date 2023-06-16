using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static asmnt_Homepage.Utility;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace asmnt_Homepage
{
    public partial class frmLoan : Form
    {
        public frmLoan()
        {
            InitializeComponent();
        }
        LoanClass loan = new LoanClass();
        /* 月付 */   //todo 加tryparse?
        private void btnPMT_Click(object sender, EventArgs e)
        {
            loan.Loan = double.Parse(txtLoan.Text);
            loan.Period = double.Parse(txtPeriod.Text);
            loan.InterestRate = double.Parse(txtRate.Text);
            loan.DownPay = double.Parse(txtDownPay.Text);

            MessageBox.Show("月付額： " + loan.monthMethod() + "元");
        }

        /* 總付 */
        private void btnTotalPay_Click(object sender, EventArgs e)
        {
            loan.Loan = double.Parse(txtLoan.Text);
            loan.Period = double.Parse(txtPeriod.Text);
            loan.InterestRate = double.Parse(txtRate.Text);
            loan.DownPay = double.Parse(txtDownPay.Text);

            MessageBox.Show("總付款： " + loan.totalloanMethod() + "元");
        }

        
        //定義靜態屬性的REPORT
        public static double RepLoan;
        public static double RepPeriod;
        public static double RepRate;
        public static double RepPMT = 0;
        public static double RepTotalPay = 0;
        public void btnReport_Click(object sender, EventArgs e)
        {
            RepLoan = double.Parse(txtLoan.Text);
            RepPeriod = double.Parse(txtPeriod.Text);
            RepRate = double.Parse(txtRate.Text);
            RepPMT = loan.monthMethod();
            RepTotalPay = loan.totalloanMethod();

            frmLoanReport report = new frmLoanReport();
            report.Show();
        }
    }
}
