<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AuthorizationPage.aspx.cs" Inherits="_02_Authorization.AuthorizationPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="Authorization" runat="server">
        <div>
            <table>
                <tr>
                    <td>Логин</td><td><asp:TextBox runat="server" ID="Login"/></td>
                </tr>
                <tr>
                    <td>Пароль</td><td><asp:TextBox runat="server" ID="Password" TextMode="Password" /></td>
                </tr>
                <tr>
                    <td colspan="2"><asp:Button runat="server" ID="SignIn" Text="Войти" OnClick="SignIn_Click"/></td>
                </tr>
                <tr>
                    <td colspan="3"><asp:Label runat="server" ID="ErrorLabel" Text="Логин или пароль не верны" ForeColor="Red" Visible="false"/></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
