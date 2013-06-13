using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
 
    protected void LogInBtn_Click(object sender, EventArgs e)
    {
        //This code uses the CustomerLogin class to validate the entered log in information, retrieve the Person Key of the user who logged in, and save the key in the "person" session, then redirect to Default5.aspx
        try
        {
            CustomerLogin cl = new CustomerLogin();
            int pk = cl.Login(txtuser.Text, txtpassword.Text);
            if (pk != 0)
            {
                Session["person"] = pk;
                Response.Redirect("Default5.aspx", false);
            }
            else
            {
                lblmsg.Text = "Invalid Login";
            }
       }

        catch (Exception ex)
        {
            Session["error"] = ex.Message;
            Response.Redirect("Default6.aspx");
        }
    }

    //When clicked, the register button will send the user to the registration page (Default3.aspx)
    protected void registerBtn_Click(object sender, EventArgs e)
    {
            Response.Redirect("Default3.aspx");
    }
}