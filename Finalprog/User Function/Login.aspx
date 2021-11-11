<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Finalprog.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        
        #form1 {
            position: relative;
            min-height: 100vh;
        }

        #content-wrap {
            padding-bottom: 2.5rem; /* Footer height */
        }

        #footer {
            position: absolute;
            bottom: 0;
            width: 100%;
            height: 2.5rem; /* Footer height */
        }

        .credits {
            position: relative;
            z-index: 9;
            font-size: 130%;
            text-align: center;
            width: 100%;
            padding: 2rem 0;
        }

            .credits a {
                display: inline-block;
                color: #df1888;
                font-family: Arial, sans-serif;
                line-height: 1.5em;
                text-decoration: none !important;
                white-space: nowrap;
                margin: 0 1.2em;
                padding: 0.6em 0;
                transition: 150ms;
            }

                .credits a:hover {
                    color: #2d71b9;
                    cursor: pointer;
                }

        .credits-logo {
            fill: currentColor;
            display: inline-block;
            vertical-align: bottom;
            width: 1.6em;
            height: 1.6em;
            margin: 0 0.5em 0 0;
        }

        @import url('https://fonts.googleapis.com/css?family=Playfair+Display:900');

        svg {
            background: #ebe7e0;
        }

        text {
            fill: #35322a;
            filter: url('#money');
            font-family: 'Playfair Display', 'Georgia', serif;
            font-size: 120px;
            font-weight: 900;
        }

        html {
            align-items: center;
            background: #ebe7e0;
            display: flex;
            justify-content: center;
            min-height: 100vh;
            min-width: 600px;
        }
    </style>
</head>

