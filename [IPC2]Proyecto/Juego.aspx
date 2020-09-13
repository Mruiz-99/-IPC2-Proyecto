<%@ Page StylesheetTheme="tema 4"  Language ="C#" AutoEventWireup="true" CodeBehind="Juego.aspx.cs" Inherits="_IPC2_Proyecto.Juego" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        
    </style>
</head>
<body>
    <form id="form1" runat="server">
       <div id="cabecera" >
            <h1>Othello</h1> 
        </div>
        <div id="campoMenu">
            
            <asp:Button ID="btnMenu" runat="server" Text="Ir al menú"  CssClass="boton" OnClick="btnMenu_Click"/>
            
        </div>
        <div id="datos"> 
            <div id="credenciales" class="auto-style1">
               
                <asp:Label ID="txtJugador1" runat="server" Text="Jugador 1"></asp:Label>
                
            </div>
            <div id="credenciales">
                 <asp:Label ID="txtJugador2" runat="server" Text="Jugador 2"></asp:Label>
            </div>

        </div>
         <div id="tablero2" >
             <asp:Table ID="tablero" runat="server">
                 <asp:TableRow>
                     <asp:TableCell CssClass="esquina"></asp:TableCell>
                     <asp:TableCell CssClass="esquina">A</asp:TableCell>
                     <asp:TableCell CssClass="esquina">B</asp:TableCell>
                     <asp:TableCell CssClass="esquina">C</asp:TableCell>
                     <asp:TableCell CssClass="esquina">D</asp:TableCell>
                     <asp:TableCell CssClass="esquina">E</asp:TableCell>
                     <asp:TableCell CssClass="esquina">F</asp:TableCell>
                     <asp:TableCell CssClass="esquina">G</asp:TableCell>
                     <asp:TableCell CssClass="esquina">H</asp:TableCell>
                     <asp:TableCell CssClass="esquina"></asp:TableCell>
                 </asp:TableRow>
                 <asp:TableRow>
                     <asp:TableCell CssClass="esquina">1</asp:TableCell>
                     <asp:TableCell><asp:Button ID="A1" runat="server" Text="" CssClass="ficha"  OnClick="A1_Click" /></asp:TableCell>
                     <asp:TableCell><asp:Button ID="B1" runat="server" Text="" CssClass="ficha"  OnClick="B1_Click"/></asp:TableCell>
                     <asp:TableCell><asp:Button ID="C1" runat="server" Text="" CssClass="ficha"  OnClick="C1_Click"/></asp:TableCell>
                     <asp:TableCell><asp:Button ID="D1" runat="server" Text="" CssClass="ficha"  OnClick="D1_Click"/></asp:TableCell>
                     <asp:TableCell><asp:Button ID="E1" runat="server" Text="" CssClass="ficha"  OnClick="E1_Click" /></asp:TableCell>
                     <asp:TableCell><asp:Button ID="F1" runat="server" Text="" CssClass="ficha" OnClick="F1_Click" /></asp:TableCell>
                     <asp:TableCell><asp:Button ID="G1" runat="server" Text="" CssClass="ficha" OnClick="G1_Click" /></asp:TableCell>
                     <asp:TableCell><asp:Button ID="H1" runat="server" Text="" CssClass="ficha" OnClick="H1_Click" /></asp:TableCell>
                     <asp:TableCell CssClass="esquina">1</asp:TableCell>
                     
                 </asp:TableRow>
                  <asp:TableRow>
                     <asp:TableCell CssClass="esquina">2</asp:TableCell>
                     <asp:TableCell><asp:Button ID="A2" runat="server" Text="" CssClass="ficha" OnClick="A2_Click" /></asp:TableCell>
                     <asp:TableCell><asp:Button ID="B2" runat="server" Text="" CssClass="ficha" OnClick="B2_Click"/></asp:TableCell>
                     <asp:TableCell><asp:Button ID="C2" runat="server" Text="" CssClass="ficha" OnClick="C2_Click"/></asp:TableCell>
                     <asp:TableCell><asp:Button ID="D2" runat="server" Text="" CssClass="ficha" OnClick="D2_Click"/></asp:TableCell>
                     <asp:TableCell><asp:Button ID="E2" runat="server" Text="" CssClass="ficha" OnClick="E2_Click"/></asp:TableCell>
                     <asp:TableCell><asp:Button ID="F2" runat="server" Text="" CssClass="ficha"  OnClick="F2_Click"/></asp:TableCell>
                     <asp:TableCell><asp:Button ID="G2" runat="server" Text="" CssClass="ficha"  OnClick="G2_Click"/></asp:TableCell>
                     <asp:TableCell><asp:Button ID="H2" runat="server" Text="" CssClass="ficha"  OnClick="H2_Click"/></asp:TableCell>
                     <asp:TableCell CssClass="esquina">2</asp:TableCell>
                     
                 </asp:TableRow>
                  <asp:TableRow>
                     <asp:TableCell CssClass="esquina">3</asp:TableCell>
                     <asp:TableCell><asp:Button ID="A3" runat="server" Text="" CssClass="ficha" OnClick="A3_Click"/></asp:TableCell>
                     <asp:TableCell><asp:Button ID="B3" runat="server" Text="" CssClass="ficha" OnClick="B3_Click"/></asp:TableCell>
                     <asp:TableCell><asp:Button ID="C3" runat="server" Text="" CssClass="ficha" OnClick="C3_Click"/></asp:TableCell>
                     <asp:TableCell><asp:Button ID="D3" runat="server" Text="" CssClass="ficha" OnClick="D3_Click"/></asp:TableCell>
                     <asp:TableCell><asp:Button ID="E3" runat="server" Text="" CssClass="ficha" OnClick="E3_Click"/></asp:TableCell>
                     <asp:TableCell><asp:Button ID="F3" runat="server" Text="" CssClass="ficha"  OnClick="F3_Click"/></asp:TableCell>
                     <asp:TableCell><asp:Button ID="G3" runat="server" Text="" CssClass="ficha"  OnClick="G3_Click"/></asp:TableCell>
                     <asp:TableCell><asp:Button ID="H3" runat="server" Text="" CssClass="ficha"  OnClick="H3_Click"/></asp:TableCell>
                     <asp:TableCell CssClass="esquina">3</asp:TableCell>
                     
                 </asp:TableRow>
                  <asp:TableRow>
                     <asp:TableCell CssClass="esquina">4</asp:TableCell>
                     <asp:TableCell><asp:Button ID="A4" runat="server" Text="" CssClass="ficha" OnClick="A4_Click"/></asp:TableCell>
                     <asp:TableCell><asp:Button ID="B4" runat="server" Text="" CssClass="ficha" OnClick="B4_Click"/></asp:TableCell>
                     <asp:TableCell><asp:Button ID="C4" runat="server" Text="" CssClass="ficha" OnClick="C4_Click"/></asp:TableCell>
                     <asp:TableCell><asp:Button ID="D4" runat="server" Text="" CssClass="ficha" OnClick="D4_Click"  /></asp:TableCell>
                     <asp:TableCell><asp:Button ID="E4" runat="server" Text="" CssClass="ficha" OnClick="E4_Click"/></asp:TableCell>
                     <asp:TableCell><asp:Button ID="F4" runat="server" Text="" CssClass="ficha"  OnClick="F4_Click"/></asp:TableCell>
                     <asp:TableCell><asp:Button ID="G4" runat="server" Text="" CssClass="ficha"  OnClick="G4_Click"/></asp:TableCell>
                     <asp:TableCell><asp:Button ID="H4" runat="server" Text="" CssClass="ficha"  OnClick="H4_Click"/></asp:TableCell>
                     <asp:TableCell CssClass="esquina">4</asp:TableCell>
                     
                 </asp:TableRow>
                  <asp:TableRow>
                     <asp:TableCell CssClass="esquina">5</asp:TableCell>
                     <asp:TableCell><asp:Button ID="A5" runat="server" Text="" CssClass="ficha" OnClick="A5_Click"/></asp:TableCell>
                     <asp:TableCell><asp:Button ID="B5" runat="server" Text="" CssClass="ficha" OnClick="B5_Click"/></asp:TableCell>
                     <asp:TableCell><asp:Button ID="C5" runat="server" Text="" CssClass="ficha" OnClick="C5_Click"/></asp:TableCell>
                     <asp:TableCell><asp:Button ID="D5" runat="server" Text="" CssClass="ficha" OnClick="D5_Click"/></asp:TableCell>
                     <asp:TableCell><asp:Button ID="E5" runat="server" Text="" CssClass="ficha" OnClick="E5_Click"/></asp:TableCell>
                     <asp:TableCell><asp:Button ID="F5" runat="server" Text="" CssClass="ficha"  OnClick="F5_Click"/></asp:TableCell>
                     <asp:TableCell><asp:Button ID="G5" runat="server" Text="" CssClass="ficha"  OnClick="G5_Click"/></asp:TableCell>
                     <asp:TableCell><asp:Button ID="H5" runat="server" Text="" CssClass="ficha"  OnClick="H5_Click"/></asp:TableCell>
                     <asp:TableCell CssClass="esquina">5</asp:TableCell>
                     
                 </asp:TableRow>
                  <asp:TableRow>
                     <asp:TableCell CssClass="esquina">6</asp:TableCell>
                      <asp:TableCell><asp:Button ID="A6" runat="server" Text="" CssClass="ficha" OnClick="A6_Click"/></asp:TableCell>
                     <asp:TableCell><asp:Button ID="B6" runat="server" Text="" CssClass="ficha" OnClick="B6_Click"/></asp:TableCell>
                     <asp:TableCell><asp:Button ID="C6" runat="server" Text="" CssClass="ficha" OnClick="C6_Click"/></asp:TableCell>
                     <asp:TableCell><asp:Button ID="D6" runat="server" Text="" CssClass="ficha" OnClick="D6_Click"/></asp:TableCell>
                     <asp:TableCell><asp:Button ID="E6" runat="server" Text="" CssClass="ficha" OnClick="E6_Click"/></asp:TableCell>
                     <asp:TableCell><asp:Button ID="F6" runat="server" Text="" CssClass="ficha"  OnClick="F6_Click"/></asp:TableCell>
                     <asp:TableCell><asp:Button ID="G6" runat="server" Text="" CssClass="ficha"  OnClick="G6_Click"/></asp:TableCell>
                     <asp:TableCell><asp:Button ID="H6" runat="server" Text="" CssClass="ficha"  OnClick="H6_Click"/></asp:TableCell>
                     <asp:TableCell CssClass="esquina">6</asp:TableCell>
                     
                 </asp:TableRow>
              <asp:TableRow>
                     <asp:TableCell CssClass="esquina">7</asp:TableCell>
                     <asp:TableCell><asp:Button ID="A7" runat="server" Text="" CssClass="ficha" OnClick="A7_Click"/></asp:TableCell>
                     <asp:TableCell><asp:Button ID="B7" runat="server" Text="" CssClass="ficha" OnClick="B7_Click"/></asp:TableCell>
                     <asp:TableCell><asp:Button ID="C7" runat="server" Text="" CssClass="ficha" OnClick="C7_Click"/></asp:TableCell>
                     <asp:TableCell><asp:Button ID="D7" runat="server" Text="" CssClass="ficha" OnClick="D7_Click"/></asp:TableCell>
                     <asp:TableCell><asp:Button ID="E7" runat="server" Text="" CssClass="ficha" OnClick="E7_Click"/></asp:TableCell>
                     <asp:TableCell><asp:Button ID="F7" runat="server" Text="" CssClass="ficha"  OnClick="F7_Click"/></asp:TableCell>
                     <asp:TableCell><asp:Button ID="G7" runat="server" Text="" CssClass="ficha"  OnClick="G7_Click"/></asp:TableCell>
                     <asp:TableCell><asp:Button ID="H7" runat="server" Text="" CssClass="ficha"  OnClick="H7_Click"/></asp:TableCell>
                     <asp:TableCell CssClass="esquina">7</asp:TableCell>
                     
                 </asp:TableRow>
              <asp:TableRow>
                     <asp:TableCell CssClass="esquina">8</asp:TableCell>
                     <asp:TableCell><asp:Button ID="A8" runat="server" Text="" CssClass="ficha" OnClick="A8_Click"/></asp:TableCell>
                     <asp:TableCell><asp:Button ID="B8" runat="server" Text="" CssClass="ficha" OnClick="B8_Click"/></asp:TableCell>
                     <asp:TableCell><asp:Button ID="C8" runat="server" Text="" CssClass="ficha" OnClick="C8_Click"/></asp:TableCell>
                     <asp:TableCell><asp:Button ID="D8" runat="server" Text="" CssClass="ficha" OnClick="D8_Click"/></asp:TableCell>
                     <asp:TableCell><asp:Button ID="E8" runat="server" Text="" CssClass="ficha" OnClick="E8_Click"/></asp:TableCell>
                     <asp:TableCell><asp:Button ID="F8" runat="server" Text="" CssClass="ficha"  OnClick="F8_Click"/></asp:TableCell>
                     <asp:TableCell><asp:Button ID="G8" runat="server" Text="" CssClass="ficha"  OnClick="G8_Click"/></asp:TableCell>
                     <asp:TableCell><asp:Button ID="H8" runat="server" Text="" CssClass="ficha"  OnClick="H8_Click"/></asp:TableCell>
                     <asp:TableCell CssClass="esquina">8</asp:TableCell>
                     
                 </asp:TableRow>
              <asp:TableRow>
                     <asp:TableCell CssClass="esquina"></asp:TableCell>
                     <asp:TableCell CssClass="esquina">A</asp:TableCell>
                     <asp:TableCell CssClass="esquina">B</asp:TableCell>
                     <asp:TableCell CssClass="esquina">C</asp:TableCell>
                     <asp:TableCell CssClass="esquina">D</asp:TableCell>
                     <asp:TableCell CssClass="esquina">E</asp:TableCell>
                     <asp:TableCell CssClass="esquina">F</asp:TableCell>
                     <asp:TableCell CssClass="esquina">G</asp:TableCell>
                     <asp:TableCell CssClass="esquina">H</asp:TableCell>
                     <asp:TableCell CssClass="esquina"></asp:TableCell>
                 </asp:TableRow>
             
             </asp:Table>
    
        </div>
        <div id="campo">
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="boton" OnClick="btnGuardar_Click" />
        </div>
    </form>
</body>
</html>
