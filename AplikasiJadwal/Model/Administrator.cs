using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace AplikasiJadwal.Model
{
    public class Administrator
    {
        public string username, password;
        SqlConnection myConnection = new SqlConnection();
        string flag;
        public DataSet ds = new DataSet();

        public ArrayList dologin()
        {
            ArrayList data = new ArrayList();
            SqlDataReader dr = null;
            try
            {
                myConnection.ConnectionString = GlobalVariabel.connString;
                myConnection.Open();
                string query = "Select * from administrator where username = @username and password = @password";
                SqlCommand com = new SqlCommand(query, myConnection);
                com.Parameters.AddWithValue("@username", username);
                com.Parameters.AddWithValue("@password", password);
                dr = com.ExecuteReader();
                if (dr.Read())
                {
                    data.Add(dr[0].ToString());
                    data.Add(dr[1].ToString());
                }
                dr.Close();
            }
            catch (System.Exception)
            {

                dr = null;
            }
            finally
            {
                if (myConnection.State == ConnectionState.Open)
                    myConnection.Close();
            }
            return data;
        }

        public string ubahPassword()
        {
            try
            {
                myConnection.ConnectionString = GlobalVariabel.connString;
                myConnection.Open();
                string query = "Update administrator set Password = @password where username = @username";
                SqlCommand com = new SqlCommand(query, myConnection);
                com.Parameters.AddWithValue("@password", password);
                com.Parameters.AddWithValue("@username", username);
                int i = com.ExecuteNonQuery();
                if (i > 0)
                    flag = "OK";
                else
                    flag = "Fail";
            }
            catch (System.Exception e)
            {
                flag = e.Message;
            }
            finally
            {
                if (myConnection.State == ConnectionState.Open)
                    myConnection.Close();
            }
            return flag;
        }

    }
}