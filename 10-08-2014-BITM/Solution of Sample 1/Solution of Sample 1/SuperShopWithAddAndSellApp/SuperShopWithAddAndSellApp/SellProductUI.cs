using System;
using System.Windows.Forms;

namespace SuperShopWithAddAndSellApp
{
    public partial class SellProductUI : Form
    {
        private Shop ashop;
        private Product aproductInfo;
        public SellProductUI(Shop ashop)
        {
            InitializeComponent();
            this.ashop = ashop;
            ShowSellItemListView();

        }

        private void sellProductButton_Click(object sender, EventArgs e)
        {
            aproductInfo = new Product(productIdTextBox.Text, Convert.ToInt16(quantityTextBox.Text));
            MessageBox.Show(ashop.SellProduct(aproductInfo));
            ShowSellItemListView();
        }

        public void ShowSellItemListView()
        {
            productListView.Items.Clear();
            foreach (Product aproduct in ashop.GetProductList())
            {
                ListViewItem alistviewItem = new ListViewItem();
                alistviewItem.Text = aproduct.ProductId;
                alistviewItem.SubItems.Add(aproduct.Quantity.ToString());
                productListView.Items.Add(alistviewItem);
            }
        }
    }
}
