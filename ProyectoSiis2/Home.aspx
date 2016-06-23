<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="ProyectoSiis2.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoBanner" runat="server">
    <link href="../bootstrap.min.css" rel="stylesheet">



    <nav>
        <ul class="nav nav-justified">
            <li class="active"><a href="Home.aspx">Inicio</a></li>
            <li><a href="IngresoELemento.aspx">Ingreso Elemento</a></li>
            <li><a href="PrestamoElemento.aspx">Prestamo</a></li>
            <li><a href="#">Devolución</a></li>
            <li><a href="ReservaElemento.aspx">Reservas</a></li>
            <li><a href="InventarioElemento.aspx">Inventarios</a></li>
        </ul>
    </nav>

</asp:Content>

<%--pre--%>

<asp:Content ID="Content3" ContentPlaceHolderID="ContenidoCuerpo" runat="server">

    <img class="Imagenblog" src="Imagenes/blogCeet.jpg" />

</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ContenidoPie" runat="server">
    <footer class="footer">
        <link href="App_Themes/Tema1/sticky-footer-navbar.css" rel="stylesheet" />
        <div class="container">
            <p class="text-muted">Sena  ©2016  ADSI Ficha 908163  Instructor Jesus Rubio </p>
        </div>
    </footer>




</asp:Content>

