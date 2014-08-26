using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SuperShopWithAddAndSellApp
{
    public partial class ShopUI : Form
    {
        private Shop aShop;
        private Product aProduct;
        public ShopUI()
        {
            InitializeComponent();
        }

      

        private void saveButton_Click(object sender, EventArgs e)
        {
            aShop = new Shop(nameTextBox.Text, addressTextBox.Text);
            DatabaseGateway aDatabaseGateway = new DatabaseGateway();
            string msg = aDatabaseGateway.SaveShop(aShop);
            MessageBox.Show(msg);
            nameTextBox.Text = "";
            addressTextBox.Text = "";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
          
            AddProductUI addProductUiForm = new AddProductUI();
            addProductUiForm.Show();
        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            SellProductUI sellListForm = new SellProductUI(aShop);
            sellListForm.Show();
        }
    }
}
