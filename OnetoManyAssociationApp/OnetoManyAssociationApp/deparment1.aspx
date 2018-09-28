<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="deparment1.aspx.cs" Inherits="OnetoManyAssociationApp.Department" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h3>Department Info</h3>
        <table>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Code"></asp:Label>   
                </td>
                <td>
                    <asp:TextBox ID="codeTextBox" runat="server"></asp:TextBox>   
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>   
                </td>
                <td>
                    <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>   
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="saveDepartmentButton" runat="server" Text="Save Department" />       
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="goButton" runat="server" Text="go To Student page" OnClick="goButton_Click" />       
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
