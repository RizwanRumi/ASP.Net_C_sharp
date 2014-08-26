using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace StudentEntryWithDatabaseApp
{
    class Database
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=H:\08-08-2014\StudentEntryWithDatabaseApp\StudentEntryWithDatabaseApp\StudentEntry.mdf;Integrated Security=True");

        public string AddDepartmentInDatabase(string code, string departmentName)
        {
            try
            {
                con.Open();

                string query = "insert into Department(code, departmentName) values('" + code + "','" + departmentName + "')";
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

        public string AddStudentInDatabase(string regNo, string name, string email)
        {
           try
            {
                //SqlConnection con = new SqlConnection();
                // con.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\lab2\Desktop\SuperShopWithAddAndSellApp\SuperShopWithAddAndSellApp\Database1.mdf;Integrated Security=True";
                con.Open();
                // "insert into Persons_info(perID, latinName, gender) values('" + txtID.Text + "','" + txtLatinName.Text + "','" + cbGender.Text + "' )";

                // string query = "(insert into Shop(name,address) values('{0}','{1}'))",nameTextbox.Text,addressTextBox.Text;

                // string query = "insert into Shop(name,address) values('" + name + "','" + address + "' )";
                string query = "insert into Student(regNo, name, email) values('" + regNo + "','" + name + "', '" + email + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                return "successfully student added in database";
            }
            catch (Exception exception)
            {
                //  MessageBox.Show(exception.Message,"error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return "database connection failed for student";
            }
        }



        public DataTable fillDataTable(string table)
        {

            string conStr =
                @"Data Source=(LocalDB)\v11.0;AttachDbFilename=H:\08-08-2014\StudentEntryWithDatabaseApp\StudentEntryWithDatabaseApp\StudentEntry.mdf;Integrated Security=True";
            string query = "SELECT * FROM " + table;

            SqlConnection sqlConn = new SqlConnection(conStr);
            sqlConn.Open();
            SqlCommand cmd = new SqlCommand(query, sqlConn);

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            sqlConn.Close();
            return dt;
        }

    }
}
