<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="SessionApp.WebForm1" %>

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
              <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>  

          </td>
          <td>
              <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
          </td>
      </tr>
        
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>  

            </td>
            <td>
                <asp:TextBox ID="emailTextBox" runat="server" style="margin-left: 0px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Phone"></asp:Label>  

            </td>
            <td>
                <asp:TextBox ID="PhoneTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
       <tr>
           <td>
               <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" />  
           </td>
       </tr>
        <tr>
            <td>
                <asp:Button ID="HomeButton" runat="server" Text="Go to another Page" OnClick="HomeButton_Click" />  
            </td>
        </tr>

    </table>
    </div>
    </form>
</body>
</html>
