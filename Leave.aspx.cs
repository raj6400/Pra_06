using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Experiment_6
{
    public partial class Leave : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblDate.Text = Request.QueryString["date"];
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }

        protected void btnApply_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmpName.Text) ||
                string.IsNullOrWhiteSpace(txtEmpDept.Text) ||
                string.IsNullOrWhiteSpace(txtEmpDesig.Text) ||
                string.IsNullOrWhiteSpace(txtReason.Text))
            {
                lblResult.ForeColor = System.Drawing.Color.Red;
                lblResult.Text = "Please fill in all fields before applying.";
                return;
            }

            lblResult.ForeColor = System.Drawing.Color.Blue;
            lblResult.Text = "Leave application submitted successfully for " + lblDate.Text + "!";
        }
    }
}