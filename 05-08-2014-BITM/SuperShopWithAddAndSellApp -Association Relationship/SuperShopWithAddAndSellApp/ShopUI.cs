using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShopWithAddAndSellApp
{
    public partial class ShopUI : Form
    {
        private Shop aShopInfo;
       public ShopUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            aShopInfo = new Shop(nameTextBox.Text, addressTextBox.Text);
            MessageBox.Show("saved Shop Info");
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (aShopInfo != null)
            {
                AddItemUI addItemUiForm = new AddItemUI(aShopInfo);
                addItemUiForm.Show();    
            }
            else
            {
                MessageBox.Show("please At first Create a Shop");
            }
        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            if (aShopInfo != null)
            {
                SellItemUI sellListForm = new SellItemUI(aShopInfo);
                sellListForm.Show();
            }
            else
            {
                MessageBox.Show("Please At first create shop");
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string detailsMsg = "";
            if (aShopInfo != null)
            {
                string deptMessage = "Shop Name: " + aShopInfo.ShopName + "Address: " + aShopInfo.ShopAddress + "\n";
                detailsMsg += deptMessage;
                string ProductInfoHeader = "Product No\tquantity\n";
                detailsMsg += ProductInfoHeader;

                foreach (Product aProduct in aShopInfo.ShowProductList())
                {
                    string productMsg = aProduct.ProductId + "   \t\t   " + aProduct.Quantity + "\n";
                    detailsMsg += productMsg;
                }

                MessageBox.Show(detailsMsg);
                
            }
            else
            {
                MessageBox.Show("Please At first create shop");
            }
        }





    }
}
