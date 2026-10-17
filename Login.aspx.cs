using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Experiment_6
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "student" && txtPassword.Text == "14234")
            {
                Session["UserID"] = txtUser.Text;

                if (chkRememberMe.Checked)
                {
                    HttpCookie cookie = new HttpCookie("UserID");
                    cookie.Value = txtUser.Text;
                    cookie.Expires = DateTime.Now.AddDays(7);
                    Response.Cookies.Add(cookie);
                }
                else
                {
                    HttpCookie cookie = new HttpCookie("UserID");
                    cookie.Expires = DateTime.Now.AddDays(-1);
                    Response.Cookies.Add(cookie);
                }

                Response.Redirect("Default.aspx");
            }
        }
    }
}