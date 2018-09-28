<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentDelete.aspx.cs" Inherits="UniversityWebbAPP.Ui.StudentDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Reg.No"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="regTextBox" runat="server"></asp:TextBox>
                     
            </td>

        </tr>
             
            <tr>
                <td>
                    <asp:Button ID="DeleteButton" runat="server" Text="Delete" OnClick="DeleteButton_Click" /> 
                </td>
               
                <td>
                    <asp:Button ID="ShowButton" runat="server" Text="Show" OnClick="ShowButton_Click" /> 
                </td>

               

            </tr>
           
           
        </table>

    </div>
        <asp:Label ID="messageLabel" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
