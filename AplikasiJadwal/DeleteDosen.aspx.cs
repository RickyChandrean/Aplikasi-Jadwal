using System;

namespace AplikasiJadwal
{
    public partial class DeleteDosen : System.Web.UI.Page
    {
        string kode;
        protected void Page_Load(object sender, EventArgs e)
        {
            kode = Request.QueryString["id"];
            Label1.Text = "Apakah anda yakin untuk menghapus data dengan kode " + kode + "?";
        }
        protected void btnHapus_Click1(object sender, System.EventArgs e)
        {
            Model.Dosen dosen = new Model.Dosen();
            dosen.kode_dosen = kode;
            string flag = dosen.hapusData();
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

        protected void btnCancel_Click1(object sender, System.EventArgs e)
        {
            Response.Redirect("Dosen.aspx");
        }
    }


}