<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication2.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Email:"></asp:Label><br />
        <asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage=" *" ControlToValidate="EmailTextBox"></asp:RequiredFieldValidator>
       <br />

         <asp:Label ID="Label2" runat="server" Text="Password:"></asp:Label><br />
        <asp:TextBox type="password" ID="PasswordTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage=" *" ControlToValidate="PasswordTextBox"></asp:RequiredFieldValidator>
       <br />

        <asp:Label ID="Label3" runat="server" Text="First name:"></asp:Label><br />
        <asp:TextBox ID="FnameTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage=" *" ControlToValidate="FnameTextBox"></asp:RequiredFieldValidator>
       <br />

        <asp:Label ID="Label4" runat="server" Text="Last name:"></asp:Label><br />
        <asp:TextBox ID="LnameTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage=" *" ControlToValidate="LnameTextBox"></asp:RequiredFieldValidator>
       <br />
        
        <asp:Label ID="Label5" runat="server" Text="Role:"></asp:Label><br />
        <asp:DropDownList ID="DropDownListRole" runat="server"></asp:DropDownList>
        <asp:HyperLink ID="HyperLink1" NavigateUrl="~/RoleManager.aspx"  runat="server">Create/edit role</asp:HyperLink>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage=" *" ControlToValidate="DropDownListRole"></asp:RequiredFieldValidator>
        
        <br />
        <br />
        <asp:Button ID="Submit" runat="server" Text="Register" OnClick="Submit_Click" />
    </div>
        <br />
        <asp:HyperLink ID="HyperLink2" NavigateUrl="~/UsersList.aspx" runat="server">Users list</asp:HyperLink>
    </form>
</body>
</html>
