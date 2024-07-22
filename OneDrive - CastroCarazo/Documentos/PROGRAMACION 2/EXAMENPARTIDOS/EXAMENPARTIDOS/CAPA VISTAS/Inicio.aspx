<%@ Page Title="" Language="C#" MasterPageFile="~/CAPA VISTAS/Site1.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="EXAMENPARTIDOS.CAPA_VISTAS.Inicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Candidatos</h1>
    <asp:Label ID="lmensaje" runat="server" Text="Label"></asp:Label>
    <br />
    &nbsp;&nbsp;
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    
    <br />
    ID
    <asp:TextBox ID="TID" runat="server"></asp:TextBox>
    <br />
    NOMBRE COMPLETO
    <asp:TextBox ID="TNOMBRECOMPLETO" runat="server"></asp:TextBox>
    <br />
    NOMBRE PARTIDO
    <asp:TextBox ID="TNOMBREPARTIDO" runat="server"></asp:TextBox>
    <br />
 
    
    <asp:Button ID="BAGREGAR" runat="server" Text="AGREGAR" OnClick="BAGREGAR_Click" />
    <br />
    <asp:Button ID="BELIMINAR" runat="server" Text="BORRAR" OnClick="BELIMINAR_Click" />
</asp:Content>
