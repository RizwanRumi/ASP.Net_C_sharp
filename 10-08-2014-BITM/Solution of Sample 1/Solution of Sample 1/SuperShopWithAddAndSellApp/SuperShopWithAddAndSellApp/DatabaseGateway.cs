using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShopWithAddAndSellApp
{
    class DatabaseGateway
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ShopDbConnectionString"].ConnectionString;
        private SqlConnection conn;
        private SqlCommand sqlCommand;
        public DatabaseGateway()
        {

        }

        public string SaveShop(Shop aShop)
        {
            conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "INSERT INTO t_Shop(Name, Address) values('" + aShop.ShopName + "','" +
                           aShop.ShopAddress + "')";
            sqlCommand = new SqlCommand(query, conn);
            sqlCommand.ExecuteNonQuery();
            conn.Close();
            return "Shop information has been saved";
        }

        public string SaveProduct(Product aProduct)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "INSERT INTO t_Product(Quantity, ProductID) VALUES (" + aProduct.Quantity + ",'" +
                           aProduct.ProductId + "')";
            sqlCommand = new SqlCommand(query, conn);
            sqlCommand.ExecuteNonQuery();
            conn.Close();
            return "Product has been saved";
        }

        public bool HasThisProductIdInDatabase(string productId)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "SELECT ProductId FROM t_Product WHERE ProductId = '" + productId + "'";
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

        public List<Product> GetAllProduct()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "SELECT ProductId, Quantity FROM t_Product";
            SqlCommand insert = new SqlCommand(query, conn);
            SqlDataReader productReader = insert.ExecuteReader();

            List<Product> productList = new List<Product>();

            while (productReader.Read())
            {
                Product aProduct = new Product();
                aProduct.ProductId = productReader["productId"].ToString();
                aProduct.Quantity = Convert.ToInt16(productReader["Quantity"]);
                productList.Add(aProduct);

            }
            conn.Close();
            return productList;
        }

        public string IncreaseProductQuantity(Product aProduct)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "UPDATE t_Product SET Quantity = Quantity + " + aProduct.Quantity + " WHERE ProductID = '" + aProduct.ProductId + "'";
            SqlCommand insert = new SqlCommand(query, conn);
            insert.ExecuteNonQuery();
            conn.Close();
            return "Product quantity has been increased";            
        }
    }
}
