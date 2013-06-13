<%@ Page Title="" Language="C#" MasterPageFile="~/FPMasterPage.master" AutoEventWireup="true" CodeFile="Default4.aspx.cs" Inherits="Default4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <!-- This page displays a "thank you for registering" message and a button to return the user to the log in page -->
    <div class="thankyou">
        <h2>Thank you for registering with Automart!</h2>
        <asp:Button ID="ToLogInBtn2" runat="server" Text="Return to Log In" OnClick="ToLogInBtn2_Click" />
    </div>
</asp:Content>

