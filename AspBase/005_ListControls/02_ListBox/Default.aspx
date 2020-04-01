<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_02_ListBox.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="DefaultPageForm" runat="server">
        <div>
            <table border="1">
                <tr>
                    <td colspan="3" align="center">Список элементов</td>
                    <td colspan="2" align="center"><asp:Literal runat="server" ID="SubMenuHeader"/></td>
                </tr>
                <tr>
                    <td colspan="3"><asp:ListBox runat="server" ID="ItemsBox" AutoPostBack="true" Width="100%" Height="100%"/></td>
                    <td colspan="2" align="right">
                        <asp:Label runat="server" ID="ElementNameLabel" Text="Имя:" Visible="false"/>
                        <asp:TextBox runat="server" ID="ElementName" Visible="false"/>
                        <br /><br />
                        <asp:Label runat="server" ID="ElementValueLabel" Text="Значение:" Visible="false"/>
                        <asp:TextBox runat="server" ID="ElementValue" Visible="false" />
                        <asp:RequiredFieldValidator 
                            runat="server"
                            ID="NameValidator" 
                            ControlToValidate="ElementName"
                            ErrorMessage="<hr />Поле имени не может быть пустым"
                            ForeColor="Red" 
                            Display="Dynamic" 
                            Visible="false" />
                        <asp:RequiredFieldValidator
                            runat="server"
                            ID="ValueValidator" 
                            ControlToValidate="ElementValue"
                            ErrorMessage="<hr />Поле значения не может быть пустым"
                            ForeColor="Red" 
                            Display="Dynamic" 
                            Visible="false" />
                    </td>
                </tr>
                <tr>
                    <td><asp:Button runat="server" ID="Add" Text="Добавить" OnClick="Add_Click"/></td>
                    <td><asp:Button runat="server" ID="Edit" Text="Изменить" OnClick="Edit_Click"/></td>
                    <td><asp:Button runat="server" ID="Delete" Text="Удалить" OnClick="Delete_Click"/></td>
                    <td><asp:Button runat="server" ID="Cancel" Text="Отмена" OnClick="Cancel_Click" Width="100%" Visible="false"/></td>
                    <td><asp:Button runat="server" ID="Confirm" Text="Принять" OnClick="Confirm_Click" Width="100%" Visible="false"/></td>
                </tr>
            </table>
            <hr />
            Выбранный элемент: <br/>
            Имя:<asp:Literal runat="server" ID="NameLiteral"/><br />
            Значение:<asp:Literal runat="server" ID="ValueLiteral"/><br />
            Индекс:<asp:Literal runat="server" ID="IndexLiteral"/><br />
        </div>
    </form>
</body>
</html>
