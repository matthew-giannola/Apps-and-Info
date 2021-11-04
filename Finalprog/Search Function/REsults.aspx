<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Results.aspx.cs" Inherits="Finalprog.REsults" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" defaultbutton="btnResultsSearch">


        <style>
            .center {
                position: absolute;
                left: 49%;
                top: 9%;
                transform: translateX(-50%) translateY(-50%);
                text-align: left;
                margin: 1px;
            }

            .center2 {
                position: absolute;
                left: 50%;
                top: 50%;
                transform: translateX(-50%) translateY(-40%);
                text-align: left;
                margin: 1px;
            }


            .outer {
                margin: 1px 1px 1px 0px;
                display: inline-block;
            }
        </style>

        <asp:Button ID="btnLogout" runat="server" Height="25px" OnClick="btnLogout_Click" Text="Log Out" Width="130px" BorderStyle="None" />
        <asp:Button ID="btnAdmin" runat="server" OnClick="btnAdmin_Click" Text="AdminPage" Visible="False" BorderStyle="None" Height="25px" Width="130px" />
        <asp:Button ID="btnUser" runat="server" OnClick="btnUser_Click" Text="User Page" BorderStyle="None" Height="25px" Width="130px" />
        &nbsp;<hr />
        <div class="center">
            <asp:TextBox class="outer" ID="txtResultsSearch" runat="server" Width="637px" Height="27px" BorderStyle="Outset"></asp:TextBox>
            <asp:Button class="outer" ID="btnResultsSearch" runat="server" OnClick="btnResultsSearch_Click" Text="Search" Height="33px" Width="136px" />
        </div>

        <div class="center2">
            <asp:Button ID="btnResults1" runat="server" Height="200px" Visible="False" Width="400px" CssClass="outer" OnClick="btnResults1_Click" />
            <asp:Button ID="btnResults2" runat="server" Height="200px" Visible="False" Width="400px" CssClass="outer" OnClick="btnResults2_Click" />
            <asp:Button ID="btnResults3" runat="server" Height="200px" Visible="False" Width="400px" CssClass="outer" OnClick="btnResults3_Click" />
            <asp:Button ID="btnResults4" runat="server" Height="200px" Visible="False" Width="400px" CssClass="outer" OnClick="btnResults4_Click" />
            <asp:Button ID="btnResults5" runat="server" Height="200px" Visible="False" Width="400px" CssClass="outer" OnClick="btnResults5_Click" />
            <asp:Button ID="btnResults6" runat="server" Height="200px" Visible="False" Width="400px" CssClass="outer" OnClick="btnResults6_Click" />
            <asp:Button ID="btnResults7" runat="server" Height="200px" Visible="False" Width="400px" CssClass="outer" OnClick="btnResults7_Click" />
            <asp:Button ID="btnResults8" runat="server" Height="200px" Visible="False" Width="400px" CssClass="outer" OnClick="btnResults8_Click" />
            <asp:Button ID="btnResults9" runat="server" Height="200px" Visible="False" Width="400px" CssClass="outer" OnClick="btnResults9_Click" />
        </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </p>
    </form>
</body>
</html>
