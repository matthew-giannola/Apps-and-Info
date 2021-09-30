<%@ Page Title="Course" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Course Page.aspx.cs" Inherits="WebApplication3.Course" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%:"Course Page" %>
        <asp:Label ID="courseDescription" runat="server" Text="Label"></asp:Label>
        <asp:Label ID="timeLbl" runat="server"></asp:Label>
    </h2>
    <head>
   <meta name="viewport" content="width=device-width" />
   <title>Sample YouTube Embed Video Example</title>
</head>
<body>
    <div>
        <asp:Panel ID="test" runat="server" Height="345px">
            <asp:Panel ID="Panel1" runat="server" Width="212px">
                <asp:Button ID="testButton" runat="server" OnClick="testButton_Click" Text="Take Test" CausesValidation="False" />
                <asp:Button ID="discussBtn" runat="server" Text="Discussion" Width="104px" />
                <asp:Panel ID="quizscorePnl" runat="server" Height="47px" Width="212px">
                    <span style="font-size: large">Quiz Score: </span>
                    <asp:Label ID="scoreLbl" runat="server" style="font-size: large"></asp:Label>
                    <asp:Panel ID="Panel2" runat="server" style="font-size: large" Width="269px">
                        Instructor:
                        <asp:Label ID="instructorLbl" runat="server"></asp:Label>
                        <br />
                        Zoom Meeting:<br /> URL:&nbsp;
                        <asp:Label ID="urlLbl" runat="server"></asp:Label>
                        <br />
                        Meeting Password:<asp:Label ID="passwordLbl" runat="server"></asp:Label>
                    </asp:Panel>
                    <asp:Panel ID="Panel3" runat="server" Height="178px" style="font-size: large" Width="593px">
                        Course Descriptio<asp:Panel ID="videoPanel" runat="server">
                        </asp:Panel>
                        n:<asp:Label ID="descLbl" runat="server"></asp:Label>
                    </asp:Panel>
                </asp:Panel>
            </asp:Panel>
        </asp:Panel>
    </div>
   </script>
</body>
</asp:Content>
