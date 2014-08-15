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
        private Shop aShop;
        private Product aProductInfo;
        public AddItemUI(Shop aShop)
        {
            InitializeComponent();
            this.aShop = aShop;
           // ShowItemInListView();
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {

            int qty = Convert.ToInt16(quantityTextBox.Text);
            Product aProduct = new Product(productIdTextBox.Text, qty);

            if (HasThisId(aProduct.ProductId))
            {
                MessageBox.Show(UpdateProductQuantity(aProduct));
            }
            else
            {
                MessageBox.Show(AddProduct(aProduct));
            }
            //ShowItemInListView();
        }

        private string AddProduct(Product aProduct)
        {
            string connectionString =
                @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\FTFL-ITS-2014000122\SuperShopWithAddAndSellApp\SuperShopWithAddAndSellApp\SuperShop.mdf";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "INSERT INTO Product_table(Quantity, ProductID) VALUES (" + aProduct.Quantity + ",'" +
                           aProduct.ProductId + "')";
            SqlCommand insert = new SqlCommand(query, conn);
            insert.ExecuteNonQuery();
            conn.Close();
            return "Product has been saved.";
        }

        private string UpdateProductQuantity(Product aProduct)
        {
            string connectionString =
                @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\FTFL-ITS-2014000122\SuperShopWithAddAndSellApp\SuperShopWithAddAndSellApp\SuperShop.mdf";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "UPDATE Product_table SET Quantity = Quantity + " + aProduct.Quantity + " WHERE ProductID = '" + aProduct.ProductId + "'"; 
            SqlCommand insert = new SqlCommand(query, conn);
            insert.ExecuteNonQuery();
            conn.Close();
            return "Product has been saved.";            
        }

        private bool HasThisId(string productId)
        {
            string connectionString =
                @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\FTFL-ITS-2014000122\SuperShopWithAddAndSellApp\SuperShopWithAddAndSellApp\SuperShop.mdf";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "SELECT ProductId FROM Product_table WHERE ProductId = '" + productId + "'";
            SqlCommand insert = new SqlCommand(query, conn);
            SqlDataReader productReader = insert.ExecuteReader();
            
            if (productReader.HasRows)
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }
            
        }

        public void ShowItemInListView()
        {
//            addItemListView.Items.Clear();
//
//            foreach (Product aProduct in aShop.GetProductList())
//            {
//                ListViewItem aListViewItem = new ListViewItem();
//                aListViewItem.Text = aProduct.ProductId;
//                aListViewItem.SubItems.Add(aProduct.Quantity.ToString());
//                addItemListView.Items.Add(aListViewItem);
//            }

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
