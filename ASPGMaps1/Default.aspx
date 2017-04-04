<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ASPGMaps1._Default" %>

<%@ Register Assembly="GMaps1" Namespace="Subgurim.Controles" TagPrefix="cc1" %>

<%--<asp:Content ContentPlaceHolderID="<FeaturedContent>" ID="FeaturedContent" runat="server">
   

</asp:Content> --%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h3> Bolgede ne var</h3>
    <div>
        <cc1:GMap ID="GMap1" runat="server" Width="600px" Height="500px" />
    </div>
    
</asp:Content>

