<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="ListInViewStateApp.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="saveButton" runat="server" OnClick="saveButton_Click" Text="Save" />
&nbsp;</p>
        <p>
            <asp:Button ID="showButton" runat="server" OnClick="showButton_Click" Text="Show ALl Name" />
        </p>
        <p>
            <asp:Label runat="server" Text="Total Student"></asp:Label>
            <asp:TextBox ID="studentTextBox" runat="server"></asp:TextBox>
        </p>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ListBox ID="studentListBox" runat="server" Height="166px" style="margin-bottom: 55px" Width="153px"></asp:ListBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </form>
</body>
</html>
