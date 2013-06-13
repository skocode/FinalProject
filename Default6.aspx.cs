using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default6 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["error"] != null)
        {
            string em = (string)Session["error"];
            errorMsg.Text = em;
        }
        else
        {
            Response.Redirect("Default.aspx");
        }
    }
    protected void errorBtn_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}