<body>


    <svg width='900' height='200'>
        <filter id='money'>
            <feMorphology in='SourceGraphic' operator='dilate' radius='2' result='expand' />

            <feOffset in='expand' dx='1' dy='1' result='shadow_1' />
            <feOffset in='expand' dx='2' dy='2' result='shadow_2' />
            <feOffset in='expand' dx='3' dy='3' result='shadow_3' />
            <feOffset in='expand' dx='4' dy='4' result='shadow_4' />
            <feOffset in='expand' dx='5' dy='5' result='shadow_5' />
            <feOffset in='expand' dx='6' dy='6' result='shadow_6' />
            <feOffset in='expand' dx='7' dy='7' result='shadow_7' />

            <feMerge result='shadow'>
                <feMergeNode in='expand' />
                <feMergeNode in='shadow_1' />
                <feMergeNode in='shadow_2' />
                <feMergeNode in='shadow_3' />
                <feMergeNode in='shadow_4' />
                <feMergeNode in='shadow_5' />
                <feMergeNode in='shadow_6' />
                <feMergeNode in='shadow_7' />
            </feMerge>

            <feFlood flood-color='#ebe7e0' />
            <feComposite in2='shadow' operator='in' result='shadow' />

            <feMorphology in='shadow' operator='dilate' radius='1' result='border' />
            <feFlood flood-color='#35322a' result='border_color' />
            <feComposite in2='border' operator='in' result='border' />

            <feOffset in='border' dx='1' dy='1' result='secondShadow_1' />
            <feOffset in='border' dx='2' dy='2' result='secondShadow_2' />
            <feOffset in='border' dx='3' dy='3' result='secondShadow_3' />
            <feOffset in='border' dx='4' dy='4' result='secondShadow_4' />
            <feOffset in='border' dx='5' dy='5' result='secondShadow_5' />
            <feOffset in='border' dx='6' dy='6' result='secondShadow_6' />
            <feOffset in='border' dx='7' dy='7' result='secondShadow_7' />
            <feOffset in='border' dx='8' dy='8' result='secondShadow_8' />
            <feOffset in='border' dx='9' dy='9' result='secondShadow_9' />
            <feOffset in='border' dx='10' dy='10' result='secondShadow_10' />
            <feOffset in='border' dx='11' dy='11' result='secondShadow_11' />

            <feMerge result='secondShadow'>
                <feMergeNode in='border' />
                <feMergeNode in='secondShadow_1' />
                <feMergeNode in='secondShadow_2' />
                <feMergeNode in='secondShadow_3' />
                <feMergeNode in='secondShadow_4' />
                <feMergeNode in='secondShadow_5' />
                <feMergeNode in='secondShadow_6' />
                <feMergeNode in='secondShadow_7' />
                <feMergeNode in='secondShadow_8' />
                <feMergeNode in='secondShadow_9' />
                <feMergeNode in='secondShadow_10' />
                <feMergeNode in='secondShadow_11' />
            </feMerge>

            <feImage x='0' y='0' width='900' height='275' xlink:href='https://s3-us-west-2.amazonaws.com/s.cdpn.io/78779/stripes.svg' />
            <feComposite in2='secondShadow' operator='in' result='secondShadow' />

            <feMerge>
                <feMergeNode in='secondShadow' />
                <feMergeNode in='border' />
                <feMergeNode in='shadow' />
                <feMergeNode in='SourceGraphic' />
            </feMerge>
        </filter>

        <text dominant-baseline='middle' text-anchor='middle' x='50%' y='50%'>
    ΦNSTITUTE
  </text>
    </svg>

    <form id="form1" runat="server">
        <div id="content-wrap" style="text-align: center; font-size: xx-large">
  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:Label ID="Label1" runat="server" ForeColor="Red" Style="font-size: large" Text="Username or Password Incorrect" Visible="False"></asp:Label>
            <br />
            Username:
            <asp:TextBox ID="txtuser" runat="server" Height="20px" OnTextChanged="TextBox1_TextChanged" Width="160px"></asp:TextBox>
            <br />
            <br />
            Password:
            <asp:TextBox ID="txtpass" runat="server" Height="20px" OnTextChanged="TextBox1_TextChanged" Width="160px"></asp:TextBox>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="hyperForgot" runat="server" Style="font-size: small" NavigateUrl="~/User Function/ForgotPassword.aspx">Forgot Password?</asp:HyperLink>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnLogin" runat="server" Height="32px" OnClick="btnLogin_Click" Text="Log In" Width="91px" />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCreate" runat="server" Height="32px" OnClick="btnCreate_Click" Text="Create Account" Width="106px" />
        </div>
        <footer id="footer" style="height: 113px;">
            <div class="credits">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <a class="other-pens" href="AboutUs.aspx" target="_blank" rel="external noopener" style="color: #000000">
                    <svg class="credits-logo codepen-logo" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 256 256" width="0" height="0">
                        <path d="M255.8 87.1c-.05-.32-.1-.63-.2-.94-.04-.18-.1-.35-.16-.53-.08-.27-.17-.54-.28-.8l-.25-.54c-.1-.3-.2-.5-.3-.8l-.3-.5-.4-.7-.4-.5-.5-.6-.4-.5-.6-.5-.5-.4c-.03-.1-.1-.1-.2-.2l-117-78c-3.7-2.5-8.5-2.5-12.2 0L5 79.7c-.06.04-.1.1-.17.13l-.5.36-.63.5-.48.4c-.2.2-.4.4-.55.6l-.37.5-.45.6-.32.5c-.14.26-.26.5-.37.75l-.25.52c-.1.23-.2.5-.2.8l-.2.6c-.1.3-.15.6-.2.9l-.1.47c-.1.5-.1.95-.1 1.44v78c0 .5 0 1 .1 1.46l.1.48c.07.3.1.62.2.93l.2.5c.08.3.17.6.27.8l.25.53.4.73.3.5c.1.23.3.44.5.65l.3.46c.2.2.3.4.5.6.2.15.3.3.5.4l.6.55.5.4.15.18 116.95 78c1.84 1.25 3.95 1.87 6.1 1.86 2.13 0 4.24-.63 6.1-1.86l117-78c.1-.05.1-.1.2-.15l.5-.37.6-.5c.15-.1.3-.27.44-.4.2-.2.4-.4.57-.6.16-.17.3-.3.4-.5.18-.2.34-.4.48-.65l.3-.5.36-.76c.1-.14.14-.3.22-.5l.3-.8.15-.53c.1-.3.12-.6.2-.9 0-.2.05-.34.1-.5.04-.5.1-.95.1-1.44V89c0-.5-.07-.96-.1-1.44 0-.17-.1-.3-.1-.47zM128 154l-38.9-26 38.9-26.02L166.9 128 128 154.02zm-11-71.15l-47.7 31.9L30.8 89 117 31.57v51.3zM49.52 128l-27.5 18.4v-36.8L49.5 128zm19.8 13.24l47.68 31.9v51.3L30.8 167l38.5-25.74zm69.68 31.9l47.7-31.9 38.5 25.74-86.2 57.46v-51.3zM206.47 128L234 109.6v36.8L206.46 128zm-19.78-13.23L139 82.87v-51.3L225.2 89l-38.5 25.77z" />
                    </svg>About Us</a>
            </div>
        </footer>
    </form>
</body>
</html>
