using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShopWithAddAndSellApp
{
    class Database
    {
       // private string Name { get; set; }
       // private string Address { get; set; }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\lab2\Desktop\SuperShopWithAddAndSellApp\SuperShopWithAddAndSellApp\Database1.mdf;Integrated Security=True");

        public string AddShopInDatabase(string name, string address)
        {
            try
            {
                //SqlConnection con = new SqlConnection();
                // con.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\lab2\Desktop\SuperShopWithAddAndSellApp\SuperShopWithAddAndSellApp\Database1.mdf;Integrated Security=True";
                con.Open();
                // "insert into Persons_info(perID, latinName, gender) values('" + txtID.Text + "','" + txtLatinName.Text + "','" + cbGender.Text + "' )";

                // string query = "(insert into Shop(name,address) values('{0}','{1}'))",nameTextbox.Text,addressTextBox.Text;

                string query = "insert into Shop(name,address) values('" + name + "','" + address + "' )";
                //   string query2 = "insert into Product(id,quantity) values('" + id + "','" +  "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                return "successfully added";
            }
            catch (Exception)
            {
                return "database connection failed";
            }
        }

        public string AddProductInDatabase(string id, int quantity)
        {
            try
            {
                //SqlConnection con = new SqlConnection();
                // con.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\lab2\Desktop\SuperShopWithAddAndSellApp\SuperShopWithAddAndSellApp\Database1.mdf;Integrated Security=True";
                con.Open();
                // "insert into Persons_info(perID, latinName, gender) values('" + txtID.Text + "','" + txtLatinName.Text + "','" + cbGender.Text + "' )";

                // string query = "(insert into Shop(name,address) values('{0}','{1}'))",nameTextbox.Text,addressTextBox.Text;

               // string query = "insert into Shop(name,address) values('" + name + "','" + address + "' )";
                  string query = "insert into Product(product_id,quantity) values('" + id + "','" + quantity + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                return "successfully product added in database";
            }
            catch (Exception exception)
            {
              //  MessageBox.Show(exception.Message,"error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                 return "database connection failed for product";
            }
        }

    }
}
