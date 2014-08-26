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
    public partial class AddItemUI : Form
    {
        private Shop shop;
        private Product aProduct;
        private Database aDatabase;
        public AddItemUI(Shop aShop)
        {
            InitializeComponent();
            shop=aShop;
            aDatabase = new Database();
           

        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            string id = productIdTextBox.Text;
            int qty = Convert.ToInt16(quantityTextBox.Text);
             Product aProduct = new Product(productIdTextBox.Text, qty);

             if (aDatabase.HasThisId(id))
             {
                 MessageBox.Show(aDatabase.UpdateProductInDatabase(id,qty));
             }
             else
             {
                 MessageBox.Show(aDatabase.AddProductInDatabase(id,qty));
             }


             addItemdataGridView.DataSource = null;
             addItemdataGridView.DataSource = aDatabase.fillDataTable("Product"); // table name
           // ShowProductsOnListView();
        }

        
        

        
    }
}
