<%@ Page  StylesheetTheme="tema 1" Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="_IPC2_Proyecto.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    </head>
<body style="height: 364px">
    <form id="form1" runat="server">
        <div  id="cabecera">
            <h1>Bienvenido</h1>
        </div>
        <div id="titulo">
            Inicio de sesión
        </div>
        <div id="campo"> 
            <asp:Label ID="Label3" runat="server" Font-Size="Large" Text="Usuario :"></asp:Label>
            <asp:TextBox ID="txtUsuario" runat="server" Height="29px" Width="350px" Font-Size="Large"></asp:TextBox>
        </div>
        <div id="campo">
            <asp:Label ID="Label4" runat="server" Font-Size="Large" Text="Contraseña :"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" Height="29px" Width="329px" TextMode="Password" Font-Size="Large"></asp:TextBox>
        </div>
        <div id="boton">
            <asp:Button ID="btnIngresar" runat="server" Font-Bold="True" Font-Size="Medium" Text="Ingresar" Width="219px" OnClick="btnIngresar_Click" />
        </div>
        <div id="boton">
            <asp:Button ID="btnRegistrarse" runat="server" Font-Bold="True" Font-Size="Medium" Text="Registrarse" Width="217px" OnClick="btnRegistrarse_Click" />
        </div>
    </form>
        </body>
</html>
