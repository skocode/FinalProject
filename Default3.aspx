<%@ Page Title="" Language="C#" MasterPageFile="~/FPMasterPage.master" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <!-- This code display a registration form in which the user can enter their information-->
    <div class="registration">
     <h2>Registration Form</h2>
     <table>
            <tr>
                <td>First Name:</td>
                <td><asp:TextBox ID="FirstNameTxt" runat="server"></asp:TextBox></td>
                <td><asp:Label ID="FNErrorLbl" runat="server" Text=""></asp:Label></td>
            </tr>
             <tr>
                <td>Last Name:</td>
                <td><asp:TextBox ID="LastNameTxt" runat="server"></asp:TextBox></td>
               <td><asp:Label ID="LNErrorLbl" runat="server" Text=""></asp:Label></td>
            </tr>
             <tr>
                <td>Email:</td>
                <td><asp:TextBox ID="EmailTxt" runat="server"></asp:TextBox></td>
                <td><asp:Label ID="EMErrorLbl" runat="server" Text=""></asp:Label></td>                
            </tr>
             <tr>
                <td>License Plate Number:</td>
                <td><asp:TextBox ID="LicenseTxt" runat="server"></asp:TextBox></td>
                <td><asp:Label ID="LPErrorLbl" runat="server" Text=""></asp:Label></td>
            </tr>
             <tr>
                <td>Vehicle Make:</td>
                <td><asp:TextBox ID="MakeTxt" runat="server"></asp:TextBox></td>
                <td></td>
            </tr>
             <tr>
                <td>Vehicle Year:</td>
                <td><asp:TextBox ID="YearTxt" runat="server"></asp:TextBox></td>
                <td></td>
            </tr>
             <tr>
                <td>Enter Password:</td>
                <td><asp:TextBox ID="PasswordTxt" runat="server" TextMode="Password"></asp:TextBox></td>
                <td><asp:Label ID="PWErrorLbl" runat="server" Text=""></asp:Label></td>
            </tr>
             <tr>
                <td>Confirm Password:</td>
                <td><asp:TextBox ID="PasswordConfirmTxt" runat="server" TextMode="Password"></asp:TextBox></td>
                <td><asp:Label ID="PWCErrorLbl" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr><td></td></tr>
             <tr>
                <td></td>
                <td><asp:Button ID="SubmitBtn" runat="server" Text="Submit Registration" OnClick="SubmitBtn_Click" /></td>
                <td><asp:Label ID="ErrorLbl" runat="server" Text=""></asp:Label></td>
                <td></td>
            </tr>
     </table>
  </div>
</asp:Content>

