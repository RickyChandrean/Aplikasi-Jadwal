using System;
using System.Data;
using System.Globalization;

namespace AplikasiJadwal
{
    public partial class Jadwal : System.Web.UI.Page
    {
        private void tampilData()
        {
            string display = "<table ID='table' class='table table-striped table-bordered' style='width:100%'>";
            display += "<thead>";
            display += "<tr>";
            display += "<th>ID</th>";
            display += "<th>Kode Dosen</th>";
            display += "<th>Kode Mata Kuliah</th>";
            display += "<th>Tanggal</th>";
            display += "<th>Jam</th>";
            display += "<th>Action</th>";
            display += "<tr/>";
            display += "<body/>";

            Model.Jadwal jadwal = new Model.Jadwal();
            string flag = jadwal.lihatData();
            if (flag == "OK")
            {
                foreach (DataRow dr in jadwal.ds.Tables[0].Rows)
                {
                    display += "<tr>";
                    foreach (DataColumn dc in jadwal.ds.Tables[0].Columns)
                    {
                        display += "<td>" + dr[dc.ColumnName].ToString() + "</td>";
                    }
                    display += "<td>";
                    display += "<a href='EditJadwal.aspx?id=" + dr[0].ToString() + "'class='btn btn-warning'>Edit</a> ";
                    display += "<a href='DeleteJadwal.aspx?id=" + dr[0].ToString() + "'class='btn btn-danger'>Hapus</a> ";
                    display += "</td>";
                    display += "</tr>";
                }
                display += "</tbody>";
                display += "</table>";
                lt_table.Text = display;
            }
            else
            {
                lt_table.Text = display;
            }
        }
        private void clearData()
        {
            txtDate.Text = "";
            txtKdMK.Text = "";
            txtKodeD.Text = "";
            TxtJam.Text = "";
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            tampilData();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtKdMK.Text == "")
            {
                Response.Write("<script>alert('Masukan Kode Mata Kuliah')</script>");
            }
            else if (txtKodeD.Text == "")
            {
                Response.Write("<script>alert('Masukan Kode Dosen')</script>");
            }
            else if (txtDate.Text == "")
            {
                Response.Write("<script>alert('Masukan Tanggal')</script>");
            }
            else if (TxtJam.Text == "")
            {
                Response.Write("<script>alert('Masukan Jam')</script>");
            }
            else
            {
                Model.Jadwal jadwal = new Model.Jadwal();
                jadwal.kode_dosen = txtKodeD.Text;
                jadwal.kode_mk = txtKdMK.Text;
                jadwal.tanggal = DateTime.ParseExact(txtDate.Text, "d/MM/yyyy", CultureInfo.InvariantCulture);
                jadwal.jam = TxtJam.Text;

                string flag = jadwal.insertData();
                if (flag == "OK")
                {
                    Response.Write("<script>alert('Data berhasil disimpan')</script>");
                    clearData();
                }
                else
                {
                    Response.Write("<script>alert('Data gagal disimpan')</script>");
                }
            }

        }

        protected void ImgButton_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            if (Calendar1.Visible == false)
            {
                Calendar1.Visible = true;
            }
            else
            {
                Calendar1.Visible = false;
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            txtDate.Text = Calendar1.SelectedDate.ToString("dd/MM/yyyy");
            Calendar1.Visible = false;
        }
    }
}