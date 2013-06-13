using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Default5 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //The code on this page calls on the "person" session to retrieve the Person Key of the logged-in user, then uses that key to retrieve the necessary customer data from the Automart database to populate the information displayed on Default5.aspx
        try
        {
            if (Session["person"] != null)
            {
                int personKey = (int)Session["person"];
                
                //This section of code uses ADO to retrieve the user's name and email address using the GetCustomer class
                GetCustomer gc = new GetCustomer(personKey);

                string customerName = null;
                DataSet ds = gc.GetName();

                foreach (DataRow row in ds.Tables["Customer"].Rows)
                {
                    customerName = row["FirstName"].ToString() + " " + row["LastName"].ToString();
                }

                WelcomeLbl.Text = "Welcome " + customerName + "!";

                string customerEmail = null;
                DataSet ds2 = gc.GetEmail();

                foreach (DataRow row in ds2.Tables["RegisteredCustomer"].Rows)
                {
                    customerEmail = row["Email"].ToString();
                }

                EmailLbl.Text = "Your registered email address is: " + customerEmail + ".";
   
               //From here, Ado.Net Data Entities is used to select vehicle and service information for the logged in user and bind
               // that information to the corresponding datalist on Default5.aspx
               AutomartModel.AutomartEntities ame = new AutomartModel.AutomartEntities();

                var veh = from v in ame.vehicles
                          where v.PersonKey == personKey
                          orderby v.VehicleId
                          select new { v.VehicleId, v.LicenseNumber, v.VehicleMake, v.VehicleYear};

                VehicleDL.DataSource = veh.ToList();
                VehicleDL.DataBind();

                var num = (from n in ame.VehicleServices
                           where n.vehicle.PersonKey == personKey
                           select n).Count();

                if (num == 0)
                {
                    NoHistoryLbl.Text = "You have no auto service history with AutoMart.";
                    NoHistoryLbl2.Text = "You have no auto service history with AutoMart.";
                }

                var ser = from s in ame.VehicleServices
                          where s.vehicle.PersonKey == personKey
                          orderby s.VehicleID
                          select new { s.VehicleServiceID, s.VehicleID, s.LocationID, s.ServiceDate, s.ServiceTime };

                ServiceDL.DataSource = ser.ToList();
                ServiceDL.DataBind();

                var det = from d in ame.VehicleServiceDetails
                          where d.VehicleService.vehicle.PersonKey == personKey
                          orderby d.VehicleServiceID
                          select new { d.VehicleServiceID, d.AutoServiceID, d.serviceNotes};

                DetailsDL.DataSource = det.ToList();
                DetailsDL.DataBind();

                var loc = from l in ame.Locations
                          orderby l.LocationID
                          select new { l.LocationID, l.LocationName};

                LocationIdDL.DataSource = loc.ToList();
                LocationIdDL.DataBind();

                var auto = from a in ame.AutoServices
                           orderby a.AutoServiceID
                           select new {a.AutoServiceID, a.ServiceName};

                AutoServiceDL.DataSource = auto.ToList();
                AutoServiceDL.DataBind();
            }
            else
            {
                Response.Redirect("Default2.aspx", false);
            }
        }

        catch (Exception ex)
        {
            Session["error"] = ex.Message;
            Response.Redirect("Default6.aspx");
        }
    }
}