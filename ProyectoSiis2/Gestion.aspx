<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Gestion.aspx.cs" Inherits="ProyectoSiis2.DevolucionElemento" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoBanner" runat="server">
    <link href="../bootstrap.min.css" rel="stylesheet">



    <nav>
        <ul class="nav nav-justified">
            <li><a href="Home.aspx">Inicio</a></li>
            <li ><a href="IngresoELemento.aspx">Ingreso Elemento</a></li>
            <li><a href="PrestamoElemento.aspx">Prestamo</a></li>
            <li class="active" ><a href="Gestion.aspx">Gestión</a></li>
            <li><a href="ReservaElemento.aspx">Reservas</a></li>
            <li><a href="InventarioElemento.aspx">Inventarios</a></li>
        </ul>
    </nav>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContenidoCuerpo" runat="server">

    <section class="content-header">
        <h6 style="margin-left: 250px; color: white;">.</h6>
    </section>
   <%-- <section class="content">
        <div class="row">
            <div class="col-md-6">
                <div class="box box-tools">
                    <div class="box-body">
                        <div class="form-group">
                            <label>Id Elemento</label>
                        </div>
                        <div class="form-group1">


                            <asp:dropdownlist id="DropDownList1" runat="server">  </asp:dropdownlist>

                            <label>Id del Elemento</label>1
                        </div>


                    </div>
                </div>
            </div>--%>


            <asp:button id="BtnMostrar" style="background-color: #5eb319; color: white; border-radius: 10px 10px; margin-top: 8px; margin-left: 40%;" runat="server" text="Presiona aqui para ver los elementos" onclick="BtnMostrar_Click" />



            <%--grilla para borrar GVDatos --%>









            <asp:gridview id="GridView1" runat="server" style="margin-left: 250px; " autogeneratecolumns="False" datakeynames="Id_Elemento" onrowdeleting="GVDatos_RowDeleting">
            <Columns>
                <asp:BoundField DataField="Id_Elemento" HeaderText="Id Elemento" />
                <asp:BoundField DataField="N_Placa" HeaderText="Numero Placa" />
             <asp:BoundField DataField="N_Serial" HeaderText="Numero Serial" />
                    <asp:BoundField DataField="Marca" HeaderText="Marca" />
                    <asp:BoundField DataField="Modelo" HeaderText="Modelo" />
                    <asp:BoundField DataField="Categoria_Id_Categoria" HeaderText="Categoria" />
                     <asp:BoundField DataField="Fecha_Ingreso" HeaderText="Fecha de Ingreso" />
                     <asp:BoundField DataField="Estado_Id_Estado" HeaderText="Estado" />
                     <asp:BoundField DataField="Nombre_Elemento" HeaderText="Nombre del Elemento" />
                 <%--    <asp:BoundField DataField="FK_Id_Empleado" HeaderText="Empleado" /--%>
                <asp:TemplateField HeaderText="Eliminar">
                  <%--  
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton2" runat="server" Text="Eliminar" CausesValidation="False" CommandName="Delete"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>--%>
            </Columns>
        </asp:gridview>



            <p>
                <asp:label id="mensaje" runat="server" ></asp:label>
            </p>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContenidoPie" runat="server">
    <footer class="footer">
        <link href="App_Themes/Tema1/sticky-footer-navbar.css" rel="stylesheet" />
        <div class="container">
            <p class="text-muted">Sena  ©2016  ADSI Ficha 908163  Instructor Jesus Rubio </p>
        </div>
    </footer>

</asp:Content>
