<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RoleManager.aspx.cs" Inherits="WebApplication2.RoleManager" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="ListBox1" AutoPostBack="true" SelectionMode="Multiple" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" runat="server"></asp:ListBox>
            <br />
            <asp:Button ID="EditButton" runat="server" OnClick="EditButton_Click" Enabled="false" Text="Edit" />
            <asp:Button ID="RemoveButton" OnClick="RemoveButton_Click" runat="server" Enabled="false" Text="Remove" />
            <br />
            <br />
            New role name:<br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="CreateButton" runat="server" OnClick="CreateButton_Click" Text="Create" />
        </div>
        <br />
        <asp:HyperLink ID="HyperLink1" NavigateUrl="~/Default.aspx" runat="server">Back to main page</asp:HyperLink>
    </form>
</body>
</html>
