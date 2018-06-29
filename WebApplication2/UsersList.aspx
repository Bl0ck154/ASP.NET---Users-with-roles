<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UsersList.aspx.cs" Inherits="WebApplication2.UsersList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Users list</h1>
            <asp:CheckBoxList ID="CheckBoxList1" AutoPostBack="true" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged" runat="server"> </asp:CheckBoxList>
            <asp:Button ID="RemoveButton" runat="server" Text="Remove" OnClick="RemoveButton_Click" Enabled="false" />
			
        </div>
        <br />
        <asp:HyperLink ID="HyperLink1" NavigateUrl="~/Default.aspx" runat="server">Create user</asp:HyperLink>
    </form>
</body>
</html>
