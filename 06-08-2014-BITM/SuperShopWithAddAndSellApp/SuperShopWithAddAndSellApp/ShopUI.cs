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
        private Shop aShopProduct;
        private Product aProduct;
        public ShopUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            aShopProduct = new Shop(nameTextBox.Text, addressTextBox.Text);
            MessageBox.Show("saved Shop Info");
        }

        private void addButton_Click(object sender, EventArgs e)
        {
           // aShopProduct = new Shop();
            //aProduct = new Product();
            AddItemUI addItemUiForm = new AddItemUI(aShopProduct);
            addItemUiForm.Show();
        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            SellItemUI sellListForm = new SellItemUI(aShopProduct);
            sellListForm.Show();
        }





    }
}
