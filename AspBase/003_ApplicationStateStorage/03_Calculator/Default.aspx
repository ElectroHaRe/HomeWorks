<%@ Page Language="C#" AutoEventWireup="false" CodeBehind="Default.aspx.cs" Inherits="_03_Calculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="DefaultPage" runat="server">
        <div>
            <table border="1">
                <tr>
                    <td colspan="4"><asp:TextBox runat="server" ID="ResultLabel" ReadOnly="true" TextMode="MultiLine" /></td>
                </tr>
                <tr>
                    <td colspan="4"><asp:TextBox runat="server" ID="OutputLabel" ReadOnly="true" TextMode="MultiLine" /></td>
                </tr>
                <tr>
                    <td><asp:Button runat="server" ID="One" Text="1" OnClick="Number_Click" width="100%"/></td>
                    <td><asp:Button runat="server" ID="Two" Text="2" OnClick="Number_Click" width="100%" /></td>
                    <td><asp:Button runat="server" ID="Three" Text="3" OnClick="Number_Click" width="100%" /></td>
                    <td><asp:Button runat="server" ID="Plus" Text="+" OnClick="Sign_Click" Width="100%" /></td>
                </tr>
                <tr>
                    <td><asp:Button runat="server" ID="Four" Text="4" OnClick="Number_Click" width="100%" /></td>
                    <td><asp:Button runat="server" ID="Five" Text="5" OnClick="Number_Click" width="100%" /></td>
                    <td><asp:Button runat="server" ID="Six" Text="6" OnClick="Number_Click" width="100%" /></td>
                    <td><asp:Button runat="server" ID="Minus" Text="-" OnClick="Sign_Click" Width="100%" /></td>
                </tr>
                <tr>
                    <td><asp:Button runat="server" ID="Seven" Text="7" OnClick="Number_Click" width="100%" /></td>
                    <td><asp:Button runat="server" ID="Eight" Text="8" OnClick="Number_Click" width="100%" /></td>
                    <td><asp:Button runat="server" ID="Nine" Text="9" OnClick="Number_Click" width="100%" /></td>
                    <td><asp:Button runat="server" ID="Multiple" Text="×" OnClick="Sign_Click" Width="100%" /></td>
                </tr>
                <tr>
                    <td><asp:Button runat="server" ID="ClearAll" OnClick="ClearAll_Click" Text="C" Width="100%" /></td>
                    <td><asp:Button runat="server" ID="Zero" Text="0" OnClick="Number_Click" width="100%" /></td>
                    <td><asp:Button runat="server" ID="ClearLast" Text="<-" OnClick="ClearLast_Click" Width="100%" /></td>
                    <td><asp:Button runat="server" ID="Divide" Text="÷" OnClick="Sign_Click" Width="100%" /></td>
                </tr>
                <tr>
                    <td colspan="3"><asp:Button runat="server" ID="Result" OnClick="Result_Click" Text="=" Width="100%" /></td>
                    <td><asp:Button runat="server" ID="Separator" OnClick="Separator_Click" Text="," Width="100%" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
