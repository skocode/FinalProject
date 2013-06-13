<%@ Page Title="" Language="C#" MasterPageFile="~/FPMasterPage.master" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <!-- This code creates a user log-in form -->
    <div class="login">
        <h2>Registered Customer Login</h2>
        <table>
            <tr>
                <td>User Name</td>
                <td><asp:TextBox ID="txtuser" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Password</td>
                <td><asp:TextBox ID="txtpassword" runat="server" TextMode="Password"></asp:TextBox></td>
            </tr>
            <tr>
                <td></td>
                <td><asp:Button ID="LogInBtn" runat="server" Text="Log In" OnClick="LogInBtn_Click" /></td>
                <td><asp:Label ID="lblmsg" runat="server" Text=""></asp:Label></td>
            </tr>
        </table>
    </div>

    <!-- This button will redirect the user to the Registration page (Default3.aspx) -->
    <div class="registerbutton">
        <h3>Not a member yet?<br />Click here to register:</h3>
        <asp:Button ID="registerBtn" runat="server" Text="Register" OnClick="registerBtn_Click" />
    </div>
</asp:Content>

