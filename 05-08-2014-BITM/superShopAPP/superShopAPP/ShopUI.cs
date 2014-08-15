using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace superShopAPP
{
    public partial class ShopUI : Form
    {
        private Shop aShop;
        private Product aProductInfo;
        public ShopUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            aShop = new Shop(nameTextBox.Text,addressTextBox.Text);
            MessageBox.Show("Saved Shop Info");
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            aProductInfo = new Product(productIdTextBox.Text,Convert.ToInt16(quantityTextBox.Text));
            MessageBox.Show(aShop.AddProduct(aProductInfo));
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            string msg = "shop Name: " + aShop.ShopName + " Address: " + aShop.ShopAddress + Environment.NewLine;
               msg += "id  \t quantity\n";

            foreach (Product aProduct in aShop.GetProductList())
            {
                msg += aProduct.ProductId + "\t" + aProduct.Quantity + "\n";
            }

            MessageBox.Show(msg);
        }
    }
}
