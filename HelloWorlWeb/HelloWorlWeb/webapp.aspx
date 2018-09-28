<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="webapp.aspx.cs" Inherits="HelloWorlWeb.webapp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:TextBox ID="nameTextBox" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <p>
            <asp:Button ID="ShowButton" runat="server" Height="34px" OnClick="ShowButton_Click" style="margin-bottom: 12px" Text="Show" Width="52px" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
