<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Results.aspx.cs" Inherits="Finalprog.REsults" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="Results.css" />                <!-- This is the link to the Page Specific .css file. -->
    <link rel="stylesheet" href="Navigation Bar.css" />         <!-- This is the link to the Navigation bar's .css file. -->
    <title></title>
</head>
<body>
    <form id="form1" runat="server" defaultbutton="btnResultsSearch">
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
        <!-- These are the tiles. -->
        <div id="TileLayout" class="TileLayout">
            <asp:HiddenField ID="CourseID" runat="server" ClientIDMode="Static" />
            <asp:HiddenField ID="CourseName" runat="server" ClientIDMode="Static" />
            <asp:HiddenField ID="Description" runat="server" ClientIDMode="Static" />

            <!--<div class="Tile" runat="server" id="Tile1">                                                                            
                <asp:Image ID="img_TileImage1" runat="server" />                                                                    
                <asp:Button ID="btn_CourseName_1" runat="server" Text="Button" OnClick="Results1_Click" CssClass="TopOfTile"/>      
                <asp:Label ID="lbl_CourseID_1" runat="server" Text="Label" CssClass="TopOfTile"></asp:Label>                        
                <asp:Label ID="lbl_Description_1" runat="server" Text="Label" CssClass="Description"></asp:Label> 
                <asp:Label ID="Label1" runat="server" Text="Label" CssClass="Description"></asp:Label>  
            </div>-->
        </div>
    </form>
</body>
</html>