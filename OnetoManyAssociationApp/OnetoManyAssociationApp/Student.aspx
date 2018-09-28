<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="OnetoManyAssociationApp.Student" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h3>
        Student Info
    </h3>
        <table>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>   
                </td>
                <td>
                    <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>   
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="RegNo"></asp:Label>   
                </td>
                <td>
                    <asp:TextBox ID="regTextBox" runat="server"></asp:TextBox>   
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label>   
                </td>
                <td>
                    <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox>   
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="saveButton" runat="server" Text="Save" />   
                </td>

            </tr>
            <tr>
                <td>
                    <asp:Button ID="showButton" runat="server" Text="Show All Studentets in One Department" />   
                </td>

            </tr>
            <tr>
                <td>
                    <asp:Label ID="messageLabe" runat="server" Text=""></asp:Label>    
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
