using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SuperShopWithAddAndSellApp
{
    public partial class AddProductUI : Form
    {
        private Shop aShop;
        private Product aProductInfo;
        DatabaseGateway aDatabaseGateway = new DatabaseGateway();
        public AddProductUI()
        {
           InitializeComponent();
        }

        private void addProductButton_Click(object sender, EventArgs e)
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
            ShowItemInListView();
        }

        private string AddProduct(Product aProduct)
        {
            aDatabaseGateway.SaveProduct(aProduct);
            return "Product has been saved.";
        }
        private string UpdateProductQuantity(Product aProduct)
        {
            return aDatabaseGateway.IncreaseProductQuantity(aProduct);
        }

        private bool HasThisId(string productId)
        {
            bool hasId = aDatabaseGateway.HasThisProductIdInDatabase(productId);
            return hasId;
        }

        public void ShowItemInListView()
        {
            List<Product> productList = aDatabaseGateway.GetAllProduct();
            addItemListView.Items.Clear();
            foreach (Product aProduct in productList)
            {
                ListViewItem aListViewItem = new ListViewItem();
                aListViewItem.Text = aProduct.ProductId;
                aListViewItem.SubItems.Add(aProduct.Quantity.ToString());
                addItemListView.Items.Add(aListViewItem);
            }
        }

        private void AddItemUI_Load(object sender, EventArgs e)
        {

        }
    }
}
