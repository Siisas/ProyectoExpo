<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="LoginSiis.aspx.cs" Inherits="ProyectoSiis2.LoginSiis" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoBanner" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContenidoCuerpo" runat="server">
    <body>
    <div class ="form-box" id="login-box">
        <div class="header">Ingreso Inventario </div>
        <div id="form1" runat="server">
          <div class="body bg-gray ">
              <div class="form-group">
                   <asp:TextBox ID="txtUsuario" runat="server" CssClass="form-control" placeholder="Ingrese Usuario"></asp:TextBox>
              </div>
              <div class ="form-group">
                   <asp:TextBox ID="txtContraseña" runat="server" CssClass="form-control" placeholder="Contraseña"></asp:TextBox>
              </div>

                  <%--<asp:Button ID="btnIngreso" CssClass="btn bg-olive btn-block" runat="server" Text="Iniciar Sesión" OnClick="btnIngreso_Click" />--%>
                 <asp:Button ID="btnIngreso" Style="background-color: #5eb319; color: white; border-radius: 10px 10px; margin-top: 15%; margin-left: 65%;" runat="server" Text="Guardar" OnClick="btnIngreso_Click" />
              <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ProyectoSiisConnectionString %>" SelectCommand="SELECT * FROM [__MigrationHistory]">
              </asp:SqlDataSource>

          </div>
          <div class="footer">
          
          </div>
      </div>  

    <p>
            <asp:Label ID="error" runat="server"></asp:Label>
        </p>
   
      </div>
</body>



</asp:Content>
