<%@ Page  StylesheetTheme="tema 2" Language="C#" AutoEventWireup="true" CodeBehind="RegistroUsuario.aspx.cs" Inherits="_IPC2_Proyecto.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="cabecera" >
            <h1>Registro de usuario</h1> 
        </div>
        <div id="titulo">
            Ingrese los siguientes datos
        </div>
        <div id="campo">
            <asp:Label ID="Label1" runat="server" Text="Nombres: " Font-Size="Large"></asp:Label>
            <asp:TextBox ID="txtNombres" runat="server" Font-Size="Large" Height="29px" Width="300px"></asp:TextBox>
        </div>
        <div id="campo">
            
            <asp:Label ID="Label2" runat="server" Text="Apellidos: " Font-Size="Large" ></asp:Label>
            <asp:TextBox ID="txtApellidos" runat="server" Font-Size="Large" Height="29px" Width="309px"></asp:TextBox>
            
        </div>
        <div id="campo">
            
            <asp:Label ID="Label3" runat="server" Text="Nombre de usuario: " Font-Size="Large"></asp:Label>
            <asp:TextBox ID="txtUsuario" runat="server" Font-Size="Large" Height="29px" Width="291px"></asp:TextBox>
            
        </div>
         <div id="campo">
            
             <asp:Label ID="Label4" runat="server" Text="Contraseña: " Font-Size="Large"></asp:Label>
             <asp:TextBox ID="txtPassword" runat="server" Font-Size="Large" Height="29px" TextMode="Password" Width="272px"></asp:TextBox>
            
        </div>
         <div id="campo">
            
             <asp:Label ID="Label5" runat="server" Text="Fecha nacimiento: " Font-Size="Large"></asp:Label>
             <asp:TextBox ID="txtFecha" runat="server" TextMode="Date" Font-Size="Large" Height="29px" Width="227px"></asp:TextBox>
            
        </div>
         <div id="campo">
            
             <asp:Label ID="Label6" runat="server" Text="País: " Font-Size="Large"></asp:Label>
             <asp:DropDownList ID="drpPais" runat="server" DataSourceID="paises" DataTextField="pais" DataValueField="id_pais" Font-Size="Large" Height="29px" Width="219px">
             </asp:DropDownList>
            
             <asp:SqlDataSource ID="paises" runat="server" ConnectionString="<%$ ConnectionStrings:[IPC2]ProyectoConnectionString %>" SelectCommand="SELECT * FROM [pais]"></asp:SqlDataSource>
            
        </div>
         <div id="campo">
            
             <asp:Label ID="Label7" runat="server" Text="Correo electrónico: " Font-Size="Large"></asp:Label>
             <asp:TextBox ID="txtCorreo" runat="server" TextMode="Email" Font-Size="Large" Height="29px" Width="374px"></asp:TextBox>
            
        </div>
        <div id="boton">
            
            <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" Font-Bold="True" Font-Size="Medium" OnClick="btnRegistrar_Click" Width="219px" />
            
        </div>
    </form>
</body>
</html>
