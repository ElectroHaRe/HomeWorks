<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_01_TableGenerator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="DefaultPage" runat="server">
        <div>
            <table>
                <tr>
                    <td>Row count</td>
                    <td><asp:TextBox runat="server" ID="RowCount" TextMode="Number" /></td>
                    <td><asp:RangeValidator runat="server" MinimumValue="1" MaximumValue="1000000" Type="Integer" 
                        ControlToValidate="RowCount" ErrorMessage="Укажите количество строк большее 0" ForeColor="Red"/></td>
                </tr>
                <tr>
                    <td>Column count</td>
                    <td><asp:TextBox runat="server" ID="ColumnCount" TextMode="Number" /></td>
                    <td><asp:RangeValidator runat="server" MinimumValue="1" MaximumValue="1000000" Type="Integer"
                        ControlToValidate="ColumnCount" ErrorMessage="Укажите количество столбцов большее 0" ForeColor="Red"/></td>
                </tr>
                <tr>
                    <td><asp:Button runat="server" Text="Generate table" ID="Generate" OnClick="Generate_Click"/></td>
                </tr>
            </table>
            <asp:PlaceHolder runat="server" ID="TablePlaceHolder" />
        </div>
    </form>
</body>
</html>
