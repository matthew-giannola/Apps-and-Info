<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchPage.aspx.cs" Inherits="Finalprog.WebForm1" %>

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
        top:50%;
        transform: translateX(-50%) translateY(-50%);
        text-align: left;
        margin: 1px;
        }

        .outer {
        margin: 1px;
        display: inline-block;
        }

        html {
         height:100%;
        }

        body {
          margin:0;
        }
        
        .bg {
          animation:slide 3s ease-in-out infinite alternate;
          background-image: linear-gradient(-60deg, #6c3 50%, #09f 50%);
          bottom:0;
          left:-50%;
          opacity:.5;
          position:fixed;
          right:-50%;
          top:0;
          z-index:-1;
        }
        
        .bg2 {
          animation-direction:alternate-reverse;
          animation-duration:4s;
        }
        
        .bg3 {
          animation-duration:5s;
        }
        
        @keyframes slide {
          0% {
            transform:translateX(-25%);
          }
          100% {
            transform:translateX(25%);
          }
        }
        </style>

        <div class="bg"></div>
<div class="bg bg2"></div>
<div class="bg bg3"></div>

        <div class ="center" >
               <div id ="searchBox">
                    <asp:TextBox class="outer" ID="txtSearch" runat="server" BorderStyle="Groove" Width="331px" Height="31px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;
                    <asp:Button class="outer" ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search" BorderStyle="Groove" Height="34px" Width="89px" />
                </div>
            </div>


        

            

            <asp:Button ID="btnLogout" runat="server" Height="25px" OnClick="btnLogout_Click" Text="Log Out" Width="130px" BorderStyle="None" />
            <asp:Button ID="btnAdmin" runat="server" OnClick="btnAdmin_Click" Text="AdminPage" Visible="False" BorderStyle="None" Height="25px" Width="130px" />
            <asp:Button ID="btnUser" runat="server" OnClick="btnUser_Click" Text="User Page" BorderStyle="None" Height="25px" Width="130px" />
&nbsp;<hr />
 
    </form>
</body>
</html>
