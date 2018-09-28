<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentEntry.aspx.cs" Inherits="UniversityWebbAPP.Ui.StudentEntry" %>

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
                        <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox>  
                    </td>

                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Phone"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="phoneTextBox" runat="server"></asp:TextBox>  
                    </td>

                </tr>
           
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
                        <asp:Label ID="Label5" runat="server" Text="Department"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="departmentDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="departmentDropDownList_SelectedIndexChanged"></asp:DropDownList> 
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        
                        <asp:Label ID="departmentLabel" runat="server" ></asp:Label>
                    </td>
                </tr>


                <tr>
                    <td>
                        <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" /> 
                    </td>
               
                    <td>
                        <asp:Button ID="ShowButton" runat="server" Text="Show" OnClick="ShowButton_Click" /> 
                    </td>

               

                </tr>
           
           
            </table>

 
        
        

        </div>
        <asp:Label ID="messageLabel" runat="server"></asp:Label>
   
    </form>

</body>
</html>
