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
        private Shop shop;
        private Product aProduct;
        private Database aDatabase;
        public SellItemUI(Shop aShop)
        {
            InitializeComponent();
            shop=aShop;

          
        }

        private void sellItemButton_Click(object sender, EventArgs e)
        {
            aDatabase = new Database();

            string id = sellProductIdTextBox.Text;
            int quantity = Convert.ToInt16(sellQuantityTextBox.Text);
            aProduct = new Product(id, quantity);
            
            if (aDatabase.HasThisId(id))
            {
                MessageBox.Show(aDatabase.SellProductInDatabase(id, quantity));
            }
            else
            {
                MessageBox.Show("Product not fornd");
            }

            sellItemdataGridView.DataSource = null;
            sellItemdataGridView.DataSource = aDatabase.fillDataTable("Product"); // table name
        }

        
    }
}
