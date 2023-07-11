using System;
using System.Data;

namespace AplikasiJadwal
{
    public partial class Jurusan : System.Web.UI.Page
    {
        private void tampilData()
        {
            string display = "<table ID='table' class='table table-striped table-bordered' style='width:100%'>";
            display += "<thead>";
            display += "<tr>";
            display += "<th>Kode Jurusan</th>";
            display += "<th>Nama Jurusan</th>";
            display += "<th>Action</th>";
            display += "<tr/>";
            display += "<body/>";

            Model.Jurusan jurusan = new Model.Jurusan();
            string flag = jurusan.lihatData();
            if (flag == "OK")
            {
                foreach (DataRow dr in jurusan.ds.Tables[0].Rows)
                {
                    display += "<tr>";
                    foreach (DataColumn dc in jurusan.ds.Tables[0].Columns)
                    {
                        display += "<td>" + dr[dc.ColumnName].ToString() + "</td>";
                    }
                    display += "<td>";
                    display += "<a href='EditJurusan.aspx?id=" + dr[0].ToString() + "'class='btn btn-warning'>Edit</a> ";
                    display += "<a href='DeleteJurusan.aspx?id=" + dr[0].ToString() + "'class='btn btn-danger'>Hapus</a> ";
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
        }
        private void clearData()
        {
            txtKodeJurusan.Text = "";
            txtNamaJurusan.Text = "";
        }
        protected void btnSimpan_Click(object sender, EventArgs e)
        {
            Model.Jurusan jurusan = new Model.Jurusan();
            jurusan.kode = txtKodeJurusan.Text;
            jurusan.nama = txtNamaJurusan.Text;
            string flag = jurusan.insertData();
            if (flag == "OK")
            {
                response.Text = GlobalVariabel.getSuccess("Data berhasil disimpan");
                clearData();
                Response.Redirect("jurusan.aspx");
            }
            else
            {
                response.Text = GlobalVariabel.getFail("Data gagal disimpan");
            }
        }
    }
}