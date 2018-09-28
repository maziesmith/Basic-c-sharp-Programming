<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="total prize.aspx.cs" Inherits="ItemPrizeAPp.total_prize" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label runat="server" Text="Number of Item"></asp:Label>
        <asp:TextBox ID="numberTextBox" runat="server"></asp:TextBox>
    
    </div>
        <asp:Label ID="Label2" runat="server" Text="unit prize"></asp:Label>
        <asp:TextBox ID="unitTextBox" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="saveButton" runat="server" OnClick="saveButton_Click" Text="Save" />
&nbsp;&nbsp;
            <asp:Button ID="showPrize" runat="server" OnClick="showPrize_Click" Text="ShowTotalPRize" />
        </p>
        <asp:Label ID="Label3" runat="server" Text="show total prize"></asp:Label>
    </form>
</body>
</html>
