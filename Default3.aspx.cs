using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SubmitBtn_Click(object sender, EventArgs e)
    {
            // Form Validation - Checks for blank required fields and password matching using C# code
            if (LastNameTxt.Text == "")
            {
                LNErrorLbl.Text = "* Required Field";
                return;
            }
            else { LNErrorLbl.Text = ""; }

            if (EmailTxt.Text == "")
            {
                EMErrorLbl.Text = "* Required Field";
                return;
            }
            else { EMErrorLbl.Text = ""; }

            if (LicenseTxt.Text == "")
            {
                LPErrorLbl.Text = "* Required Field";
                return;
            }
            else { LPErrorLbl.Text = ""; }

            if (PasswordTxt.Text == "")
            {
                PWErrorLbl.Text = "* Required Field";
                return;
            }
            else { PWErrorLbl.Text = ""; }

            if (PasswordConfirmTxt.Text == "")
            {
                PWCErrorLbl.Text = "* Required Field";
                return;
            }
            else { PWCErrorLbl.Text = ""; }

            if (PasswordTxt.Text != PasswordConfirmTxt.Text)
            {
                PWErrorLbl.Text = "* Passwords Must Match";
                PWCErrorLbl.Text = "* Passwords Must Match";
                return;
            }
            else
            {
                PWErrorLbl.Text = "";
                PWCErrorLbl.Text = "";
            }
            // End Form Validation

            // This code uses the ADO.Net Data Entities to collect user-entered registration information and enter it into the Automart database, then redirect the user to a thank you page
            
            try
            {
                AutomartModel.AutomartEntities ame = new AutomartModel.AutomartEntities();

                AutomartModel.Person p = new AutomartModel.Person();
                p.FirstName = FirstNameTxt.Text;
                p.LastName = LastNameTxt.Text;
                ame.People.AddObject(p);

                AutomartModel.RegisteredCustomer rc = new AutomartModel.RegisteredCustomer();
                rc.Email = EmailTxt.Text;
                rc.CustomerPassword = PasswordTxt.Text;
                ame.RegisteredCustomers.AddObject(rc);

                AutomartModel.vehicle v = new AutomartModel.vehicle();
                v.LicenseNumber = LicenseTxt.Text;
                v.VehicleMake = MakeTxt.Text;
                v.VehicleYear = YearTxt.Text;
                ame.vehicles.AddObject(v);

                ame.SaveChanges();

                Response.Redirect("Default4.aspx", false);
            }
            catch (Exception ex)
            {
                Session["error"] = ex.Message;
                Response.Redirect("Default6.aspx");
            }
        }
    }