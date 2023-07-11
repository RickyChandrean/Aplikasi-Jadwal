using System;
using System.Collections;

namespace AplikasiJadwal
{
    public partial class EditPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btUbah_Click(object sender, EventArgs e)
        {
            Model.Administrator admin = new Model.Administrator();
            admin.username = Session["username"].ToString();
            admin.password = TextBox1.Text;
            ArrayList data = admin.dologin();
            if (data.Count > 0)
            {
                admin.password = TextBox2.Text;
                string flag = admin.ubahPassword();
                if (flag == "OK")
                {
                    response.Text = GlobalVariabel.getSuccess("Password berhasil diubah");
                    Response.Redirect("Home.aspx");
                }
                else
                {
                    response.Text = GlobalVariabel.getFail("Password gagal diubah");
                }
            }
            else
            {
                response.Text = GlobalVariabel.getFail("Password lama salah");
            }
        }
    }
}