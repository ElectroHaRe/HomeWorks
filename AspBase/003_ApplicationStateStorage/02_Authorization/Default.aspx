<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_02_Authorization.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="Default" runat="server">
        <div>
            <table>
                <tr>
                    <td colspan="3"><a href="SecurityPage.aspx">Страница, открытая для зарегистрированных пользователей</a></td>
                </tr>
                <tr>
                    <td><asp:LinkButton runat="server" ID="SignOut" Text="Выйти" PostBackUrl="AuthorizationPage.aspx?command=signOut" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
