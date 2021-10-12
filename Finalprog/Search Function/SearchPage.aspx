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
        left:37%;
        top:35%;
        transform: translateX(-50%) translateY(-50%);
        text-align: left;
        margin: 1px;
        }

        .outer {
        margin: 1px;
        display: inline-block;
        }</style>



        <div class ="center">
                <div id ="resultsLabel">
                    <asp:Label ID="lblResults" runat="server" Text="Results Pint Here"></asp:Label>
                 </div>  
            

                <div id ="searchButton">
                </div>


               <div id ="searchBox">
                    <asp:TextBox class="outer" ID="txtSearch" runat="server" BorderStyle="Groove" Width="283px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;
                    <asp:Button class="outer" ID="btnSearch" runat="server" OnClick="Button1_Click" Text="Search" BorderStyle="Groove" />
                    <br />
                    <asp:Button class="outer" ID="btnNav" runat="server" OnClick="ButtonNav_Click" Text="Course Page" BorderStyle="Groove" Visible="False" />
                    <br />
                    <br />
                </div>


                <div id ="searchDropdown">
                     <br />
                     <asp:Label ID="lblSearch" runat="server" ForeColor="#CC0000" Text="Please select a search parameter " Visible="False"></asp:Label>
                </div>
            </div>


        

            
        <div id ="adminButton">
        </div>
    </form>
</body>
</html>
