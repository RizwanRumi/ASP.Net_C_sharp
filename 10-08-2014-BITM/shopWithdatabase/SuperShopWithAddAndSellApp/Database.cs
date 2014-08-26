using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShopWithAddAndSellApp
{
    class Database
    {
        private Product Product;
      
        static string connectionString = ConfigurationManager.ConnectionStrings["SuperShopDatabaseApp"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);
        public string AddShopInDatabase(string name, string address)
        {
        //    try
            {
              con.Open();
              
                string query = "insert into Shop(name,address) values('" + name + "','" + address + "' )";
              
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();
                return "successfully added";
            }
          //  catch (Exception)
            {
            //    return "database connection failed";
            }
        }

        public string AddProductInDatabase(string id, int quantity)
        {
            try
            {
                con.Open();
               
                string query = "insert into Product(product_id,quantity) values('" + id + "','" + quantity + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();
                return "successfully product added in database";
            }
            catch (Exception exception)
            {
              //  MessageBox.Show(exception.Message,"error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                 return "database connection failed for product";
            }
        }

        public string UpdateProductInDatabase(string id, int quantity)
        {
            try
            {
                con.Open();
                /*"UPDATE Student 
SET Address = @add, City = @cit Where FirstName = @fn and LastName = @add)";*/
                string query = "UPDATE Product SET quantity = quantity + " + quantity + " WHERE product_id = '" + id + "'"; 
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();
                return "successfully product added in database";
            }
            catch (Exception exception)
            {
                //  MessageBox.Show(exception.Message,"error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return "database connection failed for product";
            }
        }

        public string SellProductInDatabase(string id, int quantity)
        {
            //try
            {
                con.Open();
                string query = "UPDATE Product SET quantity = quantity - " + quantity + " WHERE product_id = '" + id + "' AND quantity > " + quantity  ;
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();
                return "successfully product deduct in database";
            }
         //   catch (Exception exception)
            {
                //  MessageBox.Show(exception.Message,"error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return "database connection failed for product";
            }
        }

        public DataTable fillDataTable(string table)
        {

            string conStr =@"Data Source=(LocalDB)\v11.0;AttachDbFilename=H:\08-08-2014\shopWithdatabase\SuperShopWithAddAndSellApp\SupershopEntry.mdf;Integrated Security=True";
                
            string query = "SELECT * FROM " + table;

            SqlConnection sqlConn = new SqlConnection(conStr);
            sqlConn.Open();
            SqlCommand cmd = new SqlCommand(query, sqlConn);

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            sqlConn.Close();
            return dt;
        }

        public bool HasThisId(string productId)
        {
         
            con.Open();
            string query = "SELECT product_id FROM Product WHERE product_id = '" + productId + "'";
            SqlCommand insert = new SqlCommand(query, con);
            SqlDataReader productReader = insert.ExecuteReader();

            if (productReader.HasRows)
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }


    }
}
