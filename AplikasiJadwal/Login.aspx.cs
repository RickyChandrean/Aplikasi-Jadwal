using System;
using System.Collections;
using System.Web;

namespace AplikasiJadwal
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btLogin_Click(object sender, System.EventArgs e)
        {
            Model.Administrator admin = new Model.Administrator();
            admin.username = txtUsername.Text;
            admin.password = txtPassword.Text;
            ArrayList data = admin.dologin();
            if (data.Count > 0)
            {
                if (ckremember.Checked)
                {
                    HttpCookie userinfo = new HttpCookie("userinfo");
                    userinfo["username"] = admin.username;
                    userinfo.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(userinfo);
                }
                Session["username"] = admin.username;
                Response.Redirect("Home.aspx");
            }
            else
            {
                response.Text = "<p style= 'color:red'>Login gagal. Username atau Password salah </p>";
            }

        }
    }
}