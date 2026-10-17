using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Experiment_6
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] == null)
            {
                Response.Redirect("Login.aspx");
                return; 
            }

            lblWelcome.Text = "Welcome, " + Session["UserID"].ToString();
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            string selectedDate = Calendar1.SelectedDate.ToString("yyyy-MM-dd");
            Response.Redirect("Leave.aspx?date=" + selectedDate);
        }
    }
}