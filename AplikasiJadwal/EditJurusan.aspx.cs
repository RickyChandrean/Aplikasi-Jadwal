using System;
using System.Collections;

namespace AplikasiJadwal
{
    public partial class EditJurusan : System.Web.UI.Page
    {
        string kode;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                kode = Request.QueryString["id"];
                Model.Jurusan jurusan = new Model.Jurusan();
                jurusan.kode = kode;
                ArrayList data = jurusan.cariData();
                txtKode.Text = data[0].ToString();
                txtJurusan.Text = data[1].ToString();
            }

        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            Model.Jurusan jurusan = new Model.Jurusan();
            jurusan.kode = txtKode.Text;
            jurusan.nama = txtJurusan.Text;
            string flag = jurusan.editData();
            if (flag == "OK")
            {
                response.Text = GlobalVariabel.getSuccess("Data berhasil diubah");
                Label1.Visible = false;
                Label2.Visible = false;
                txtKode.Visible = false;
                txtJurusan.Visible = false;
                btnEdit.Visible = false;

            }
            else
            {
                response.Text = GlobalVariabel.getFail("Data gagal diubah");
            }
        }
    }
}