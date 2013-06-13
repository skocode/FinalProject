using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// This class validates the name and password entered by the user on the log-in page by connecting to the Automart database and comparing the entered information against the RegisteredCustomer table and returning the personkey of the user, if available.
/// </summary>
public class CustomerLogin
{
	private SqlConnection connect;

    public CustomerLogin()
    {
        connect = new SqlConnection(@"Data Source=localhost;initial catalog=Automart;user=CustomerLogin;password=P@ssw0rd1");
    }

    public int Login(string userName, string password)
    {
        int pKey = 0;
        string sql = "Select PersonKey, Email, CustomerPassword From Customer.RegisteredCustomer Where Email=@userName and CustomerPassword=@password";
        SqlCommand cmd = new SqlCommand(sql, connect);
        cmd.Parameters.AddWithValue("@userName", userName);
        cmd.Parameters.AddWithValue("@password", password);
        SqlDataReader reader = null;

        connect.Open();
        reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            if (reader["personKey"] != null)
            {
                pKey = (int)reader["personKey"];
            }
        }
        reader.Close();
        connect.Close();

        return pKey;
	}
}