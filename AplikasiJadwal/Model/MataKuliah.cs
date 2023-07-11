using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace AplikasiJadwal.Model
{
    public class MataKuliah
    {
        public string kode, nama, semester;
        public int sks;
        SqlConnection myConnection = new SqlConnection();
        string flag;
        public DataSet ds = new DataSet();
        public string insertData()
        {
            try
            {
                myConnection.ConnectionString = GlobalVariabel.connString;
                myConnection.Open();
                string query = "insert into Mata_kuliah values(@kode, @nama, @sks, @semester)";
                SqlCommand com = new SqlCommand(query, myConnection);
                com.Parameters.AddWithValue("@kode", kode);
                com.Parameters.AddWithValue("@nama", nama);
                com.Parameters.AddWithValue("@sks", sks);
                com.Parameters.AddWithValue("@semester", semester);
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
                string query = "update Mata_kuliah set Matakuliah = @nama, sks = @sks, semester = @semester where Kd_MK = @kode";
                SqlCommand com = new SqlCommand(query, myConnection);
                com.Parameters.AddWithValue("@nama", nama);
                com.Parameters.AddWithValue("@sks", sks);
                com.Parameters.AddWithValue("@semester", semester);
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
                string query = "delete Mata_kuliah where Kd_MK = @kode";
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
                string query = "select Kd_Mk 'Kode', Matakuliah 'nama', SKS, Semester from Mata_Kuliah";
                SqlDataAdapter da = new SqlDataAdapter(query, myConnection);
                da.Fill(ds, "matakuliah");
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
                string query = "select * from Mata_kuliah where Kd_MK = @kode";
                SqlCommand com = new SqlCommand(query, myConnection);
                com.Parameters.AddWithValue("@kode", kode);
                dr = com.ExecuteReader();
                if (dr.Read())
                {
                    data.Add(dr[0].ToString());
                    data.Add(dr[1].ToString());
                    data.Add(dr[2].ToString());
                    data.Add(dr[3].ToString());
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