<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="MethodInWebApp.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Basic Amount"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="basicAmountTextBox" runat="server"></asp:TextBox>
        <br />
    
    </div>
        <asp:Label ID="Label2" runat="server" Text="House Rent"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="houserentPercentageTextBox" runat="server"></asp:TextBox>
&nbsp;<asp:Label ID="Label5" runat="server" Text="% of BasicAmount"></asp:Label>
&nbsp;<p>
            <asp:Label ID="Label3" runat="server" Text="Medical ALowance"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="medicalAllowanceTextBox" runat="server"></asp:TextBox>
            <asp:Label ID="Label6" runat="server" Text="% of BasicAmount"></asp:Label>
        </p>
        <asp:Button ID="saveButton" runat="server" OnClick="saveButton_Click" Text="Save" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="showButtonTextBox" runat="server" OnClick="showButtonTextBox_Click" Text="Show Button" />
        <p>
            <asp:Label ID="totalAmountlevel" runat="server" Text="Total amount"></asp:Label>
        </p>
    </form>
</body>
</html>
