<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="EXAMENPARTIDOS.CAPA_VISTAS.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../CSS/Login.css" rel="stylesheet" />
</head>
<body>
  <div class="background">
    <div class="shape"></div>
    <div class="shape"></div>
  </div>
  <form id="form1" runat="server">
    <h3>Login Here</h3>

    <label for="username">Username</label>
      <asp:TextBox ID="Tusuario" runat="server"></asp:TextBox>
    <label for="password">Password</label>
      <asp:TextBox ID="Tclave" type="Password" runat="server"></asp:TextBox>
      <asp:Button ID="Bingresar" class="button" runat="server" Text="Ingresar" OnClick="Bingresar_Click" />
      <asp:Label ID="lmensaje" runat="server" ForeColor="Red"></asp:Label>
  </form>
</body>
</html>
