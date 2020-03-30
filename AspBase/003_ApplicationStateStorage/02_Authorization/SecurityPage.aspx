<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SecurityPage.aspx.cs" Inherits="_02_Authorization.SecurityPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="Security" runat="server">
        <div>
            <h1>Добро пожаловать '<asp:Label runat="server" ID="UserName" />'</h1>
            <hr />
            <table>
                <tr>
                    <td><a href="Default.aspx">Главная страница</a></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
