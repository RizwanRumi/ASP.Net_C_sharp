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
    public partial class AddItemUI : Form
    {
        private Shop aShop;
        private Product aProductInfo;
        public AddItemUI(Shop aShop)
        {
            InitializeComponent();
            this.aShop = aShop;
            ShowItemInListView();
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            aProductInfo = new Product(productIdTextBox.Text, Convert.ToInt16(quantityTextBox.Text));
            MessageBox.Show(aShop.AddProduct(aProductInfo));
            ShowItemInListView();
        }

        public void ShowItemInListView()
        {
            addItemListView.Items.Clear();

            foreach (Product aProduct in aShop.GetProductList())
            {
                ListViewItem aListViewItem = new ListViewItem();
                aListViewItem.Text = aProduct.ProductId;
                aListViewItem.SubItems.Add(aProduct.Quantity.ToString());
                addItemListView.Items.Add(aListViewItem);
            }
        }

        
    }
}
