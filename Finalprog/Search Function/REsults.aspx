﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Results.aspx.cs" Inherits="Finalprog.REsults" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <asp:TextBox ID="txtResultsSearch" runat="server"></asp:TextBox>
           <asp:Button ID="btnResultsSearch" runat="server" OnClick="btnResultsSearch_Click" Text="Search" />
        </div>
        <asp:ListBox ID="lstResults" runat="server" Width="453px"></asp:ListBox>
    </form>
</body>
</html>
