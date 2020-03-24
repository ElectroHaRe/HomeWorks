<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_01_Sum.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server" Text="Введите целые числа:" />
            <br />
            <br />
            <asp:TextBox runat="server" ID="firstSummand" TextMode="Number" />
            + 
            <asp:TextBox runat="server" ID="secondSummand" TextMode="Number"/>
            =
            <asp:Label runat="server" ID="result" />
            <br />
            <br />
            <asp:Button runat="server" ID="calculate" Text="Вычислить" OnClick="Calculate_Click"/>
        </div>
    </form>
</body>
</html>
