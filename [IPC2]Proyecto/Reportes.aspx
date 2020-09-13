<%@ Page StylesheetTheme="tema 5"  Language="C#" AutoEventWireup="true" CodeBehind="Reportes.aspx.cs" Inherits="_IPC2_Proyecto.Reportes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="cabecera" >
            <h1>Estadísticas</h1> 
        </div>
        <div id="campo">
            <asp:Button ID="btnGanados" runat="server" Text="Juegos ganados" CssClass="boton"/>
        </div>
        <div id="campo">
            <asp:Button ID="btnEmpatados" runat="server" Text="Juegos empatados"  CssClass="boton"/>
        </div>
        <div id="campo">
            <asp:Button ID="btnPerdidos" runat="server" Text="Juegos perdidos" CssClass="boton"/>
        </div>
        <div id="campo">
            <asp:Button ID="btnTorneos" runat="server" Text="Reporte de torneos" CssClass="boton" />
        </div>
        <div id="campo">
            <asp:Button ID="btn" runat="server" Text="Atras" CssClass="boton" />
        </div>
       
    </form>
</body>
</html>
