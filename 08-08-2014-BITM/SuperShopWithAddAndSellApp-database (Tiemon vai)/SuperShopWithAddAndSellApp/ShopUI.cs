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
        public ShopUI()
        {
            InitializeComponent();
        }

      

        private void saveButton_Click(object sender, EventArgs e)
        {
            aShop = new Shop(nameTextBox.Text, addressTextBox.Text);
            string connectionString =
                @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\FTFL-ITS-2014000122\SuperShopWithAddAndSellApp\SuperShopWithAddAndSellApp\SuperShop.mdf";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "INSERT INTO Shop_table(Name, Address) values('" + aShop.ShopName + "','" +
                           aShop.ShopAddress + "')";
            SqlCommand insert = new SqlCommand(query, conn);
            insert.ExecuteNonQuery();
            conn.Close();
            nameTextBox.Text = "";
            addressTextBox.Text = "";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
          
            AddItemUI addItemUiForm = new AddItemUI(aShop);
            addItemUiForm.Show();
        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            SellItem sellListForm = new SellItem(aShop);
            sellListForm.Show();
        }





    }
}
