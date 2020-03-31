<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_02_Themes.Default" Theme="Dark" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="DefaultPageForm" runat="server">
        <asp:Panel runat="server">
            <div>
                <table>
                    <tr>
                        <td><asp:Label runat="server" Text="Login" /></td>
                        <td><asp:TextBox runat="server" ID="Login" /></td>
                    </tr>
                    <tr>
                        <td><asp:Label runat="server" Text="Password" /></td>
                        <td><asp:TextBox runat="server" ID="Password" /></td>
                    </tr>
                    <tr>
                        <td><asp:Button runat="server" ID="SignIn" Text="Sign in" /></td>
                    </tr>
                    <tr></tr>
                    <tr>
                        <td><asp:DropDownList runat="server" ID="Themes" AutoPostBack="true" /></td>
                    </tr>
                </table>
            </div>
        </asp:Panel>
    </form>
</body>
</html>
