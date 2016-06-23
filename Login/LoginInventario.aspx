<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="LoginInventario.aspx.cs" Inherits="ProyectoSiis2.LoginInventario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoBanner" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContenidoCuerpo" runat="server">
   
<body class="bg-black">

    
    <div class ="form-box" id="login-box">
        <div class="header">Ingreso Inventario </div>
        <form id="form1" runat="server">
          <div class="body bg-gray ">
              <div class="form-group">
                   <asp:TextBox ID="txtUsuario" runat="server" CssClass="form-control" placeholder="Ingrese Usuario"></asp:TextBox>
              </div>
              <div class ="form-group">
                   <asp:TextBox ID="txtContraseña" runat="server" CssClass="form-control" placeholder="Contraseña"></asp:TextBox>
              </div>
          </div>
          <div class="footer">
              <asp:Button ID="btnIngreso" CssClass="btn bg-olive btn-block" runat="server" Text="Iniciar Sesión" OnClick="btnIngreso_Click" />
              <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:WebFormsIdentityConnectionString %>" SelectCommand="ValidarUsuario" SelectCommandType="StoredProcedure">
                  <SelectParameters>
                      <asp:ControlParameter ControlID="txtUsuario" Name="usuario" PropertyName="Text" Type="String" />
                      <asp:ControlParameter ControlID="txtContraseña" Name="Contraseña" PropertyName="Text" Type="String" />
                  </SelectParameters>
              </asp:SqlDataSource>
          </div>
      </div>  
    <p>
            <asp:Label ID="error" runat="server"></asp:Label>
        </p>
   </form>
      </div>
    </body>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContenidoPie" runat="server">

      <footer class="footer">
        <link href="App_Themes/Tema1/sticky-footer-navbar.css" rel="stylesheet" />
        <div class="container">
            <p class="text-muted">Sena  ©2016  ADSI Ficha 908163  Instructor Jesus Rubio </p>
        </div>
    </footer>

</asp:Content>
