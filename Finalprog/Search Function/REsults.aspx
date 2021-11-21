<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Results.aspx.cs" Inherits="Finalprog.REsults" enableeventvalidation="false" %>

<!DOCTYPE html>
<form id="form2" runat="server" defaultbutton="btnResultsSearch">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="Results.css" />                <!-- This is the link to the Page Specific .css file. -->
    <link rel="stylesheet" href="Navigation Bar.css" />         <!-- This is the link to the Navigation bar's .css file. -->
    <title></title>
</head>
<body>
        <!-- This is the nav bar. -->
        <div>
            <div class="NavBar" runat="server">
                <asp:Button ID="btnLogout" runat="server" OnClick="btnLogout_Click" Text="Log Out" CssClass="navButton"/>
                <asp:Button ID="btnAdmin" runat="server" OnClick="btnAdmin_Click" Text="AdminPage" Visible="False" CssClass="navButton"/>
                <asp:Button ID="btnUser" runat="server" OnClick="btnUser_Click" Text="User Page" CssClass="navButton"/>
            </div>
        </div>
        <!-- This is for the search bar. -->
        <div class="SearchBar">
            <asp:TextBox class="outer" ID="txtResultsSearch" runat="server" Width="637px" Height="27px" CssClass="SearchBar"></asp:TextBox>
            <asp:Button class="outer" ID="btnResultsSearch" runat="server" OnClick="btnResultsSearch_Click" Text="Search" CssClass="SearchButton"/>
        </div>
</body>
</html>
</form>