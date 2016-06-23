<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="InventarioElemento.aspx.cs" Inherits="ProyectoSiis2.InventarioElemento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoBanner" runat="server">
  <link href="../bootstrap.min.css" rel="stylesheet">

             

            <nav >
                <ul class="nav nav-justified">
                    <li><a  href="Home.aspx"">Inicio</a></li>
                    <li><a  href="IngresoELemento.aspx">Ingreso Elemento</a></li>
                    <li><a  href="#">Prestamo</a></li>
                    <li><a  href="#">Devolución</a></li>
                    <li><a  href="ReservaElemento.aspx">Reservas</a></li>
                    <li class="active" ><a  href="InventarioElemento.aspx">Inventarios</a></li>
                </ul>
            </nav>
        
     </asp:Content>


       
<asp:Content ID="Content3" ContentPlaceHolderID="ContenidoCuerpo" runat="server">



      
              
              <asp:GridView ID="GridView1" class="grilla" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical">
                  <AlternatingRowStyle BackColor="#CCCCCC" />
                <Columns>
                    <asp:BoundField DataField="Id_Elemento" HeaderText="Id Elemento" />
                    <asp:BoundField DataField="N_placa" HeaderText="Numero Placa" />
                    <asp:BoundField DataField="N_Serial" HeaderText="Numero Serial" />
                    <asp:BoundField DataField="Marca" HeaderText="Marca" />
                    <asp:BoundField DataField="Modelo" HeaderText="Modelo" />
                    <asp:BoundField DataField="Fecha_Ingreso" HeaderText="Fecha de Ingreso" />
                     <asp:BoundField DataField="Nombre_Elemento" HeaderText="Nombre del elemento" />
                     <asp:BoundField DataField="Categoria_Id_Categoria" HeaderText="ID Categoria" />
                     <asp:BoundField DataField="Estado_Id_Estado" HeaderText="IDEstado" />
                </Columns>
                  <FooterStyle BackColor="
                      " />
                  <HeaderStyle BackColor="#5eb319" Font-Bold="True" ForeColor="Black" />
                  <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Right" Width="40px" />
                  <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                  <SortedAscendingCellStyle BackColor="#F1F1F1" />
                  <SortedAscendingHeaderStyle BackColor="#808080" />
                  <SortedDescendingCellStyle BackColor="#CAC9C9" />
                  <SortedDescendingHeaderStyle BackColor="#383838" />
                  
            </asp:GridView>
    
         <p>
            <asp:Label ID = "mensaje" runat = "server"></asp:Label>
        </p>
           <%--   <asp:Button ID = "BtnMostrar" Style="background-color:#5eb319;color:white;border-radius:10px 10px;margin-top:8px; margin-left:40%;" runat = "server" Text = "Presiona aqui para ver el inventario" OnClick="BtnMostrar_Click"/>
 --%>



 <asp:GridView ID="GVDatos" runat="server" AutoGenerateColumns="False" DataKeyNames="Id_Elemento" OnRowCancelingEdit="GVDatos_RowCancelingEdit" OnRowEditing="GVDatos_RowEditing" OnRowUpdating="GVDatos_RowUpdating">
            <Columns>
                <asp:BoundField DataField="Id_Elemento" HeaderText="Id_Elemento" />
                <asp:TemplateField HeaderText="Id_Elemento">
                    <EditItemTemplate>
                        <asp:TextBox ID="TxtNumeroPlaca" runat="server" Text='<%# Bind("N_placa") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("N_placa") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="TxtNumeroSerial">
                    <EditItemTemplate>
                        <asp:TextBox ID="TxtNumeroSerial" runat="server" Text='<%# Bind("N_Serial") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("N_Serial") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="TxtMarca">
                    <EditItemTemplate>
                        <asp:TextBox ID="TxtMarca" runat="server" Text='<%# Bind("Marca") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("Marca") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="TxtModelo">
                    <EditItemTemplate>
                        <asp:TextBox ID="TxtModelo" runat="server" Text='<%# Bind("Modelo") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%# Bind("Modelo") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="TxtCategoria">
                    <EditItemTemplate>
                        <asp:TextBox ID="TxtCategoria" runat="server" Text='<%# Bind("Categoria_Id_Categoria") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label7" runat="server" Text='<%# Bind("Categoria_Id_Categoria") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>


                <asp:TemplateField HeaderText="TxtFecha_Ingreso">
                    <EditItemTemplate>
                        <asp:TextBox ID="TxtFecha_Ingreso" runat="server" Text='<%# Bind("Fecha_Ingreso") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label5" runat="server" Text='<%# Bind("Fecha_Ingreso") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                          <asp:TemplateField HeaderText="TxtEstado">
                    <EditItemTemplate>
                        <asp:TextBox ID="TxtEstado" runat="server" Text='<%# Bind("Estado_Id_Estado") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label8" runat="server" Text='<%# Bind("Estado_Id_Estado") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>


                <asp:TemplateField HeaderText="TxtNombreElemento">
                    <EditItemTemplate>
                        <asp:TextBox ID="TxtNombreElemento" runat="server" Text='<%# Bind("Nombre_Elemento") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label6" runat="server" Text='<%# Bind("Nombre_Elemento") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
               
      

                <asp:CommandField ShowEditButton="True" />
            </Columns>
        </asp:GridView>
    <div>
    
    </div>
         <p>
            <asp:Label ID="LblMsg" runat="server"></asp:Label>
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
