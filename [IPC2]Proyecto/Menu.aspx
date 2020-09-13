<%@ Page StylesheetTheme="tema 3"  Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="_IPC2_Proyecto.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div id="cabecera" >
            <h1>Menú</h1> 
        </div>
        <div id="titulo">
            Othello
        </div>
        <div id="campo">
            <asp:Button ID="btn1Jugador" runat="server" Text="Jugar partida individual" CssClass="boton" />
        </div>
        <div id="campo">
            <asp:Button ID="btn2Jugadores" runat="server" Text="Jugar partida contra otro jugador" CssClass="boton" />
        </div>
        <div id="campo">
            <asp:Button ID="btnTorneo" runat="server" Text="Jugar un torneo " CssClass="boton" />
        </div>
        <div id="campo">
            <asp:Button ID="btnReportes" runat="server" Text="Ver estadísticas" CssClass="boton" />
        </div>
        <div id="campoAnterior">
            <asp:Button ID="btnCargar" runat="server" Text="Cargar partida" CssClass="boton" OnClick="btnCargar_Click"  />
        </div>
        <section id="campoEspecial">
            <asp:FileUpload ID="archivoXML" runat="server" Height="40px"  Width="432px" CssClass="archivo" />
        </section>
        <div id="campo">
            
            <asp:Button ID="btnCerrarSesion" runat="server" Text="Cerrar sesión" CssClass="boton" OnClick="btnCerrarSesion_Click" />
            
        </div>
    </form>
</body>
</html>
