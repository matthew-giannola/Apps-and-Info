<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CoursePage.aspx.cs" Inherits="Finalprog.CoursePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCourse" runat="server" Style="font-weight: 700; font-size: xx-large" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Button ID="testButton" runat="server" Height="46px" OnClick="testButton_Click" Text="Take Test" Width="85px" />
            <asp:Panel ID="test" runat="server" Height="246px">
            </asp:Panel>
            <br />
            <br />
            <br />
        </div>

        <div class="form-group">
        </div>
    </form>
</body>
</html>
