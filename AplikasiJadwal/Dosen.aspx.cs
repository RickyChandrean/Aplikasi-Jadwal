using System;
using System.Data;

namespace AplikasiJadwal
{
    public partial class Dosen : System.Web.UI.Page
    {
        private void tampilData()
        {
            string display = "<table ID='table' class='table table-striped table-bordered' style='width:100%'>";
            display += "<thead>";
            display += "<tr>";
            display += "<th>Kode Dosen</th>";
            display += "<th>Kode Jurusan</th>";
            display += "<th>Nama Dosen</th>";
            display += "<th>Telp</th>";
            display += "<th>Alamat</th>";
            display += "<th>Action</th>";
            display += "<tr/>";
            display += "<body/>";

            Model.Dosen dosen = new Model.Dosen();
            string flag = dosen.lihatData();
            if (flag == "OK")
            {
                foreach (DataRow dr in dosen.ds.Tables[0].Rows)
                {
                    display += "<tr>";
                    foreach (DataColumn dc in dosen.ds.Tables[0].Columns)
                    {
                        display += "<td>" + dr[dc.ColumnName].ToString() + "</td>";
                    }
                    display += "<td>";
                    display += "<a href='EditDosen.aspx?id=" + dr[0].ToString() + "'class='btn btn-warning'>Edit</a> ";
                    display += "<a href='DeleteDosen.aspx?id=" + dr[0].ToString() + "'class='btn btn-danger'>Hapus</a> ";
                    display += "</td>";
                    display += "</tr>";
                }
                display += "</tbody>";
                display += "</table>";
                lt_table.Text = display;
            }
            else
            {
                lt_table.Text = "Tidak ada data tersedia";
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            tampilData();
            populateData();
        }
        private void clearData()
        {
            txtKodeD.Text = "";
            ddjurusan.SelectedIndex = 0;
            txtNamaDosen.Text = "";
            TxtTelp.Text = "";
            TxtAlamat.Text = "";
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            Model.Dosen dosen = new Model.Dosen();
            dosen.kode_dosen = txtKodeD.Text;
            dosen.kode_jurusan = ddjurusan.Text;
            dosen.nama_dosen = txtNamaDosen.Text;
            dosen.telp = TxtTelp.Text;
            dosen.alamat = TxtAlamat.Text;
            string flag = dosen.insertData();
            if (flag == "OK")
            {
                response.Text = GlobalVariabel.getSuccess("Data berhasil disimpan");
                clearData();
                Response.Redirect("Dosen.aspx");

            }
            else
            {
                response.Text = GlobalVariabel.getFail("Data gagal disimpan");
            }

        }

        private void populateData()
        {
            Model.Jurusan jurusan = new Model.Jurusan();
            string flag = jurusan.lihatData();
            if (flag == "OK")
            {
                foreach (DataRow dr in jurusan.ds.Tables[0].Rows)
                {
                    ddjurusan.Items.Add(dr[0].ToString());
                }
            }
        }
    }
}