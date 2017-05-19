<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProyectoSiis2.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoBanner" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContenidoCuerpo" runat="server">
    <img id="inventario" src="imagenes/inventario.jpg" />

    <div id="Busuario">
        Usuario
        
           

        <asp:TextBox ID="TxtUsuario" runat="server"></asp:TextBox>

    </div>
    <div id="Bcontrasena">
        Contraseña
        
            

        <asp:TextBox ID="TxtPassword" runat="server" TextMode="Password"></asp:TextBox>

    </div>

    <asp:Button ID="IniciarSesion" runat="server" Text="Iniciar Sesion" OnClick="IniciarSesion_Click" />


</asp:Content>
