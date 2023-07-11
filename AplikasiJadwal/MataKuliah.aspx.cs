using System;
using System.Data;

namespace AplikasiJadwal
{
    public partial class MataKuliah : System.Web.UI.Page
    {
        private void tampilData()
        {
            string display = "<table ID='table' class='table table-striped table-bordered' style='width:100%'>";
            display += "<thead>";
            display += "<tr>";
            display += "<th>Kode Mata Kuliah</th>";
            display += "<th>Mata Kuliah</th>";
            display += "<th>SKS</th>";
            display += "<th>Semester</th>";
            display += "<th>Action</th>";
            display += "<tr/>";
            display += "<body/>";

            Model.MataKuliah matkul = new Model.MataKuliah();
            string flag = matkul.lihatData();
            if (flag == "OK")
            {
                foreach (DataRow dr in matkul.ds.Tables[0].Rows)
                {
                    display += "<tr>";
                    foreach (DataColumn dc in matkul.ds.Tables[0].Columns)
                    {
                        display += "<td>" + dr[dc.ColumnName].ToString() + "</td>";
                    }
                    display += "<td>";
                    display += "<a href='EditMataKuliah.aspx?id=" + dr[0].ToString() + "'class='btn btn-warning'>Edit</a> ";
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
            txtKodeMK.Text = "";
            txtNamaJurusan.Text = "";
            TxtSKS.Text = "";
            TxtSems.Text = "";
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Model.MataKuliah mataKuliah = new Model.MataKuliah();
            mataKuliah.kode = txtKodeMK.Text;
            mataKuliah.nama = txtNamaJurusan.Text;
            mataKuliah.sks = Convert.ToInt32(TxtSKS.Text);
            mataKuliah.semester = TxtSems.Text;
            string flag = mataKuliah.insertData();
            if (flag == "OK")
            {
                response.Text = GlobalVariabel.getSuccess("Data berhasil disimpan");
                clearData();
            }
            else
            {
                response.Text = GlobalVariabel.getFail("Data gagal disimpan");
            }

        }
    }
}