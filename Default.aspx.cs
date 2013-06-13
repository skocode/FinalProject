using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            //This code uses the ADO.Net DataEntities to pull the location and service information from the Automart database
            //and bind the info to the corresponding datalists on the Default.aspx page
            AutomartModel.AutomartEntities ame = new AutomartModel.AutomartEntities();

            var loc = from l in ame.Locations
                      orderby l.LocationName
                      select new { l.LocationName, l.LocationAddress, l.LocationCity, l.LocationState, l.LocationZip };

            LocationsDL.DataSource = loc.ToList();
            LocationsDL.DataBind();

            var serv = from s in ame.AutoServices
                       orderby s.ServiceName
                       select new { s.ServiceName, s.ServicePrice };

            ServicesDL.DataSource = serv.ToList();
            ServicesDL.DataBind();
        }

        catch (Exception ex)
        {
            Session["error"] = ex.Message;
            Response.Redirect("Default6.aspx");
        }
    }

    protected void ToLogInBtn_Click(object sender, EventArgs e)
    {
        //When clicked, the log in button will redirect the user to Default2.aspx
            Response.Redirect("Default2.aspx");
    }
}