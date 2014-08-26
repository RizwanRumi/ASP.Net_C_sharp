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
    public partial class SellItemUI : Form
    {
        private Shop aShop;
        private Product aProductInfo;
        public SellItemUI(Shop aShop)
        {
            InitializeComponent();
            this.aShop = aShop;
            SellItemInListView();
        }

        private void sellItemButton_Click(object sender, EventArgs e)
        {
            aProductInfo = new Product(sellProductIdTextBox.Text, Convert.ToInt16(sellQuantityTextBox.Text));
            MessageBox.Show(aShop.SellProduct(aProductInfo));
            SellItemInListView();
        }

        public void SellItemInListView()
        {
             addItemListView.Items.Clear();

            foreach (Product aProduct in aShop.SellProductList())
            {
                ListViewItem aListViewItem = new ListViewItem();
                aListViewItem.Text = aProduct.ProductId;
                aListViewItem.SubItems.Add(aProduct.Quantity.ToString());
                addItemListView.Items.Add(aListViewItem);
            }
        }
    }
}
