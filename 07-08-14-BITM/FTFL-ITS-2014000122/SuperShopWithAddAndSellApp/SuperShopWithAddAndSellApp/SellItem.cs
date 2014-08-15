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
        private Shop ashop;
        private Product aproductInfo;
        public SellItem(Shop ashop)
        {
            InitializeComponent();
            this.ashop = ashop;
            ShowSellItemListView();

        }

        private void sellItemButton_Click(object sender, EventArgs e)
        {
            aproductInfo = new Product(productIdTextBox.Text, Convert.ToInt16(quantityTextBox.Text));
            MessageBox.Show(ashop.SellProduct(aproductInfo));
            ShowSellItemListView();
        }

        public void ShowSellItemListView()
        {
            sellItemListView.Items.Clear();
            foreach (Product aproduct in ashop.GetProductList())
            {
                ListViewItem alistviewItem = new ListViewItem();
                alistviewItem.Text = aproduct.ProductId;
                alistviewItem.SubItems.Add(aproduct.Quantity.ToString());
                sellItemListView.Items.Add(alistviewItem);
            }
        }
    }
}
