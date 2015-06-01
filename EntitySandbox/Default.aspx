<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EntitySandbox.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
</head>
<body>
	<form id="form1" runat="server">
	<div>
		<asp:TextBox ID="tbPersons" runat="server" TextMode="MultiLine" Height="200" Width="400"></asp:TextBox>
		<hr />
		
		<asp:TextBox ID="tbFirstName" runat="server"></asp:TextBox>
		<asp:TextBox ID="tbLastName" runat="server"></asp:TextBox>
		<asp:TextBox ID="tbHobby" runat="server"></asp:TextBox>
		<asp:Button ID="btnAddPerson" runat="server" Text="Add Person" OnClick="btnAddPerson_Click" />	
	</div>
	</form>
</body>
</html>
