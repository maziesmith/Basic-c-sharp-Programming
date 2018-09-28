<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Another.aspx.cs" Inherits="SessionApp.Another" %>

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
                <asp:Button ID="showButton" runat="server" Text="Show" OnClick="showButton_Click" /> 
            </td>
        </tr>
        <tr>

            <td>
                <asp:Label ID="messageLabel" runat="server" ></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="anotherButton" runat="server" Text="Go to Home" OnClick="anotherButton_Click" /> 
            </td>
        </tr>
    </table>
       
    </div>
    </form>
</body>
</html>
