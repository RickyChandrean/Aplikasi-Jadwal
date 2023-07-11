using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace AplikasiJadwal.Model
{
    public class Jurusan
    {
        public string kode, nama;
        SqlConnection myConnection = new SqlConnection();
        string flag;
        public DataSet ds = new DataSet();
        public string insertData()
        {
            try
            {
                myConnection.ConnectionString = GlobalVariabel.connString;
                myConnection.Open();
                string query = "insert into jurusan values(@kode, @nama)";
                SqlCommand com = new SqlCommand(query, myConnection);
                com.Parameters.AddWithValue("@kode", kode);
                com.Parameters.AddWithValue("@nama", nama);
                int i = com.ExecuteNonQuery();
                if (i > 0)
                {
                    flag = "OK";
                }
                else
                {
                    flag = "FAIL";
                }
            }
            catch (Exception ex)
            {
                flag = ex.Message;
            }
            finally
            {
                if (myConnection.State == ConnectionState.Open)
                {
                    myConnection.Close();
                    myConnection = null;
                }
            }
            return flag;
        }
        public string editData()
        {
            try
            {
                myConnection.ConnectionString = GlobalVariabel.connString;
                myConnection.Open();
                string query = "update jurusan set Nama_Jurusan = @nama  where Kd_Jurusan = @kode ";
                SqlCommand com = new SqlCommand(query, myConnection);
                com.Parameters.AddWithValue("@nama", nama);
                com.Parameters.AddWithValue("@kode", kode);
                int i = com.ExecuteNonQuery();
                if (i > 0)
                {
                    flag = "OK";
                }
                else
                {
                    flag = "FAIL";
                }
            }
            catch (Exception ex)
            {
                flag = ex.Message;
            }
            finally
            {
                if (myConnection.State == ConnectionState.Open)
                {
                    myConnection.Close();
                    myConnection = null;
                }
            }
            return flag;
        }
        public string hapusData()
        {
            try
            {
                myConnection.ConnectionString = GlobalVariabel.connString;
                myConnection.Open();
                string query = "delete jurusan where Kd_Jurusan = @kode";
                SqlCommand com = new SqlCommand(query, myConnection);
                com.Parameters.AddWithValue("@kode", kode);
                int i = com.ExecuteNonQuery();
                if (i > 0)
                {
                    flag = "OK";
                }
                else
                {
                    flag = "FAIL";
                }
            }
            catch (Exception ex)
            {
                flag = ex.Message;
            }
            finally
            {
                if (myConnection.State == ConnectionState.Open)
                {
                    myConnection.Close();
                    myConnection = null;
                }
            }
            return flag;
        }
        public string lihatData()
        {
            try
            {
                myConnection.ConnectionString = GlobalVariabel.connString;
                myConnection.Open();
                string query = "select Kd_Jurusan 'Kode', Nama_Jurusan 'Nama Jurusan' from jurusan";
                SqlDataAdapter da = new SqlDataAdapter(query, myConnection);
                da.Fill(ds, "jurusan");
                flag = "OK";
            }
            catch (Exception ex)
            {
                flag = ex.Message;
            }
            finally
            {
                if (myConnection.State == ConnectionState.Open)
                {
                    myConnection.Close();
                    myConnection = null;
                }
            }
            return flag;
        }
        public ArrayList cariData()
        {
            ArrayList data = new ArrayList();
            SqlDataReader dr = null;
            try
            {
                myConnection.ConnectionString = GlobalVariabel.connString;
                myConnection.Open();
                string query = "select * from jurusan where Kd_Jurusan = @kode";
                SqlCommand com = new SqlCommand(query, myConnection);
                com.Parameters.AddWithValue("@kode", kode);
                dr = com.ExecuteReader();
                if (dr.Read())
                {
                    data.Add(dr[0].ToString());
                    data.Add(dr[1].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                dr = null;
            }
            finally
            {
                if (myConnection.State == ConnectionState.Open)
                {
                    myConnection.Close();
                    myConnection = null;
                }
            }
            return data;
        }
    }
}