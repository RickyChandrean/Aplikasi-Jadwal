using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace AplikasiJadwal.Model
{
    public class Jadwal
    {
        public int id;
        public string kode_dosen, kode_mk, jam;
        public DateTime tanggal;
        string flag;
        SqlConnection myConnection = new SqlConnection();
        public DataSet ds = new DataSet();
        public string insertData()
        {
            try
            {
                myConnection.ConnectionString = GlobalVariabel.connString;
                myConnection.Open();
                string query = "insert into Jadwal values(@kode_dosen, @kode_mk, @tanggal, @jam)";
                SqlCommand com = new SqlCommand(query, myConnection);
                com.Parameters.AddWithValue("@kode_dosen", kode_dosen);
                com.Parameters.AddWithValue("@kode_mk", kode_mk);
                com.Parameters.AddWithValue("@tanggal", tanggal);
                com.Parameters.AddWithValue("@jam", jam);
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
                string query = "update jadwal set Kd_Dosen = @kode_dosen, Kd_MK = @kode_mk, Tanggal = @tanggal, Jam = @jam where ID = @id";
                SqlCommand com = new SqlCommand(query, myConnection);
                com.Parameters.AddWithValue("@kode_dosen", kode_dosen);
                com.Parameters.AddWithValue("@kode_mk", kode_mk);
                com.Parameters.AddWithValue("@tanggal", tanggal);
                com.Parameters.AddWithValue("@jam", jam);
                com.Parameters.AddWithValue("@id", id);
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
                string query = "delete Jadwal where ID = @id";
                SqlCommand com = new SqlCommand(query, myConnection);
                com.Parameters.AddWithValue("@id", id);
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
                string query = "select * from Jadwal";
                SqlDataAdapter da = new SqlDataAdapter(query, myConnection);
                da.Fill(ds, "jadwal");
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
                string query = "select * from Jadwal where id = @id";
                SqlCommand com = new SqlCommand(query, myConnection);
                com.Parameters.AddWithValue("@id", id);
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