using System;
using System.Collections;

namespace AplikasiJadwal
{
    public partial class EditMataKuliah : System.Web.UI.Page
    {
        string kode;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                kode = Request.QueryString["id"];
                Model.MataKuliah matkul = new Model.MataKuliah();
                matkul.kode = kode;
                ArrayList data = matkul.cariData();
                txtKodeMK.Text = data[0].ToString();
                txtNamaJurusan.Text = data[1].ToString();
                TxtSKS.Text = data[2].ToString();
                TxtSems.Text = data[3].ToString();
            }

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Model.MataKuliah mataKuliah = new Model.MataKuliah();
            mataKuliah.kode = txtKodeMK.Text;
            mataKuliah.nama = txtNamaJurusan.Text;
            mataKuliah.sks = Convert.ToInt32(TxtSKS.Text);
            mataKuliah.semester = TxtSems.Text;
            string flag = mataKuliah.editData();
            if (flag == "OK")
            {
                response.Text = GlobalVariabel.getSuccess("Data berhasil diubah");
                Label1.Visible = false;
                Label2.Visible = false;
                Label3.Visible = false;
                Label4.Visible = false;
                txtKodeMK.Visible = false;
                txtNamaJurusan.Visible = false;
                TxtSems.Visible = false;
                TxtSKS.Visible = false;
                btnSubmit.Visible = false;

            }
            else
            {
                response.Text = GlobalVariabel.getFail("Data gagal diubah");
            }
        }
    }
}