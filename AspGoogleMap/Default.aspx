<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AspGoogleMap._Default" %>

<%@ Register Assembly="GMaps" Namespace="Subgurim.Controles" TagPrefix="cc1" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   <h3>Hotels in Los Angeles</h3>
    <cc1:GMap ID="GMap1" runat="server" Width="800px" Height="500px" />
</asp:Content>
