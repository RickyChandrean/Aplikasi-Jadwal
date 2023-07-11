using System;
using System.Collections;
using System.Data;
using System.Web.UI;

namespace AplikasiJadwal
{
    public partial class EditDosen : System.Web.UI.Page
    {
        string kode;
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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                populateData();
                kode = Request.QueryString["id"];
                Model.Dosen dosen = new Model.Dosen();
                dosen.kode_dosen = kode;
                ArrayList data = dosen.cariData();
                txtKodeD.Text = data[0].ToString();
                ddjurusan.Text = data[1].ToString();
                txtNamaDosen.Text = data[2].ToString();
                TxtTelp.Text = data[3].ToString();
                TxtAlamat.Text = data[4].ToString();
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Model.Dosen dosen = new Model.Dosen();
            dosen.kode_dosen = txtKodeD.Text;
            dosen.kode_jurusan = ddjurusan.Text;
            dosen.nama_dosen = txtNamaDosen.Text;
            dosen.telp = TxtTelp.Text;
            dosen.alamat = TxtAlamat.Text;
            string flag = dosen.editData();
            if (flag == "OK")
            {
                response.Text = GlobalVariabel.getSuccess("Data berhasil diubah");
                txtKodeD.Visible = false;
                ddjurusan.Visible = false;
                txtNamaDosen.Visible = false;
                TxtTelp.Visible = false;
                TxtAlamat.Visible = false;
                Label1.Visible = false;
                Label2.Visible = false;
                Label3.Visible = false;
                Label4.Visible = false;
                Label5.Visible = false;
                btnSubmit.Visible = false;
            }
            else
            {
                response.Text = GlobalVariabel.getFail("Data gagal diubah");
            }
        }
    }
}