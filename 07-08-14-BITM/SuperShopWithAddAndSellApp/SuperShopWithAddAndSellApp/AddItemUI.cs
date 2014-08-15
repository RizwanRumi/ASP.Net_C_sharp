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
            int quantity = Convert.ToInt16(quantityTextBox.Text);
            aProduct = new Product(id, quantity);
            string mes = shop.AddProduct(aProduct);
            MessageBox.Show(mes);
              string msg = aDatabase.AddProductInDatabase(id, quantity);
             MessageBox.Show(msg);
            
            ShowProductsOnListView();
        }


        void ShowProductsOnListView()
        {
            addItemListView.Items.Clear();
    foreach (Product aProduct in shop.productList)
            {
        ListViewItem aListViewItem = new ListViewItem();
        aListViewItem.Text = aProduct.ProductId;
        aListViewItem.SubItems.Add(Convert.ToString(aProduct.Quantity));
        addItemListView.Items.Add(aListViewItem);
            }

        }

        
    }
}
