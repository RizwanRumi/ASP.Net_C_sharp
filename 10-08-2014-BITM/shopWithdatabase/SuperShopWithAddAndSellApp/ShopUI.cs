using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShopWithAddAndSellApp
{
    public partial class ShopUI : Form
    {
        private Shop aShop;
        private Product aProduct;
        private Database aDatabase;

        public ShopUI()
        {
            InitializeComponent();
            aDatabase = new Database();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string address = addressTextBox.Text;
            aShop = new Shop(name,address);
            string msg = aDatabase.AddShopInDatabase(name,address);
            MessageBox.Show(msg);

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddItemUI addItemUuiForm = new AddItemUI(aShop);
            addItemUuiForm.Show();
        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            SellItemUI sellItemtForm = new SellItemUI(aShop);
            sellItemtForm.Show();
        }





    }
}
