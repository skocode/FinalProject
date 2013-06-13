<%@ Page Title="" Language="C#" MasterPageFile="~/FPMasterPage.master" AutoEventWireup="true" CodeFile="Default6.aspx.cs" Inherits="Default6" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <!-- This page displays an error message for any Try/Cath errors in the website's code-->
    <div class="error">
        <h3>I'm sorry! We've encountered an error.</h3>
        <br />
        <p>Error Message:</p>
        <asp:Label ID="errorMsg" runat="server" Text=""></asp:Label>
        <br /><br />
        <asp:Button ID="errorBtn" runat="server" Text="Return to Homepage" OnClick="errorBtn_Click" />
    </div>
</asp:Content>

