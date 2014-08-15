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
    public partial class SellItem : Form
    {
        private Shop shop;
        private Product aProduct;
        public SellItem(Shop aShop)
        {
            InitializeComponent();
            shop=aShop;

            ShowProductsOnListView();
        }

        private void sellItemButton_Click(object sender, EventArgs e)
        {
            aProduct = new Product(sellProductIdTextBox.Text, Convert.ToInt16(sellQuantityTextBox.Text));
            string msg = shop.SellProduct(aProduct);

            ShowProductsOnListView();

            MessageBox.Show(msg);
        }

        void ShowProductsOnListView()
        {
            sellItemListView.Items.Clear();
            foreach (Product aProduct in shop.productList)
            {



                ListViewItem aListViewItem = new ListViewItem();


                aListViewItem.Text = aProduct.ProductId;
                aListViewItem.SubItems.Add(Convert.ToString(aProduct.Quantity));

                sellItemListView.Items.Add(aListViewItem);
            }
        }
    }
}
