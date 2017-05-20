<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProyectoSiis2.RegistroUsuario.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>


<%--    <link href="Css/bootstrap.min.css" rel="stylesheet" />--%>
    <link href="../Css/CssLogin.css" rel="stylesheet" />
</head>
<body style="background-image: url(Imagenes/FondoLogin.jpg);" />
<form style="padding-top: 90px;" runat="server">
    <div id="Pnl_Login">
        <div id="Form_Login">
            <div id="Titulo_Login" class="text-center">
                <div id="Logo_Login"></div>
                <div>Ri</div>
            </div>
            <br />
            <div class="input-group input-group-lg">
                <div class="input-group-addon">
                    <span class="glyphicon glyphicon-user"></span>&nbsp;Usuario&nbsp;&nbsp;&nbsp;
                </div>
                <asp:textbox id="TxtUsuario" runat="server" cssclass="form-control text-center"></asp:textbox>
            </div>
            <div class="input-group input-group-lg">
                <div class="input-group-addon">
                    <span class="glyphicon glyphicon-lock"></span>Password 
                </div>
                <asp:textbox id="TxtPassword" runat="server" textmode="Password" cssclass="form-control text-center"></asp:textbox>
            </div>
            <br />
            <asp:button id="Btn_Login" runat="server" text="Ingresar" cssclass="btn btn-primary center-block btn-lg" onclick="Btn_Login_Click" />
            <asp:panel runat="server" id="Pnl_Message">
                <asp:Label ID="lblmsg" runat="server"></asp:Label>
            </asp:panel>
            <div id="Caplock" class="alert alert-info ">
                <span class="glyphicon glyphicon-info-sign glyphicon-bold"></span>Bloq Mayús activado
            </div>
        </div>
    </div>
</form>
<footer class="navbar-default navbar-fixed-bottom">
    <div class="container text-center">
        <p style="font-size: 1.0vw">Copyright © Cafeteria Mil Delicias 2016</p>
    </div>
</footer>
</body>
</html>
