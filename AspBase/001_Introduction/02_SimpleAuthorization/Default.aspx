<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_02_SimpleAuthorization.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Authorization page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Login</td>
                    <td><asp:TextBox runat="server" ID="login" /></td>
                </tr>
                <tr>
                    <td>Password</td>
                    <td><asp:TextBox runat="server" ID="password" TextMode="Password" EnableViewState="false"/></td>
                </tr>
                <tr>
                    <td><asp:Button runat="server" ID="signIn" Text="Sign in" OnClick="SignIn_Click"/></td>
                    <td>
                        <asp:Label runat="server" ID="errorLabel" Text="Login or password is incorrect" ForeColor="Red" Visible="false"/>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
