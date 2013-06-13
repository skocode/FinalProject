<%@ Page Title="" Language="C#" MasterPageFile="~/FPMasterPage.master" AutoEventWireup="true" CodeFile="Default5.aspx.cs" Inherits="Default5" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <div class="welcome">
        <!-- Display name and Email -->
        <h3><asp:Label ID="WelcomeLbl" runat="server" Text="Label"></asp:Label></h3>
        <p><asp:Label ID="EmailLbl" runat="server" Text="Label"></asp:Label></p>
    </div>

    <div class="infobox">
        <h3>Your Registered Vehicles:</h3><br />
        <div class="datalist">
            <asp:DataList ID="VehicleDL" runat="server">
                <ItemTemplate>
                    <strong>Vehicle ID #<%#Eval("VehicleId") %>: </strong><%#Eval("VehicleYear") %> <%#Eval("VehicleMake") %>, License Number: <%#Eval("LicenseNumber") %><br />
                </ItemTemplate>
            </asp:DataList>
        </div>
    </div>

    <div class="infobox">
        <h3>Your Maintenance Service History:</h3><br />
        <div class="datalist">
            <asp:DataList ID="ServiceDL" runat="server">
                <ItemTemplate>
                    <strong>Vehicle Service ID #<%#Eval("VehicleServiceID") %>: </strong>Service on Vehicle #<%#Eval("VehicleID") %> at <%#Eval("ServiceTime") %> on <%#Eval("ServiceDate") %> at Location #<%#Eval("LocationID") %>.<br />
                </ItemTemplate>
            </asp:DataList>
            <asp:Label ID="NoHistoryLbl" runat="server" Text=""></asp:Label>
         </div>
    </div>

    <div class="infobox">
        <h3>Service Details:</h3><br />
        <div class="datalist">
            <asp:DataList ID="DetailsDL" runat="server">
                <ItemTemplate>
                    <strong>Vehicle Service ID #<%#Eval("VehicleServiceID") %>: </strong>Auto Service #<%#Eval("AutoServiceID") %><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<strong>Service Notes: </strong><%#Eval("serviceNotes") %><br /><br />
                </ItemTemplate>
            </asp:DataList>
            <asp:Label ID="NoHistoryLbl2" runat="server" Text=""></asp:Label>
        </div>
    </div>

    <div class="key">
        <h3>Location ID Key:</h3><br />
        <div class="datalist">
            <asp:DataList ID="LocationIdDL" runat="server">
                <ItemTemplate>
                    <strong>Location ID #<%#Eval("LocationID") %>: </strong><%#Eval("LocationName") %><br />
                </ItemTemplate>
            </asp:DataList>
        </div>
    </div>

    <div class="key">
        <h3>Auto Service ID Key:</h3><br />
        <div class="datalist">
            <asp:DataList ID="AutoServiceDL" runat="server">
                <ItemTemplate>
                    <strong>Auto Service ID #<%#Eval("AutoServiceID") %>: </strong><%#Eval("ServiceName") %><br />
                </ItemTemplate>
            </asp:DataList>
        </div>
    </div>
</asp:Content>

