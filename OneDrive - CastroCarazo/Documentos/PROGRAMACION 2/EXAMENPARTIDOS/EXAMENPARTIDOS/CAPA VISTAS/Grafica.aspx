<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Grafica.aspx.cs" Inherits="EXAMENPARTIDOS.CAPA_VISTAS.Grafica" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Gráfica</title>
    <link rel="stylesheet" type="text/css" href="Content/Site.css" />
    <script src="https://cdn.jsdelivr.net/npm/@ionic/core@5.0.0/dist/ionic.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="content">
            <h1>Gráfica de Votos</h1>
            <asp:Chart ID="Chart1" runat="server">
                
            </asp:Chart>
        </div>
    </form>
</body>
</html>
