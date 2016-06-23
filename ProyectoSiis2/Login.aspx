<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProyectoSiis2.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoBanner" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContenidoCuerpo" runat="server">
 <img id="inventario" src="imagenes/inventario.jpg" />
    
    <div id="Busuario">Usuario
        <form id="textoUsuario">
            <asp:TextBox ID="Usuario" runat="server"></asp:TextBox>
           </form>
    </div>
    <div id="Bcontrasena">Contraseña
         <form id="textoUsuario">
             <asp:TextBox ID="Contraseña" runat="server" TextMode="Password"></asp:TextBox>
         </form>
    </div>

    <asp:Button ID="IniciarSesion" runat="server" Text="Iniciar Sesion" />


</asp:Content>
