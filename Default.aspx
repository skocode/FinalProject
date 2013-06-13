<%@ Page Title="" Language="C#" MasterPageFile="~/FPMasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<!-- This code uses Linq Syntax to display datalists listing the Automart locations and available services. -->
<div class="homebox">
    <h2>Locations</h2>
    <asp:DataList ID="LocationsDL" runat="server">
        <ItemTemplate>
            <strong><%#Eval("LocationName") %>: </strong><br /><%#Eval("LocationAddress") %><br /> <%#Eval("LocationCity") %>, <%#Eval("LocationState") %> <%#Eval("LocationZip") %><br /><br />
        </ItemTemplate>
    </asp:DataList>
</div>
<div class="homebox">
    <h2>Services</h2>
    <asp:DataList ID="ServicesDL" runat="server">
        <ItemTemplate>
            <strong><%#Eval("ServiceName") %>: </strong>$<%#Eval("ServicePrice") %><br /><br />
        </ItemTemplate>
    </asp:DataList>
</div>

<!-- This button will redirect the user to the Log In page -->
<div class="homebutton">
<h3>Log in to see your vehicle's service history: </h3>
<asp:Button ID="ToLogInBtn" runat="server" Text="Log In" OnClick="ToLogInBtn_Click" />
</div>

</asp:Content>

