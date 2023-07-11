using System;
using System.Collections;
using System.Web.UI;

namespace AplikasiJadwal
{
    public partial class EditJadwal : System.Web.UI.Page
    {
        string kode;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                kode = Request.QueryString["id"];
                Model.Jadwal jadwal = new Model.Jadwal();
                jadwal.id = Convert.ToInt32(kode);
                ArrayList data = jadwal.cariData();
                txtid.Text = data[0].ToString();
                txtKodeD.Text = data[1].ToString();
                txtKdMK.Text = data[2].ToString();
                txtDate.Text = data[3].ToString();
                TxtJam.Text = data[4].ToString();
            }
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
                jadwal.tanggal = DateTime.Parse(txtDate.Text);
                jadwal.jam = TxtJam.Text;
                string flag = jadwal.editData();
                if (flag == "OK")
                {
                    response.Text = GlobalVariabel.getSuccess("Data berhasil diubah");
                }
                else
                {
                    response.Text = GlobalVariabel.getFail(flag);
                }
            }
        }
        protected void ImgButton_Click(object sender, ImageClickEventArgs e)
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