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
        <p></p>
        <!-- This is for the search bar. -->
        <div class="SearchBar">
            <asp:TextBox class="outer" ID="txtResultsSearch" runat="server" Width="637px" Height="27px" CssClass="SearchBar"></asp:TextBox>
            <asp:Button class="outer" ID="btnResultsSearch" runat="server" OnClick="btnResultsSearch_Click" Text="Search" CssClass="SearchButton"/>
        </div>

        <!-- These are the tiles. -->
        <div class="TileLayout">
            <div class="Tile" runat="server" id="Tile1">                                                                            <!-- This is to set the div so it populates correctly -->
                <asp:Image ID="img_TileImage1" runat="server" />                                                                    <!-- This is a header image for the tile. -->
                <asp:Button ID="btn_CourseName_1" runat="server" Text="Button" OnClick="Results1_Click" CssClass="TopOfTile"/>      <!-- Button to head to other course. -->
                <asp:Label ID="lbl_CourseID_1" runat="server" Text="Label" CssClass="TopOfTile"></asp:Label>                        <!-- Label displaying the Course ID. -->
                <asp:Label ID="lbl_Description_1" runat="server" Text="Label" CssClass="Description"></asp:Label>                   <!-- Label displaying the Course Description. -->
            </div>
            <div class="Tile" runat="server" id="Tile2">
                <asp:Image ID="img_TileImage2" runat="server" />
                <asp:Button ID="btn_CourseName_2" runat="server" Text="Button" OnClick="Results1_Click" CssClass="TopOfTile"/>
                <asp:Label ID="lbl_CourseID_2" runat="server" Text="Label" CssClass="TopOfTile"> </asp:Label>
                <asp:Label ID="lbl_Description_2" runat="server" Text="Label" CssClass="Description"> </asp:Label>
            </div>
            <div class="Tile" runat="server" id="Tile3" onclick="Results3_Click">
                <asp:Image ID="img_TileImage3" runat="server" />
                <asp:Button ID="btn_CourseName_3" runat="server" Text="Button" OnClick="Results1_Click" CssClass="TopOfTile"/>
                <asp:Label ID="lbl_CourseID_3" runat="server" Text="Label" CssClass="TopOfTile"> </asp:Label>
                <asp:Label ID="lbl_Description_3" runat="server" Text="Label" CssClass="Description"> </asp:Label>
            </div>
            <div class="Tile" runat="server" id="Tile4" onclick="Results4_Click">
                <asp:Image ID="img_TileImage4" runat="server" />
                <asp:Button ID="btn_CourseName_4" runat="server" Text="Button" OnClick="Results1_Click" CssClass="TopOfTile"/>
                <asp:Label ID="lbl_CourseID_4" runat="server" Text="Label" CssClass="TopOfTile"> </asp:Label>
                <asp:Label ID="lbl_Description_4" runat="server" Text="Label" CssClass="Description"> </asp:Label>
            </div>
            <div class="Tile" runat="server" id="Tile5" onclick="Results5_Click">
                <asp:Image ID="img_TileImage5" runat="server" />
                <asp:Button ID="btn_CourseName_5" runat="server" Text="Button" OnClick="Results1_Click" CssClass="TopOfTile"/>
                <asp:Label ID="lbl_CourseID_5" runat="server" Text="Label" CssClass="TopOfTile"> </asp:Label>
                <asp:Label ID="lbl_Description_5" runat="server" Text="Label" CssClass="Description"> </asp:Label>
            </div>
            <div class="Tile" runat="server" id="Tile6" onclick="Results6_Click">
                <asp:Image ID="img_TileImage6" runat="server" />
                <asp:Button ID="btn_CourseName_6" runat="server" Text="Button" OnClick="Results1_Click" CssClass="TopOfTile"/>
                <asp:Label ID="lbl_CourseID_6" runat="server" Text="Label" CssClass="TopOfTile"> </asp:Label>
                <asp:Label ID="lbl_Description_6" runat="server" Text="Label" CssClass="Description"> </asp:Label>
            </div>
            <div class="Tile" runat="server" id="Tile7" onclick="Results7_Click">
                <asp:Image ID="img_TileImage7" runat="server" />
                <asp:Button ID="btn_CourseName_7" runat="server" Text="Button" OnClick="Results1_Click" CssClass="TopOfTile"/>
                <asp:Label ID="lbl_CourseID_7" runat="server" Text="Label" CssClass="TopOfTile"> </asp:Label>
                <asp:Label ID="lbl_Description_7" runat="server" Text="Label" CssClass="Description"> </asp:Label>
            </div>
            <div class="Tile" runat="server" id="Tile8" onclick="Results8_Click">
                <asp:Image ID="img_TileImage8" runat="server" />
                <asp:Button ID="btn_CourseName_8" runat="server" Text="Button" OnClick="Results1_Click" CssClass="CourseName"/>
                <asp:Label ID="lbl_CourseID_8" runat="server" Text="Label" CssClass="CourseID"> </asp:Label>
                <asp:Label ID="lbl_Description_8" runat="server" Text="Label" CssClass="Description"> </asp:Label>
            </div>
            <div class="Tile" runat="server" id="Tile9" onclick="Results9_Click">
                <asp:Image ID="img_TileImage9" runat="server" />
                <asp:Button ID="btn_CourseName_9" runat="server" Text="Button" OnClick="Results1_Click" CssClass="TopOfTile"/>
                <asp:Label ID="lbl_CourseID_9" runat="server" Text="Label" CssClass="CourseID"> </asp:Label>
                <asp:Label ID="lbl_Description_9" runat="server" Text="Label" CssClass="Description"> </asp:Label>
            </div>
            <div class="Tile" runat="server" id="Tile10" onclick="Results10_Click">
                <asp:Image ID="img_TileImage10" runat="server" />
                <asp:Button ID="btn_CourseName_10" runat="server" Text="Button" OnClick="Results1_Click" CssClass="CourseName"/>
                <asp:Label ID="lbl_CourseID_10" runat="server" Text="Label" CssClass="CourseID"> </asp:Label>
                <asp:Label ID="lbl_Description_10" runat="server" Text="Label" CssClass="Description"> </asp:Label>
            </div>
        </div>
    </form>
</body>
</html>