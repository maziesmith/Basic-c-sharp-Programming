<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentSearch.aspx.cs" Inherits="UniversityWebbAPP.Ui.StudentSearch" %>

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
            <asp:Button ID="searchButton" runat="server" Text="Search" OnClick="SearchButton_Click" /> 
        </td>
               </tr>
        <tr>
            <td>
                <asp:Label ID="Label" runat="server" Text="Name"></asp:Label>   
            </td>
            <td>
                <asp:Label ID="nameLabel" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>   
            </td>
            <td>
                <asp:Label ID="emailLabel" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Phone"></asp:Label>   
            </td>
            <td>
                <asp:Label ID="phoneLabel" runat="server" Text=""></asp:Label>
            </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
