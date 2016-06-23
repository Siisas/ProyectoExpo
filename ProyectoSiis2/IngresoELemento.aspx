<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="IngresoELemento.aspx.cs" Inherits="ProyectoSiis2.IngresoELemento" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoBanner" runat="server">
    <link href="../bootstrap.min.css" rel="stylesheet">



    <nav>
        <ul class="nav nav-justified">
            <li><a href="Home.aspx">Inicio</a></li>
            <li class="active"><a href="IngresoELemento.aspx">Ingreso Elemento</a></li>
            <li><a href="PrestamoElemento.aspx">Prestamo</a></li>
            <li><a href="#">Devolución</a></li>
            <li><a href="ReservaElemento.aspx">Reservas</a></li>
            <li><a href="InventarioElemento.aspx">Inventarios</a></li>
        </ul>
    </nav>

</asp:Content>



<asp:Content ID="Content3" ContentPlaceHolderID="ContenidoCuerpo" runat="server">



    <section class="content-header">
        <h6 style="margin-left: 250px; color: white;">.</h6>
    </section>
    <section class="content">
        <div class="row">
            <div class="col-md-6">
                <div class="box box-tools">
                    <div class="box-body">
                        <div class="form-group">
                            <label>Id de Control</label>
                        </div>
                        <div class="form-group1">
                            <asp:TextBox ID="TxtIdElemento" runat="server" CssClass="form-control " Width="600px   "></asp:TextBox>
                            <label>Número Placa</label>1
                        </div>
                        <div class="form-group1">
                            <asp:TextBox ID="TxtNumeroPlaca" runat="server" CssClass="form-control" Width="600px"></asp:TextBox>
                        </div>
                        <div class="form-group1">
                            <label>Número Serial</label>
                        </div>
                        <div class="form-group1">
                            <asp:TextBox ID="TxtNumeroSerial" runat="server" CssClass="form-control" Width="600px"></asp:TextBox>
                        </div>
                        <div class="form-group1">
                            <label>Marca</label>
                        </div>
                        <div class="form-group1">
                            <asp:TextBox ID="TxtMarca" runat="server" CssClass="form-control" Width="600px"></asp:TextBox>
                        </div>
                        <div class="form-group1">
                            <label>Categoria</label>
                        </div>
                        <div class="form-group1">
                            <asp:TextBox ID="TxtCategoria" runat="server" CssClass="form-control" Width="600px"></asp:TextBox>
                        </div>
                        <div class="form-group1">
                            <label>Id_Empleado</label>
                        </div>
                        <div class="form-group1">
                            <asp:TextBox ID="TxtFK_Id_Empleado" runat="server" CssClass="form-control" Width="600px"></asp:TextBox>
                        </div>
                    </div>
                </div>
            </div>

            <div class="col-md-6">
                <div class="box box-tools">
                    <div class="box-body">
                        <div class="form-group">
                            <label>Modelo</label>
                        </div>
                        <div class="form-group1">
                            <asp:TextBox ID="TxtModelo" runat="server" CssClass="form-control" Width="600px"></asp:TextBox>
                        </div>
                        <div class="form-group1">
                            <label>Fecha Ingreso</label>
                        </div>
                        <div class="form-group1">
                            <asp:TextBox ID="TxtFecha_Ingreso" runat="server" CssClass="form-control" Width="600px"></asp:TextBox>
                            <asp:ImageButton ID="ImagenCal" runat="server" ImageUrl="~/Imagenes/calendar.jpg" Width="35px" OnClick="ImagenCal_Click" />
                            <asp:Calendar ID="CalendarIng" runat="server" OnSelectionChanged="CalendarIng_SelectionChanged"></asp:Calendar>
                        </div>

                        <div class="form-group1">
                            <label>Nombre Elemento</label>
                        </div>
                        <div class="form-group1">
                            <asp:TextBox ID="TxtNombreElemento" runat="server" CssClass="form-control" Width="600px"></asp:TextBox>
                        </div>
                        <div class="form-group1">
                            <label>Estado</label>
                        </div>
                        <div class="form-group1">
                            <asp:TextBox ID="TxtEstado" runat="server" CssClass="form-control" Width="600px"></asp:TextBox>
                        </div>
                        
                    </div>
                </div>
            </div>
        </div>


        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Button ID="BtnGuardar" Style="background-color: #5eb319; color: white; border-radius: 10px 10px; margin-top: 15%; margin-left: 65%;" runat="server" Text="Guardar" OnClick="BtnGuardar_Click" />
                <asp:Button ID="BtnCancelar" Style="background-color: #5eb319; color: white; border-radius: 10px 10px; margin-top: 3px; margin-left: 10px;" runat="server" Text="Cancelar" />
            </td>
        </tr>


    </section>





    </tbody>
          </table>
        </div>
      </div>
          
          
          <p>
              <asp:Label ID="mensaje" Style="color: black; text-align: center; text-shadow: 5px 5px 5px Gray; text-align: center; font-weight: bold;"
                  runat="server"></asp:Label>
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

