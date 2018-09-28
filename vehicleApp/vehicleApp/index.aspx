<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="vehicleApp.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Name:"></asp:Label>
&nbsp;
        <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
        <br />
    
    </div>
        <asp:Label ID="Label2" runat="server" Text="Reg No."></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="regNoTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="createButton" runat="server" OnClick="createButton_Click" Text="Create" />
        <br />
        <br />
        <asp:Label ID="Label" runat="server" Text="Speed"></asp:Label>
        <asp:TextBox ID="speedTextBox" runat="server"></asp:TextBox>
&nbsp;
        <asp:Label ID="Label5" runat="server" Text="Km/h"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="enterButton" runat="server" OnClick="enterButton_Click" Text="Enter" />
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Max Speed"></asp:Label>
        <asp:TextBox ID="maxSpeedTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Min Speed"></asp:Label>
&nbsp;
        <asp:TextBox ID="minSpeedTextBox" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="showButton" runat="server" OnClick="showButton_Click" Text="Show" />
&nbsp;<p>
            <asp:Label ID="Label7" runat="server" Text="Average Speed"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="averageSpeedTextBox" runat="server"></asp:TextBox>
        </p>
    </form>
</body>
</html>
