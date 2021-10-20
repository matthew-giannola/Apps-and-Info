<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Results.aspx.cs" Inherits="Finalprog.REsults" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <style>
            .center {
        position: absolute;
        left:50%;
        top:5%;
        transform: translateX(-50%) translateY(-50%);
        text-align: left;
        margin: 1px;
        }

             .center2 {
        position: absolute;
        left:50%;
        top:50%;
        transform: translateX(-50%) translateY(-40%);
        text-align: left;
        margin: 1px;
        }

        .outer {
        margin: 1px 1px 1px 0px;
        display: inline-block;
        }</style>
       

        <div class ="center">
           <asp:TextBox class="outer" ID="txtResultsSearch" runat="server" Width="637px" Height="27px" BorderStyle="Outset"></asp:TextBox>
           <asp:Button class="outer" ID="btnResultsSearch" runat="server" OnClick="btnResultsSearch_Click" Text="Search" Height="33px" Width="136px" />
        </div>
        <div class ="center2">
        <asp:ListBox ID="lstResults" runat="server" Width="633px" Height="324px" Font-Names="Roboto Condensed" Font-Size="Large"></asp:ListBox>
        </div>


    </form>
</body>
</html>
