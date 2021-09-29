<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserPage.aspx.cs" Inherits="Finalprog.UserPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #TextArea1 {
            height: 78px;
            width: 193px;
        }
    </style>
</head>
<body id="formBack" runat="server">
    <form id="form1" runat="server">
        <div id="formDiv">
            <asp:Label ID="Label1" runat="server" style="font-size: xx-large" Text="Label"></asp:Label>
            <br />
            <br />
            <br />
            Status Message<br />
            <asp:TextBox ID="StatusText" runat="server" Height="81px" OnTextChanged="StatusText_TextChanged" Width="420px"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="btnRed" runat="server" BackColor="#990000" Height="35px" OnClick="btnRed_Click" Width="40px" />
            <asp:Button ID="btnGreen" runat="server" BackColor="#006600" Height="35px" Width="40px" OnClick="btnGreen_Click" />
            <asp:Button ID="btnBlue" runat="server" BackColor="#000066" Height="35px" Width="40px" OnClick="btnBlue_Click" />
            <asp:Button ID="btnWhite" runat="server" BackColor="White" Height="35px" Width="40px" OnClick="btnWhite_Click" />
            <br />
            <br />
            <br />
            <asp:Button ID="btnLogout" runat="server" Height="24px" OnClick="btnLogout_Click" Text="Log Out" Width="71px" />
        </div>
    </form>
</body>
</html>
