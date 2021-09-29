<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication3._Default" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    &nbsp;
    <asp:Button ID="Button1" runat="server" Height="104px" OnClick="Button1_Click" Text="Programming in C++" Width="152px" />
    <asp:Button ID="Button2" runat="server" Height="104px" OnClick="Button2_Click" Text="Programming in Java" Width="152px" />
</asp:Content>
