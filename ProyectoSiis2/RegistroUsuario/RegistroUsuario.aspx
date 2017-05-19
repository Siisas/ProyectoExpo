﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroUsuario.aspx.cs" Inherits="ProyectoSiis2.RegistroUsuario.RegistroUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <asp:Label runat="server">Nombre</asp:Label>
                <asp:TextBox id="TxtNombre" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label runat="server">Password</asp:Label>
                <asp:TextBox id="TxtPassword" runat="server"></asp:TextBox>
            </div>
              <div>
                <asp:Label runat="server">Cedula</asp:Label>
                <asp:TextBox id="TxtCedula" runat="server"></asp:TextBox>
            </div>
              <div>
                <asp:Label runat="server">Perfil</asp:Label>
                <asp:TextBox id="TxtPerfil" runat="server"></asp:TextBox>
            </div>


            <asp:Button Text="Guardar"  id="BtnGuardar" runat="server" OnClick="BtnGuardar_Click"/>
            <asp:Button ID="Button1" runat="server" Text="Button" />
            <asp:Label ID="Mensaje" runat="server" ></asp:Label>
        </div>
    </form>
</body>
</html>
