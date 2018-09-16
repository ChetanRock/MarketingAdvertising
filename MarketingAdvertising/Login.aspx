<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MarketingAdvertising.Login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Welcome to Marketing Advertising</title>
    <script src="Scripts/jquery-1.10.2.js"></script>

    <script type="text/javascript">
        function ValidateFields() {
            if (validateEmail()) {
                if ($('[id*=lastname]')[0].value == "" || $('[id*=firstname]')[0].value == "" || $('[id*=txtemail]')[0].value == "" || $('[id*=txtemail]')[0].value == "") {
                    alert("Enter all fields");
                    return false;
                }
                return true;
            }
            else { return false; }
        }

        function validateEmail() {
            var email = $('[id*=txtemail]')[0].value;
            var re = /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
            if (!re.test(email)) {
                alert('Enter valid email address.');
                return false;
            }
            else { return true; }
        }

    </script>


    <style type="text/css">
        body {
            background-color: #f4f4f4;
            color: #5a5656;
            font-family: 'Open Sans', Arial, Helvetica, sans-serif;
            font-size: 14px;
            line-height: 1.5em;
            height: 100%;
        }

        a {
            text-decoration: none;
        }

        h1 {
            font-size: 1em;
        }

        h1, p {
            margin-bottom: 10px;
        }

        strong {
            font-weight: bold;
        }

        .uppercase {
            text-transform: uppercase;
        }

        /* ---------- LOGIN ---------- */
        #login {
            /*margin: 50px auto;*/
            width: auto;
            float: right;
        }

        form div input[type="text"], input[type="password"] {
            background-color: #e5e5e5;
            border: none;
            border-radius: 3px;
            -moz-border-radius: 3px;
            -webkit-border-radius: 3px;
            color: #5a5656;
            font-family: 'Open Sans', Arial, Helvetica, sans-serif;
            font-size: 14px;
            height: 50px;
            outline: none;
            padding: 0px 10px;
            width: 280px;
            -webkit-appearance: none;
        }

        form div input[type="submit"] {
            background-color: #008dde;
            border: none;
            border-radius: 3px;
            -moz-border-radius: 3px;
            -webkit-border-radius: 3px;
            color: #f4f4f4;
            cursor: pointer;
            font-family: 'Open Sans', Arial, Helvetica, sans-serif;
            height: 50px;
            text-transform: uppercase;
            width: 300px;
            -webkit-appearance: none;
        }

        form div select option {
            font-family: 'Open Sans', Arial, Helvetica, sans-serif;
            font-size: 14px;
        }

        form div h1 {
            font-family: 'Open Sans', Arial, Helvetica, sans-serif;
            font-size: 14px;
        }

        form div a {
            color: #5a5656;
            font-size: 10px;
        }

            form div a:hover {
                text-decoration: underline;
            }


        .errorMessage {
            font-size: 12px;
            color: red;
        }

        #footer .push {
            clear: both;
            position: relative;
            z-index: 10;
            height: 4em;
            margin-top: -4em;
        }
    </style>
</head>
<body>

    <form id="form1" runat="server">
        <div id="login">
            <asp:Label ID="lblError" CssClass="errorMessage" runat="server" Visible="false"></asp:Label>
            <p>
                <input type="text" id="txtEmailId" runat="server" placeholder="Email ID">
            </p>
            <p>
                <input type="password" id="txtPassword" runat="server" placeholder="Password">
            </p>
            <p>
                <asp:Button ID="btnLogin" CssClass="button" OnClick="btnLogin_Click" runat="server"
                    Text="Login" />
            </p>
        </div>
        <div id="registration" style="float: left">
            <asp:Label ID="lblErrorRegister" CssClass="errorMessage" runat="server" Visible="false"></asp:Label>

            <table>
                <tr>
                    <td>
                        <input id="firstname" name="firstname" class="textbox" placeholder="First Name" type="text"
                            value="" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <input id="lastname" name="lastname" class="textbox" placeholder="Last Name" type="text"
                            value="" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <input id="txtemail" placeholder="email@email.com" class="textbox" name="email" value=""
                            runat="server" onblur="return validateEmail();" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <input id="password" type="password" placeholder="Password" class="textbox" value=""
                            runat="server" />
                    </td>
                </tr>


                <tr>

                    <td>
                        <asp:Button ID="btnRegister" OnClientClick="return ValidateFields()" OnClick="btnRegister_Click" CssClass="button" runat="server"
                            Text="Register" />
                    </td>
                </tr>
            </table>
        </div>



    </form>

</body>
</html>
