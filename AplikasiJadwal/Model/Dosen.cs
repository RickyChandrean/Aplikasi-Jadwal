using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace AplikasiJadwal.Model
{
    public class Dosen
    {
        public string kode_dosen, kode_jurusan, nama_dosen, telp, alamat;
        SqlConnection myConnection = new SqlConnection();
        string flag;
        public DataSet ds = new DataSet();
        public string insertData()
        {
            try
            {
                myConnection.ConnectionString = GlobalVariabel.connString;
                myConnection.Open();
                string query = "insert into Dosen values(@kode_dosen, @kode_jurusan, @nama_dosen, @telp, @alamat)";
                SqlCommand com = new SqlCommand(query, myConnection);
                com.Parameters.AddWithValue("@kode_dosen", kode_dosen);
                com.Parameters.AddWithValue("@kode_jurusan", kode_jurusan);
                com.Parameters.AddWithValue("@nama_dosen", nama_dosen);
                com.Parameters.AddWithValue("@telp", telp);
                com.Parameters.AddWithValue("@alamat", alamat);
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
                string query = "update Dosen set Kd_jurusan = @kode_jurusan, Nama_dosen = @nama_dosen, Telp = @telp, alamat = @alamat where Kd_Dosen = @kode_dosen";
                SqlCommand com = new SqlCommand(query, myConnection);
                com.Parameters.AddWithValue("@kode_jurusan", kode_jurusan);
                com.Parameters.AddWithValue("@nama_dosen", nama_dosen);
                com.Parameters.AddWithValue("@telp", telp);
                com.Parameters.AddWithValue("@alamat", alamat);
                com.Parameters.AddWithValue("@kode_dosen", kode_dosen);
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
                string query = "delete Dosen where Kd_Dosen = @kode_dosen";
                SqlCommand com = new SqlCommand(query, myConnection);
                com.Parameters.AddWithValue("@kode_dosen", kode_dosen);
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
                string query = "select * from Dosen";
                SqlDataAdapter da = new SqlDataAdapter(query, myConnection);
                da.Fill(ds, "dosen");
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
                string query = "select * from Dosen where Kd_Dosen = @kode";
                SqlCommand com = new SqlCommand(query, myConnection);
                com.Parameters.AddWithValue("@kode", kode_dosen);
                dr = com.ExecuteReader();
                if (dr.Read())
                {
                    data.Add(dr[0].ToString());
                    data.Add(dr[1].ToString());
                    data.Add(dr[2].ToString());
                    data.Add(dr[3].ToString());
                    data.Add(dr[4].ToString());
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