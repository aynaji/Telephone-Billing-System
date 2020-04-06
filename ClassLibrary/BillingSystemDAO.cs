using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace ClassLibrary
{
    public class BillingSystemDAO
    {
        public SqlConnection Connection()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\aynaj\source\repos\Telephone Billing System\ClassLibrary\login.mdf;Integrated Security=True"))
                return connection;
        }

        public List<LoginUser> LoginEntry(String username, string password)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\aynaj\Documents\C#\Telephone-Billing-System-master\ClassLibrary\DB.mdf;Integrated Security=True"))
            using (SqlCommand sqlCommand = new SqlCommand($"select * from login where username=@User and password=@Password"))
            {
                connection.Open();
                sqlCommand.Connection = connection;
                sqlCommand.Parameters.AddWithValue("User", username);
                sqlCommand.Parameters.AddWithValue("Password", password);

                List<LoginUser> userlist = new List<LoginUser>();
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        userlist.Add(new LoginUser(reader.GetString(0), reader.GetString(1)));
                    }
                }

                return userlist;
            }
        }
        public List<Customer> SelectAllCustomer()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\aynaj\Documents\C#\Telephone-Billing-System-master\ClassLibrary\DB.mdf;Integrated Security=True"))
            using (SqlCommand sqlCommand = new SqlCommand("select * from Customer"))
            {
                connection.Open();
                sqlCommand.Connection = connection;
                List<Customer> customerlist = new List<Customer>();
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        customerlist.Add(new Customer(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetDateTime(5), reader.GetString(6)));
                    }
                }

                return customerlist;
            }
        }

        public void InsertCustomer(Customer customer)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\aynaj\Documents\C#\Telephone-Billing-System-master\ClassLibrary\DB.mdf;Integrated Security=True"))
            using (SqlCommand sqlCommand = new SqlCommand($"insert into Customer values (@title, @fname,@lname,@email,@dob,@address)")
            )
            {
                connection.Open();
                sqlCommand.Connection = connection;
                sqlCommand.Parameters.AddWithValue("title", customer.Title);
                sqlCommand.Parameters.AddWithValue("fname", customer.Fname);
                sqlCommand.Parameters.AddWithValue("lname", customer.Lname);
                sqlCommand.Parameters.AddWithValue("email", customer.Email);
                sqlCommand.Parameters.AddWithValue("dob", customer.Dob);
                sqlCommand.Parameters.AddWithValue("address", customer.Address);
                sqlCommand.ExecuteNonQuery();
            }
        }

    }
}
