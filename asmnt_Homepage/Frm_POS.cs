using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace asmnt_Homepage
{
    public partial class frmPOS : Form
    {
        public frmPOS()
        {
            InitializeComponent();
        }
        //todo 簡化?包含?
        int TotalPrice = 0;
        int BeerCount = 0;
        int TequilaCount = 0;
        int WhiskyCount = 0;
        int WineCount = 0;
        int BeerTotal = 0;
        int TequilaTotal = 0;
        int WhiskyTotal = 0;
        int WineTotal = 0;

        StringBuilder itemList  = new StringBuilder();  
        private void btnBeer_Click(object sender, EventArgs e)
        {
            TotalPrice += 120;
            BeerCount ++;
            BeerTotal = BeerCount * 120;
            txtPrice.Text = $"NT$ {TotalPrice}";
            UpdateItemList();
        }
        private void btnTequila_Click(object sender, EventArgs e)
        {
            TotalPrice += 180;
            TequilaCount ++;
            TequilaTotal = TequilaCount * 180;
            txtPrice.Text = $"NT$ {TotalPrice}";
            UpdateItemList();
        }

        private void btnWhisky_Click(object sender, EventArgs e)
        {
            TotalPrice += 350;
            WhiskyCount ++;
            WhiskyTotal = WhiskyCount * 350;
            txtPrice.Text = $"NT$ {TotalPrice}";
            UpdateItemList();
        }

        private void btnWine_Click(object sender, EventArgs e)
        {
            TotalPrice += 320;
            WineCount ++;
            WineTotal = WineCount * 320;
            txtPrice.Text = $"NT$ {TotalPrice}";
            UpdateItemList();
        }
        private void UpdateItemList()
        {
            itemList.Clear();  //避免每次觸發事件都新增結果
            if (BeerCount > 0)
                itemList.AppendLine($"Beer x{BeerCount}, 共NT${BeerTotal}元");
            if (TequilaCount > 0)
                itemList.AppendLine($"Tequila x{TequilaCount}, 共NT${TequilaTotal}元");
            if (WhiskyCount > 0)
                itemList.AppendLine($"Whisky x{WhiskyCount}, 共NT${WhiskyTotal}元");
            if (WineCount > 0)
                itemList.AppendLine($"Wine x{WineCount}, 共NT${WineTotal}元");
            txtList.Text = itemList.ToString();
        }

        //要同時把總金額歸零、清單清除
        private void btnClearList_Click(object sender, EventArgs e)
        {
            ClearList();
        }
        private void ClearList()
        {
            TotalPrice = 0;
            BeerCount = 0;
            TequilaCount = 0;
            WhiskyCount = 0;
            WineCount = 0;
            itemList.Clear();
            txtList.Text = "尚未點餐";
            txtPrice.Text = "NT$ 0";
        }

        //付款方式
        private void btnCash_Click(object sender, EventArgs e)
        {
            if (TotalPrice > 0)
            {
               MessageBox.Show ($"肝臟增加了NT${TotalPrice}元的負擔", "恭喜你", MessageBoxButtons.OKCancel);
            }
            else 
            {
               MessageBox.Show
                    ("還沒點餐是要付什麼錢", "尚未點餐", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCreditCard_Click(object sender, EventArgs e)
        {
            if (TotalPrice > 0)
            {
                double DiscountPrice = Math.Round(TotalPrice*0.9);
                MessageBox.Show($"原價：NT${TotalPrice}元" +$"\n刷卡折扣價：NT${DiscountPrice}元",  "小心變卡奴", MessageBoxButtons.OKCancel);
            }
            else
            {
                MessageBox.Show
                    ("你直接把卡送我好了", "尚未點餐", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }


    }
}
