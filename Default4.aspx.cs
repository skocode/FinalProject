using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ToLogInBtn2_Click(object sender, EventArgs e)
    {
        //When clicked, the ToLogInBtn2 will redirect the user to the log in page (Default2.aspx)
            Response.Redirect("Default2.aspx");
    }

}