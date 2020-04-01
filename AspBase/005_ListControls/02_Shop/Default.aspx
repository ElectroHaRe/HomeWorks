<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_02_Shop.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .ListBox
        {
            height:200px;
            width:100%;
        }
        .td1 { width:45%; }
        .bt { width:100%; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table border="1">
                <tr>
                    <td class="td1"><asp:ListBox runat="server" ID="Shop" SelectionMode="Multiple" CssClass="ListBox" /></td>
                    <td >
                    <asp:Button runat="server" ID="MoveToBasket" Text="-->>" OnClick="MoveToBasket_Click"/>
                    <hr />
                    <asp:Button runat="server" ID="MoveToShop" Text="<<--" OnClick="MoveToShop_Click"/>
                    </td>
                    <td class="td1"><asp:ListBox runat="server" ID="Basket" SelectionMode="Multiple" CssClass="ListBox"/></td>
                </tr>
                <tr>
                    <td><asp:Button runat="server" ID="AllToBasket" Text="Всё в корзину" OnClick="AllToBasket_Click" CssClass="bt"/></td>
                    <td/>
                    <td><asp:Button runat="server" ID="AllToShop" Text="Очистить корзину" OnClick="AllToShop_Click" CssClass="bt"/></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
