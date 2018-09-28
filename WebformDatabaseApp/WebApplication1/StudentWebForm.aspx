<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentWebForm.aspx.cs" Inherits="WebformDatabaseApp.StudentWebForm" %>

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
               <asp:Label runat="server" Text="Name"></asp:Label>

                </td>
                
               <td>
             <asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox>
               </td>
              
                
            </tr>
            <tr>
                <td>
               <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>

                </td>
                
               <td>
             <asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox>
               </td>
              
                
            </tr>


            <tr>
                <td>
               <asp:Label ID="Label2" runat="server" Text="Phone"></asp:Label>

                </td>
                
               <td>
             <asp:TextBox ID="PhoneTextBox" runat="server"></asp:TextBox>
               </td>
              
                
            </tr>
            

            <tr>
                <td>

     <asp:Button ID="Button1" runat="server" Text="Save" OnClick="Save_Click" />

                </td>
                   
            </tr>



        </table>
           
    
        

    </div>
    </form>
</body>
</html>
