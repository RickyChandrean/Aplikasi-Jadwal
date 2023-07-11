using System;

namespace AplikasiJadwal
{
    public partial class DeleteJurusan : System.Web.UI.Page
    {
        string kode;
        protected void Page_Load(object sender, EventArgs e)
        {
            kode = Request.QueryString["id"];
            Label1.Text = "Apakah anda yakin untuk menghapus data dengan kode " + kode + "?";
        }

        protected void btnHapus_Click(object sender, EventArgs e)
        {
            Model.Jurusan jurusan = new Model.Jurusan();
            jurusan.kode = kode;
            string flag = jurusan.hapusData();
            if (flag == "OK")
            {
                response.Text = GlobalVariabel.getSuccess("Data Berhasil Dihapus");
                Label1.Text = "";
                btnHapus.Visible = false;
                btnCancel.Text = "Kembali";
            }
            else
            {
                response.Text = GlobalVariabel.getFail("Data Gagal Dihapus");
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Jurusan.aspx");
        }
    }
}