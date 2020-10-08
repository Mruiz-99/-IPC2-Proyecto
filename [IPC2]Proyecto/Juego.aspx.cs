
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;
using System.Windows.Forms;
using System.Xml;
using Microsoft.VisualBasic;

namespace _IPC2_Proyecto
{
    public partial class Juego : System.Web.UI.Page
    {
        string color, posicion, colorJ1, colorJ2;
        string[] movimientos;
        bool turno = false;
        string  columna, fila;
        int colorInt = 0, contadorJ1 = 0, contadorJ2 = 0;
        int i = -1;
        int j = 0;
        int C_A1 = 0, C_A2 = 0, C_A3 = 0, C_A4 = 0, C_A5 = 0, C_A6 = 0, C_A7 = 0, C_A8 = 0,
            C_B1 = 0, C_B2 = 0, C_B3 = 0, C_B4 = 0, C_B5 = 0, C_B6 = 0, C_B7 = 0, C_B8 = 0,
            C_C1 = 0, C_C2 = 0, C_C3 = 0, C_C4 = 0, C_C5 = 0, C_C6 = 0, C_C7 = 0, C_C8 = 0,
            C_D1 = 0, C_D2 = 0, C_D3 = 0, C_D6 = 0, C_D7 = 0, C_D8 = 0,
            C_E1 = 0, C_E2 = 0, C_E3 = 0, C_E6 = 0, C_E7 = 0, C_E8 = 0,
            C_F1 = 0, C_F2 = 0, C_F3 = 0, C_F4 = 0, C_F5 = 0, C_F6 = 0, C_F7 = 0, C_F8 = 0,
            C_G1 = 0, C_G2 = 0, C_G3 = 0, C_G4 = 0, C_G5 = 0, C_G6 = 0, C_G7 = 0, C_G8 = 0,
            C_H1 = 0, C_H2 = 0, C_H3 = 0, C_H4 = 0, C_H5 = 0, C_H6 = 0, C_H7 = 0, C_H8 = 0;

        string path;
        string[,] posiciones = new string[60,2];
        string archivoXML;
        string[] colores = { "Negro", "Blanco" };
        string[] parametros;
        string user;
        string[] lista;


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack) 
            {
                if (j == 0)
                {
                    j++;
                    if (Request.Params["parametro"] != null)
                    {
                        parametros = Request.Params["parametro"].Split(',');
                        archivoXML = parametros[0];
                        if (archivoXML == "individual") {
                            colorInt = int.Parse(Interaction.InputBox("Ingrese el numero de opcion que desee: \n1.    Fichas blancas \n2.    Fichas negras  \n3.    Asignacion aleatoria ", "Seleccione el color de fichas ", "", -1, -1));
                            if (colorInt == 2)
                            {
                                txtJugador1.Text = parametros[1] + "(Negro)";
                                txtJugador2.Text = "Jugador 2 (Blanco)";
                                colorJ1 = "negro";
                                colorJ2 = "blanco";
                                txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                            }
                            if (colorInt == 1)
                            {
                                txtJugador1.Text = parametros[1] + "(Blanco)";
                                txtJugador2.Text = "Jugador 2 (Negro)";
                                colorJ1 = "blanco";
                                colorJ2 = "negro";
                                txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                            }
                            if (colorInt == 3)
                            {
                                Random rnd = new Random();


                                int ColoresIndex = rnd.Next(colores.Length);
                                if (colores[ColoresIndex] == "Negro")
                                {
                                    txtJugador1.Text = parametros[1] + "(Negro)";
                                    txtJugador2.Text = "Jugador 2 (Blanco)";
                                    colorJ1 = "negro";
                                    colorJ2 = "blanco";
                                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);

                                }

                                else
                                {
                                    txtJugador1.Text = parametros[1] + "(Blanco)";
                                    txtJugador2.Text = "Jugador 2 (Negro)";
                                    colorJ1 = "blanco";
                                    colorJ2 = "negro";
                                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                                }
                            }
                            A1.BackColor = Color.FromArgb(147, 200, 90);
                            B1.BackColor = Color.FromArgb(147, 200, 90);
                            C1.BackColor = Color.FromArgb(147, 200, 90);
                            D1.BackColor = Color.FromArgb(147, 200, 90);
                            E1.BackColor = Color.FromArgb(147, 200, 90);
                            F1.BackColor = Color.FromArgb(147, 200, 90);
                            G1.BackColor = Color.FromArgb(147, 200, 90);
                            H1.BackColor = Color.FromArgb(147, 200, 90);
                            A2.BackColor = Color.FromArgb(147, 200, 90);
                            B2.BackColor = Color.FromArgb(147, 200, 90);
                            C2.BackColor = Color.FromArgb(147, 200, 90);
                            D2.BackColor = Color.FromArgb(147, 200, 90);
                            E2.BackColor = Color.FromArgb(147, 200, 90);
                            F2.BackColor = Color.FromArgb(147, 200, 90);
                            G2.BackColor = Color.FromArgb(147, 200, 90);
                            H2.BackColor = Color.FromArgb(147, 200, 90);
                            A3.BackColor = Color.FromArgb(147, 200, 90);
                            B3.BackColor = Color.FromArgb(147, 200, 90);
                            C3.BackColor = Color.FromArgb(147, 200, 90);
                            D3.BackColor = Color.FromArgb(147, 200, 90);
                            E3.BackColor = Color.FromArgb(147, 200, 90);
                            F3.BackColor = Color.FromArgb(147, 200, 90);
                            G3.BackColor = Color.FromArgb(147, 200, 90);
                            H3.BackColor = Color.FromArgb(147, 200, 90);
                            A4.BackColor = Color.FromArgb(147, 200, 90);
                            B4.BackColor = Color.FromArgb(147, 200, 90);
                            C4.BackColor = Color.FromArgb(147, 200, 90);
                            D4.BackColor = Color.FromArgb(225, 225, 225, 225);
                            E4.BackColor = Color.FromArgb(0, 0, 0, 0);
                            F4.BackColor = Color.FromArgb(147, 200, 90);
                            G4.BackColor = Color.FromArgb(147, 200, 90);
                            H4.BackColor = Color.FromArgb(147, 200, 90);
                            A5.BackColor = Color.FromArgb(147, 200, 90);
                            B5.BackColor = Color.FromArgb(147, 200, 90);
                            C5.BackColor = Color.FromArgb(147, 200, 90);
                            D5.BackColor = Color.FromArgb(0, 0, 0, 0);
                            E5.BackColor = Color.FromArgb(225, 225, 225, 225);
                            F5.BackColor = Color.FromArgb(147, 200, 90);
                            G5.BackColor = Color.FromArgb(147, 200, 90);
                            H5.BackColor = Color.FromArgb(147, 200, 90);
                            A6.BackColor = Color.FromArgb(147, 200, 90);
                            B6.BackColor = Color.FromArgb(147, 200, 90);
                            C6.BackColor = Color.FromArgb(147, 200, 90);
                            D6.BackColor = Color.FromArgb(147, 200, 90);
                            E6.BackColor = Color.FromArgb(147, 200, 90);
                            F6.BackColor = Color.FromArgb(147, 200, 90);
                            G6.BackColor = Color.FromArgb(147, 200, 90);
                            H6.BackColor = Color.FromArgb(147, 200, 90);
                            A7.BackColor = Color.FromArgb(147, 200, 90);
                            B7.BackColor = Color.FromArgb(147, 200, 90);
                            C7.BackColor = Color.FromArgb(147, 200, 90);
                            D7.BackColor = Color.FromArgb(147, 200, 90);
                            E7.BackColor = Color.FromArgb(147, 200, 90);
                            F7.BackColor = Color.FromArgb(147, 200, 90);
                            G7.BackColor = Color.FromArgb(147, 200, 90);
                            H7.BackColor = Color.FromArgb(147, 200, 90);
                            A8.BackColor = Color.FromArgb(147, 200, 90);
                            B8.BackColor = Color.FromArgb(147, 200, 90);
                            C8.BackColor = Color.FromArgb(147, 200, 90);
                            D8.BackColor = Color.FromArgb(147, 200, 90);
                            E8.BackColor = Color.FromArgb(147, 200, 90);
                            F8.BackColor = Color.FromArgb(147, 200, 90);
                            G8.BackColor = Color.FromArgb(147, 200, 90);
                            H8.BackColor = Color.FromArgb(147, 200, 90);
                        }
                        else
                        {
                            turno = false;
                            XmlReader xmlReader = XmlReader.Create(Server.MapPath("~/XML/" + archivoXML));
                            while (xmlReader.Read())
                            {
                                if (xmlReader.IsStartElement())
                                {
                                    switch (xmlReader.Name.ToString())
                                    {
                                        case "ficha":
                                            i++;
                                            break;
                                        case "color":
                                            if (turno == true)
                                            {
                                                string ficha;
                                                ficha =xmlReader.ReadString();
                                                Random rnd = new Random();

                                                int ColoresIndex = rnd.Next(colores.Length);
                                                if (colores[ColoresIndex] == "Negro")
                                                {
                                                    txtJugador1.Text = parametros[1] + "(Negro)";
                                                    txtJugador2.Text = "Jugador 2 (Blanco)";
                                                    colorJ1 = "negro";
                                                    colorJ2 = "blanco";

                                                }

                                                else
                                                {
                                                    txtJugador1.Text = parametros[1] + "(Blanco)";
                                                    txtJugador2.Text = "Jugador 2 (Negro)";
                                                    colorJ1 = "blanco";
                                                    colorJ2 = "negro";
                                                }
                                                if (ficha == "blanco")
                                                {
                                                    if (colorJ1 == "negro")
                                                    {
                                                        txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                                                    }
                                                    else {
                                                        txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                                                    }
                                                    
                                                }
                                                if (ficha == "negro")
                                                {
                                                    if (colorJ1 == "negro")
                                                    {
                                                        txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                                                    }
                                                    else
                                                    {
                                                        txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if (xmlReader.ReadString() == "blanco")
                                                {
                                                    color = "blanco";
                                                }
                                                else
                                                {
                                                    color = "negro";
                                                }

                                            }
                                            break;
                                        case "columna":
                                            columna = xmlReader.ReadString();
                                            break;
                                        case "fila":
                                            fila = xmlReader.ReadString();
                                            posiciones[i, 0] = color;
                                            posiciones[i, 1] = columna + fila;
                                            break;
                                        case "siguienteTiro":
                                            turno = true;
                                            break;
                                    }
                                }
                            }
                            xmlReader.Close();
                            A1.BackColor = Color.FromArgb(147, 200, 90);
                            B1.BackColor = Color.FromArgb(147, 200, 90);
                            C1.BackColor = Color.FromArgb(147, 200, 90);
                            D1.BackColor = Color.FromArgb(147, 200, 90);
                            E1.BackColor = Color.FromArgb(147, 200, 90);
                            F1.BackColor = Color.FromArgb(147, 200, 90);
                            G1.BackColor = Color.FromArgb(147, 200, 90);
                            H1.BackColor = Color.FromArgb(147, 200, 90);
                            A2.BackColor = Color.FromArgb(147, 200, 90);
                            B2.BackColor = Color.FromArgb(147, 200, 90);
                            C2.BackColor = Color.FromArgb(147, 200, 90);
                            D2.BackColor = Color.FromArgb(147, 200, 90);
                            E2.BackColor = Color.FromArgb(147, 200, 90);
                            F2.BackColor = Color.FromArgb(147, 200, 90);
                            G2.BackColor = Color.FromArgb(147, 200, 90);
                            H2.BackColor = Color.FromArgb(147, 200, 90);
                            A3.BackColor = Color.FromArgb(147, 200, 90);
                            B3.BackColor = Color.FromArgb(147, 200, 90);
                            C3.BackColor = Color.FromArgb(147, 200, 90);
                            D3.BackColor = Color.FromArgb(147, 200, 90);
                            E3.BackColor = Color.FromArgb(147, 200, 90);
                            F3.BackColor = Color.FromArgb(147, 200, 90);
                            G3.BackColor = Color.FromArgb(147, 200, 90);
                            H3.BackColor = Color.FromArgb(147, 200, 90);
                            A4.BackColor = Color.FromArgb(147, 200, 90);
                            B4.BackColor = Color.FromArgb(147, 200, 90);
                            C4.BackColor = Color.FromArgb(147, 200, 90);
                            D4.BackColor = Color.FromArgb(147, 200, 90);
                            E4.BackColor = Color.FromArgb(147, 200, 90);
                            F4.BackColor = Color.FromArgb(147, 200, 90);
                            G4.BackColor = Color.FromArgb(147, 200, 90);
                            H4.BackColor = Color.FromArgb(147, 200, 90);
                            A5.BackColor = Color.FromArgb(147, 200, 90);
                            B5.BackColor = Color.FromArgb(147, 200, 90);
                            C5.BackColor = Color.FromArgb(147, 200, 90);
                            D5.BackColor = Color.FromArgb(147, 200, 90);
                            E5.BackColor = Color.FromArgb(147, 200, 90);
                            F5.BackColor = Color.FromArgb(147, 200, 90);
                            G5.BackColor = Color.FromArgb(147, 200, 90);
                            H5.BackColor = Color.FromArgb(147, 200, 90);
                            A6.BackColor = Color.FromArgb(147, 200, 90);
                            B6.BackColor = Color.FromArgb(147, 200, 90);
                            C6.BackColor = Color.FromArgb(147, 200, 90);
                            D6.BackColor = Color.FromArgb(147, 200, 90);
                            E6.BackColor = Color.FromArgb(147, 200, 90);
                            F6.BackColor = Color.FromArgb(147, 200, 90);
                            G6.BackColor = Color.FromArgb(147, 200, 90);
                            H6.BackColor = Color.FromArgb(147, 200, 90);
                            A7.BackColor = Color.FromArgb(147, 200, 90);
                            B7.BackColor = Color.FromArgb(147, 200, 90);
                            C7.BackColor = Color.FromArgb(147, 200, 90);
                            D7.BackColor = Color.FromArgb(147, 200, 90);
                            E7.BackColor = Color.FromArgb(147, 200, 90);
                            F7.BackColor = Color.FromArgb(147, 200, 90);
                            G7.BackColor = Color.FromArgb(147, 200, 90);
                            H7.BackColor = Color.FromArgb(147, 200, 90);
                            A8.BackColor = Color.FromArgb(147, 200, 90);
                            B8.BackColor = Color.FromArgb(147, 200, 90);
                            C8.BackColor = Color.FromArgb(147, 200, 90);
                            D8.BackColor = Color.FromArgb(147, 200, 90);
                            E8.BackColor = Color.FromArgb(147, 200, 90);
                            F8.BackColor = Color.FromArgb(147, 200, 90);
                            G8.BackColor = Color.FromArgb(147, 200, 90);
                            H8.BackColor = Color.FromArgb(147, 200, 90);

                            for (int f = 0; f <= i; f++)
                            {
                                color = posiciones[f, 0];
                                posicion = posiciones[f, 1];
                                pintar(color, posicion);
                            }
                        }
                        
                    }
                }
            }
            else
            {
                if ((movJ1.Text != "Movimientos:") && (movJ2.Text != "Movimientos:")) {
                    movimientos = movJ1.Text.Split(':');
                    contadorJ1 = int.Parse(movimientos[1]);
                    movimientos = movJ2.Text.Split(':');
                    contadorJ2 = int.Parse(movimientos[1]);
                }
               
                if (txtJugador2.Text == "Jugador 2 (Blanco)")
                {
                    colorJ1 = "negro";
                    colorJ2 = "blanco";
                }
                else
                {
                    colorJ2 = "negro";
                    colorJ1 = "blanco";
                }
            }

            
            
            
        }
        public void pintar(string color, string posicion) {
            if (posicion == "A1") {
                if (color == "blanco")
                {
                    A1.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else {
                    A1.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if(posicion == "A2") {
                if (color == "blanco")
                {
                    A2.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    A2.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "A3")
            {
                if (color == "blanco")
                {
                    A3.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    A3.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "A4")
            {
                if (color == "blanco")
                {
                    A4.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    A4.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "A5")
            {
                if (color == "blanco")
                {
                    A5.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    A5.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "A6")
            {
                
                if (color == "blanco")
                {
                    A6.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    A6.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "A7")
            {
                
                if (color == "blanco")
                {
                    A7.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    A7.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "A8")
            {
                
                if (color == "blanco")
                {
                    A8.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    A8.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "B1")
            {
                
                if (color == "blanco")
                {
                    B1.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    B1.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "B2")
            {
                
                if (color == "blanco")
                {
                    B2.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    B2.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "B3")
            {
                
                if (color == "blanco")
                {
                    B3.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    B3.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "B4")
            {
                
                if (color == "blanco")
                {
                    B4.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    B4.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "B5")
            {
                
                if (color == "blanco")
                {
                    B5.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    B5.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "B6")
            {
                
                if (color == "blanco")
                {
                    B6.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    B6.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "B7")
            {
                
                if (color == "blanco")
                {
                    B7.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    B7.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "B8")
            {
                
                if (color == "blanco")
                {
                    B8.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    B8.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "C1")
            {
                
                if (color == "blanco")
                {
                    C1.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    C1.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "C2")
            {
                
                if (color == "blanco")
                {
                    C2.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    C2.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "C3")
            {
                
                if (color == "blanco")
                {
                    C3.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    C3.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "C4")
            {
                
                if (color == "blanco")
                {
                    C4.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    C4.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "C5")
            {
                
                if (color == "blanco")
                {
                    C5.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    C5.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "C6")
            {
                
                if (color == "blanco")
                {
                    C6.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    C6.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "C7")
            {
                
                if (color == "blanco")
                {
                    C7.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    C7.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "C8")
            {
                
                if (color == "blanco")
                {
                    C8.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    C8.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "D1")
            {
                
                if (color == "blanco")
                {
                    D1.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    D1.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "D2")
            {
                
                if (color == "blanco")
                {
                    D2.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    D2.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "D3")
            {
                
                if (color == "blanco")
                {
                    D3.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    D3.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "D4")
            {
                if (color == "blanco")
                {
                    D4.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    D4.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "D5")
            {
                
                if (color == "blanco")
                {
                    D5.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    D5.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "D6")
            {
                
                if (color == "blanco")
                {
                    D6.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    D6.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "D7")
            {
                if (color == "blanco")
                {
                    D7.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    D7.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "D8")
            {
                
                if (color == "blanco")
                {
                    D8.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    D8.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "E1")
            {
                
                if (color == "blanco")
                {
                    E1.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    E1.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "E2")
            {
                
                if (color == "blanco")
                {
                    E2.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    E2.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "E3")
            {
                
                if (color == "blanco")
                {
                    E3.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    E3.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "E4")
            {
                
                if (color == "blanco")
                {
                    E4.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    E4.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "E5")
            {
                
                if (color == "blanco")
                {
                    E5.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    E5.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "E6")
            {
                
                if (color == "blanco")
                {
                    E6.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    E6.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "E7")
            {
                
                if (color == "blanco")
                {
                    E7.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    E7.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "E8")
            {
                
                if (color == "blanco")
                {
                    E8.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    E8.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "F1")
            {
                
                if (color == "blanco")
                {
                    F1.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    F1.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "F2")
            {
                
                if (color == "blanco")
                {
                    F2.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    F2.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "F3")
            {
                
                if (color == "blanco")
                {
                    F3.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    F3.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "F4")
            {
                
                if (color == "blanco")
                {
                    F4.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    F4.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "F5")
            {
                
                if (color == "blanco")
                {
                    F5.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    F5.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "F6")
            {
                
                if (color == "blanco")
                {
                    F6.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    F6.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "F7")
            {
                
                if (color == "blanco")
                {
                    F7.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    F7.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "F8")
            {
                
                if (color == "blanco")
                {
                    F8.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    F8.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "G1")
            {
                
                if (color == "blanco")
                {
                    G1.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    G1.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "G2")
            {
                
                if (color == "blanco")
                {
                    G2.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    G2.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "G3")
            {
                
                if (color == "blanco")
                {
                    G3.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    G3.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "G4")
            {
                
                if (color == "blanco")
                {
                    G4.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    G4.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "G5")
            {
                
                if (color == "blanco")
                {
                    G5.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    G5.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "G6")
            {
                
                if (color == "blanco")
                {
                    G6.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    G6.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "G7")
            {
                
                if (color == "blanco")
                {
                    G7.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    G7.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "G8")
            {
                
                if (color == "blanco")
                {
                    G8.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    G8.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "H1")
            {
                
                if (color == "blanco")
                {
                    H1.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    H1.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "H2")
            {
                
                if (color == "blanco")
                {
                    H2.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    H2.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "H3")
            {
               
                if (color == "blanco")
                {
                    H3.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    H3.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "H4")
            {
                
                if (color == "blanco")
                {
                    H4.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    H4.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "H5")
            {
                
                if (color == "blanco")
                {
                    H5.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    H5.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "H6")
            {
                
                if (color == "blanco")
                {
                    H6.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    H6.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "H7")
            {
                
                if (color == "blanco")
                {
                    H7.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    H7.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }
            else if (posicion == "H8")
            {
                
                if (color == "blanco")
                {
                    H8.BackColor = Color.FromArgb(225, 225, 225,225);
                }
                else
                {
                    H8.BackColor = Color.FromArgb(0, 0, 0,0);
                }
            }


        }
        public string[,] Guardar()
        {
            int p = 0;

            if (A1.BackColor != Color.FromArgb(147, 200, 90)) 
            {
                if (A1.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p,0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p,1] = "A1";
                p++;
            }
            if (A2.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (A2.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "A2";
                p++;
            }
            if (A3.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (A3.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "A3";
                p++;
            }
            if (A4.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (A4.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "A4";
                p++;
            }
            if (A5.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (A5.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "A5";
                p++;
            }
            if (A6.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (A6.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "A6";
                p++;
            }
            if (A7.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (A7.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "A7";
                p++;
            }
            if (A8.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (A8.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "A8";
                p++;
            }
            if (B1.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (B1.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "B1";
                p++;
            }
            if (B2.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (B2.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "B2";
                p++;
            }
            if (B3.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (B3.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "B3";
                p++;
            }
            if (B4.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (B4.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "B4";
                p++;
            }
            if (B5.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (B5.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "B5";
                p++;
            }
            if (B6.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (B6.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "B6";
                p++;
            }
            if (B7.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (B7.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "B7";
                p++;
            }
            if (B8.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (B8.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "B8";
                p++;
            }
            if (C1.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (C1.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "C1";
                p++;
            }
            if (C2.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (C2.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "C2";
                p++;
            }
            if (C3.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (C3.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "C3";
                p++;
            }
            if (C4.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (C4.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "C4";
                p++;
            }
            if (C5.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (C5.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "C5";
                p++;
            }
            if (C6.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (C6.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "C6";
                p++;
            }
            if (C7.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (C7.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "C7";
                p++;
            }
            if (C8.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (C8.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "C8";
                p++;
            }
            if (D1.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (D1.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "D1";
                p++;
            }
            if (D2.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (D2.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "D2";
                p++;
            }
            if (D3.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (D3.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "D3";
                p++;
            }
            if (D4.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (D4.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "D4";
                p++;
            }
            if (D5.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (D5.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "D5";
                p++;
            }
            if (D6.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (D6.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "D6";
                p++;
            }
            if (D7.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (D7.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "D7";
                p++;
            }
            if (D8.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (D8.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "D8";
                p++;
            }
            if (E1.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (E1.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "E1";
                p++;
            }
            if (E2.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (E2.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "E2";
                p++;
            }
            if (E3.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (E3.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "E3";
                p++;
            }
            if (E4.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (E4.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "E4";
                p++;
            }
            if (E5.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (E5.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "E5";
                p++;
            }
            if (E6.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (E6.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "E6";
                p++;
            }
            if (E7.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (E7.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "E7";
                p++;
            }
            if (E8.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (E8.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "E8";
                p++;
            }
            if (F1.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (F1.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "F1";
                p++;
            }
            if (F2.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (F2.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "F2";
                p++;
            }
            if (F3.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (F3.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "F3";
                p++;
            }
            if (F4.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (F4.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "F4";
                p++;
            }
            if (F5.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (F5.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "F5";
                p++;
            }
            if (F6.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (F6.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "F6";
                p++;
            }
            if (F7.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (F7.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "F7";
                p++;
            }
            if (F8.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (F8.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "F8";
                p++;
            }
            if (G1.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (G1.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "G1";
                p++;
            }
            if (G2.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (G2.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "G2";
                p++;
            }
            if (G3.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (G3.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "G3";
                p++;
            }
            if (G4.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (G4.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "G4";
                p++;
            }
            if (G5.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (G5.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "G5";
                p++;
            }
            if (G6.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (G6.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "G6";
                p++;
            }
            if (G7.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (G7.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "G7";
                p++;
            }
            if (G8.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (G8.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "G8";
                p++;
            }
            if (H1.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (H1.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "H1";
                p++;
            }
            if (H2.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (H2.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "H2";
                p++;
            }
            if (H3.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (H3.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "H3";
                p++;
            }
            if (H4.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (H4.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "H4";
                p++;
            }
            if (H5.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (H5.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "H5";
                p++;
            }
            if (H6.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (H6.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "H6";
                p++;
            }
            if (H7.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (H7.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "H7";
                p++;
            }
            if (H8.BackColor != Color.FromArgb(147, 200, 90))
            {
                if (H8.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    posiciones[p, 0] = "blanco";
                }
                else
                {
                    posiciones[p, 0] = "negro";
                }
                posiciones[p, 1] = "H8";
                p++;
            }
            return posiciones;

        }

        protected void A1_Click(object sender, EventArgs e)
        {
            if (A1.BackColor == Color.FromArgb(147, 200, 90))
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    Reglas(colorJ1, "A1");
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    Reglas(colorJ2, "A1");
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
            else
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }


        }
        protected void A2_Click(object sender, EventArgs e)
        {
            if (A2.BackColor == Color.FromArgb(147, 200, 90))
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    Reglas(colorJ1, "A2");
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    Reglas(colorJ2, "A2");
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
            else
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }

        }
        protected void A3_Click(object sender, EventArgs e)
        {
            if (A3.BackColor == Color.FromArgb(147, 200, 90))
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    Reglas(colorJ1, "A3");
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    Reglas(colorJ2, "A3");
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
            else
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }


        }
        protected void A4_Click(object sender, EventArgs e)
        {
            if (A4.BackColor == Color.FromArgb(147, 200, 90))
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    Reglas(colorJ1, "A4");
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    Reglas(colorJ2, "A4");
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
            else
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }

            C_A4++;

        }
        protected void A5_Click(object sender, EventArgs e)
        {
            if (A5.BackColor == Color.FromArgb(147, 200, 90))
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    Reglas(colorJ1, "A5");
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    Reglas(colorJ2, "A5");
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
            else
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }


        }
        protected void A6_Click(object sender, EventArgs e)
        {
            if (A6.BackColor == Color.FromArgb(147, 200, 90))
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    Reglas(colorJ1, "A6");
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    Reglas(colorJ2, "A6");
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
            else
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
        }
        protected void A7_Click(object sender, EventArgs e)
        {
            if (A7.BackColor == Color.FromArgb(147, 200, 90))
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    Reglas(colorJ1, "A7");
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    Reglas(colorJ2, "A7");
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
            else
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
        }
        protected void A8_Click(object sender, EventArgs e)
        {
            if (A8.BackColor == Color.FromArgb(147, 200, 90))
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    Reglas(colorJ1, "A8");
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    Reglas(colorJ2, "A8");
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
            else
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
        }
        protected void B1_Click(object sender, EventArgs e)
        {
            if (B1.BackColor == Color.FromArgb(147, 200, 90))
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    Reglas(colorJ1, "B1");
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    Reglas(colorJ2, "B1");
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
            else
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }

        }
        protected void B2_Click(object sender, EventArgs e)
        {

            if (B2.BackColor == Color.FromArgb(147, 200, 90))
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    Reglas(colorJ1, "B2");
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    Reglas(colorJ2, "B2");
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
            else
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }

        }
        protected void B3_Click(object sender, EventArgs e)
        {
            if (B3.BackColor == Color.FromArgb(147, 200, 90))
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    Reglas(colorJ1, "B3");
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    Reglas(colorJ2, "B3");
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
            else
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
                    }
        protected void B4_Click(object sender, EventArgs e)
        {
            if (B4.BackColor == Color.FromArgb(147, 200, 90))
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    Reglas(colorJ1, "B4");
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    Reglas(colorJ2, "B4");
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
            else
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
        }
        protected void B5_Click(object sender, EventArgs e)
        {
            if (B5.BackColor == Color.FromArgb(147, 200, 90))
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    Reglas(colorJ1, "B5");
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    Reglas(colorJ2, "B5");
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
            else
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
        }
        protected void B6_Click(object sender, EventArgs e)
        {
            if (B6.BackColor == Color.FromArgb(147, 200, 90))
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    Reglas(colorJ1, "B6");
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    Reglas(colorJ2, "B6");
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
            else
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }

        }
        protected void B7_Click(object sender, EventArgs e)
        {
            if (B7.BackColor == Color.FromArgb(147, 200, 90))
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    Reglas(colorJ1, "B7");
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    Reglas(colorJ2, "B7");
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
            else
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
        }
        protected void B8_Click(object sender, EventArgs e)
        {
            if (B8.BackColor == Color.FromArgb(147, 200, 90))
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    Reglas(colorJ1, "B8");
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    Reglas(colorJ2, "B8");
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
            else
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
        }
        protected void C1_Click(object sender, EventArgs e)
        {
            if (C1.BackColor == Color.FromArgb(147, 200, 90))
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    Reglas(colorJ1, "C1");
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    Reglas(colorJ2, "C1");
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
            else
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
        }
        protected void C2_Click(object sender, EventArgs e)
        {
            if (C2.BackColor == Color.FromArgb(147, 200, 90))
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    Reglas(colorJ1, "C2");
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    Reglas(colorJ2, "C2");
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
            else
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
        }
        protected void C3_Click(object sender, EventArgs e)
        {
            if (C3.BackColor == Color.FromArgb(147, 200, 90))
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    Reglas(colorJ1, "C3");
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    Reglas(colorJ2, "C3");
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
            else
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
        }
        protected void C4_Click(object sender, EventArgs e)
        {
            if (C4.BackColor == Color.FromArgb(147, 200, 90))
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    Reglas(colorJ1, "C4");
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    Reglas(colorJ2, "C4");
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
            else
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
        }
        protected void C5_Click(object sender, EventArgs e)
        {
            if (C5.BackColor == Color.FromArgb(147, 200, 90))
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    Reglas(colorJ1, "C5");
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    Reglas(colorJ2, "C5");
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
            else
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
        }
        protected void C6_Click(object sender, EventArgs e)
        {
            if (C6.BackColor == Color.FromArgb(147, 200, 90))
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    Reglas(colorJ1, "C6");
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    Reglas(colorJ2, "C6");
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
            else
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
        }
        protected void C7_Click(object sender, EventArgs e)
        {
            if (C7.BackColor == Color.FromArgb(147, 200, 90))
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    Reglas(colorJ1, "C7");
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    Reglas(colorJ2, "C7");
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
            else
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
        }
        protected void C8_Click(object sender, EventArgs e)
        {
            if (C8.BackColor == Color.FromArgb(147, 200, 90))
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    Reglas(colorJ1, "C8");
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    Reglas(colorJ2, "C8");
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
            else
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }

            }

        protected void D1_Click(object sender, EventArgs e)
        {
        if (D1.BackColor == Color.FromArgb(147, 200, 90))
        {
            if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
            {
                Reglas(colorJ1, "D1");
                txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
            }
            else
            {
                Reglas(colorJ2, "D1");
                txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
            }
        }
        else
        {
            if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
            {
                txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
            }
            else
            {
                txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
            }
        }

    }
        protected void D2_Click(object sender, EventArgs e)
        {
            if (D2.BackColor == Color.FromArgb(147, 200, 90))
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    Reglas(colorJ1, "D2");
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    Reglas(colorJ2, "D2");
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
            else
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
        }
        protected void D3_Click(object sender, EventArgs e)
        {
            if (D3.BackColor == Color.FromArgb(147, 200, 90))
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    Reglas(colorJ1,"D3");
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    Reglas(colorJ2, "D3");
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
             }
            else
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
             }
        }
        


        private void Reglas(string colorJ, string Posicion)
        {
            if (Posicion == "A3")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {

                    /*horizontal derecha*/
                    if (B3.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (C3.BackColor == Color.FromArgb(0, 0, 0, 0)) 
                        {
                            pintar("negro", "B3");
                            comprobacion = true;
                        }
                        if ((D3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B3");
                            pintar("negro", "C3");
                            comprobacion = true;
                        }

                        if ((E3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B3");
                            pintar("negro", "C3");
                            pintar("negro", "D3");
                            comprobacion = true;
                        }
                        if ((F3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B3");
                            pintar("negro", "C3");
                            pintar("negro", "D3");
                            pintar("negro", "E3");
                            comprobacion = true;
                        }
                        if ((G3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B3");
                            pintar("negro", "C3");
                            pintar("negro", "D3");
                            pintar("negro", "E3");
                            pintar("negro", "F3");
                            comprobacion = true;
                        }
                        if ((G3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B3");
                            pintar("negro", "C3");
                            pintar("negro", "D3");
                            pintar("negro", "E3");
                            pintar("negro", "F3");
                            pintar("negro", "G3");
                            comprobacion = true;
                        }
                    }
                    /*vertical arriba*/
                    if (A2.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (A1.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "A2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (A4.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (A5.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "A4");
                            comprobacion = true;
                        }
                        if ((A5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("negro", "A4");
                            pintar("negro", "A5");
                            comprobacion = true;
                        }
                        if ((A5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "A4");
                            pintar("negro", "A5");
                            pintar("negro", "A6");
                            comprobacion = true;
                        }
                        if ((A5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A7.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "A4");
                            pintar("negro", "A5");
                            pintar("negro", "A6");
                            pintar("negro", "A7");
                            comprobacion = true;
                        }
                    }

                }
                if (colorJ == "blanco")
                {
                    /*horizontal derecha*/
                    if (B3.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (C3.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "B3");
                            comprobacion = true;
                        }
                        if ((D3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B3");
                            pintar("blanco", "C3");
                            comprobacion = true;
                        }

                        if ((E3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B3");
                            pintar("blanco", "C3");
                            pintar("blanco", "D3");
                            comprobacion = true;
                        }
                        if ((F3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B3");
                            pintar("blanco", "C3");
                            pintar("blanco", "D3");
                            pintar("blanco", "E3");
                            comprobacion = true;
                        }
                        if ((G3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B3");
                            pintar("blanco", "C3");
                            pintar("blanco", "D3");
                            pintar("blanco", "E3");
                            pintar("blanco", "F3");
                            comprobacion = true;
                        }
                        if ((G3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B3");
                            pintar("blanco", "C3");
                            pintar("blanco", "D3");
                            pintar("blanco", "E3");
                            pintar("blanco", "F3");
                            pintar("blanco", "G3");
                            comprobacion = true;
                        }


                    }
                    /*vertical arriba*/
                    if (A2.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (A1.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "A2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (A4.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (A5.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "A4");
                            comprobacion = true;
                        }
                        if ((A5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("blanco", "A4");
                            pintar("blanco", "A5");
                            comprobacion = true;
                        }
                        if ((A5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "A4");
                            pintar("blanco", "A5");
                            pintar("blanco", "A6");
                            comprobacion = true;
                        }
                        if ((A5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A7.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "A4");
                            pintar("blanco", "A5");
                            pintar("blanco", "A6");
                            pintar("blanco", "A7");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true) {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
                    
        }

            if (Posicion == "B3")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {
                    
                    /*horizontal derecha*/
                    if (C3.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (D3.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "C3");
                            comprobacion = true;
                        }

                        if ((E3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C3");
                            pintar("negro", "D3");
                            comprobacion = true;
                        }
                        if ((F3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C3");
                            pintar("negro", "D3");
                            pintar("negro", "E3");
                            comprobacion = true;
                        }
                        if ((G3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C3");
                            pintar("negro", "D3");
                            pintar("negro", "E3");
                            pintar("negro", "F3");
                            comprobacion = true;
                        }
                        if ((G3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C3");
                            pintar("negro", "D3");
                            pintar("negro", "E3");
                            pintar("negro", "F3");
                            pintar("negro", "G3");
                            comprobacion = true;
                        }
                    }
                    /*vertical arriba*/
                    if (B2.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (B1.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "B2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (B4.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (B5.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "B4");
                            comprobacion = true;
                        }
                        if ((B5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("negro", "B4");
                            pintar("negro", "B5");
                            comprobacion = true;
                        }
                        if ((B5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B4");
                            pintar("negro", "B5");
                            pintar("negro", "B6");
                            comprobacion = true;
                        }
                        if ((B5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B7.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B4");
                            pintar("negro", "B5");
                            pintar("negro", "B6");
                            pintar("negro", "B7");
                            comprobacion = true;
                        }
                    }

                }
                if (colorJ == "blanco")
                {
                    /*horizontal derecha*/
                    if (C3.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (D3.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "C3");
                            comprobacion = true;
                        }

                        if ((E3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C3");
                            pintar("blanco", "D3");
                            comprobacion = true;
                        }
                        if ((F3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C3");
                            pintar("blanco", "D3");
                            pintar("blanco", "E3");
                            comprobacion = true;
                        }
                        if ((G3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C3");
                            pintar("blanco", "D3");
                            pintar("blanco", "E3");
                            pintar("blanco", "F3");
                            comprobacion = true;
                        }
                        if ((G3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C3");
                            pintar("blanco", "D3");
                            pintar("blanco", "E3");
                            pintar("blanco", "F3");
                            pintar("blanco", "G3");
                            comprobacion = true;
                        }


                    }
                    /*vertical arriba*/
                    if (B2.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (B1.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "B2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (B4.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (B5.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "B4");
                            comprobacion = true;
                        }
                        if ((B5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("blanco", "B4");
                            pintar("blanco", "B5");
                            comprobacion = true;
                        }
                        if ((B5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B4");
                            pintar("blanco", "B5");
                            pintar("blanco", "B6");
                            comprobacion = true;
                        }
                        if ((B5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B7.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B4");
                            pintar("blanco", "B5");
                            pintar("blanco", "B6");
                            pintar("blanco", "B7");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true)
                {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
            }

            if (Posicion == "C3")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {
                    /*horizontal izquierda*/
                    if (B3.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (A3.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "B3");
                            comprobacion = true;
                        }
                    }
                    /*horizontal derecha*/
                    if (D3.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if(E3.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "D3");
                            comprobacion = true;
                        }
                        if ((F3.BackColor == Color.FromArgb(0, 0, 0, 0)) &&  (E3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D3");
                            pintar("negro", "E3");
                            comprobacion = true;
                        }
                        if ((G3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D3");
                            pintar("negro", "E3");
                            pintar("negro", "F3");
                            comprobacion = true;
                        }
                        if ((G3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D3");
                            pintar("negro", "E3");
                            pintar("negro", "F3");
                            pintar("negro", "G3");
                            comprobacion = true;
                        }
                    }
                    /*vertical arriba*/
                    if (C2.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (C1.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "C2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (C4.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (C5.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "C4");
                            comprobacion = true;
                        }
                        if ((C5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("negro", "C4");
                            pintar("negro", "C5");
                            comprobacion = true;
                        }
                        if ((C5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C4");
                            pintar("negro", "C5");
                            pintar("negro", "C6");
                            comprobacion = true;
                        }
                        if ((C5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C7.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C4");
                            pintar("negro", "C5");
                            pintar("negro", "C6");
                            pintar("negro", "C7");
                            comprobacion = true;
                        }
                    }
                    /*diagonal hacia arriba izquierda*/
                    if (B2.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (A1.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "B2");
                            comprobacion = true;
                        }
                    }
                    /*diagonal hacia abajo derecha*/
                    if (D4.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (E5.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "D4");
                            comprobacion = true;
                        }
                        if ((E5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("negro", "D4");
                            pintar("negro", "E5");
                            comprobacion = true;
                        }
                        if ((E5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D4");
                            pintar("negro", "E5");
                            pintar("negro", "F6");
                            comprobacion = true;
                        }
                        if ((E5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G7.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D4");
                            pintar("negro", "E5");
                            pintar("negro", "F6");
                            pintar("negro", "G7");
                            comprobacion = true;
                        }
                    }

                }
                if (colorJ == "blanco")
                {
                    /*horizontal izquierda*/
                    if (B3.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (A3.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "B3");
                            comprobacion = true;
                        }
                    }

                    /*horizontal derecha*/
                    if (D3.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (E3.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "D3");
                            comprobacion = true;
                        }
                        if ((F3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco" , "D3");
                            pintar("blanco", "E3");
                            comprobacion = true;
                        }
                        if ((F3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D3");
                            pintar("blanco", "E3");
                            pintar("blanco", "F3");
                            comprobacion = true;
                        }
                        if ((H3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D3");
                            pintar("blanco", "E3");
                            pintar("blanco", "F3");
                            pintar("blanco", "G3");
                            comprobacion = true;
                        }


                     }
                    /*vertical arriba*/
                    if (C2.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (C1.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "C2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (C4.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (C5.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "C4");
                            comprobacion = true;
                        }
                        if ((C5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("blanco", "C4");
                            pintar("blanco", "C5");
                            comprobacion = true;
                        }
                        if ((C5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C4");
                            pintar("blanco", "C5");
                            pintar("blanco", "C6");
                            comprobacion = true;
                        }
                        if ((C5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C7.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C4");
                            pintar("blanco", "C5");
                            pintar("blanco", "C6");
                            pintar("blanco", "C7");
                            comprobacion = true;
                        }
                    }
                    /*diagonal hacia arriba izquierda*/
                    if (B2.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (A1.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "B2");
                            comprobacion = true;
                        }
                    }
                    /*diagonal hacia abajo derecha*/
                    if (D4.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (E5.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "D4");
                            comprobacion = true;
                        }
                        if ((E5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("blanco", "D4");
                            pintar("blanco", "E5");
                            comprobacion = true;
                        }
                        if ((E5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D4");
                            pintar("blanco", "E5");
                            pintar("blanco", "F6");
                            comprobacion = true;
                        }
                        if ((E5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G7.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D4");
                            pintar("blanco", "E5");
                            pintar("blanco", "F6");
                            pintar("blanco", "G7");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true)
                {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
            }

            if (Posicion == "D3")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {
                    /*horizontal izquierda*/
                    if (C3.BackColor == Color.FromArgb(225, 225, 225, 225)) {
                        if (B3.BackColor == Color.FromArgb(0, 0, 0, 0)) {
                            pintar("negro", "C3");
                            comprobacion = true;
                        }
                        if ((A3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B3.BackColor == Color.FromArgb(225,225,225,225)))
                        {
                            pintar("negro", "C3");
                            pintar("negro", "B3");
                            comprobacion = true;
                        }
                    }
                    /*horizontal derecha*/
                    if (E3.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (F3.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "E3");
                            comprobacion = true;
                        }
                        if ((G3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E3");
                            pintar("negro", "F3");
                            comprobacion = true;
                        }
                        if ((G3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("negro", "E3");
                            pintar("negro", "F3");
                            pintar("negro", "G3");
                            comprobacion = true;
                        }
                    }
                    /*vertical arriba*/
                    if (D2.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (D1.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "D2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (D4.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (D5.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "D4");
                            comprobacion = true;
                        }
                        if ((D5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("negro", "D4");
                            pintar("negro", "D5");
                            comprobacion = true;
                        }
                        if ((D5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D4");
                            pintar("negro", "D5");
                            pintar("negro", "D6");
                            comprobacion = true;
                        }
                        if ((D5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D7.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D4");
                            pintar("negro", "D5");
                            pintar("negro", "D6");
                            pintar("negro", "D7");
                            comprobacion = true;
                        }
                    }
                    /*diagonal hacia arriba izquierda*/
                    if (C2.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (B1.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "C2");
                            comprobacion = true;
                        }
                    }
                    /*diagonal hacia abajo derecha*/
                    if (E4.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (F5.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "E4");
                            comprobacion = true;
                        }
                        if ((F5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("negro", "E4");
                            pintar("negro", "F5");
                            comprobacion = true;
                        }
                        if ((F5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E4");
                            pintar("negro", "F5");
                            pintar("negro", "G6");
                            comprobacion = true;
                        }
                    }

                }
                if (colorJ == "blanco")
                {
                    /*horizontal izquierda*/
                    if (C3.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (B3.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "C3");
                            comprobacion = true;
                        }
                        if ((B3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("blanco", "C3");
                            pintar("blanco", "B3");
                            comprobacion = true;
                        }
                    }

                    /*horizontal derecha*/
                    if (E3.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (F3.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "E3");
                            comprobacion = true;
                        }
                        if ((F3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("blanco", "E3");
                            pintar("blanco", "F3");
                            comprobacion = true;
                        }
                        if ((H3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E3");
                            pintar("blanco", "F3");
                            pintar("blanco", "G3");
                            comprobacion = true;
                        }
                    }
                    /*vertical arriba*/
                    if (D2.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (D1.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "D2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (D4.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (D5.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "D4");
                            comprobacion = true;
                        }
                        if ((D5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("blanco", "D4");
                            pintar("blanco", "D5");
                            comprobacion = true;
                        }
                        if ((D5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D4");
                            pintar("blanco", "D5");
                            pintar("blanco", "D6");
                            comprobacion = true;
                        }
                        if ((D5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D7.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D4");
                            pintar("blanco", "D5");
                            pintar("blanco", "D6");
                            pintar("blanco", "D7");
                            comprobacion = true;
                        }
                    }
                    /*diagonal hacia arriba derecha*/
                    if (C2.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (B1.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "C2");
                            comprobacion = true;
                        }
                    }
                    /*diagonal hacia abajo izquierda*/
                    if (E4.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (F5.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "E4");
                            comprobacion = true;
                        }
                        if ((F5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("blanco", "E4");
                            pintar("blanco", "F5");
                            comprobacion = true;
                        }
                        if ((F5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E4");
                            pintar("blanco", "F5");
                            pintar("blanco", "G6");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true)
                {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
            }

            if (Posicion == "E3")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {
                    /*horizontal izquierda*/
                    if (D3.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (C3.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "D3");
                            comprobacion = true;
                        }
                        if ((B3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D3");
                            pintar("negro", "C3");
                            comprobacion = true;
                        }
                        if ((A3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D3");
                            pintar("negro", "C3");
                            pintar("negro", "B3");
                            comprobacion = true;
                        }
                    }
                    /*horizontal derecha*/
                    if (F3.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (G3.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "F3");
                            comprobacion = true;
                        }
                        if ((H3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F3");
                            pintar("negro", "G3");
                            comprobacion = true;
                        }
                    }
                    /*vertical arriba*/
                    if (E2.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (E1.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "E2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (E4.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (E5.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "E4");
                            comprobacion = true;
                        }
                        if ((E5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("negro", "E4");
                            pintar("negro", "E5");
                            comprobacion = true;
                        }
                        if ((E5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E4");
                            pintar("negro", "E5");
                            pintar("negro", "E6");
                            comprobacion = true;
                        }
                        if ((E5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E7.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E4");
                            pintar("negro", "E5");
                            pintar("negro", "E6");
                            pintar("negro", "E7");
                            comprobacion = true;
                        }
                    }
                    /*diagonal hacia arriba izquierda*/
                    if (D2.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (C1.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "D2");
                            comprobacion = true;
                        }
                    }
                    /*diagonal hacia abajo derecha*/
                    if (F4.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (G5.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "F4");
                            comprobacion = true;
                        }
                        if ((G5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("negro", "F4");
                            pintar("negro", "G5");
                            comprobacion = true;
                        }
                    }

                }
                if (colorJ == "blanco")
                {
                    /*horizontal izquierda*/
                    if (D3.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (C3.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "D3");
                            comprobacion = true;
                        }
                        if ((B3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D3");
                            pintar("blanco", "C3");
                            comprobacion = true;
                        }
                        if ((A3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D3");
                            pintar("blanco", "C3");
                            pintar("blanco", "B3");
                            comprobacion = true;
                        }
                    }

                    /*horizontal derecha*/
                    if (E3.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (G3.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "F3");
                            comprobacion = true;
                        }
                        if ((H3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F3");
                            pintar("blanco", "G3");
                            comprobacion = true;
                        }
                    }
                    /*vertical arriba*/
                    if (E2.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (E1.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "E2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (E4.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (E5.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "E4");
                            comprobacion = true;
                        }
                        if ((E5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("blanco", "E4");
                            pintar("blanco", "E5");
                            comprobacion = true;
                        }
                        if ((E5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E4");
                            pintar("blanco", "E5");
                            pintar("blanco", "E6");
                            comprobacion = true;
                        }
                        if ((E5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E7.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E4");
                            pintar("blanco", "E5");
                            pintar("blanco", "E6");
                            pintar("blanco", "E7");
                            comprobacion = true;
                        }
                    }
                    /*diagonal hacia arriba izquierda*/
                    if (D2.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (C1.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "D2");
                            comprobacion = true;
                        }
                    }
                    /*diagonal hacia abajo derecha*/
                    if (F4.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (G5.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "F4");
                            comprobacion = true;
                        }
                        if ((G5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("blanco", "F4");
                            pintar("blanco", "G5");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true)
                {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
            }

            if (Posicion == "F3")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {
                    /*horizontal izquierda*/
                    if (E3.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (D3.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "E3");
                            comprobacion = true;
                        }
                        if ((C3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro","E3");
                            pintar("negro", "D3");
                            comprobacion = true;
                        }
                        if ((B3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E3");
                            pintar("negro", "D3");
                            pintar("negro", "C3");
                            comprobacion = true;
                        }
                        if ((A3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E3");
                            pintar("negro", "D3");
                            pintar("negro", "C3");
                            pintar("negro", "B3");
                            comprobacion = true;
                        }
                    }
                    /*horizontal derecha*/
                    if (G3.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (H3.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "G3");
                            comprobacion = true;
                        }
                    }
                    /*vertical arriba*/
                    if (F2.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (F1.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "F2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (F4.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (F5.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "F4");
                            comprobacion = true;
                        }
                        if ((F5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("negro", "F4");
                            pintar("negro", "F5");
                            comprobacion = true;
                        }
                        if ((F5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F4");
                            pintar("negro", "F5");
                            pintar("negro", "F6");
                            comprobacion = true;
                        }
                        if ((F5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F7.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F4");
                            pintar("negro", "F5");
                            pintar("negro", "F6");
                            pintar("negro", "F7");
                            comprobacion = true;
                        }
                    }
                    /*diagonal hacia arriba izquierda*/
                    if (E2.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (D1.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "E2");
                            comprobacion = true;
                        }
                    }
                    /*diagonal hacia abajo derecha*/
                    if (G4.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (H5.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "G4");
                            comprobacion = true;
                        }
                    }

                }
                if (colorJ == "blanco")
                {
                    /*horizontal izquierda*/
                    if (E3.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (D3.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "E3");
                            comprobacion = true;
                        }
                        if ((C3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E3");
                            pintar("blanco", "D3");
                            comprobacion = true;
                        }
                        if ((B3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E3");
                            pintar("blanco", "D3");
                            pintar("blanco", "C3");
                            comprobacion = true;
                        }
                        if ((A3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E3");
                            pintar("blanco", "D3");
                            pintar("blanco", "C3");
                            pintar("blanco", "B3");
                            comprobacion = true;
                        }
                    }

                    /*horizontal derecha*/
                    if (G3.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (H3.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "G3");
                            comprobacion = true;
                        }
                    }
                    /*vertical arriba*/
                    if (F2.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (F1.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "F2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (F4.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (F5.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "F4");
                            comprobacion = true;
                        }
                        if ((F5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("blanco", "F4");
                            pintar("blanco", "F5");
                            comprobacion = true;
                        }
                        if ((F5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F4");
                            pintar("blanco", "F5");
                            pintar("blanco", "F6");
                            comprobacion = true;
                        }
                        if ((F5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F7.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F4");
                            pintar("blanco", "F5");
                            pintar("blanco", "F6");
                            pintar("blanco", "F7");
                            comprobacion = true;
                        }
                    }
                    /*diagonal hacia arriba izquierda*/
                    if (E2.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (D1.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "E2");
                            comprobacion = true;
                        }
                    }
                    /*diagonal hacia abajo derecha*/
                    if (G4.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (H5.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "G4");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true)
                {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
            }

            if (Posicion == "G3")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {
                    /*horizontal izquierda*/
                    if (F3.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (E3.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "F3");
                            comprobacion = true;
                        }
                        if ((D3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F3");
                            pintar("negro", "E3");
                            comprobacion = true;
                        }
                        if ((C3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F3");
                            pintar("negro", "E3");
                            pintar("negro", "D3");
                            comprobacion = true;
                        }
                        if ((B3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F3");
                            pintar("negro", "E3");
                            pintar("negro", "D3");
                            pintar("negro", "C3");
                            comprobacion = true;
                        }
                        if ((A3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F3");
                            pintar("negro", "E3");
                            pintar("negro", "D3");
                            pintar("negro", "C3");
                            pintar("negro", "B3");
                            comprobacion = true;
                        }
                    }

                    /*vertical arriba*/
                    if (G2.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (G1.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "G2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (G4.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (G5.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "G4");
                            comprobacion = true;
                        }
                        if ((G5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("negro", "G4");
                            pintar("negro", "G5");
                            comprobacion = true;
                        }
                        if ((G5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G4");
                            pintar("negro", "G5");
                            pintar("negro", "G6");
                            comprobacion = true;
                        }
                        if ((G5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G7.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G4");
                            pintar("negro", "G5");
                            pintar("negro", "G6");
                            pintar("negro", "G7");
                            comprobacion = true;
                        }
                    }

                }
                if (colorJ == "blanco")
                {
                    /*horizontal izquierda*/
                    if (F3.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (E3.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "F3");
                            comprobacion = true;
                        }
                        if ((D3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F3");
                            pintar("blanco", "E3");
                            comprobacion = true;
                        }
                        if ((C3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F3");
                            pintar("blanco", "E3");
                            pintar("blanco", "D3");
                            comprobacion = true;
                        }
                        if ((B3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F3");
                            pintar("blanco", "E3");
                            pintar("blanco", "D3");
                            pintar("blanco", "C3");
                            comprobacion = true;
                        }
                        if ((A3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F3");
                            pintar("blanco", "E3");
                            pintar("blanco", "D3");
                            pintar("blanco", "C3");
                            pintar("blanco", "B3");
                            comprobacion = true;
                        }
                    }


                    /*vertical arriba*/
                    if (G2.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (G1.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "G2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (G4.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (G5.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "G4");
                            comprobacion = true;
                        }
                        if ((G5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("blanco", "G4");
                            pintar("blanco", "G5");
                            comprobacion = true;
                        }
                        if ((G5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G4");
                            pintar("blanco", "G5");
                            pintar("blanco", "G6");
                            comprobacion = true;
                        }
                        if ((G5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G7.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G4");
                            pintar("blanco", "G5");
                            pintar("blanco", "G6");
                            pintar("blanco", "G7");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true)
                {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
            }

            if (Posicion == "H3")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {
                    /*horizontal izquierda*/
                    if (G3.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (F3.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "G3");
                            comprobacion = true;
                        }
                        if ((E3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro" , "G3");
                            pintar("negro", "F3");
                            comprobacion = true;
                        }
                        if ((D3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G3");
                            pintar("negro", "F3");
                            pintar("negro", "E3");
                            comprobacion = true;
                        }
                        if ((C3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G3");
                            pintar("negro", "F3");
                            pintar("negro", "E3");
                            pintar("negro", "D3");
                            comprobacion = true;
                        }
                        if ((B3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G3");
                            pintar("negro", "F3");
                            pintar("negro", "E3");
                            pintar("negro", "D3");
                            pintar("negro", "C3");
                            comprobacion = true;
                        }
                        if ((A3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G3");
                            pintar("negro", "F3");
                            pintar("negro", "E3");
                            pintar("negro", "D3");
                            pintar("negro", "C3");
                            pintar("negro", "B3");
                            comprobacion = true;
                        }
                    }

                    /*vertical arriba*/
                    if (H2.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (H1.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "H2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (H4.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (H5.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "H4");
                            comprobacion = true;
                        }
                        if ((H5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("negro", "H4");
                            pintar("negro", "H5");
                            comprobacion = true;
                        }
                        if ((H5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "H4");
                            pintar("negro", "H5");
                            pintar("negro", "H6");
                            comprobacion = true;
                        }
                        if ((H5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H7.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "H4");
                            pintar("negro", "H5");
                            pintar("negro", "H6");
                            pintar("negro", "H7");
                            comprobacion = true;
                        }
                    }

                }
                if (colorJ == "blanco")
                {
                    /*horizontal izquierda*/
                    if (G3.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (F3.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "G3");
                            comprobacion = true;
                        }
                        if ((E3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G3");
                            pintar("blanco", "F3");
                            comprobacion = true;
                        }
                        if ((D3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G3");
                            pintar("blanco", "F3");
                            pintar("blanco", "E3");
                            comprobacion = true;
                        }
                        if ((C3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G3");
                            pintar("blanco", "F3");
                            pintar("blanco", "E3");
                            pintar("blanco", "D3");
                            comprobacion = true;
                        }
                        if ((B3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G3");
                            pintar("blanco", "F3");
                            pintar("blanco", "E3");
                            pintar("blanco", "D3");
                            pintar("blanco", "C3");
                            comprobacion = true;
                        }
                        if ((A3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G3");
                            pintar("blanco", "F3");
                            pintar("blanco", "E3");
                            pintar("blanco", "D3");
                            pintar("blanco", "C3");
                            pintar("blanco", "B3");
                            comprobacion = true;
                        }
                    }


                    /*vertical arriba*/
                    if (H2.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (H1.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "H2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (H4.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (H5.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "H4");
                            comprobacion = true;
                        }
                        if ((H5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("blanco", "H4");
                            pintar("blanco", "H5");
                            comprobacion = true;
                        }
                        if ((H5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "H4");
                            pintar("blanco", "H5");
                            pintar("blanco", "H6");
                            comprobacion = true;
                        }
                        if ((H5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H7.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "H4");
                            pintar("blanco", "H5");
                            pintar("blanco", "H6");
                            pintar("blanco", "H7");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true)
                {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
            }

           
            if (Posicion == "A2")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {

                    /*horizontal derecha*/
                    if (B2.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (C2.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "B2");
                            comprobacion = true;
                        }
                        if ((D2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C2.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B2");
                            pintar("negro", "C2");
                            comprobacion = true;
                        }

                        if ((E2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C2.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B2");
                            pintar("negro", "C2");
                            pintar("negro", "D2");
                            comprobacion = true;
                        }
                        if ((F2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C2.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B2");
                            pintar("negro", "C2");
                            pintar("negro", "D2");
                            pintar("negro", "E2");
                            comprobacion = true;
                        }
                        if ((G2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C2.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B2");
                            pintar("negro", "C2");
                            pintar("negro", "D2");
                            pintar("negro", "E2");
                            pintar("negro", "F2");
                            comprobacion = true;
                        }
                        if ((G2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C2.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B2");
                            pintar("negro", "C2");
                            pintar("negro", "D2");
                            pintar("negro", "E2");
                            pintar("negro", "F2");
                            pintar("negro", "G2");
                            comprobacion = true;
                        }
                    }

                    /*vertical abajo*/
                    if (A3.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (A4.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "A3");
                            comprobacion = true;
                        }
                        if ((A5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "A3");
                            pintar("negro", "A4");
                            comprobacion = true;
                        }
                        if ((A5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "A3");
                            pintar("negro", "A4");
                            pintar("negro", "A5");
                            comprobacion = true;
                        }
                        if ((A5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "A3");
                            pintar("negro", "A4");
                            pintar("negro", "A5");
                            pintar("negro", "A6");
                            comprobacion = true;
                        }
                        if ((A5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "A3");
                            pintar("negro", "A4");
                            pintar("negro", "A5");
                            pintar("negro", "A6");
                            pintar("negro", "A7");
                            comprobacion = true;
                        }
                    }

                }
                if (colorJ == "blanco")
                {
                    /*horizontal derecha*/
                    if (B2.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (C2.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "B2");
                            comprobacion = true;
                        }
                        if ((D2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C2.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B2");
                            pintar("blanco", "C2");
                            comprobacion = true;
                        }

                        if ((E2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C2.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B2");
                            pintar("blanco", "C2");
                            pintar("blanco", "D2");
                            comprobacion = true;
                        }
                        if ((F2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C2.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B2");
                            pintar("blanco", "C2");
                            pintar("blanco", "D2");
                            pintar("blanco", "E2");
                            comprobacion = true;
                        }
                        if ((G2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C2.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B2");
                            pintar("blanco", "C2");
                            pintar("blanco", "D2");
                            pintar("blanco", "E2");
                            pintar("blanco", "F2");
                            comprobacion = true;
                        }
                        if ((G2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C2.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B2");
                            pintar("blanco", "C2");
                            pintar("blanco", "D2");
                            pintar("blanco", "E2");
                            pintar("blanco", "F2");
                            pintar("blanco", "G2");
                            comprobacion = true;
                        }


                    }
                    /*vertical abajo*/
                    if (A3.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (A4.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "A3");
                            comprobacion = true;
                        }
                        if ((A5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "A3");
                            pintar("blanco", "A4");
                            comprobacion = true;
                        }
                        if ((A5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "A3");
                            pintar("blanco", "A4");
                            pintar("blanco", "A5");
                            comprobacion = true;
                        }
                        if ((A5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "A3");
                            pintar("blanco", "A4");
                            pintar("blanco", "A5");
                            pintar("blanco", "A6");
                            comprobacion = true;
                        }
                        if ((A5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "A3");
                            pintar("blanco", "A4");
                            pintar("blanco", "A5");
                            pintar("blanco", "A6");
                            pintar("blanco", "A7");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true)
                {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
            }

            if (Posicion == "B2")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {

                    /*horizontal derecha*/
                    if (C2.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (D2.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "C2");
                            comprobacion = true;
                        }

                        if ((E2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D2.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C2");
                            pintar("negro", "D2");
                            comprobacion = true;
                        }
                        if ((F2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D2.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C2");
                            pintar("negro", "D2");
                            pintar("negro", "E2");
                            comprobacion = true;
                        }
                        if ((G2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D2.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C2");
                            pintar("negro", "D2");
                            pintar("negro", "E2");
                            pintar("negro", "F2");
                            comprobacion = true;
                        }
                        if ((G2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D2.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C2");
                            pintar("negro", "D2");
                            pintar("negro", "E2");
                            pintar("negro", "F2");
                            pintar("negro", "G2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (B3.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (B4.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "B3");
                            comprobacion = true;
                        }
                        if ((B5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B3");
                            pintar("negro", "B4");
                            comprobacion = true;
                        }
                        if ((B5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B3");
                            pintar("negro", "B4");
                            pintar("negro", "B5");
                            comprobacion = true;
                        }
                        if ((B5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B3");
                            pintar("negro", "B4");
                            pintar("negro", "B5");
                            pintar("negro", "B6");
                            comprobacion = true;
                        }
                        if ((B5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B3");
                            pintar("negro", "B4");
                            pintar("negro", "B5");
                            pintar("negro", "B6");
                            pintar("negro", "B7");
                            comprobacion = true;
                        }
                    }
                    /*diagonal hacia abajo derecha*/
                    if (C3.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (D4.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "C3");
                            comprobacion = true;
                        }
                        if ((E5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C3");
                            pintar("negro", "D4");
                            comprobacion = true;
                        }
                        if ((E5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C3");
                            pintar("negro", "D4");
                            pintar("negro", "E5");
                            comprobacion = true;
                        }
                        if ((E5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C3");
                            pintar("negro", "D4");
                            pintar("negro", "E5");
                            pintar("negro", "F6");
                            comprobacion = true;
                        }
                        if ((E5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C3");
                            pintar("negro", "D4");
                            pintar("negro", "E5");
                            pintar("negro", "F6");
                            pintar("negro", "G7");
                            comprobacion = true;
                        }
                    }

                }
                if (colorJ == "blanco")
                {
                    /*horizontal derecha*/
                    if (C2.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (D2.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "C2");
                            comprobacion = true;
                        }

                        if ((E2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D2.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C2");
                            pintar("blanco", "D2");
                            comprobacion = true;
                        }
                        if ((F2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D2.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C2");
                            pintar("blanco", "D2");
                            pintar("blanco", "E2");
                            comprobacion = true;
                        }
                        if ((G2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E2.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C2");
                            pintar("blanco", "D2");
                            pintar("blanco", "E2");
                            pintar("blanco", "F2");
                            comprobacion = true;
                        }
                        if ((G2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C2");
                            pintar("blanco", "D2");
                            pintar("blanco", "E2");
                            pintar("blanco", "F2");
                            pintar("blanco", "G2");
                            comprobacion = true;
                        }


                    }
                    /*vertical abajo*/
                    if (B3.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (B4.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "B3");
                            comprobacion = true;
                        }
                        if ((B5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B3");
                            pintar("blanco", "B4");
                            comprobacion = true;
                        }
                        if ((B5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B3");
                            pintar("blanco", "B4");
                            pintar("blanco", "B5");
                            comprobacion = true;
                        }
                        if ((B5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B3");
                            pintar("blanco", "B4");
                            pintar("blanco", "B5");
                            pintar("blanco", "B6");
                            comprobacion = true;
                        }
                        if ((B5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B3");
                            pintar("blanco", "B4");
                            pintar("blanco", "B5");
                            pintar("blanco", "B6");
                            pintar("blanco", "B7");
                            comprobacion = true;
                        }
                    }
                    /*diagonal hacia abajo derecha*/
                    if (C3.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (D4.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "C3");
                            comprobacion = true;
                        }
                        if ((E5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C3");
                            pintar("blanco", "D4");
                            comprobacion = true;
                        }
                        if ((E5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C3");
                            pintar("blanco", "D4");
                            pintar("blanco", "E5");
                            comprobacion = true;
                        }
                        if ((E5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C3");
                            pintar("blanco", "D4");
                            pintar("blanco", "E5");
                            pintar("blanco", "F6");
                            comprobacion = true;
                        }
                        if ((E5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C3");
                            pintar("blanco", "D4");
                            pintar("blanco", "E5");
                            pintar("blanco", "F6");
                            pintar("blanco", "G7");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true)
                {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
            }

            if (Posicion == "C2")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {
                    /*horizontal izquierda*/
                    if (B2.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (A2.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "B2");
                            comprobacion = true;
                        }
                    }
                    /*horizontal derecha*/
                    if (D2.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (E2.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "D2");
                            comprobacion = true;
                        }
                        if ((F2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E2.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D2");
                            pintar("negro", "E2");
                            comprobacion = true;
                        }
                        if ((G2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E2.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D2");
                            pintar("negro", "E2");
                            pintar("negro", "F2");
                            comprobacion = true;
                        }
                        if ((G2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D2");
                            pintar("negro", "E2");
                            pintar("negro", "F2");
                            pintar("negro", "G2");
                            comprobacion = true;
                        }
                    }

                    /*vertical abajo*/
                    if (C3.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (C4.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "C3");
                            comprobacion = true;
                        }
                        if ((C5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C3");
                            pintar("negro", "C4");
                            comprobacion = true;
                        }
                        if ((C5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C3");
                            pintar("negro", "C4");
                            pintar("negro", "C5");
                            comprobacion = true;
                        }
                        if ((C5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C3");
                            pintar("negro", "C4");
                            pintar("negro", "C5");
                            pintar("negro", "C6");
                            comprobacion = true;
                        }
                        if ((C5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C3");
                            pintar("negro", "C4");
                            pintar("negro", "C5");
                            pintar("negro", "C6");
                            pintar("negro", "C7");
                            comprobacion = true;
                        }
                    }
                    /*diagonal hacia abajo derecha*/
                    if (D3.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (E4.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "D3");
                            comprobacion = true;
                        }
                        if ((F5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D3");
                            pintar("negro", "E4");
                            comprobacion = true;
                        }
                        if ((F5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D3");
                            pintar("negro", "E4");
                            pintar("negro", "F5");
                            comprobacion = true;
                        }
                        if ((F5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D3");
                            pintar("negro", "E4");
                            pintar("negro", "F5");
                            pintar("negro", "G6");
                            comprobacion = true;
                        }
                    }

                }
                if (colorJ == "blanco")
                {
                    /*horizontal izquierda*/
                    if (B2.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (A2.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "B2");
                            comprobacion = true;
                        }
                    }

                    /*horizontal derecha*/
                    if (D2.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (E2.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "D2");
                            comprobacion = true;
                        }
                        if ((F2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E2.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D2");
                            pintar("blanco", "E2");
                            comprobacion = true;
                        }
                        if ((F2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E2.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D2");
                            pintar("blanco", "E2");
                            pintar("blanco", "F2");
                            comprobacion = true;
                        }
                        if ((H2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E2.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D2");
                            pintar("blanco", "E2");
                            pintar("blanco", "F2");
                            pintar("blanco", "G2");
                            comprobacion = true;
                        }


                    }
                    /*vertical abajo*/
                    if (C3.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (C4.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "C3");
                            comprobacion = true;
                        }
                        if ((C5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C3");
                            pintar("blanco", "C4");
                            comprobacion = true;
                        }
                        if ((C5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C3");
                            pintar("blanco", "C4");
                            pintar("blanco", "C5");
                            comprobacion = true;
                        }
                        if ((C5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C3");
                            pintar("blanco", "C4");
                            pintar("blanco", "C5");
                            pintar("blanco", "C6");
                            comprobacion = true;
                        }
                        if ((C5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C3");
                            pintar("blanco", "C4");
                            pintar("blanco", "C5");
                            pintar("blanco", "C6");
                            pintar("blanco", "C7");
                            comprobacion = true;
                        }
                    }
                    /*diagonal hacia abajo derecha*/
                    if (D3.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (E4.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "D3");
                            comprobacion = true;
                        }
                        if ((F5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D3");
                            pintar("blanco", "E4");
                            comprobacion = true;
                        }
                        if ((F5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D3");
                            pintar("blanco", "E4");
                            pintar("blanco", "F5");
                            comprobacion = true;
                        }
                        if ((F5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D3");
                            pintar("blanco", "E4");
                            pintar("blanco", "F5");
                            pintar("blanco", "G6");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true)
                {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
            }

            if (Posicion == "D2")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {
                    /*horizontal izquierda*/
                    if (C2.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (B2.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "C2");
                            comprobacion = true;
                        }
                        if ((A2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B2.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C2");
                            pintar("negro", "B2");
                            comprobacion = true;
                        }
                    }
                    /*horizontal derecha*/
                    if (E2.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (F2.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "E2");
                            comprobacion = true;
                        }
                        if ((G2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F2.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E2");
                            pintar("negro", "F2");
                            comprobacion = true;
                        }
                        if ((G2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H2.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("negro", "E2");
                            pintar("negro", "F2");
                            pintar("negro", "G2");
                            comprobacion = true;
                        }
                    }

                    /*vertical abajo*/
                    if (D3.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (D4.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "D3");
                            comprobacion = true;
                        }
                        if ((D5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D3");
                            pintar("negro", "D4");
                            comprobacion = true;
                        }
                        if ((D5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D3");
                            pintar("negro", "D4");
                            pintar("negro", "D5");
                            comprobacion = true;
                        }
                        if ((D5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D3");
                            pintar("negro", "D4");
                            pintar("negro", "D5");
                            pintar("negro", "D6");
                            comprobacion = true;
                        }
                        if ((D5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D3");
                            pintar("negro", "D4");
                            pintar("negro", "D5");
                            pintar("negro", "D6");
                            pintar("negro", "D7");
                            comprobacion = true;
                        }
                    }
                    /*diagonal hacia abajo izquierda*/
                    if (E3.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (F4.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "E3");
                            comprobacion = true;
                        }
                        if ((G5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E3");
                            pintar("negro", "F4");
                            comprobacion = true;
                        }
                        if ((G5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E3");
                            pintar("negro", "F4");
                            pintar("negro", "G5");
                            comprobacion = true;
                        }
                    }

                }
                if (colorJ == "blanco")
                {
                    /*horizontal izquierda*/
                    if (C2.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (B2.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "C2");
                            comprobacion = true;
                        }
                        if ((B2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A2.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("blanco", "C2");
                            pintar("blanco", "B2");
                            comprobacion = true;
                        }
                    }

                    /*horizontal derecha*/
                    if (E2.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (F2.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "E2");
                            comprobacion = true;
                        }
                        if ((F2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G2.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("blanco", "E2");
                            pintar("blanco", "F2");
                            comprobacion = true;
                        }
                        if ((H2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G2.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E2");
                            pintar("blanco", "F2");
                            pintar("blanco", "G2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (D3.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (D4.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "D3");
                            comprobacion = true;
                        }
                        if ((D5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D3");
                            pintar("blanco", "D4");
                            comprobacion = true;
                        }
                        if ((D5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D3");
                            pintar("blanco", "D4");
                            pintar("blanco", "D5");
                            comprobacion = true;
                        }
                        if ((D5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D3");
                            pintar("blanco", "D4");
                            pintar("blanco", "D5");
                            pintar("blanco", "D6");
                            comprobacion = true;
                        }
                        if ((D5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D3");
                            pintar("blanco", "D4");
                            pintar("blanco", "D5");
                            pintar("blanco", "D6");
                            pintar("blanco", "D7");
                            comprobacion = true;
                        }
                    }
                    /*diagonal hacia abajo derecha*/
                    if (E3.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (F4.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "E3");
                            comprobacion = true;
                        }
                        if ((G5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E3");
                            pintar("blanco", "F4");
                            comprobacion = true;
                        }
                        if ((G5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E3");
                            pintar("blanco", "F4");
                            pintar("blanco", "G5");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true)
                {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
            }

            if (Posicion == "E2")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {
                    /*horizontal izquierda*/
                    if (D2.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (C2.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "D2");
                            comprobacion = true;
                        }
                        if ((B2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C2.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D2");
                            pintar("negro", "C2");
                            comprobacion = true;
                        }
                        if ((A2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C2.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D3");
                            pintar("negro", "C3");
                            pintar("negro", "B3");
                            comprobacion = true;
                        }
                    }
                    /*horizontal derecha*/
                    if (F2.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (G2.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "F2");
                            comprobacion = true;
                        }
                        if ((H2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G2.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F2");
                            pintar("negro", "G2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (E3.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (E4.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "E3");
                            comprobacion = true;
                        }
                        if ((E5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E3");
                            pintar("negro", "E4");
                            comprobacion = true;
                        }
                        if ((E5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E3");
                            pintar("negro", "E4");
                            pintar("negro", "E5");
                            comprobacion = true;
                        }
                        if ((E5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E3");
                            pintar("negro", "E4");
                            pintar("negro", "E5");
                            pintar("negro", "E6");
                            comprobacion = true;
                        }
                        if ((E5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E3");
                            pintar("negro", "E4");
                            pintar("negro", "E5");
                            pintar("negro", "E6");
                            pintar("negro", "E7");
                            comprobacion = true;
                        }
                    }
                    /*diagonal hacia abajo derecha*/
                    if (F3.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (G4.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "F3");
                            comprobacion = true;
                        }
                        if ((H5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F3");
                            pintar("negro", "G4");
                            comprobacion = true;
                        }
                    }

                }
                if (colorJ == "blanco")
                {
                    /*horizontal izquierda*/
                    if (D2.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (C2.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "D2");
                            comprobacion = true;
                        }
                        if ((B2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C2.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D2");
                            pintar("blanco", "C2");
                            comprobacion = true;
                        }
                        if ((A2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C2.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D2");
                            pintar("blanco", "C2");
                            pintar("blanco", "B2");
                            comprobacion = true;
                        }
                    }

                    /*horizontal derecha*/
                    if (E2.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (G2.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "F2");
                            comprobacion = true;
                        }
                        if ((H2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G2.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F2");
                            pintar("blanco", "G2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (E3.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (E4.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "E3");
                            comprobacion = true;
                        }
                        if ((E5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E3");
                            pintar("blanco", "E4");
                            comprobacion = true;
                        }
                        if ((E5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E3");
                            pintar("blanco", "E4");
                            pintar("blanco", "E5");
                            comprobacion = true;
                        }
                        if ((E5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E3");
                            pintar("blanco", "E4");
                            pintar("blanco", "E5");
                            pintar("blanco", "E6");
                            comprobacion = true;
                        }
                        if ((E5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E3");
                            pintar("blanco", "E4");
                            pintar("blanco", "E5");
                            pintar("blanco", "E6");
                            pintar("blanco", "E7");
                            comprobacion = true;
                        }
                    }
                    /*diagonal hacia abajo derecha*/
                    if (F3.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (G4.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "F3");
                            comprobacion = true;
                        }
                        if ((H5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F3");
                            pintar("blanco", "G4");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true)
                {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
            }

            if (Posicion == "F2")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {
                    /*horizontal izquierda*/
                    if (E2.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (D2.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "E2");
                            comprobacion = true;
                        }
                        if ((C2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D2.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E2");
                            pintar("negro", "D2");
                            comprobacion = true;
                        }
                        if ((B2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D2.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E2");
                            pintar("negro", "D2");
                            pintar("negro", "C2");
                            comprobacion = true;
                        }
                        if ((A2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D2.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E2");
                            pintar("negro", "D2");
                            pintar("negro", "C2");
                            pintar("negro", "B2");
                            comprobacion = true;
                        }
                    }
                    /*horizontal derecha*/
                    if (G2.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (H2.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "G2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (F3.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (F4.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "F3");
                            comprobacion = true;
                        }
                        if ((F5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F3");
                            pintar("negro", "F4");
                            comprobacion = true;
                        }
                        if ((F5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F3");
                            pintar("negro", "F4");
                            pintar("negro", "F5");
                            comprobacion = true;
                        }
                        if ((F5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F3");
                            pintar("negro", "F4");
                            pintar("negro", "F5");
                            pintar("negro", "F6");
                            comprobacion = true;
                        }
                        if ((F5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F3");
                            pintar("negro", "F4");
                            pintar("negro", "F5");
                            pintar("negro", "F6");
                            pintar("negro", "F7");
                            comprobacion = true;
                        }
                    }

                }
                if (colorJ == "blanco")
                {
                    /*horizontal izquierda*/
                    if (E2.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (D2.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "E2");
                            comprobacion = true;
                        }
                        if ((C2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D2.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E2");
                            pintar("blanco", "D2");
                            comprobacion = true;
                        }
                        if ((B2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D2.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E2");
                            pintar("blanco", "D2");
                            pintar("blanco", "C2");
                            comprobacion = true;
                        }
                        if ((A2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D2.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E2");
                            pintar("blanco", "D2");
                            pintar("blanco", "C2");
                            pintar("blanco", "B2");
                            comprobacion = true;
                        }
                    }

                    /*horizontal derecha*/
                    if (G2.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (H2.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "G2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (F3.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (F4.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "F3");
                            comprobacion = true;
                        }
                        if ((F5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F3");
                            pintar("blanco", "F4");
                            comprobacion = true;
                        }
                        if ((F5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F3");
                            pintar("blanco", "F4");
                            pintar("blanco", "F5");
                            comprobacion = true;
                        }
                        if ((F5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F3");
                            pintar("blanco", "F4");
                            pintar("blanco", "F5");
                            pintar("blanco", "F6");
                            comprobacion = true;
                        }
                        if ((F5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F3");
                            pintar("blanco", "F4");
                            pintar("blanco", "F5");
                            pintar("blanco", "F6");
                            pintar("blanco", "F7");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true)
                {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
            }

            if (Posicion == "G2")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {
                    /*horizontal izquierda*/
                    if (F2.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (E2.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "F2");
                            comprobacion = true;
                        }
                        if ((D2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E2.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F2");
                            pintar("negro", "E2");
                            comprobacion = true;
                        }
                        if ((C2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E2.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F2");
                            pintar("negro", "E2");
                            pintar("negro", "D2");
                            comprobacion = true;
                        }
                        if ((B2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E2.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F2");
                            pintar("negro", "E2");
                            pintar("negro", "D2");
                            pintar("negro", "C2");
                            comprobacion = true;
                        }
                        if ((A2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E2.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F2");
                            pintar("negro", "E2");
                            pintar("negro", "D2");
                            pintar("negro", "C2");
                            pintar("negro", "B2");
                            comprobacion = true;
                        }
                    }

                    
                    /*vertical abajo*/
                    if (G3.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (G4.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "G3");
                            comprobacion = true;
                        }
                        if ((G5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G3");
                            pintar("negro", "G4");
                            comprobacion = true;
                        }
                        if ((G5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G3");
                            pintar("negro", "G4");
                            pintar("negro", "G5");
                            comprobacion = true;
                        }
                        if ((G5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G3");
                            pintar("negro", "G4");
                            pintar("negro", "G5");
                            pintar("negro", "G6");
                            comprobacion = true;
                        }
                        if ((G5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G3");
                            pintar("negro", "G4");
                            pintar("negro", "G5");
                            pintar("negro", "G6");
                            pintar("negro", "G7");
                            comprobacion = true;
                        }
                    }

                }
                if (colorJ == "blanco")
                {
                    /*horizontal izquierda*/
                    if (F2.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (E2.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "F2");
                            comprobacion = true;
                        }
                        if ((D2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E2.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F2");
                            pintar("blanco", "E2");
                            comprobacion = true;
                        }
                        if ((C2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E2.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F2");
                            pintar("blanco", "E2");
                            pintar("blanco", "D2");
                            comprobacion = true;
                        }
                        if ((B2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E2.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F2");
                            pintar("blanco", "E2");
                            pintar("blanco", "D2");
                            pintar("blanco", "C2");
                            comprobacion = true;
                        }
                        if ((A2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E2.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F2");
                            pintar("blanco", "E2");
                            pintar("blanco", "D2");
                            pintar("blanco", "C2");
                            pintar("blanco", "B2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (G3.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (G4.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "G3");
                            comprobacion = true;
                        }
                        if ((G5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G3");
                            pintar("blanco", "G4");
                            comprobacion = true;
                        }
                        if ((G5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G3");
                            pintar("blanco", "G4");
                            pintar("blanco", "G5");
                            comprobacion = true;
                        }
                        if ((G5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G3");
                            pintar("blanco", "G4");
                            pintar("blanco", "G5");
                            pintar("blanco", "G6");
                            comprobacion = true;
                        }
                        if ((G5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G3");
                            pintar("blanco", "G4");
                            pintar("blanco", "G5");
                            pintar("blanco", "G6");
                            pintar("blanco", "G7");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true)
                {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
            }

            if (Posicion == "H2")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {
                    /*horizontal izquierda*/
                    if (G2.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (F2.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "G2");
                            comprobacion = true;
                        }
                        if ((E2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F2.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G2");
                            pintar("negro", "F2");
                            comprobacion = true;
                        }
                        if ((D2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F2.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G2");
                            pintar("negro", "F2");
                            pintar("negro", "E2");
                            comprobacion = true;
                        }
                        if ((C2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F2.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G2");
                            pintar("negro", "F2");
                            pintar("negro", "E2");
                            pintar("negro", "D2");
                            comprobacion = true;
                        }
                        if ((B2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F2.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G2");
                            pintar("negro", "F2");
                            pintar("negro", "E2");
                            pintar("negro", "D2");
                            pintar("negro", "C2");
                            comprobacion = true;
                        }
                        if ((A2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F2.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G2");
                            pintar("negro", "F2");
                            pintar("negro", "E2");
                            pintar("negro", "D2");
                            pintar("negro", "C2");
                            pintar("negro", "B2");
                            comprobacion = true;
                        }
                    }
                                        
                    /*vertical abajo*/
                    if (H3.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (H4.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "H3");
                            comprobacion = true;
                        }
                        if ((H5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "H3");
                            pintar("negro", "H4");
                            comprobacion = true;
                        }
                        if ((H5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "H3");
                            pintar("negro", "H4");
                            pintar("negro", "H5");
                            comprobacion = true;
                        }
                        if ((H5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "H3");
                            pintar("negro", "H4");
                            pintar("negro", "H5");
                            pintar("negro", "H6");
                            comprobacion = true;
                        }
                        if ((H5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "H3");
                            pintar("negro", "H4");
                            pintar("negro", "H5");
                            pintar("negro", "H6");
                            pintar("negro", "H7");
                            comprobacion = true;
                        }
                    }

                }
                if (colorJ == "blanco")
                {
                    /*horizontal izquierda*/
                    if (G2.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (F2.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "G2");
                            comprobacion = true;
                        }
                        if ((E2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F2.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G2");
                            pintar("blanco", "F2");
                            comprobacion = true;
                        }
                        if ((D2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F2.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G2");
                            pintar("blanco", "F2");
                            pintar("blanco", "E2");
                            comprobacion = true;
                        }
                        if ((C2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F2.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G2");
                            pintar("blanco", "F2");
                            pintar("blanco", "E2");
                            pintar("blanco", "D2");
                            comprobacion = true;
                        }
                        if ((B2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F2.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G2");
                            pintar("blanco", "F2");
                            pintar("blanco", "E2");
                            pintar("blanco", "D2");
                            pintar("blanco", "C2");
                            comprobacion = true;
                        }
                        if ((A2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F2.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G2");
                            pintar("blanco", "F2");
                            pintar("blanco", "E2");
                            pintar("blanco", "D2");
                            pintar("blanco", "C2");
                            pintar("blanco", "B2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (H3.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (H4.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "H3");
                            comprobacion = true;
                        }
                        if ((H5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "H3");
                            pintar("blanco", "H4");
                            comprobacion = true;
                        }
                        if ((H5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "H3");
                            pintar("blanco", "H4");
                            pintar("blanco", "H5");
                            comprobacion = true;
                        }
                        if ((H5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "H3");
                            pintar("blanco", "H4");
                            pintar("blanco", "H5");
                            pintar("blanco", "H6");
                            comprobacion = true;
                        }
                        if ((H5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "H3");
                            pintar("blanco", "H4");
                            pintar("blanco", "H5");
                            pintar("blanco", "H6");
                            pintar("blanco", "H7");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true)
                {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
            }



            if (Posicion == "A1")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {

                    /*horizontal derecha*/
                    if (B1.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (C1.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "B1");
                            comprobacion = true;
                        }
                        if ((D1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C1.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B1");
                            pintar("negro", "C1");
                            comprobacion = true;
                        }

                        if ((E1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C1.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B1");
                            pintar("negro", "C1");
                            pintar("negro", "D1");
                            comprobacion = true;
                        }
                        if ((F1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C1.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B1");
                            pintar("negro", "C1");
                            pintar("negro", "D1");
                            pintar("negro", "E1");
                            comprobacion = true;
                        }
                        if ((G1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C1.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B1");
                            pintar("negro", "C1");
                            pintar("negro", "D1");
                            pintar("negro", "E1");
                            pintar("negro", "F1");
                            comprobacion = true;
                        }
                        if ((G1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C1.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B1");
                            pintar("negro", "C1");
                            pintar("negro", "D1");
                            pintar("negro", "E1");
                            pintar("negro", "F1");
                            pintar("negro", "G1");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (A2.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (A3.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "A2");
                            comprobacion = true;
                        }
                        if ((A4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "A2");
                            pintar("negro", "A3");
                            comprobacion = true;
                        }
                        if ((A5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "A2");
                            pintar("negro", "A3");
                            pintar("negro", "A4");
                            comprobacion = true;
                        }
                        if ((A5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "A2");
                            pintar("negro", "A3");
                            pintar("negro", "A4");
                            pintar("negro", "A5");
                            comprobacion = true;
                        }
                        if ((A5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "A2");
                            pintar("negro", "A3");
                            pintar("negro", "A4");
                            pintar("negro", "A5");
                            pintar("negro", "A6");
                            comprobacion = true;
                        }
                        if ((A5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "A2");
                            pintar("negro", "A3");
                            pintar("negro", "A4");
                            pintar("negro", "A5");
                            pintar("negro", "A6");
                            pintar("negro", "A7");
                            comprobacion = true;
                        }
                    }
                    /*diagonal hacia abajo derecha*/
                    if (B2.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (C3.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "B2");
                            comprobacion = true;
                        }
                        if ((D4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B2");
                            pintar("negro", "C3");
                            comprobacion = true;
                        }
                        if ((E5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B2");
                            pintar("negro", "C3");
                            pintar("negro", "D4");
                            comprobacion = true;
                        }
                        if ((E5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B2");
                            pintar("negro", "C3");
                            pintar("negro", "D4");
                            pintar("negro", "E5");
                            comprobacion = true;
                        }
                        if ((E5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B2");
                            pintar("negro", "C3");
                            pintar("negro", "D4");
                            pintar("negro", "E5");
                            pintar("negro", "F6");
                            comprobacion = true;
                        }
                        if ((E5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B2");
                            pintar("negro", "C3");
                            pintar("negro", "D4");
                            pintar("negro", "E5");
                            pintar("negro", "F6");
                            pintar("negro", "G7");
                            comprobacion = true;
                        }
                    }

                }
                if (colorJ == "blanco")
                {
                    /*horizontal derecha*/
                    if (B1.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (C1.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "B1");
                            comprobacion = true;
                        }
                        if ((D1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C1.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B1");
                            pintar("blanco", "C1");
                            comprobacion = true;
                        }

                        if ((E1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C1.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B1");
                            pintar("blanco", "C1");
                            pintar("blanco", "D1");
                            comprobacion = true;
                        }
                        if ((F1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C1.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B1");
                            pintar("blanco", "C1");
                            pintar("blanco", "D1");
                            pintar("blanco", "E1");
                            comprobacion = true;
                        }
                        if ((G1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C1.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B1");
                            pintar("blanco", "C1");
                            pintar("blanco", "D1");
                            pintar("blanco", "E1");
                            pintar("blanco", "F1");
                            comprobacion = true;
                        }
                        if ((G1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C1.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B1");
                            pintar("blanco", "C1");
                            pintar("blanco", "D1");
                            pintar("blanco", "E1");
                            pintar("blanco", "F1");
                            pintar("blanco", "G1");
                            comprobacion = true;
                        }


                    }
                    /*vertical abajo*/
                    if (A2.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (A3.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "A2");
                            comprobacion = true;
                        }
                        if ((A4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "A2");
                            pintar("blanco", "A3");
                            comprobacion = true;
                        }
                        if ((A5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "A2");
                            pintar("blanco", "A3");
                            pintar("blanco", "A4");
                            comprobacion = true;
                        }
                        if ((A5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "A2");
                            pintar("blanco", "A3");
                            pintar("blanco", "A4");
                            pintar("blanco", "A5");
                            comprobacion = true;
                        }
                        if ((A5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "A2");
                            pintar("blanco", "A3");
                            pintar("blanco", "A4");
                            pintar("blanco", "A5");
                            pintar("blanco", "A6");
                            comprobacion = true;
                        }
                        if ((A5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "A2");
                            pintar("blanco", "A3");
                            pintar("blanco", "A4");
                            pintar("blanco", "A5");
                            pintar("blanco", "A6");
                            pintar("blanco", "A7");
                            comprobacion = true;
                        }
                    }
                    /*diagonal hacia abajo derecha*/
                    if (B2.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (C3.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "B2");
                            comprobacion = true;
                        }
                        if ((D4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B2");
                            pintar("blanco", "C3");
                            comprobacion = true;
                        }
                        if ((E5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B2");
                            pintar("blanco", "C3");
                            pintar("blanco", "D4");
                            comprobacion = true;
                        }
                        if ((E5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B2");
                            pintar("blanco", "C3");
                            pintar("blanco", "D4");
                            pintar("blanco", "E5");
                            comprobacion = true;
                        }
                        if ((E5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B2");
                            pintar("blanco", "C3");
                            pintar("blanco", "D4");
                            pintar("blanco", "E5");
                            pintar("blanco", "F6");
                            comprobacion = true;
                        }
                        if ((E5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B2");
                            pintar("blanco", "C3");
                            pintar("blanco", "D4");
                            pintar("blanco", "E5");
                            pintar("blanco", "F6");
                            pintar("blanco", "G7");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true)
                {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
            }

            if (Posicion == "B1")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {

                    /*horizontal derecha*/
                    if (C1.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (D1.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "C1");
                            comprobacion = true;
                        }

                        if ((E1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D1.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C1");
                            pintar("negro", "D1");
                            comprobacion = true;
                        }
                        if ((F1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D1.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C1");
                            pintar("negro", "D1");
                            pintar("negro", "E1");
                            comprobacion = true;
                        }
                        if ((G1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D1.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C1");
                            pintar("negro", "D1");
                            pintar("negro", "E1");
                            pintar("negro", "F1");
                            comprobacion = true;
                        }
                        if ((G1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D1.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C1");
                            pintar("negro", "D1");
                            pintar("negro", "E1");
                            pintar("negro", "F1");
                            pintar("negro", "G1");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (B2.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (B3.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "B2");
                            comprobacion = true;
                        }
                        if ((B4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B2");
                            pintar("negro", "B3");
                            comprobacion = true;
                        }
                        if ((B5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B2");
                            pintar("negro", "B3");
                            pintar("negro", "B4");
                            comprobacion = true;
                        }
                        if ((B5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B2");
                            pintar("negro", "B3");
                            pintar("negro", "B4");
                            pintar("negro", "B5");
                            comprobacion = true;
                        }
                        if ((B5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B2");
                            pintar("negro", "B3");
                            pintar("negro", "B4");
                            pintar("negro", "B5");
                            pintar("negro", "B6");
                            comprobacion = true;
                        }
                        if ((B5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B2");
                            pintar("negro", "B3");
                            pintar("negro", "B4");
                            pintar("negro", "B5");
                            pintar("negro", "B6");
                            pintar("negro", "B7");
                            comprobacion = true;
                        }
                    }
                    /*diagonal hacia abajo derecha*/
                    if (C2.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (D3.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "C2");
                            comprobacion = true;
                        }
                        if ((E4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C2");
                            pintar("negro", "D3");
                            comprobacion = true;
                        }
                        if ((F5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C2");
                            pintar("negro", "D3");
                            pintar("negro", "E4");
                            comprobacion = true;
                        }
                        if ((F5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C2");
                            pintar("negro", "D3");
                            pintar("negro", "E4");
                            pintar("negro", "F5");
                            comprobacion = true;
                        }
                        if ((F5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C2");
                            pintar("negro", "D3");
                            pintar("negro", "E4");
                            pintar("negro", "F5");
                            pintar("negro", "G6");
                            comprobacion = true;
                        }
                    }

                }
                if (colorJ == "blanco")
                {
                    /*horizontal derecha*/
                    if (C1.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (D1.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "C1");
                            comprobacion = true;
                        }

                        if ((E1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D1.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C1");
                            pintar("blanco", "D1");
                            comprobacion = true;
                        }
                        if ((F1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D1.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C1");
                            pintar("blanco", "D1");
                            pintar("blanco", "E1");
                            comprobacion = true;
                        }
                        if ((G1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E1.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C1");
                            pintar("blanco", "D1");
                            pintar("blanco", "E1");
                            pintar("blanco", "F1");
                            comprobacion = true;
                        }
                        if ((G1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C1");
                            pintar("blanco", "D1");
                            pintar("blanco", "E1");
                            pintar("blanco", "F1");
                            pintar("blanco", "G1");
                            comprobacion = true;
                        }


                    }
                    /*vertical abajo*/
                    if (B2.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (B3.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "B2");
                            comprobacion = true;
                        }
                        if ((B4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B2");
                            pintar("blanco", "B3");
                            comprobacion = true;
                        }
                        if ((B5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B2");
                            pintar("blanco", "B3");
                            pintar("blanco", "B4");
                            comprobacion = true;
                        }
                        if ((B5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B2");
                            pintar("blanco", "B3");
                            pintar("blanco", "B4");
                            pintar("blanco", "B5");
                            comprobacion = true;
                        }
                        if ((B5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B2");
                            pintar("blanco", "B3");
                            pintar("blanco", "B4");
                            pintar("blanco", "B5");
                            pintar("blanco", "B6");
                            comprobacion = true;
                        }
                        if ((B5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B2");
                            pintar("blanco", "B3");
                            pintar("blanco", "B4");
                            pintar("blanco", "B5");
                            pintar("blanco", "B6");
                            pintar("blanco", "B7");
                            comprobacion = true;
                        }
                    }
                    /*diagonal hacia abajo derecha*/
                    if (C2.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (D3.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "C2");
                            comprobacion = true;
                        }
                        if ((E4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C2");
                            pintar("blanco", "D3");
                            comprobacion = true;
                        }
                        if ((F5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C2");
                            pintar("blanco", "D3");
                            pintar("blanco", "E4");
                            comprobacion = true;
                        }
                        if ((F5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C2");
                            pintar("blanco", "D3");
                            pintar("blanco", "E4");
                            pintar("blanco", "F5");
                            comprobacion = true;
                        }
                        if ((F5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C2");
                            pintar("blanco", "D3");
                            pintar("blanco", "E4");
                            pintar("blanco", "F5");
                            pintar("blanco", "G6");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true)
                {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
            }

            if (Posicion == "C1")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {
                    /*horizontal izquierda*/
                    if (B1.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (A1.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "B1");
                            comprobacion = true;
                        }
                    }
                    /*horizontal derecha*/
                    if (D1.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (E1.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "D1");
                            comprobacion = true;
                        }
                        if ((F1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E1.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D1");
                            pintar("negro", "E1");
                            comprobacion = true;
                        }
                        if ((G1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E1.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D1");
                            pintar("negro", "E1");
                            pintar("negro", "F1");
                            comprobacion = true;
                        }
                        if ((G1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D1");
                            pintar("negro", "E1");
                            pintar("negro", "F1");
                            pintar("negro", "G1");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (C2.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (C3.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "C2");
                            comprobacion = true;
                        }
                        if ((C4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C2");
                            pintar("negro", "C3");
                            comprobacion = true;
                        }
                        if ((C5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C2");
                            pintar("negro", "C3");
                            pintar("negro", "C4");
                            comprobacion = true;
                        }
                        if ((C5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C2");
                            pintar("negro", "C3");
                            pintar("negro", "C4");
                            pintar("negro", "C5");
                            comprobacion = true;
                        }
                        if ((C5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C2");
                            pintar("negro", "C3");
                            pintar("negro", "C4");
                            pintar("negro", "C5");
                            pintar("negro", "C6");
                            comprobacion = true;
                        }
                        if ((C5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C2");
                            pintar("negro", "C3");
                            pintar("negro", "C4");
                            pintar("negro", "C5");
                            pintar("negro", "C6");
                            pintar("negro", "C7");
                            comprobacion = true;
                        }
                    }
                    /*diagonal hacia abajo derecha*/
                    if (D2.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (E3.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "D2");
                            comprobacion = true;
                        }
                        if ((F4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D2");
                            pintar("negro", "E3");
                            comprobacion = true;
                        }
                        if ((G5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D2");
                            pintar("negro", "E3");
                            pintar("negro", "F4");
                            comprobacion = true;
                        }
                        if ((G5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D2");
                            pintar("negro", "E3");
                            pintar("negro", "F4");
                            pintar("negro", "G5");
                            comprobacion = true;
                        }
                    }
                }
                if (colorJ == "blanco")
                {
                    /*horizontal izquierda*/
                    if (B1.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (A1.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "B1");
                            comprobacion = true;
                        }
                    }

                    /*horizontal derecha*/
                    if (D1.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (E1.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "D1");
                            comprobacion = true;
                        }
                        if ((F1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E1.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D1");
                            pintar("blanco", "E1");
                            comprobacion = true;
                        }
                        if ((F1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E1.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D1");
                            pintar("blanco", "E1");
                            pintar("blanco", "F1");
                            comprobacion = true;
                        }
                        if ((H1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E1.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D1");
                            pintar("blanco", "E1");
                            pintar("blanco", "F1");
                            pintar("blanco", "G1");
                            comprobacion = true;
                        }


                    }
                    /*vertical abajo*/
                    if (C2.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (C3.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "C2");
                            comprobacion = true;
                        }
                        if ((C4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C2");
                            pintar("blanco", "C3");
                            comprobacion = true;
                        }
                        if ((C5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C2");
                            pintar("blanco", "C3");
                            pintar("blanco", "C4");
                            comprobacion = true;
                        }
                        if ((C5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C2");
                            pintar("blanco", "C3");
                            pintar("blanco", "C4");
                            pintar("blanco", "C5");
                            comprobacion = true;
                        }
                        if ((C5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C2");
                            pintar("blanco", "C3");
                            pintar("blanco", "C4");
                            pintar("blanco", "C5");
                            pintar("blanco", "C6");
                            comprobacion = true;
                        }
                        if ((C5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C2");
                            pintar("blanco", "C3");
                            pintar("blanco", "C4");
                            pintar("blanco", "C5");
                            pintar("blanco", "C6");
                            pintar("blanco", "C7");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (D2.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (E3.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "D2");
                            comprobacion = true;
                        }
                        if ((F4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D2");
                            pintar("blanco", "E3");
                            comprobacion = true;
                        }
                        if ((G5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D2");
                            pintar("blanco", "E3");
                            pintar("blanco", "F4");
                            comprobacion = true;
                        }
                        if ((G5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D2");
                            pintar("blanco", "E3");
                            pintar("blanco", "F4");
                            pintar("blanco", "G5");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true)
                {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
            }

            if (Posicion == "D1")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {
                    /*horizontal izquierda*/
                    if (C1.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (B1.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "C1");
                            comprobacion = true;
                        }
                        if ((A1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B1.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C1");
                            pintar("negro", "B1");
                            comprobacion = true;
                        }
                    }
                    /*horizontal derecha*/
                    if (E1.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (F1.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "E1");
                            comprobacion = true;
                        }
                        if ((G1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F1.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E1");
                            pintar("negro", "F1");
                            comprobacion = true;
                        }
                        if ((G1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H1.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("negro", "E1");
                            pintar("negro", "F1");
                            pintar("negro", "G1");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (D2.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (D3.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "D2");
                            comprobacion = true;
                        }
                        if ((D4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D2");
                            pintar("negro", "D3");
                            comprobacion = true;
                        }
                        if ((D5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D2");
                            pintar("negro", "D3");
                            pintar("negro", "D4");
                            comprobacion = true;
                        }
                        if ((D5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D2");
                            pintar("negro", "D3");
                            pintar("negro", "D4");
                            pintar("negro", "D5");
                            comprobacion = true;
                        }
                        if ((D5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D2");
                            pintar("negro", "D3");
                            pintar("negro", "D4");
                            pintar("negro", "D5");
                            pintar("negro", "D6");
                            comprobacion = true;
                        }
                        if ((D5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D2");
                            pintar("negro", "D3");
                            pintar("negro", "D4");
                            pintar("negro", "D5");
                            pintar("negro", "D6");
                            pintar("negro", "D7");
                            comprobacion = true;
                        }
                    }
                    /*diagonal hacia abajo derecha*/
                    if (E2.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (F3.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "E2");
                            comprobacion = true;
                        }
                        if ((G4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E2");
                            pintar("negro", "F3");
                            comprobacion = true;
                        }
                        if ((H5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E2");
                            pintar("negro", "F3");
                            pintar("negro", "G4");
                            comprobacion = true;
                        }
                    }

                }
                if (colorJ == "blanco")
                {
                    /*horizontal izquierda*/
                    if (C1.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (B1.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "C1");
                            comprobacion = true;
                        }
                        if ((B1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A1.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("blanco", "C1");
                            pintar("blanco", "B1");
                            comprobacion = true;
                        }
                    }

                    /*horizontal derecha*/
                    if (E1.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (F1.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "E1");
                            comprobacion = true;
                        }
                        if ((F1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G1.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("blanco", "E1");
                            pintar("blanco", "F1");
                            comprobacion = true;
                        }
                        if ((H1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G1.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E1");
                            pintar("blanco", "F1");
                            pintar("blanco", "G1");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (D2.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (D3.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "D2");
                            comprobacion = true;
                        }
                        if ((D4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D2");
                            pintar("blanco", "D3");
                            comprobacion = true;
                        }
                        if ((D5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D2");
                            pintar("blanco", "D3");
                            pintar("blanco", "D4");
                            comprobacion = true;
                        }
                        if ((D5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D2");
                            pintar("blanco", "D3");
                            pintar("blanco", "D4");
                            pintar("blanco", "D5");
                            comprobacion = true;
                        }
                        if ((D5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D2");
                            pintar("blanco", "D3");
                            pintar("blanco", "D4");
                            pintar("blanco", "D5");
                            pintar("blanco", "D6");
                            comprobacion = true;
                        }
                        if ((D5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D2");
                            pintar("blanco", "D3");
                            pintar("blanco", "D4");
                            pintar("blanco", "D5");
                            pintar("blanco", "D6");
                            pintar("blanco", "D7");
                            comprobacion = true;
                        }
                    }
                    /*diagonal hacia abajo derecha*/
                    if (E2.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (F3.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "E2");
                            comprobacion = true;
                        }
                        if ((G4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E2");
                            pintar("blanco", "F3");
                            comprobacion = true;
                        }
                        if ((H5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E2");
                            pintar("blanco", "F3");
                            pintar("blanco", "G4");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true)
                {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
            }
            /*ME quede aqui, diagonal de E1 a H4*/
            if (Posicion == "E1")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {
                    /*horizontal izquierda*/
                    if (D1.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (C1.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "D1");
                            comprobacion = true;
                        }
                        if ((B1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C1.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D1");
                            pintar("negro", "C1");
                            comprobacion = true;
                        }
                        if ((A1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C1.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D3");
                            pintar("negro", "C3");
                            pintar("negro", "B3");
                            comprobacion = true;
                        }
                    }
                    /*horizontal derecha*/
                    if (F1.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (G1.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "F1");
                            comprobacion = true;
                        }
                        if ((H1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G1.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F1");
                            pintar("negro", "G1");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (E2.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (E3.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "E2");
                            comprobacion = true;
                        }
                        if ((E4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E2");
                            pintar("negro", "E3");
                            comprobacion = true;
                        }
                        if ((E5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E2");
                            pintar("negro", "E3");
                            pintar("negro", "E4");
                            comprobacion = true;
                        }
                        if ((E5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E2");
                            pintar("negro", "E3");
                            pintar("negro", "E4");
                            pintar("negro", "E5");
                            comprobacion = true;
                        }
                        if ((E5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E2");
                            pintar("negro", "E3");
                            pintar("negro", "E4");
                            pintar("negro", "E5");
                            pintar("negro", "E6");
                            comprobacion = true;
                        }
                        if ((E5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E2");
                            pintar("negro", "E3");
                            pintar("negro", "E4");
                            pintar("negro", "E5");
                            pintar("negro", "E6");
                            pintar("negro", "E7");
                            comprobacion = true;
                        }
                    }

                }
                if (colorJ == "blanco")
                {
                    /*horizontal izquierda*/
                    if (D1.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (C1.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "D1");
                            comprobacion = true;
                        }
                        if ((B1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C1.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D1");
                            pintar("blanco", "C1");
                            comprobacion = true;
                        }
                        if ((A1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C1.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D1");
                            pintar("blanco", "C1");
                            pintar("blanco", "B1");
                            comprobacion = true;
                        }
                    }

                    /*horizontal derecha*/
                    if (E1.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (G1.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "F1");
                            comprobacion = true;
                        }
                        if ((H1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G1.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F1");
                            pintar("blanco", "G1");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (E2.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (E3.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "E2");
                            comprobacion = true;
                        }
                        if ((E4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E2");
                            pintar("blanco", "E3");
                            comprobacion = true;
                        }
                        if ((E5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E2");
                            pintar("blanco", "E3");
                            pintar("blanco", "E4");
                            comprobacion = true;
                        }
                        if ((E5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E2");
                            pintar("blanco", "E3");
                            pintar("blanco", "E4");
                            pintar("blanco", "E5");
                            comprobacion = true;
                        }
                        if ((E5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E2");
                            pintar("blanco", "E3");
                            pintar("blanco", "E4");
                            pintar("blanco", "E5");
                            pintar("blanco", "E6");
                            comprobacion = true;
                        }
                        if ((E5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E2");
                            pintar("blanco", "E3");
                            pintar("blanco", "E4");
                            pintar("blanco", "E5");
                            pintar("blanco", "E6");
                            pintar("blanco", "E7");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true)
                {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
            }

            if (Posicion == "F1")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {
                    /*horizontal izquierda*/
                    if (E1.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (D1.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "E1");
                            comprobacion = true;
                        }
                        if ((C1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D1.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E1");
                            pintar("negro", "D1");
                            comprobacion = true;
                        }
                        if ((B1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D1.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E1");
                            pintar("negro", "D1");
                            pintar("negro", "C1");
                            comprobacion = true;
                        }
                        if ((A1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D1.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E1");
                            pintar("negro", "D1");
                            pintar("negro", "C1");
                            pintar("negro", "B1");
                            comprobacion = true;
                        }
                    }
                    /*horizontal derecha*/
                    if (G1.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (H1.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "G1");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (F2.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (F3.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "F2");
                            comprobacion = true;
                        }
                        if ((F4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F2");
                            pintar("negro", "F3");
                            comprobacion = true;
                        }
                        if ((F5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F2");
                            pintar("negro", "F3");
                            pintar("negro", "F4");
                            comprobacion = true;
                        }
                        if ((F5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F2");
                            pintar("negro", "F3");
                            pintar("negro", "F4");
                            pintar("negro", "F5");
                            comprobacion = true;
                        }
                        if ((F5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F2");
                            pintar("negro", "F3");
                            pintar("negro", "F4");
                            pintar("negro", "F5");
                            pintar("negro", "F6");
                            comprobacion = true;
                        }
                        if ((F5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F2");
                            pintar("negro", "F3");
                            pintar("negro", "F4");
                            pintar("negro", "F5");
                            pintar("negro", "F6");
                            pintar("negro", "F7");
                            comprobacion = true;
                        }
                    }

                }
                if (colorJ == "blanco")
                {
                    /*horizontal izquierda*/
                    if (E1.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (D1.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "E1");
                            comprobacion = true;
                        }
                        if ((C1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D1.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E1");
                            pintar("blanco", "D1");
                            comprobacion = true;
                        }
                        if ((B1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D1.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E1");
                            pintar("blanco", "D1");
                            pintar("blanco", "C1");
                            comprobacion = true;
                        }
                        if ((A1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D1.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E1");
                            pintar("blanco", "D1");
                            pintar("blanco", "C1");
                            pintar("blanco", "B1");
                            comprobacion = true;
                        }
                    }

                    /*horizontal derecha*/
                    if (G1.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (H1.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "G1");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (F2.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (F3.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "F2");
                            comprobacion = true;
                        }
                        if ((F4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F2");
                            pintar("blanco", "F3");
                            comprobacion = true;
                        }
                        if ((F5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F2");
                            pintar("blanco", "F3");
                            pintar("blanco", "F4");
                            comprobacion = true;
                        }
                        if ((F5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F2");
                            pintar("blanco", "F3");
                            pintar("blanco", "F4");
                            pintar("blanco", "F5");
                            comprobacion = true;
                        }
                        if ((F5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F2");
                            pintar("blanco", "F3");
                            pintar("blanco", "F4");
                            pintar("blanco", "F5");
                            pintar("blanco", "F6");
                            comprobacion = true;
                        }
                        if ((F5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F2");
                            pintar("blanco", "F3");
                            pintar("blanco", "F4");
                            pintar("blanco", "F5");
                            pintar("blanco", "F6");
                            pintar("blanco", "F7");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true)
                {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
            }

            if (Posicion == "G1")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {
                    /*horizontal izquierda*/
                    if (F1.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (E1.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "F1");
                            comprobacion = true;
                        }
                        if ((D1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E1.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F1");
                            pintar("negro", "E1");
                            comprobacion = true;
                        }
                        if ((C1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E1.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F1");
                            pintar("negro", "E1");
                            pintar("negro", "D1");
                            comprobacion = true;
                        }
                        if ((B1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E1.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F1");
                            pintar("negro", "E1");
                            pintar("negro", "D1");
                            pintar("negro", "C1");
                            comprobacion = true;
                        }
                        if ((A1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E1.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F1");
                            pintar("negro", "E1");
                            pintar("negro", "D1");
                            pintar("negro", "C1");
                            pintar("negro", "B1");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (G2.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (G3.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "G2");
                            comprobacion = true;
                        }
                        if ((G4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G2");
                            pintar("negro", "G3");
                            comprobacion = true;
                        }
                        if ((G5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G2");
                            pintar("negro", "G3");
                            pintar("negro", "G4");
                            comprobacion = true;
                        }
                        if ((G5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G2");
                            pintar("negro", "G3");
                            pintar("negro", "G4");
                            pintar("negro", "G5");
                            comprobacion = true;
                        }
                        if ((G5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G2");
                            pintar("negro", "G3");
                            pintar("negro", "G4");
                            pintar("negro", "G5");
                            pintar("negro", "G6");
                            comprobacion = true;
                        }
                        if ((G5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G2");
                            pintar("negro", "G3");
                            pintar("negro", "G4");
                            pintar("negro", "G5");
                            pintar("negro", "G6");
                            pintar("negro", "G7");
                            comprobacion = true;
                        }
                    }

                }
                if (colorJ == "blanco")
                {
                    /*horizontal izquierda*/
                    if (F1.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (E1.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "F1");
                            comprobacion = true;
                        }
                        if ((D1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E1.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F1");
                            pintar("blanco", "E1");
                            comprobacion = true;
                        }
                        if ((C1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E1.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F1");
                            pintar("blanco", "E1");
                            pintar("blanco", "D1");
                            comprobacion = true;
                        }
                        if ((B1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E1.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F1");
                            pintar("blanco", "E1");
                            pintar("blanco", "D1");
                            pintar("blanco", "C1");
                            comprobacion = true;
                        }
                        if ((A1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E1.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F1");
                            pintar("blanco", "E1");
                            pintar("blanco", "D1");
                            pintar("blanco", "C1");
                            pintar("blanco", "B1");
                            comprobacion = true;
                        }
                    }

                    /*vertical abajo*/
                    if (G2.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (G3.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "G2");
                            comprobacion = true;
                        }
                        if ((G4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G2");
                            pintar("blanco", "G3");
                            comprobacion = true;
                        }
                        if ((G5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G2");
                            pintar("blanco", "G3");
                            pintar("blanco", "G4");
                            comprobacion = true;
                        }
                        if ((G5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G2");
                            pintar("blanco", "G3");
                            pintar("blanco", "G4");
                            pintar("blanco", "G5");
                            comprobacion = true;
                        }
                        if ((G5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G2");
                            pintar("blanco", "G3");
                            pintar("blanco", "G4");
                            pintar("blanco", "G5");
                            pintar("blanco", "G6");
                            comprobacion = true;
                        }
                        if ((G5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G2");
                            pintar("blanco", "G3");
                            pintar("blanco", "G4");
                            pintar("blanco", "G5");
                            pintar("blanco", "G6");
                            pintar("blanco", "G7");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true)
                {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
            }

            if (Posicion == "H1")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {
                    /*horizontal izquierda*/
                    if (G1.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (F1.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "G1");
                            comprobacion = true;
                        }
                        if ((E1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F1.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G1");
                            pintar("negro", "F1");
                            comprobacion = true;
                        }
                        if ((D1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F1.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G1");
                            pintar("negro", "F1");
                            pintar("negro", "E1");
                            comprobacion = true;
                        }
                        if ((C1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F1.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G1");
                            pintar("negro", "F1");
                            pintar("negro", "E1");
                            pintar("negro", "D1");
                            comprobacion = true;
                        }
                        if ((B1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F1.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G1");
                            pintar("negro", "F1");
                            pintar("negro", "E1");
                            pintar("negro", "D1");
                            pintar("negro", "C1");
                            comprobacion = true;
                        }
                        if ((A1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F1.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G1");
                            pintar("negro", "F1");
                            pintar("negro", "E1");
                            pintar("negro", "D1");
                            pintar("negro", "C1");
                            pintar("negro", "B1");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (H2.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (H3.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "H2");
                            comprobacion = true;
                        }
                        if ((H4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "H2");
                            pintar("negro", "H3");
                            comprobacion = true;
                        }
                        if ((H5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "H2");
                            pintar("negro", "H3");
                            pintar("negro", "H4");
                            comprobacion = true;
                        }
                        if ((H5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "H2");
                            pintar("negro", "H3");
                            pintar("negro", "H4");
                            pintar("negro", "H5");
                            comprobacion = true;
                        }
                        if ((H5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "H2");
                            pintar("negro", "H3");
                            pintar("negro", "H4");
                            pintar("negro", "H5");
                            pintar("negro", "H6");
                            comprobacion = true;
                        }
                        if ((H5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "H2");
                            pintar("negro", "H3");
                            pintar("negro", "H4");
                            pintar("negro", "H5");
                            pintar("negro", "H6");
                            pintar("negro", "H7");
                            comprobacion = true;
                        }
                    }

                }
                if (colorJ == "blanco")
                {
                    /*horizontal izquierda*/
                    if (G1.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (F1.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "G1");
                            comprobacion = true;
                        }
                        if ((E1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F1.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G1");
                            pintar("blanco", "F1");
                            comprobacion = true;
                        }
                        if ((D1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F1.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G1");
                            pintar("blanco", "F1");
                            pintar("blanco", "E1");
                            comprobacion = true;
                        }
                        if ((C1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F1.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G1");
                            pintar("blanco", "F1");
                            pintar("blanco", "E1");
                            pintar("blanco", "D1");
                            comprobacion = true;
                        }
                        if ((B1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F1.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G1");
                            pintar("blanco", "F1");
                            pintar("blanco", "E1");
                            pintar("blanco", "D1");
                            pintar("blanco", "C1");
                            comprobacion = true;
                        }
                        if ((A1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F1.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G1");
                            pintar("blanco", "F1");
                            pintar("blanco", "E1");
                            pintar("blanco", "D1");
                            pintar("blanco", "C1");
                            pintar("blanco", "B1");
                            comprobacion = true;
                        }
                    }


                    /*vertical abajo*/
                    if (H2.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (H3.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "H2");
                            comprobacion = true;
                        }
                        if ((H4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "H2");
                            pintar("blanco", "H3");
                            comprobacion = true;
                        }
                        if ((H5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "H2");
                            pintar("blanco", "H3");
                            pintar("blanco", "H4");
                            comprobacion = true;
                        }
                        if ((H5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "H2");
                            pintar("blanco", "H3");
                            pintar("blanco", "H4");
                            pintar("blanco", "H5");
                            comprobacion = true;
                        }
                        if ((H5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "H2");
                            pintar("blanco", "H3");
                            pintar("blanco", "H4");
                            pintar("blanco", "H5");
                            pintar("blanco", "H6");
                            comprobacion = true;
                        }
                        if ((H5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "H2");
                            pintar("blanco", "H3");
                            pintar("blanco", "H4");
                            pintar("blanco", "H5");
                            pintar("blanco", "H6");
                            pintar("blanco", "H7");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true)
                {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
            }


            if (Posicion == "A4")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {

                    /*horizontal derecha*/
                    if (B4.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (C4.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "B4");
                            comprobacion = true;
                        }
                        if ((D4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B4");
                            pintar("negro", "C4");
                            comprobacion = true;
                        }

                        if ((E4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B4");
                            pintar("negro", "C4");
                            pintar("negro", "D4");
                            comprobacion = true;
                        }
                        if ((F4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B4");
                            pintar("negro", "C4");
                            pintar("negro", "D4");
                            pintar("negro", "E4");
                            comprobacion = true;
                        }
                        if ((G4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B4");
                            pintar("negro", "C4");
                            pintar("negro", "D4");
                            pintar("negro", "E4");
                            pintar("negro", "F4");
                            comprobacion = true;
                        }
                        if ((G4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B4");
                            pintar("negro", "C4");
                            pintar("negro", "D4");
                            pintar("negro", "E4");
                            pintar("negro", "F4");
                            pintar("negro", "G4");
                            comprobacion = true;
                        }
                    }
                    /*vertical arriba*/
                    if (A3.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (A2.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "A3");
                            comprobacion = true;
                        }
                        if ((A1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A2.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "A3");
                            pintar("negro", "A2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (A5.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (A6.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "A5");
                            comprobacion = true;
                        }
                        if ((A7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "A5");
                            pintar("negro", "A6");
                            comprobacion = true;
                        }
                        if ((A8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A7.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "A5");
                            pintar("negro", "A6");
                            pintar("negro", "A7");
                            comprobacion = true;
                        }
                    }

                }
                if (colorJ == "blanco")
                {
                    /*horizontal derecha*/
                    if (B4.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (C4.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "B4");
                            comprobacion = true;
                        }
                        if ((D4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B4");
                            pintar("blanco", "C4");
                            comprobacion = true;
                        }

                        if ((E4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B4");
                            pintar("blanco", "C4");
                            pintar("blanco", "D4");
                            comprobacion = true;
                        }
                        if ((F4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B4");
                            pintar("blanco", "C4");
                            pintar("blanco", "D4");
                            pintar("blanco", "E4");
                            comprobacion = true;
                        }
                        if ((G4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B4");
                            pintar("blanco", "C4");
                            pintar("blanco", "D4");
                            pintar("blanco", "E4");
                            pintar("blanco", "F4");
                            comprobacion = true;
                        }
                        if ((G4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B4");
                            pintar("blanco", "C4");
                            pintar("blanco", "D4");
                            pintar("blanco", "E4");
                            pintar("blanco", "F4");
                            pintar("blanco", "G4");
                            comprobacion = true;
                        }


                    }
                    /*vertical arriba*/
                    if (A3.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (A2.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "A3");
                            comprobacion = true;
                        }
                        if ((A1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A2.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "A3");
                            pintar("blanco", "A2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (A5.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (A6.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "A5");
                            comprobacion = true;
                        }
                        if ((A7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "A5");
                            pintar("blanco", "A6");
                            comprobacion = true;
                        }
                        if ((A8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A7.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "A5");
                            pintar("blanco", "A6");
                            pintar("blanco", "A7");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true)
                {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
            }

            if (Posicion == "B4")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {

                    /*horizontal derecha*/
                    if (C4.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (D4.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "C4");
                            comprobacion = true;
                        }

                        if ((E4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C4");
                            pintar("negro", "D4");
                            comprobacion = true;
                        }
                        if ((F4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C4");
                            pintar("negro", "D4");
                            pintar("negro", "E4");
                            comprobacion = true;
                        }
                        if ((G4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C4");
                            pintar("negro", "D4");
                            pintar("negro", "E4");
                            pintar("negro", "F4");
                            comprobacion = true;
                        }
                        if ((G4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C4");
                            pintar("negro", "D4");
                            pintar("negro", "E4");
                            pintar("negro", "F4");
                            pintar("negro", "G4");
                            comprobacion = true;
                        }
                    }
                    /*vertical arriba*/
                    if (B3.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (B2.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "B3");
                            comprobacion = true;
                        }
                        if ((B1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B2.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B3");
                            pintar("negro", "B2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (B5.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (B6.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "B5");
                            comprobacion = true;
                        }
                        if ((B7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B5");
                            pintar("negro", "B6");
                            comprobacion = true;
                        }
                        if ((B8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B7.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B5");
                            pintar("negro", "B6");
                            pintar("negro", "B7");
                            comprobacion = true;
                        }
                    }

                }
                if (colorJ == "blanco")
                {
                    /*horizontal derecha*/
                    if (C4.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (D4.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "C4");
                            comprobacion = true;
                        }

                        if ((E4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C4");
                            pintar("blanco", "D4");
                            comprobacion = true;
                        }
                        if ((F4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C4");
                            pintar("blanco", "D4");
                            pintar("blanco", "E4");
                            comprobacion = true;
                        }
                        if ((G4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C4");
                            pintar("blanco", "D4");
                            pintar("blanco", "E4");
                            pintar("blanco", "F4");
                            comprobacion = true;
                        }
                        if ((G4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C4");
                            pintar("blanco", "D4");
                            pintar("blanco", "E4");
                            pintar("blanco", "F4");
                            pintar("blanco", "G4");
                            comprobacion = true;
                        }


                    }
                    /*vertical arriba*/
                    if (B3.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (B2.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "B3");
                            comprobacion = true;
                        }
                        if ((B1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B2.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B3");
                            pintar("blanco", "B2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (B5.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (B6.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "B5");
                            comprobacion = true;
                        }
                        if ((B7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B5");
                            pintar("blanco", "B6");
                            comprobacion = true;
                        }
                        if ((B8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B7.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B5");
                            pintar("blanco", "B6");
                            pintar("blanco", "B7");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true)
                {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
            }

            if (Posicion == "C4")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {
                    /*horizontal izquierda*/
                    if (B4.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (A4.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "B4");
                            comprobacion = true;
                        }
                    }
                    /*horizontal derecha*/
                    if (D4.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (E4.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "D4");
                            comprobacion = true;
                        }
                        if ((F4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D4");
                            pintar("negro", "E4");
                            comprobacion = true;
                        }
                        if ((G4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D4");
                            pintar("negro", "E4");
                            pintar("negro", "F4");
                            comprobacion = true;
                        }
                        if ((G4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D4");
                            pintar("negro", "E4");
                            pintar("negro", "F4");
                            pintar("negro", "G4");
                            comprobacion = true;
                        }
                    }
                    /*vertical arriba*/
                    if (C3.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (C2.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "C3");
                            comprobacion = true;
                        }
                        if ((C1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C2.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C3");
                            pintar("negro", "C2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (C5.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (C6.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "C5");
                            comprobacion = true;
                        }
                        if ((C7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C5");
                            pintar("negro", "C6");
                            comprobacion = true;
                        }
                        if ((C8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C7.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C5");
                            pintar("negro", "C6");
                            pintar("negro", "C7");
                            comprobacion = true;
                        }
                    }

                }
                if (colorJ == "blanco")
                {
                    /*horizontal izquierda*/
                    if (B4.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (A4.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "B4");
                            comprobacion = true;
                        }
                    }

                    /*horizontal derecha*/
                    if (D4.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (E4.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "D4");
                            comprobacion = true;
                        }
                        if ((F4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D4");
                            pintar("blanco", "E4");
                            comprobacion = true;
                        }
                        if ((F4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D4");
                            pintar("blanco", "E4");
                            pintar("blanco", "F4");
                            comprobacion = true;
                        }
                        if ((H4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D4");
                            pintar("blanco", "E4");
                            pintar("blanco", "F4");
                            pintar("blanco", "G4");
                            comprobacion = true;
                        }


                    }
                    /*vertical arriba*/
                    if (C3.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (C2.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "C3");
                            comprobacion = true;
                        }
                        if ((C1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C2.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C3");
                            pintar("blanco", "C2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (C5.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (C6.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "C5");
                            comprobacion = true;
                        }
                        if ((C7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C5");
                            pintar("blanco", "C6");
                            comprobacion = true;
                        }
                        if ((C8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C7.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C5");
                            pintar("blanco", "C6");
                            pintar("blanco", "C7");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true)
                {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
            }

            if (Posicion == "F4")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {
                    /*horizontal izquierda*/
                    if (E4.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (D4.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "E4");
                            comprobacion = true;
                        }
                        if ((C4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E4");
                            pintar("negro", "D4");
                            comprobacion = true;
                        }
                        if ((B4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E4");
                            pintar("negro", "D4");
                            pintar("negro", "C4");
                            comprobacion = true;
                        }
                        if ((A4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E4");
                            pintar("negro", "D4");
                            pintar("negro", "C4");
                            pintar("negro", "B4");
                            comprobacion = true;
                        }
                    }
                    /*horizontal derecha*/
                    if (G4.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (H4.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "G4");
                            comprobacion = true;
                        }
                    }
                    /*vertical arriba*/
                    if (F3.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (F2.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "F3");
                            comprobacion = true;
                        }
                        if ((F1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F2.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F3");
                            pintar("negro", "F2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (F5.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (F6.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "F5");
                            comprobacion = true;
                        }
                        if ((F7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F5");
                            pintar("negro", "F6");
                            comprobacion = true;
                        }
                        if ((F8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F7.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F5");
                            pintar("negro", "F6");
                            pintar("negro", "F7");
                            comprobacion = true;
                        }
                    }
                    /*diagonal hacia arriba izquierda*/
                    if (E3.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (D2.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "E3");
                            comprobacion = true;
                        }
                        if ((C1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D2.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E3");
                            pintar("negro", "D2");
                            comprobacion = true;
                        }
                    }
                    /*diagonal hacia abajo derecha*/
                    if (G5.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (H6.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "G5");
                            comprobacion = true;
                        }
                    }
                }
                if (colorJ == "blanco")
                {
                    /*horizontal izquierda*/
                    if (E4.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (D4.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "E4");
                            comprobacion = true;
                        }
                        if ((C4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E4");
                            pintar("blanco", "D4");
                            comprobacion = true;
                        }
                        if ((B4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E4");
                            pintar("blanco", "D4");
                            pintar("blanco", "C4");
                            comprobacion = true;
                        }
                        if ((A4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E4");
                            pintar("blanco", "D4");
                            pintar("blanco", "C4");
                            pintar("blanco", "B4");
                            comprobacion = true;
                        }
                    }

                    /*vertical arriba*/
                    if (F3.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (F2.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "F3");
                            comprobacion = true;
                        }
                        if ((F1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F2.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F3");
                            pintar("blanco", "F2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (F5.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (F6.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "F5");
                            comprobacion = true;
                        }
                        if ((F7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F5");
                            pintar("blanco", "F6");
                            comprobacion = true;
                        }
                        if ((F8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F7.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F5");
                            pintar("blanco", "F6");
                            pintar("blanco", "F7");
                            comprobacion = true;
                        }
                    }
                    /*diagonal hacia arriba izquierda*/
                    if (E3.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (D2.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "E3");
                            comprobacion = true;
                        }
                        if ((C1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D2.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E3");
                            pintar("blanco", "D2");
                            comprobacion = true;
                        }
                    }
                    /*diagonal hacia abajo derecha*/
                    if (G5.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (H6.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "G5");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true)
                {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
            }

            if (Posicion == "G4")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {
                    /*horizontal izquierda*/
                    if (F4.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (E4.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "F4");
                            comprobacion = true;
                        }
                        if ((D4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F4");
                            pintar("negro", "E4");
                            comprobacion = true;
                        }
                        if ((C4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F4");
                            pintar("negro", "E4");
                            pintar("negro", "D4");
                            comprobacion = true;
                        }
                        if ((B4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F4");
                            pintar("negro", "E4");
                            pintar("negro", "D4");
                            pintar("negro", "C4");
                            comprobacion = true;
                        }
                        if ((A4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F4");
                            pintar("negro", "E4");
                            pintar("negro", "D4");
                            pintar("negro", "C4");
                            pintar("negro", "B4");
                            comprobacion = true;
                        }
                    }

                    /*vertical arriba*/
                    if (G3.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (G2.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "G3");
                            comprobacion = true;
                        }
                        if ((G1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G2.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G3");
                            pintar("negro", "G2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (G5.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (G6.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "G5");
                            comprobacion = true;
                        }
                        if ((G7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G5");
                            pintar("negro", "G6");
                            comprobacion = true;
                        }
                        if ((G8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G7.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G5");
                            pintar("negro", "G6");
                            pintar("negro", "G7");
                            comprobacion = true;
                        }
                    }
                    /*diagonal hacia arriba izquierda*/
                    if (F3.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (E2.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "F3");
                            comprobacion = true;
                        }
                        if ((D1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E2.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F3");
                            pintar("negro", "E2");
                            comprobacion = true;
                        }
                    }

                }
                if (colorJ == "blanco")
                {
                    /*horizontal izquierda*/
                    if (F4.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (E4.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "F4");
                            comprobacion = true;
                        }
                        if ((D4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F4");
                            pintar("blanco", "E4");
                            comprobacion = true;
                        }
                        if ((C4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F4");
                            pintar("blanco", "E4");
                            pintar("blanco", "D4");
                            comprobacion = true;
                        }
                        if ((B4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F4");
                            pintar("blanco", "E4");
                            pintar("blanco", "D4");
                            pintar("blanco", "C4");
                            comprobacion = true;
                        }
                        if ((A4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F4");
                            pintar("blanco", "E4");
                            pintar("blanco", "D4");
                            pintar("blanco", "C4");
                            pintar("blanco", "B4");
                            comprobacion = true;
                        }
                    }
                    /*vertical arriba*/
                    if (G3.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (G2.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "G3");
                            comprobacion = true;
                        }
                        if ((G1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G2.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G3");
                            pintar("blanco", "G2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (G5.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (G6.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "G5");
                            comprobacion = true;
                        }
                        if ((G7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G5");
                            pintar("blanco", "G6");
                            comprobacion = true;
                        }
                        if ((G8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G7.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G5");
                            pintar("blanco", "G6");
                            pintar("blanco", "G7");
                            comprobacion = true;
                        }
                    }
                    /*diagonal hacia arriba izquierda*/
                    if (F3.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (E2.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "F3");
                            comprobacion = true;
                        }
                        if ((D1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E2.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F3");
                            pintar("blanco", "E2");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true)
                {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
            }

            if (Posicion == "H4")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {
                    /*horizontal izquierda*/
                    if (G4.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (F4.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "G4");
                            comprobacion = true;
                        }
                        if ((E4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G4");
                            pintar("negro", "F4");
                            comprobacion = true;
                        }
                        if ((D4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G4");
                            pintar("negro", "F4");
                            pintar("negro", "E4");
                            comprobacion = true;
                        }
                        if ((C4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G4");
                            pintar("negro", "F4");
                            pintar("negro", "E4");
                            pintar("negro", "D4");
                            comprobacion = true;
                        }
                        if ((B4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G4");
                            pintar("negro", "F4");
                            pintar("negro", "E4");
                            pintar("negro", "D4");
                            pintar("negro", "C4");
                            comprobacion = true;
                        }
                        if ((A4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G4");
                            pintar("negro", "F4");
                            pintar("negro", "E4");
                            pintar("negro", "D4");
                            pintar("negro", "C4");
                            pintar("negro", "B4");
                            comprobacion = true;
                        }
                    }

                    /*vertical arriba*/
                    if (H3.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (H2.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("negro", "H3");
                            comprobacion = true;
                        }
                        if ((H1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H2.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("negro", "H3");
                            pintar("negro", "H2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (H5.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (H6.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("negro", "H5");
                            comprobacion = true;
                        }
                        if ((H7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("negro", "H5");
                            pintar("negro", "H6");
                            comprobacion = true;
                        }
                        if ((H8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H7.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("negro", "H5");
                            pintar("negro", "H6");
                            pintar("negro", "H7");
                            comprobacion = true;
                        }
                    }

                }
                if (colorJ == "blanco")
                {
                    /*horizontal izquierda*/
                    if (G4.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (F4.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "G4");
                            comprobacion = true;
                        }
                        if ((E4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G4");
                            pintar("blanco", "F4");
                            comprobacion = true;
                        }
                        if ((D4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G4");
                            pintar("blanco", "F4");
                            pintar("blanco", "E4");
                            comprobacion = true;
                        }
                        if ((C4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G4");
                            pintar("blanco", "F4");
                            pintar("blanco", "E4");
                            pintar("blanco", "D4");
                            comprobacion = true;
                        }
                        if ((B4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G4");
                            pintar("blanco", "F4");
                            pintar("blanco", "E4");
                            pintar("blanco", "D4");
                            pintar("blanco", "C4");
                            comprobacion = true;
                        }
                        if ((A4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G4");
                            pintar("blanco", "F4");
                            pintar("blanco", "E4");
                            pintar("blanco", "D4");
                            pintar("blanco", "C4");
                            pintar("blanco", "B4");
                            comprobacion = true;
                        }
                    }
                    /*vertical arriba*/
                    if (H3.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (H2.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "H3");
                            comprobacion = true;
                        }
                        if ((H1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H2.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "H3");
                            pintar("blanco", "H2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (H5.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (H6.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "H5");
                            comprobacion = true;
                        }
                        if ((H7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "H5");
                            pintar("blanco", "H6");
                            comprobacion = true;
                        }
                        if ((H8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H7.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "H5");
                            pintar("blanco", "H6");
                            pintar("blanco", "H7");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true)
                {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
            }


            if (Posicion == "A5")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {

                    /*horizontal derecha*/
                    if (B5.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (C5.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "B5");
                            comprobacion = true;
                        }
                        if ((D5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C5.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B5");
                            pintar("negro", "C5");
                            comprobacion = true;
                        }

                        if ((E5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C5.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B5");
                            pintar("negro", "C5");
                            pintar("negro", "D5");
                            comprobacion = true;
                        }
                        if ((F5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C5.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B5");
                            pintar("negro", "C5");
                            pintar("negro", "D5");
                            pintar("negro", "E5");
                            comprobacion = true;
                        }
                        if ((G5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C5.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B5");
                            pintar("negro", "C5");
                            pintar("negro", "D5");
                            pintar("negro", "E5");
                            pintar("negro", "F5");
                            comprobacion = true;
                        }
                        if ((G5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C5.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B5");
                            pintar("negro", "C5");
                            pintar("negro", "D5");
                            pintar("negro", "E5");
                            pintar("negro", "F5");
                            pintar("negro", "G5");
                            comprobacion = true;
                        }
                    }
                    /*vertical arriba*/
                    if (A4.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (A3.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "A4");
                            comprobacion = true;
                        }
                        if ((A2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "A4");
                            pintar("negro", "A3");
                            comprobacion = true;
                        }
                        if ((A1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A2.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "A4");
                            pintar("negro", "A3");
                            pintar("negro", "A2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (A6.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (A7.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "A6");
                            comprobacion = true;
                        }
                        if ((A8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A7.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "A6");
                            pintar("negro", "A7");
                            comprobacion = true;
                        }
                    }

                }
                if (colorJ == "blanco")
                {
                    /*horizontal derecha*/
                    if (B5.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (C5.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "B5");
                            comprobacion = true;
                        }
                        if ((D5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C5.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B5");
                            pintar("blanco", "C5");
                            comprobacion = true;
                        }

                        if ((E5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C5.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B5");
                            pintar("blanco", "C5");
                            pintar("blanco", "D5");
                            comprobacion = true;
                        }
                        if ((F5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C5.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B5");
                            pintar("blanco", "C5");
                            pintar("blanco", "D5");
                            pintar("blanco", "E5");
                            comprobacion = true;
                        }
                        if ((G5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C5.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B5");
                            pintar("blanco", "C5");
                            pintar("blanco", "D5");
                            pintar("blanco", "E5");
                            pintar("blanco", "F5");
                            comprobacion = true;
                        }
                        if ((G5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C5.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B5");
                            pintar("blanco", "C5");
                            pintar("blanco", "D5");
                            pintar("blanco", "E5");
                            pintar("blanco", "F5");
                            pintar("blanco", "G5");
                            comprobacion = true;
                        }


                    }
                    /*vertical arriba*/
                    if (A4.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (A3.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "A4");
                            comprobacion = true;
                        }
                        if ((A2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "A4");
                            pintar("blanco", "A3");
                            comprobacion = true;
                        }
                        if ((A1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A2.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "A4");
                            pintar("blanco", "A3");
                            pintar("blanco", "A2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (A6.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (A7.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "A6");
                            comprobacion = true;
                        }
                        if ((A8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A7.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "A6");
                            pintar("blanco", "A7");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true)
                {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
            }

            if (Posicion == "B5")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {

                    /*horizontal derecha*/
                    if (C5.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (D5.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "C5");
                            comprobacion = true;
                        }

                        if ((E5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D5.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C5");
                            pintar("negro", "D5");
                            comprobacion = true;
                        }
                        if ((F5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D5.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C5");
                            pintar("negro", "D5");
                            pintar("negro", "E5");
                            comprobacion = true;
                        }
                        if ((G5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D5.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C5");
                            pintar("negro", "D5");
                            pintar("negro", "E5");
                            pintar("negro", "F5");
                            comprobacion = true;
                        }
                        if ((G5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D5.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C5");
                            pintar("negro", "D5");
                            pintar("negro", "E5");
                            pintar("negro", "F5");
                            pintar("negro", "G5");
                            comprobacion = true;
                        }
                    }
                    /*vertical arriba*/
                    if (B4.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (B3.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "B4");
                            comprobacion = true;
                        }
                        if ((B2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B4");
                            pintar("negro", "B3");
                            comprobacion = true;
                        }
                        if ((B1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B2.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B4");
                            pintar("negro", "B3");
                            pintar("negro", "B2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (B6.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (B7.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "B6");
                            comprobacion = true;
                        }
                        if ((B8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B7.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B6");
                            pintar("negro", "B7");
                            comprobacion = true;
                        }
                    }

                }
                if (colorJ == "blanco")
                {
                    /*horizontal derecha*/
                    if (C5.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (D5.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "C5");
                            comprobacion = true;
                        }

                        if ((E5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D5.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C5");
                            pintar("blanco", "D5");
                            comprobacion = true;
                        }
                        if ((F5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D5.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C5");
                            pintar("blanco", "D5");
                            pintar("blanco", "E5");
                            comprobacion = true;
                        }
                        if ((G5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E5.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C5");
                            pintar("blanco", "D5");
                            pintar("blanco", "E5");
                            pintar("blanco", "F5");
                            comprobacion = true;
                        }
                        if ((G5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C5");
                            pintar("blanco", "D5");
                            pintar("blanco", "E5");
                            pintar("blanco", "F5");
                            pintar("blanco", "G5");
                            comprobacion = true;
                        }


                    }
                    /*vertical arriba*/
                    if (B4.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (B3.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "B4");
                            comprobacion = true;
                        }
                        if ((B2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B4");
                            pintar("blanco", "B3");
                            comprobacion = true;
                        }
                        if ((B1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B2.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B4");
                            pintar("blanco", "B3");
                            pintar("blanco", "B2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (B6.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (B7.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "B6");
                            comprobacion = true;
                        }
                        if ((B8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B7.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B6");
                            pintar("blanco", "B7");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true)
                {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
            }

            if (Posicion == "C5")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {
                    /*horizontal izquierda*/
                    if (B5.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (A5.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "B5");
                            comprobacion = true;
                        }
                    }
                    /*horizontal derecha*/
                    if (D5.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (E5.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "D5");
                            comprobacion = true;
                        }
                        if ((F5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E5.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D5");
                            pintar("negro", "E5");
                            comprobacion = true;
                        }
                        if ((G5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E5.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D5");
                            pintar("negro", "E5");
                            pintar("negro", "F5");
                            comprobacion = true;
                        }
                        if ((G5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D5");
                            pintar("negro", "E5");
                            pintar("negro", "F5");
                            pintar("negro", "G5");
                            comprobacion = true;
                        }
                    }
                    /*vertical arriba*/
                    if (C2.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (C1.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "C2");
                            comprobacion = true;
                        }
                    }
                    /*vertical arriba*/
                    if (C4.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (C3.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "C4");
                            comprobacion = true;
                        }
                        if ((C2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C4");
                            pintar("negro", "C3");
                            comprobacion = true;
                        }
                        if ((C1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C2.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C4");
                            pintar("negro", "C3");
                            pintar("negro", "C2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (C6.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (C7.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "C6");
                            comprobacion = true;
                        }
                        if ((C8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C7.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C6");
                            pintar("negro", "C7");
                            comprobacion = true;
                        }
                    }

                }
                if (colorJ == "blanco")
                {
                    /*horizontal izquierda*/
                    if (B5.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (A5.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "B5");
                            comprobacion = true;
                        }
                    }

                    /*horizontal derecha*/
                    if (D5.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (E5.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "D5");
                            comprobacion = true;
                        }
                        if ((F5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E5.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D5");
                            pintar("blanco", "E5");
                            comprobacion = true;
                        }
                        if ((F5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E5.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D5");
                            pintar("blanco", "E5");
                            pintar("blanco", "F5");
                            comprobacion = true;
                        }
                        if ((H5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E5.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D5");
                            pintar("blanco", "E5");
                            pintar("blanco", "F5");
                            pintar("blanco", "G5");
                            comprobacion = true;
                        }


                    }
                    /*vertical arriba*/
                    if (C4.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (C3.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "C4");
                            comprobacion = true;
                        }
                        if ((C2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C4");
                            pintar("blanco", "C3");
                            comprobacion = true;
                        }
                        if ((C1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C2.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C4");
                            pintar("blanco", "C3");
                            pintar("blanco", "C2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (C6.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (C7.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "C6");
                            comprobacion = true;
                        }
                        if ((C8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C7.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C6");
                            pintar("blanco", "C7");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true)
                {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
            }

            if (Posicion == "F5")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {
                    /*horizontal izquierda*/
                    if (E5.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (D5.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "E5");
                            comprobacion = true;
                        }
                        if ((C5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D5.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E5");
                            pintar("negro", "D5");
                            comprobacion = true;
                        }
                        if ((B5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D5.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E5");
                            pintar("negro", "D5");
                            pintar("negro", "C5");
                            comprobacion = true;
                        }
                        if ((A5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D5.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E5");
                            pintar("negro", "D5");
                            pintar("negro", "C5");
                            pintar("negro", "B5");
                            comprobacion = true;
                        }
                    }
                    /*horizontal derecha*/
                    if (G5.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (H5.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "G5");
                            comprobacion = true;
                        }
                    }
                    /*vertical arriba*/
                    if (F4.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (F3.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "F4");
                            comprobacion = true;
                        }
                        if ((F2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F4");
                            pintar("negro", "F3");
                            comprobacion = true;
                        }
                        if ((F1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F2.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F4");
                            pintar("negro", "F3");
                            pintar("negro", "F2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (F6.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (F7.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "F6");
                            comprobacion = true;
                        }
                        if ((F8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F7.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F6");
                            pintar("negro", "F7");
                            comprobacion = true;
                        }
                    }
                    /*diagonal hacia arriba izquierda*/
                    if (E4.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (D3.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "E4");
                            comprobacion = true;
                        }
                        if ((C2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E4");
                            pintar("negro", "D3");
                            comprobacion = true;
                        }
                        if ((B1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C2.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E4");
                            pintar("negro", "D3");
                            pintar("negro", "C2");
                            comprobacion = true;
                        }
                    }
                    /*diagonal hacia abajo izquierda*/
                    if (G6.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (H7.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "G6");
                            comprobacion = true;
                        }
                    }

                }
                if (colorJ == "blanco")
                {
                    /*horizontal izquierda*/
                    if (E5.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (D5.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "E5");
                            comprobacion = true;
                        }
                        if ((C5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D5.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E5");
                            pintar("blanco", "D5");
                            comprobacion = true;
                        }
                        if ((B5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D5.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E5");
                            pintar("blanco", "D5");
                            pintar("blanco", "C5");
                            comprobacion = true;
                        }
                        if ((A5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D5.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E5");
                            pintar("blanco", "D5");
                            pintar("blanco", "C5");
                            pintar("blanco", "B5");
                            comprobacion = true;
                        }
                    }

                    /*horizontal derecha*/
                    if (G5.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (H5.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "G5");
                            comprobacion = true;
                        }
                    }
                    /*vertical arriba*/
                    if (F4.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (F3.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "F4");
                            comprobacion = true;
                        }
                        if ((F2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F4");
                            pintar("blanco", "F3");
                            comprobacion = true;
                        }
                        if ((F1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F2.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F4");
                            pintar("blanco", "F3");
                            pintar("blanco", "F2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (F6.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (F7.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "F6");
                            comprobacion = true;
                        }
                        if ((F8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F7.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F6");
                            pintar("blanco", "F7");
                            comprobacion = true;
                        }
                    }
                    /*diagonal hacia arriba izquierda*/
                    if (E4.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (D3.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "E4");
                            comprobacion = true;
                        }
                        if ((C2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E4");
                            pintar("blanco", "D3");
                            comprobacion = true;
                        }
                        if ((B1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C2.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E4");
                            pintar("blanco", "D3");
                            pintar("blanco", "C2");
                            comprobacion = true;
                        }
                    }
                    /*diagonal hacia abajo derecha*/
                    if (G6.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (H7.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "G6");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true)
                {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
            }

            if (Posicion == "G5")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {
                    /*horizontal izquierda*/
                    if (F5.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (E5.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "F5");
                            comprobacion = true;
                        }
                        if ((D5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E5.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F5");
                            pintar("negro", "E5");
                            comprobacion = true;
                        }
                        if ((C5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E5.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F5");
                            pintar("negro", "E5");
                            pintar("negro", "D5");
                            comprobacion = true;
                        }
                        if ((B5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E5.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F5");
                            pintar("negro", "E5");
                            pintar("negro", "D5");
                            pintar("negro", "C5");
                            comprobacion = true;
                        }
                        if ((A5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E5.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F5");
                            pintar("negro", "E5");
                            pintar("negro", "D5");
                            pintar("negro", "C5");
                            pintar("negro", "B5");
                            comprobacion = true;
                        }
                    }

                    /*vertical arriba*/
                    if (G4.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (G3.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "G4");
                            comprobacion = true;
                        }
                        if ((G2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G4");
                            pintar("negro", "G3");
                            comprobacion = true;
                        }
                        if ((G1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G2.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G4");
                            pintar("negro", "G3");
                            pintar("negro", "G2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (G6.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (G7.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "G6");
                            comprobacion = true;
                        }
                        if ((G8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G7.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G6");
                            pintar("negro", "G7");
                            comprobacion = true;
                        }
                    }
                    /*diagonal hacia arriba*/
                    if (F4.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (E3.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "F4");
                            comprobacion = true;
                        }
                        if ((D2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F4");
                            pintar("negro", "E3");
                            comprobacion = true;
                        }
                        if ((C1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D2.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F4");
                            pintar("negro", "E3");
                            pintar("negro", "D2");
                            comprobacion = true;
                        }
                    }
                }
                if (colorJ == "blanco")
                {
                    /*horizontal izquierda*/
                    if (F5.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (E5.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "F5");
                            comprobacion = true;
                        }
                        if ((D5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E5.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F5");
                            pintar("blanco", "E5");
                            comprobacion = true;
                        }
                        if ((C5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E5.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F5");
                            pintar("blanco", "E5");
                            pintar("blanco", "D5");
                            comprobacion = true;
                        }
                        if ((B5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E5.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F5");
                            pintar("blanco", "E5");
                            pintar("blanco", "D5");
                            pintar("blanco", "C5");
                            comprobacion = true;
                        }
                        if ((A5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E5.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F5");
                            pintar("blanco", "E5");
                            pintar("blanco", "D5");
                            pintar("blanco", "C5");
                            pintar("blanco", "B5");
                            comprobacion = true;
                        }
                    }


                    /*vertical arriba*/
                    if (G4.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (G3.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "G4");
                            comprobacion = true;
                        }
                        if ((G2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G4");
                            pintar("blanco", "G3");
                            comprobacion = true;
                        }
                        if ((G1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G2.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G4");
                            pintar("blanco", "G3");
                            pintar("blanco", "G2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (G6.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (G7.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "G6");
                            comprobacion = true;
                        }
                        if ((G8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G7.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G6");
                            pintar("blanco", "G7");
                            comprobacion = true;
                        }
                    }
                    /*diagonal hacia arriba izquierda*/
                    if (F4.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (E3.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "F4");
                            comprobacion = true;
                        }
                        if ((D2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F4");
                            pintar("blanco", "E3");
                            comprobacion = true;
                        }
                        if ((C1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D2.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F4");
                            pintar("blanco", "E3");
                            pintar("blanco", "D2");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true)
                {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
            }

            if (Posicion == "H5")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {
                    /*horizontal izquierda*/
                    if (G5.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (F5.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "G5");
                            comprobacion = true;
                        }
                        if ((E5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F5.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G5");
                            pintar("negro", "F5");
                            comprobacion = true;
                        }
                        if ((D5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F5.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G5");
                            pintar("negro", "F5");
                            pintar("negro", "E5");
                            comprobacion = true;
                        }
                        if ((C5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F5.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G5");
                            pintar("negro", "F5");
                            pintar("negro", "E5");
                            pintar("negro", "D5");
                            comprobacion = true;
                        }
                        if ((B5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F5.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G5");
                            pintar("negro", "F5");
                            pintar("negro", "E5");
                            pintar("negro", "D5");
                            pintar("negro", "C5");
                            comprobacion = true;
                        }
                        if ((A5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F5.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G5");
                            pintar("negro", "F5");
                            pintar("negro", "E5");
                            pintar("negro", "D5");
                            pintar("negro", "C5");
                            pintar("negro", "B5");
                            comprobacion = true;
                        }
                    }

                    /*vertical arriba*/
                    if (H4.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (H3.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "H4");
                            comprobacion = true;
                        }
                        if ((H2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "H4");
                            pintar("negro", "H3");
                            comprobacion = true;
                        }
                        if ((H1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H2.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "H4");
                            pintar("negro", "H3");
                            pintar("negro", "H2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (H6.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (H7.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "H6");
                            comprobacion = true;
                        }
                        if ((H8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H7.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "H6");
                            pintar("negro", "H7");
                            comprobacion = true;
                        }
                    }
                    /*diagonal hacia arriba izquierda*/
                    if (G4.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (F3.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "G4");
                            comprobacion = true;
                        }
                        if ((E2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G4");
                            pintar("negro", "F3");
                            comprobacion = true;
                        }
                        if ((D1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E2.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G4");
                            pintar("negro", "F3");
                            pintar("negro", "E2");
                            comprobacion = true;
                        }
                    }

                }
                if (colorJ == "blanco")
                {
                    /*horizontal izquierda*/
                    if (G5.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (F5.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "G5");
                            comprobacion = true;
                        }
                        if ((E5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F5.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G5");
                            pintar("blanco", "F5");
                            comprobacion = true;
                        }
                        if ((D5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F5.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G5");
                            pintar("blanco", "F5");
                            pintar("blanco", "E5");
                            comprobacion = true;
                        }
                        if ((C5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F5.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G5");
                            pintar("blanco", "F5");
                            pintar("blanco", "E5");
                            pintar("blanco", "D5");
                            comprobacion = true;
                        }
                        if ((B5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F5.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G5");
                            pintar("blanco", "F5");
                            pintar("blanco", "E5");
                            pintar("blanco", "D5");
                            pintar("blanco", "C5");
                            comprobacion = true;
                        }
                        if ((A5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F5.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G5");
                            pintar("blanco", "F5");
                            pintar("blanco", "E5");
                            pintar("blanco", "D5");
                            pintar("blanco", "C5");
                            pintar("blanco", "B5");
                            comprobacion = true;
                        }
                    }
                    /*vertical arriba*/
                    if (H4.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (H3.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "H4");
                            comprobacion = true;
                        }
                        if ((H2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "H4");
                            pintar("blanco", "H3");
                            comprobacion = true;
                        }
                        if ((H1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H2.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "H4");
                            pintar("blanco", "H3");
                            pintar("blanco", "H2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (H6.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (H7.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "H6");
                            comprobacion = true;
                        }
                        if ((H8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H7.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "H6");
                            pintar("blanco", "H7");
                            comprobacion = true;
                        }
                    }
                    /*diagonal hacia arriba izquierda*/
                    if (G4.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (F3.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "G4");
                            comprobacion = true;
                        }
                        if ((E2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G4");
                            pintar("blanco", "F3");
                            comprobacion = true;
                        }
                        if ((D1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E2.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G4");
                            pintar("blanco", "F3");
                            pintar("blanco", "E2");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true)
                {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
            }


            if (Posicion == "A6")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {

                    /*horizontal derecha*/
                    if (B6.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (C6.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "B6");
                            comprobacion = true;
                        }
                        if ((D6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B6");
                            pintar("negro", "C6");
                            comprobacion = true;
                        }

                        if ((E6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B6");
                            pintar("negro", "C6");
                            pintar("negro", "D6");
                            comprobacion = true;
                        }
                        if ((F6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B6");
                            pintar("negro", "C6");
                            pintar("negro", "D6");
                            pintar("negro", "E6");
                            comprobacion = true;
                        }
                        if ((G6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B6");
                            pintar("negro", "C6");
                            pintar("negro", "D6");
                            pintar("negro", "E6");
                            pintar("negro", "F6");
                            comprobacion = true;
                        }
                        if ((G6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B6");
                            pintar("negro", "C6");
                            pintar("negro", "D6");
                            pintar("negro", "E6");
                            pintar("negro", "F6");
                            pintar("negro", "G6");
                            comprobacion = true;
                        }
                    }
                    /*vertical arriba*/
                    if (A5.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (A4.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "A5");
                            comprobacion = true;
                        }
                        if ((A3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "A5");
                            pintar("negro", "A4");
                            comprobacion = true;
                        }
                        if ((A2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "A5");
                            pintar("negro", "A4");
                            pintar("negro", "A3");
                            comprobacion = true;
                        }
                        if ((A1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "A5");
                            pintar("negro", "A4");
                            pintar("negro", "A3");
                            pintar("negro", "A2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (A7.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (A8.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "A7");
                            comprobacion = true;
                        }
                    }

                }
                if (colorJ == "blanco")
                {
                    /*horizontal derecha*/
                    if (B6.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (C6.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "B6");
                            comprobacion = true;
                        }
                        if ((D6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B6");
                            pintar("blanco", "C6");
                            comprobacion = true;
                        }

                        if ((E6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B6");
                            pintar("blanco", "C6");
                            pintar("blanco", "D6");
                            comprobacion = true;
                        }
                        if ((F6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B6");
                            pintar("blanco", "C6");
                            pintar("blanco", "D6");
                            pintar("blanco", "E6");
                            comprobacion = true;
                        }
                        if ((G6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B6");
                            pintar("blanco", "C6");
                            pintar("blanco", "D6");
                            pintar("blanco", "E6");
                            pintar("blanco", "F6");
                            comprobacion = true;
                        }
                        if ((G6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B6");
                            pintar("blanco", "C6");
                            pintar("blanco", "D6");
                            pintar("blanco", "E6");
                            pintar("blanco", "F6");
                            pintar("blanco", "G6");
                            comprobacion = true;
                        }


                    }
                    /*vertical arriba*/
                    if (A5.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (A4.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "A5");
                            comprobacion = true;
                        }
                        if ((A3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "A5");
                            pintar("blanco", "A4");
                            comprobacion = true;
                        }
                        if ((A2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "A5");
                            pintar("blanco", "A4");
                            pintar("blanco", "A3");
                            comprobacion = true;
                        }
                        if ((A1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "A5");
                            pintar("blanco", "A4");
                            pintar("blanco", "A3");
                            pintar("blanco", "A2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (A7.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (A8.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "A7");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true)
                {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
            }

            if (Posicion == "B6")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {

                    /*horizontal derecha*/
                    if (C6.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (D6.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "C6");
                            comprobacion = true;
                        }

                        if ((E6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C6");
                            pintar("negro", "D6");
                            comprobacion = true;
                        }
                        if ((F6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C6");
                            pintar("negro", "D6");
                            pintar("negro", "E6");
                            comprobacion = true;
                        }
                        if ((G6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C6");
                            pintar("negro", "D6");
                            pintar("negro", "E6");
                            pintar("negro", "F6");
                            comprobacion = true;
                        }
                        if ((G6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C6");
                            pintar("negro", "D6");
                            pintar("negro", "E6");
                            pintar("negro", "F6");
                            pintar("negro", "G6");
                            comprobacion = true;
                        }
                    }
                    /*vertical arriba*/
                    if (B5.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (B4.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "B5");
                            comprobacion = true;
                        }
                        if ((B3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B5");
                            pintar("negro", "B4");
                            comprobacion = true;
                        }
                        if ((B2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B5");
                            pintar("negro", "B4");
                            pintar("negro", "B3");
                            comprobacion = true;
                        }
                        if ((B1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B5");
                            pintar("negro", "B4");
                            pintar("negro", "B3");
                            pintar("negro", "B2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (B7.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (B8.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "B7");
                            comprobacion = true;
                        }
                    }

                }
                if (colorJ == "blanco")
                {
                    /*horizontal derecha*/
                    if (C6.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (D6.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "C6");
                            comprobacion = true;
                        }

                        if ((E6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C6");
                            pintar("blanco", "D6");
                            comprobacion = true;
                        }
                        if ((F6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C6");
                            pintar("blanco", "D6");
                            pintar("blanco", "E6");
                            comprobacion = true;
                        }
                        if ((G6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C6");
                            pintar("blanco", "D6");
                            pintar("blanco", "E6");
                            pintar("blanco", "F6");
                            comprobacion = true;
                        }
                        if ((G6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C6");
                            pintar("blanco", "D6");
                            pintar("blanco", "E6");
                            pintar("blanco", "F6");
                            pintar("blanco", "G6");
                            comprobacion = true;
                        }


                    }
                    /*vertical arriba*/
                    if (B5.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (B4.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "B5");
                            comprobacion = true;
                        }
                        if ((B3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B5");
                            pintar("blanco", "B4");
                            comprobacion = true;
                        }
                        if ((B2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B5");
                            pintar("blanco", "B4");
                            pintar("blanco", "B3");
                            comprobacion = true;
                        }
                        if ((B1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B5");
                            pintar("blanco", "B4");
                            pintar("blanco", "B3");
                            pintar("blanco", "B2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (B7.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (B8.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "B7");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true)
                {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
            }

            if (Posicion == "C6")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {
                    /*horizontal izquierda*/
                    if (B6.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (A6.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "B6");
                            comprobacion = true;
                        }
                    }
                    /*horizontal derecha*/
                    if (D6.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (E6.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "D6");
                            comprobacion = true;
                        }
                        if ((F6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D6");
                            pintar("negro", "E6");
                            comprobacion = true;
                        }
                        if ((G6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D6");
                            pintar("negro", "E6");
                            pintar("negro", "F6");
                            comprobacion = true;
                        }
                        if ((G6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D6");
                            pintar("negro", "E6");
                            pintar("negro", "F6");
                            pintar("negro", "G6");
                            comprobacion = true;
                        }
                    }
                    /*vertical arriba*/
                    if (C2.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (C1.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "C2");
                            comprobacion = true;
                        }
                    }
                    /*vertical arriba*/
                    if (C5.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (C4.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "C5");
                            comprobacion = true;
                        }
                        if ((C3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C5");
                            pintar("negro", "C4");
                            comprobacion = true;
                        }
                        if ((C2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C5");
                            pintar("negro", "C4");
                            pintar("negro", "C3");
                            comprobacion = true;
                        }
                        if ((C1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C5");
                            pintar("negro", "C4");
                            pintar("negro", "C3");
                            pintar("negro", "C2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (C7.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (C8.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "C7");
                            comprobacion = true;
                        }
                    }

                }
                if (colorJ == "blanco")
                {
                    /*horizontal izquierda*/
                    if (B6.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (A6.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "B6");
                            comprobacion = true;
                        }
                    }

                    /*horizontal derecha*/
                    if (D6.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (E6.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "D6");
                            comprobacion = true;
                        }
                        if ((F6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D6");
                            pintar("blanco", "E6");
                            comprobacion = true;
                        }
                        if ((F6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D6");
                            pintar("blanco", "E6");
                            pintar("blanco", "F6");
                            comprobacion = true;
                        }
                        if ((H6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D6");
                            pintar("blanco", "E6");
                            pintar("blanco", "F6");
                            pintar("blanco", "G6");
                            comprobacion = true;
                        }


                    }
                    /*vertical arriba*/
                    if (C5.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (C4.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "C5");
                            comprobacion = true;
                        }
                        if ((C3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C5");
                            pintar("blanco", "C4");
                            comprobacion = true;
                        }
                        if ((C2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C5");
                            pintar("blanco", "C4");
                            pintar("blanco", "C3");
                            comprobacion = true;
                        }
                        if ((C1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C5");
                            pintar("blanco", "C4");
                            pintar("blanco", "C3");
                            pintar("blanco", "C2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (C7.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (C8.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "C7");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true)
                {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
            }

            if (Posicion == "D6")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {
                    /*horizontal izquierda*/
                    if (C6.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (B6.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "C6");
                            comprobacion = true;
                        }
                        if ((A6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C6");
                            pintar("negro", "B6");
                            comprobacion = true;
                        }
                    }
                    /*horizontal derecha*/
                    if (E6.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (F6.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "E6");
                            comprobacion = true;
                        }
                        if ((G6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E6");
                            pintar("negro", "F6");
                            comprobacion = true;
                        }
                        if ((G6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("negro", "E6");
                            pintar("negro", "F6");
                            pintar("negro", "G6");
                            comprobacion = true;
                        }
                    }
                    /*vertical arriba*/
                    if (D5.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (D4.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "D5");
                            comprobacion = true;
                        }
                        if ((D3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D5");
                            pintar("negro", "D4");
                            comprobacion = true;
                        }
                        if ((D2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D5");
                            pintar("negro", "D4");
                            pintar("negro", "D3");
                            comprobacion = true;
                        }
                        if ((D1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D5");
                            pintar("negro", "D4");
                            pintar("negro", "D3");
                            pintar("negro", "D2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (D7.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (D8.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "D7");
                            comprobacion = true;
                        }
                    }

                }
                if (colorJ == "blanco")
                {
                    /*horizontal izquierda*/
                    if (C6.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (B6.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "C6");
                            comprobacion = true;
                        }
                        if ((B6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("blanco", "C6");
                            pintar("blanco", "B6");
                            comprobacion = true;
                        }
                    }

                    /*horizontal derecha*/
                    if (E6.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (F6.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "E6");
                            comprobacion = true;
                        }
                        if ((F6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("blanco", "E6");
                            pintar("blanco", "F6");
                            comprobacion = true;
                        }
                        if ((H6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E6");
                            pintar("blanco", "F6");
                            pintar("blanco", "G6");
                            comprobacion = true;
                        }
                    }
                    /*vertical arriba*/
                    if (D5.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (D4.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "D5");
                            comprobacion = true;
                        }
                        if ((D3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D5");
                            pintar("blanco", "D4");
                            comprobacion = true;
                        }
                        if ((D2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D5");
                            pintar("blanco", "D4");
                            pintar("blanco", "D3");
                            comprobacion = true;
                        }
                        if ((D1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D5");
                            pintar("blanco", "D4");
                            pintar("blanco", "D3");
                            pintar("blanco", "D2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (D7.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (D8.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "D7");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true)
                {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
            }

            if (Posicion == "E6")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {
                    /*horizontal izquierda*/
                    if (D6.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (C6.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "D6");
                            comprobacion = true;
                        }
                        if ((B6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D6");
                            pintar("negro", "C6");
                            comprobacion = true;
                        }
                        if ((A6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D3");
                            pintar("negro", "C3");
                            pintar("negro", "B3");
                            comprobacion = true;
                        }
                    }
                    /*horizontal derecha*/
                    if (F6.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (G6.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "F6");
                            comprobacion = true;
                        }
                        if ((H6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F6");
                            pintar("negro", "G6");
                            comprobacion = true;
                        }
                    }
                    /*vertical arriba*/
                    if (E5.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (E4.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "E5");
                            comprobacion = true;
                        }
                        if ((E3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E5");
                            pintar("negro", "E4");
                            comprobacion = true;
                        }
                        if ((E2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E5");
                            pintar("negro", "E4");
                            pintar("negro", "E3");
                            comprobacion = true;
                        }
                        if ((E1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E5");
                            pintar("negro", "E4");
                            pintar("negro", "E3");
                            pintar("negro", "E2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (E7.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (E8.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "E7");
                            comprobacion = true;
                        }
                    }

                }
                if (colorJ == "blanco")
                {
                    /*horizontal izquierda*/
                    if (D6.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (C6.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "D6");
                            comprobacion = true;
                        }
                        if ((B6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D6");
                            pintar("blanco", "C6");
                            comprobacion = true;
                        }
                        if ((A6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D6");
                            pintar("blanco", "C6");
                            pintar("blanco", "B6");
                            comprobacion = true;
                        }
                    }

                    /*horizontal derecha*/
                    if (E6.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (G6.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "F6");
                            comprobacion = true;
                        }
                        if ((H6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F6");
                            pintar("blanco", "G6");
                            comprobacion = true;
                        }
                    }
                    /*vertical arriba*/
                    if (E5.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (E4.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "E5");
                            comprobacion = true;
                        }
                        if ((E3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E5");
                            pintar("blanco", "E4");
                            comprobacion = true;
                        }
                        if ((E2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E5");
                            pintar("blanco", "E4");
                            pintar("blanco", "E3");
                            comprobacion = true;
                        }
                        if ((E1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E5");
                            pintar("blanco", "E4");
                            pintar("blanco", "E3");
                            pintar("blanco", "E2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (E7.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (E8.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "E7");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true)
                {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
            }

            if (Posicion == "F6")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {
                    /*horizontal izquierda*/
                    if (E6.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (D6.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "E6");
                            comprobacion = true;
                        }
                        if ((C6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E6");
                            pintar("negro", "D6");
                            comprobacion = true;
                        }
                        if ((B6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E6");
                            pintar("negro", "D6");
                            pintar("negro", "C6");
                            comprobacion = true;
                        }
                        if ((A6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E6");
                            pintar("negro", "D6");
                            pintar("negro", "C6");
                            pintar("negro", "B6");
                            comprobacion = true;
                        }
                    }
                    /*horizontal derecha*/
                    if (G6.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (H6.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "G6");
                            comprobacion = true;
                        }
                    }
                    /*vertical arriba*/
                    if (F5.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (F4.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "F5");
                            comprobacion = true;
                        }
                        if ((F3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F5");
                            pintar("negro", "F4");
                            comprobacion = true;
                        }
                        if ((F2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F5");
                            pintar("negro", "F4");
                            pintar("negro", "F3");
                            comprobacion = true;
                        }
                        if ((F1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F5");
                            pintar("negro", "F4");
                            pintar("negro", "F3");
                            pintar("negro", "F2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (F7.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (F8.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "F7");
                            comprobacion = true;
                        }
                    }
                    /*diagonal hacia arriba izquierda*/
                    if (E5.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (D4.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "E5");
                            comprobacion = true;
                        }
                        if ((C3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E5");
                            pintar("negro", "D4");
                            comprobacion = true;
                        }
                        if ((B2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E5");
                            pintar("negro", "D4");
                            pintar("negro", "C3");
                            comprobacion = true;
                        }
                        if ((A1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E5");
                            pintar("negro", "D4");
                            pintar("negro", "C3");
                            pintar("negro", "B2");
                            comprobacion = true;
                        }
                    }
                    /*diagonal hacia abajo derecha*/
                    if (G7.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (H8.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "G7");
                            comprobacion = true;
                        }
                    }

                }
                if (colorJ == "blanco")
                {
                    /*horizontal izquierda*/
                    if (E6.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (D6.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "E6");
                            comprobacion = true;
                        }
                        if ((C6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E6");
                            pintar("blanco", "D6");
                            comprobacion = true;
                        }
                        if ((B6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E6");
                            pintar("blanco", "D6");
                            pintar("blanco", "C6");
                            comprobacion = true;
                        }
                        if ((A6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E6");
                            pintar("blanco", "D6");
                            pintar("blanco", "C6");
                            pintar("blanco", "B6");
                            comprobacion = true;
                        }
                    }

                    /*horizontal derecha*/
                    if (G6.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (H6.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "G6");
                            comprobacion = true;
                        }
                    }
                    /*vertical arriba*/
                    if (F5.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (F4.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "F5");
                            comprobacion = true;
                        }
                        if ((F3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F5");
                            pintar("blanco", "F4");
                            comprobacion = true;
                        }
                        if ((F2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F5");
                            pintar("blanco", "F4");
                            pintar("blanco", "F3");
                            comprobacion = true;
                        }
                        if ((F1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F5");
                            pintar("blanco", "F4");
                            pintar("blanco", "F3");
                            pintar("blanco", "F2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (F7.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (F8.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "F7");
                            comprobacion = true;
                        }
                    }
                    /*diagonal hacia arriba izquierda*/
                    if (E5.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (D4.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "E5");
                            comprobacion = true;
                        }
                        if ((C3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E5");
                            pintar("blanco", "D4");
                            comprobacion = true;
                        }
                        if ((B2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E5");
                            pintar("blanco", "D4");
                            pintar("blanco", "C3");
                            comprobacion = true;
                        }
                        if ((A1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E5");
                            pintar("blanco", "D4");
                            pintar("blanco", "C3");
                            pintar("blanco", "B2");
                            comprobacion = true;
                        }
                    }
                    /*diagonal hacia abajo derecha*/
                    if (G7.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (H8.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "G7");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true)
                {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
            }

            if (Posicion == "G6")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {
                    /*horizontal izquierda*/
                    if (F6.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (E6.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "F6");
                            comprobacion = true;
                        }
                        if ((D6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F6");
                            pintar("negro", "E6");
                            comprobacion = true;
                        }
                        if ((C6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F6");
                            pintar("negro", "E6");
                            pintar("negro", "D6");
                            comprobacion = true;
                        }
                        if ((B6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F6");
                            pintar("negro", "E6");
                            pintar("negro", "D6");
                            pintar("negro", "C6");
                            comprobacion = true;
                        }
                        if ((A6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F6");
                            pintar("negro", "E6");
                            pintar("negro", "D6");
                            pintar("negro", "C6");
                            pintar("negro", "B6");
                            comprobacion = true;
                        }
                    }
                    /*vertical arriba*/
                    if (G5.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (G4.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "G5");
                            comprobacion = true;
                        }
                        if ((G3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G5");
                            pintar("negro", "G4");
                            comprobacion = true;
                        }
                        if ((G2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G5");
                            pintar("negro", "G4");
                            pintar("negro", "G3");
                            comprobacion = true;
                        }
                        if ((G1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G5");
                            pintar("negro", "G4");
                            pintar("negro", "G3");
                            pintar("negro", "G2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (G7.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (G8.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "G7");
                            comprobacion = true;
                        }
                    }
                    /*diagonal hacia arriba izquierda*/
                    if (F5.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (E4.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "F5");
                            comprobacion = true;
                        }
                        if ((D3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F5");
                            pintar("negro", "E4");
                            comprobacion = true;
                        }
                        if ((C2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F5");
                            pintar("negro", "E4");
                            pintar("negro", "D3");
                            comprobacion = true;
                        }
                        if ((B1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F5");
                            pintar("negro", "E4");
                            pintar("negro", "D3");
                            pintar("negro", "C2");
                            comprobacion = true;
                        }
                    }
                }
                if (colorJ == "blanco")
                {
                    /*horizontal izquierda*/
                    if (F6.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (E6.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "F6");
                            comprobacion = true;
                        }
                        if ((D6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F6");
                            pintar("blanco", "E6");
                            comprobacion = true;
                        }
                        if ((C6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F6");
                            pintar("blanco", "E6");
                            pintar("blanco", "D6");
                            comprobacion = true;
                        }
                        if ((B6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F6");
                            pintar("blanco", "E6");
                            pintar("blanco", "D6");
                            pintar("blanco", "C6");
                            comprobacion = true;
                        }
                        if ((A6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F6");
                            pintar("blanco", "E6");
                            pintar("blanco", "D6");
                            pintar("blanco", "C6");
                            pintar("blanco", "B6");
                            comprobacion = true;
                        }
                    }
                    /*vertical arriba*/
                    if (G5.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (G4.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "G5");
                            comprobacion = true;
                        }
                        if ((G3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G5");
                            pintar("blanco", "G4");
                            comprobacion = true;
                        }
                        if ((G2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G5");
                            pintar("blanco", "G4");
                            pintar("blanco", "G3");
                            comprobacion = true;
                        }
                        if ((G1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G5");
                            pintar("blanco", "G4");
                            pintar("blanco", "G3");
                            pintar("blanco", "G2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (G7.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (G8.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "G7");
                            comprobacion = true;
                        }
                    }
                    /*diagonal hacia arriba izquierda*/
                    if (F5.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (E4.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "F5");
                            comprobacion = true;
                        }
                        if ((D3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F5");
                            pintar("blanco", "E4");
                            comprobacion = true;
                        }
                        if ((C2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F5");
                            pintar("blanco", "E4");
                            pintar("blanco", "D3");
                            comprobacion = true;
                        }
                        if ((B1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F5");
                            pintar("blanco", "E4");
                            pintar("blanco", "D3");
                            pintar("blanco", "C2");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true)
                {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
            }

            if (Posicion == "H6")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {
                    /*horizontal izquierda*/
                    if (G6.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (F6.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "G6");
                            comprobacion = true;
                        }
                        if ((E6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G6");
                            pintar("negro", "F6");
                            comprobacion = true;
                        }
                        if ((D6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G6");
                            pintar("negro", "F6");
                            pintar("negro", "E6");
                            comprobacion = true;
                        }
                        if ((C6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G6");
                            pintar("negro", "F6");
                            pintar("negro", "E6");
                            pintar("negro", "D6");
                            comprobacion = true;
                        }
                        if ((B6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G6");
                            pintar("negro", "F6");
                            pintar("negro", "E6");
                            pintar("negro", "D6");
                            pintar("negro", "C6");
                            comprobacion = true;
                        }
                        if ((A6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G6");
                            pintar("negro", "F6");
                            pintar("negro", "E6");
                            pintar("negro", "D6");
                            pintar("negro", "C6");
                            pintar("negro", "B6");
                            comprobacion = true;
                        }
                    }

                    /*vertical arriba*/
                    if (H5.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (H4.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "H5");
                            comprobacion = true;
                        }
                        if ((H3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "H5");
                            pintar("negro", "H4");
                            comprobacion = true;
                        }
                        if ((H2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "H5");
                            pintar("negro", "H4");
                            pintar("negro", "H3");
                            comprobacion = true;
                        }
                        if ((H1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "H5");
                            pintar("negro", "H4");
                            pintar("negro", "H3");
                            pintar("negro", "H2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (H7.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (H8.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "H7");
                            comprobacion = true;
                        }
                    }
                    /*diagonal hacia arriba izquierda*/
                    if (G5.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (F4.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "G5");
                            comprobacion = true;
                        }
                        if ((E3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G5");
                            pintar("negro", "F4");
                            comprobacion = true;
                        }
                        if ((D2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G5");
                            pintar("negro", "F4");
                            pintar("negro", "E3");
                            comprobacion = true;
                        }
                        if ((C1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F4.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G5");
                            pintar("negro", "F4");
                            pintar("negro", "E3");
                            pintar("negro", "D2");
                            comprobacion = true;
                        }
                    }
                }
                if (colorJ == "blanco")
                {
                    /*horizontal izquierda*/
                    if (G6.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (F6.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "G6");
                            comprobacion = true;
                        }
                        if ((E6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G6");
                            pintar("blanco", "F6");
                            comprobacion = true;
                        }
                        if ((D6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G6");
                            pintar("blanco", "F6");
                            pintar("blanco", "E6");
                            comprobacion = true;
                        }
                        if ((C6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G6");
                            pintar("blanco", "F6");
                            pintar("blanco", "E6");
                            pintar("blanco", "D6");
                            comprobacion = true;
                        }
                        if ((B6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G6");
                            pintar("blanco", "F6");
                            pintar("blanco", "E6");
                            pintar("blanco", "D6");
                            pintar("blanco", "C6");
                            comprobacion = true;
                        }
                        if ((A6.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E6.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G6");
                            pintar("blanco", "F6");
                            pintar("blanco", "E6");
                            pintar("blanco", "D6");
                            pintar("blanco", "C6");
                            pintar("blanco", "B6");
                            comprobacion = true;
                        }
                    }
                    /*vertical arriba*/
                    if (H5.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (H4.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "H5");
                            comprobacion = true;
                        }
                        if ((H3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "H5");
                            pintar("blanco", "H4");
                            comprobacion = true;
                        }
                        if ((H2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "H5");
                            pintar("blanco", "H4");
                            pintar("blanco", "H3");
                            comprobacion = true;
                        }
                        if ((H1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "H5");
                            pintar("blanco", "H4");
                            pintar("blanco", "H3");
                            pintar("blanco", "H2");
                            comprobacion = true;
                        }
                    }
                    /*vertical abajo*/
                    if (H7.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (H8.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "H7");
                            comprobacion = true;
                        }
                    }
                    /*diagonal hacia arriba izquierda*/
                    if (G5.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (F4.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "G5");
                            comprobacion = true;
                        }
                        if ((E3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G5");
                            pintar("blanco", "F4");
                            comprobacion = true;
                        }
                        if ((D2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G5");
                            pintar("blanco", "F4");
                            pintar("blanco", "E3");
                            comprobacion = true;
                        }
                        if ((C1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F4.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G5");
                            pintar("blanco", "F4");
                            pintar("blanco", "E3");
                            pintar("blanco", "D2");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true)
                {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
            }


            if (Posicion == "A7")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {

                    /*horizontal derecha*/
                    if (B7.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (C7.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "B7");
                            comprobacion = true;
                        }
                        if ((D7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C7.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B7");
                            pintar("negro", "C7");
                            comprobacion = true;
                        }

                        if ((E7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C7.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B7");
                            pintar("negro", "C7");
                            pintar("negro", "D7");
                            comprobacion = true;
                        }
                        if ((F7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C7.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B7");
                            pintar("negro", "C7");
                            pintar("negro", "D7");
                            pintar("negro", "E7");
                            comprobacion = true;
                        }
                        if ((G7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C7.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B7");
                            pintar("negro", "C7");
                            pintar("negro", "D7");
                            pintar("negro", "E7");
                            pintar("negro", "F7");
                            comprobacion = true;
                        }
                        if ((G7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C7.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B7");
                            pintar("negro", "C7");
                            pintar("negro", "D7");
                            pintar("negro", "E7");
                            pintar("negro", "F7");
                            pintar("negro", "G7");
                            comprobacion = true;
                        }
                    }
                    /*vertical arriba*/
                    if (A6.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (A5.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "A6");
                            comprobacion = true;
                        }
                        if ((A4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A5.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "A6");
                            pintar("negro", "A5");
                            comprobacion = true;
                        }
                        if ((A3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A5.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "A6");
                            pintar("negro", "A5");
                            pintar("negro", "A4");
                            comprobacion = true;
                        }
                        if ((A2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A5.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "A6");
                            pintar("negro", "A5");
                            pintar("negro", "A4");
                            pintar("negro", "A3");
                            comprobacion = true;
                        }
                        if ((A1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A5.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "A6");
                            pintar("negro", "A5");
                            pintar("negro", "A4");
                            pintar("negro", "A3");
                            pintar("negro", "A2");
                            comprobacion = true;
                        }
                    }

                }
                if (colorJ == "blanco")
                {
                    /*horizontal derecha*/
                    if (B7.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (C7.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "B7");
                            comprobacion = true;
                        }
                        if ((D7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C7.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B7");
                            pintar("blanco", "C7");
                            comprobacion = true;
                        }

                        if ((E7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C7.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B7");
                            pintar("blanco", "C7");
                            pintar("blanco", "D7");
                            comprobacion = true;
                        }
                        if ((F7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C7.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B7");
                            pintar("blanco", "C7");
                            pintar("blanco", "D7");
                            pintar("blanco", "E7");
                            comprobacion = true;
                        }
                        if ((G7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C7.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B7");
                            pintar("blanco", "C7");
                            pintar("blanco", "D7");
                            pintar("blanco", "E7");
                            pintar("blanco", "F7");
                            comprobacion = true;
                        }
                        if ((G7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C7.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B7");
                            pintar("blanco", "C7");
                            pintar("blanco", "D7");
                            pintar("blanco", "E7");
                            pintar("blanco", "F7");
                            pintar("blanco", "G7");
                            comprobacion = true;
                        }


                    }
                    /*vertical arriba*/
                    if (A6.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (A5.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "A6");
                            comprobacion = true;
                        }
                        if ((A4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A5.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "A6");
                            pintar("blanco", "A5");
                            comprobacion = true;
                        }
                        if ((A3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A5.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "A6");
                            pintar("blanco", "A5");
                            pintar("blanco", "A4");
                            comprobacion = true;
                        }
                        if ((A2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A5.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "A6");
                            pintar("blanco", "A5");
                            pintar("blanco", "A4");
                            pintar("blanco", "A3");
                            comprobacion = true;
                        }
                        if ((A1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A5.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "A6");
                            pintar("blanco", "A5");
                            pintar("blanco", "A4");
                            pintar("blanco", "A3");
                            pintar("blanco", "A2");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true)
                {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
            }

            if (Posicion == "B7")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {

                    /*horizontal derecha*/
                    if (C7.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (D7.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "C7");
                            comprobacion = true;
                        }

                        if ((E7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D7.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C7");
                            pintar("negro", "D7");
                            comprobacion = true;
                        }
                        if ((F7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D7.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C7");
                            pintar("negro", "D7");
                            pintar("negro", "E7");
                            comprobacion = true;
                        }
                        if ((G7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D7.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C7");
                            pintar("negro", "D7");
                            pintar("negro", "E7");
                            pintar("negro", "F7");
                            comprobacion = true;
                        }
                        if ((G7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D7.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C7");
                            pintar("negro", "D7");
                            pintar("negro", "E7");
                            pintar("negro", "F7");
                            pintar("negro", "G7");
                            comprobacion = true;
                        }
                    }
                    /*vertical arriba*/
                    if (B6.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (B5.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "B6");
                            comprobacion = true;
                        }
                        if ((B4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B5.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B6");
                            pintar("negro", "B5");
                            comprobacion = true;
                        }
                        if ((B3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B5.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B6");
                            pintar("negro", "B5");
                            pintar("negro", "B4");
                            comprobacion = true;
                        }
                        if ((B2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B5.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B6");
                            pintar("negro", "B5");
                            pintar("negro", "B4");
                            pintar("negro", "B3");
                            comprobacion = true;
                        }
                        if ((B1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B5.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B6");
                            pintar("negro", "B5");
                            pintar("negro", "B4");
                            pintar("negro", "B3");
                            pintar("negro", "B2");
                            comprobacion = true;
                        }
                    }

                }
                if (colorJ == "blanco")
                {
                    /*horizontal derecha*/
                    if (C7.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (D7.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "C7");
                            comprobacion = true;
                        }

                        if ((E7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D7.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C7");
                            pintar("blanco", "D7");
                            comprobacion = true;
                        }
                        if ((F7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D7.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C7");
                            pintar("blanco", "D7");
                            pintar("blanco", "E7");
                            comprobacion = true;
                        }
                        if ((G7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E7.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C7");
                            pintar("blanco", "D7");
                            pintar("blanco", "E7");
                            pintar("blanco", "F7");
                            comprobacion = true;
                        }
                        if ((G7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C7");
                            pintar("blanco", "D7");
                            pintar("blanco", "E7");
                            pintar("blanco", "F7");
                            pintar("blanco", "G7");
                            comprobacion = true;
                        }


                    }
                    /*vertical arriba*/
                    if (B6.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (B5.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "B6");
                            comprobacion = true;
                        }
                        if ((B4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B5.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B6");
                            pintar("blanco", "B5");
                            comprobacion = true;
                        }
                        if ((B3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B5.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B6");
                            pintar("blanco", "B5");
                            pintar("blanco", "B4");
                            comprobacion = true;
                        }
                        if ((B2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B5.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B6");
                            pintar("blanco", "B5");
                            pintar("blanco", "B4");
                            pintar("blanco", "B3");
                            comprobacion = true;
                        }
                        if ((B1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B5.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B6");
                            pintar("blanco", "B5");
                            pintar("blanco", "B4");
                            pintar("blanco", "B3");
                            pintar("blanco", "B2");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true)
                {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
            }

            if (Posicion == "C7")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {
                    /*horizontal izquierda*/
                    if (B7.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (A7.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "B7");
                            comprobacion = true;
                        }
                    }
                    /*horizontal derecha*/
                    if (D7.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (E7.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "D7");
                            comprobacion = true;
                        }
                        if ((F7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E7.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D7");
                            pintar("negro", "E7");
                            comprobacion = true;
                        }
                        if ((G7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E7.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D7");
                            pintar("negro", "E7");
                            pintar("negro", "F7");
                            comprobacion = true;
                        }
                        if ((G7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D7");
                            pintar("negro", "E7");
                            pintar("negro", "F7");
                            pintar("negro", "G7");
                            comprobacion = true;
                        }
                    }
                    /*vertical arriba*/
                    if (C6.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (C5.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "C6");
                            comprobacion = true;
                        }
                        if ((C4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C5.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C6");
                            pintar("negro", "C5");
                            comprobacion = true;
                        }
                        if ((C3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C5.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C6");
                            pintar("negro", "C5");
                            pintar("negro", "C4");
                            comprobacion = true;
                        }
                        if ((C2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C5.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C6");
                            pintar("negro", "C5");
                            pintar("negro", "C4");
                            pintar("negro", "C3");
                            comprobacion = true;
                        }
                        if ((C1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C5.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C6");
                            pintar("negro", "C5");
                            pintar("negro", "C4");
                            pintar("negro", "C3");
                            pintar("negro", "C2");
                            comprobacion = true;
                        }
                    }

                }
                if (colorJ == "blanco")
                {
                    /*horizontal izquierda*/
                    if (B7.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (A7.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "B7");
                            comprobacion = true;
                        }
                    }

                    /*horizontal derecha*/
                    if (D7.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (E7.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "D7");
                            comprobacion = true;
                        }
                        if ((F7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E7.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D7");
                            pintar("blanco", "E7");
                            comprobacion = true;
                        }
                        if ((F7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E7.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D7");
                            pintar("blanco", "E7");
                            pintar("blanco", "F7");
                            comprobacion = true;
                        }
                        if ((H7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E7.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D7");
                            pintar("blanco", "E7");
                            pintar("blanco", "F7");
                            pintar("blanco", "G7");
                            comprobacion = true;
                        }


                    }
                    /*vertical arriba*/
                    if (C6.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (C5.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "C6");
                            comprobacion = true;
                        }
                        if ((C4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C5.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C6");
                            pintar("blanco", "C5");
                            comprobacion = true;
                        }
                        if ((C3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C5.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C6");
                            pintar("blanco", "C5");
                            pintar("blanco", "C4");
                            comprobacion = true;
                        }
                        if ((C2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C5.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C6");
                            pintar("blanco", "C5");
                            pintar("blanco", "C4");
                            pintar("blanco", "C3");
                            comprobacion = true;
                        }
                        if ((C1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C5.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C6");
                            pintar("blanco", "C5");
                            pintar("blanco", "C4");
                            pintar("blanco", "C3");
                            pintar("blanco", "C2");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true)
                {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
            }

            if (Posicion == "D7")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {
                    /*horizontal izquierda*/
                    if (C7.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (B7.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "C7");
                            comprobacion = true;
                        }
                        if ((A7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B7.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C7");
                            pintar("negro", "B7");
                            comprobacion = true;
                        }
                    }
                    /*horizontal derecha*/
                    if (E7.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (F7.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "E7");
                            comprobacion = true;
                        }
                        if ((G7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F7.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E7");
                            pintar("negro", "F7");
                            comprobacion = true;
                        }
                        if ((G7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H7.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("negro", "E7");
                            pintar("negro", "F7");
                            pintar("negro", "G7");
                            comprobacion = true;
                        }
                    }
                    /*vertical arriba*/
                    if (D6.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (D5.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "D6");
                            comprobacion = true;
                        }
                        if ((D4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D5.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D6");
                            pintar("negro", "D5");
                            comprobacion = true;
                        }
                        if ((D3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D5.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D6");
                            pintar("negro", "D5");
                            pintar("negro", "D4");
                            comprobacion = true;
                        }
                        if ((D2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D5.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D6");
                            pintar("negro", "D5");
                            pintar("negro", "D4");
                            pintar("negro", "D3");
                            comprobacion = true;
                        }
                        if ((D1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D5.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D6");
                            pintar("negro", "D5");
                            pintar("negro", "D4");
                            pintar("negro", "D3");
                            pintar("negro", "D2");
                            comprobacion = true;
                        }
                    }

                }
                if (colorJ == "blanco")
                {
                    /*horizontal izquierda*/
                    if (C7.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (B7.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "C7");
                            comprobacion = true;
                        }
                        if ((B7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A7.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("blanco", "C7");
                            pintar("blanco", "B7");
                            comprobacion = true;
                        }
                    }

                    /*horizontal derecha*/
                    if (E7.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (F7.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "E7");
                            comprobacion = true;
                        }
                        if ((F7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G7.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("blanco", "E7");
                            pintar("blanco", "F7");
                            comprobacion = true;
                        }
                        if ((H7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G7.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E7");
                            pintar("blanco", "F7");
                            pintar("blanco", "G7");
                            comprobacion = true;
                        }
                    }
                    /*vertical arriba*/
                    if (D6.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (D5.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "D6");
                            comprobacion = true;
                        }
                        if ((D4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D5.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D6");
                            pintar("blanco", "D5");
                            comprobacion = true;
                        }
                        if ((D3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D5.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D6");
                            pintar("blanco", "D5");
                            pintar("blanco", "D4");
                            comprobacion = true;
                        }
                        if ((D2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D5.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D6");
                            pintar("blanco", "D5");
                            pintar("blanco", "D4");
                            pintar("blanco", "D3");
                            comprobacion = true;
                        }
                        if ((D1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D5.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D6");
                            pintar("blanco", "D5");
                            pintar("blanco", "D4");
                            pintar("blanco", "D3");
                            pintar("blanco", "D2");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true)
                {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
            }

            if (Posicion == "E7")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {
                    /*horizontal izquierda*/
                    if (D7.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (C7.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "D7");
                            comprobacion = true;
                        }
                        if ((B7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C7.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D7");
                            pintar("negro", "C7");
                            comprobacion = true;
                        }
                        if ((A7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C7.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D3");
                            pintar("negro", "C3");
                            pintar("negro", "B3");
                            comprobacion = true;
                        }
                    }
                    /*horizontal derecha*/
                    if (F7.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (G7.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "F7");
                            comprobacion = true;
                        }
                        if ((H7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G7.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F7");
                            pintar("negro", "G7");
                            comprobacion = true;
                        }
                    }
                    /*vertical arriba*/
                    if (E6.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (E5.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "E6");
                            comprobacion = true;
                        }
                        if ((E4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E5.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E6");
                            pintar("negro", "E5");
                            comprobacion = true;
                        }
                        if ((E3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E5.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E6");
                            pintar("negro", "E5");
                            pintar("negro", "E4");
                            comprobacion = true;
                        }
                        if ((E2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E5.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E6");
                            pintar("negro", "E5");
                            pintar("negro", "E4");
                            pintar("negro", "E3");
                            comprobacion = true;
                        }
                        if ((E1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E5.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E6");
                            pintar("negro", "E5");
                            pintar("negro", "E4");
                            pintar("negro", "E3");
                            pintar("negro", "E2");
                            comprobacion = true;
                        }
                    }

                }
                if (colorJ == "blanco")
                {
                    /*horizontal izquierda*/
                    if (D7.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (C7.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "D7");
                            comprobacion = true;
                        }
                        if ((B7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C7.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D7");
                            pintar("blanco", "C7");
                            comprobacion = true;
                        }
                        if ((A7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C7.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D7");
                            pintar("blanco", "C7");
                            pintar("blanco", "B7");
                            comprobacion = true;
                        }
                    }

                    /*horizontal derecha*/
                    if (E7.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (G7.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "F7");
                            comprobacion = true;
                        }
                        if ((H7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G7.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F7");
                            pintar("blanco", "G7");
                            comprobacion = true;
                        }
                    }
                    /*vertical arriba*/
                    if (E6.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (E5.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "E6");
                            comprobacion = true;
                        }
                        if ((E4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E5.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E6");
                            pintar("blanco", "E5");
                            comprobacion = true;
                        }
                        if ((E3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E5.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E6");
                            pintar("blanco", "E5");
                            pintar("blanco", "E4");
                            comprobacion = true;
                        }
                        if ((E2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E5.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E6");
                            pintar("blanco", "E5");
                            pintar("blanco", "E4");
                            pintar("blanco", "E3");
                            comprobacion = true;
                        }
                        if ((E1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E5.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E6");
                            pintar("blanco", "E5");
                            pintar("blanco", "E4");
                            pintar("blanco", "E3");
                            pintar("blanco", "E2");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true)
                {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
            }

            if (Posicion == "F7")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {
                    /*horizontal izquierda*/
                    if (E7.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (D7.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "E7");
                            comprobacion = true;
                        }
                        if ((C7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D7.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E7");
                            pintar("negro", "D7");
                            comprobacion = true;
                        }
                        if ((B7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D7.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E7");
                            pintar("negro", "D7");
                            pintar("negro", "C7");
                            comprobacion = true;
                        }
                        if ((A7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D7.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E7");
                            pintar("negro", "D7");
                            pintar("negro", "C7");
                            pintar("negro", "B7");
                            comprobacion = true;
                        }
                    }
                    /*horizontal derecha*/
                    if (G7.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (H7.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "G7");
                            comprobacion = true;
                        }
                    }
                    /*vertical arriba*/
                    if (F6.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (F5.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "F6");
                            comprobacion = true;
                        }
                        if ((F4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F5.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F6");
                            pintar("negro", "F5");
                            comprobacion = true;
                        }
                        if ((F3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F5.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F6");
                            pintar("negro", "F5");
                            pintar("negro", "F4");
                            comprobacion = true;
                        }
                        if ((F2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F5.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F6");
                            pintar("negro", "F5");
                            pintar("negro", "F4");
                            pintar("negro", "F3");
                            comprobacion = true;
                        }
                        if ((F1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F5.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F6");
                            pintar("negro", "F5");
                            pintar("negro", "F4");
                            pintar("negro", "F3");
                            pintar("negro", "F2");
                            comprobacion = true;
                        }
                    }

                }
                if (colorJ == "blanco")
                {
                    /*horizontal izquierda*/
                    if (E7.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (D7.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "E7");
                            comprobacion = true;
                        }
                        if ((C7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D7.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E7");
                            pintar("blanco", "D7");
                            comprobacion = true;
                        }
                        if ((B7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D7.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E7");
                            pintar("blanco", "D7");
                            pintar("blanco", "C7");
                            comprobacion = true;
                        }
                        if ((A7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D7.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E7");
                            pintar("blanco", "D7");
                            pintar("blanco", "C7");
                            pintar("blanco", "B7");
                            comprobacion = true;
                        }
                    }

                    /*horizontal derecha*/
                    if (G7.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (H7.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "G7");
                            comprobacion = true;
                        }
                    }
                    /*vertical arriba*/
                    if (F6.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (F5.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "F6");
                            comprobacion = true;
                        }
                        if ((F4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F5.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F6");
                            pintar("blanco", "F5");
                            comprobacion = true;
                        }
                        if ((F3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F5.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F6");
                            pintar("blanco", "F5");
                            pintar("blanco", "F4");
                            comprobacion = true;
                        }
                        if ((F2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F5.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F6");
                            pintar("blanco", "F5");
                            pintar("blanco", "F4");
                            pintar("blanco", "F3");
                            comprobacion = true;
                        }
                        if ((F1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F5.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F6");
                            pintar("blanco", "F5");
                            pintar("blanco", "F4");
                            pintar("blanco", "F3");
                            pintar("blanco", "F2");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true)
                {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
            }

            if (Posicion == "G7")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {
                    /*horizontal izquierda*/
                    if (F7.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (E7.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "F7");
                            comprobacion = true;
                        }
                        if ((D7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E7.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F7");
                            pintar("negro", "E7");
                            comprobacion = true;
                        }
                        if ((C7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E7.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F7");
                            pintar("negro", "E7");
                            pintar("negro", "D7");
                            comprobacion = true;
                        }
                        if ((B7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E7.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F7");
                            pintar("negro", "E7");
                            pintar("negro", "D7");
                            pintar("negro", "C7");
                            comprobacion = true;
                        }
                        if ((A7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E7.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F7");
                            pintar("negro", "E7");
                            pintar("negro", "D7");
                            pintar("negro", "C7");
                            pintar("negro", "B7");
                            comprobacion = true;
                        }
                    }
                    /*vertical arriba*/
                    if (G6.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (G5.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "G6");
                            comprobacion = true;
                        }
                        if ((G4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G5.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G6");
                            pintar("negro", "G5");
                            comprobacion = true;
                        }
                        if ((G3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G5.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G6");
                            pintar("negro", "G5");
                            pintar("negro", "G4");
                            comprobacion = true;
                        }
                        if ((G2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G5.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G6");
                            pintar("negro", "G5");
                            pintar("negro", "G4");
                            pintar("negro", "G3");
                            comprobacion = true;
                        }
                        if ((G1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G5.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G6");
                            pintar("negro", "G5");
                            pintar("negro", "G4");
                            pintar("negro", "G3");
                            pintar("negro", "G2");
                            comprobacion = true;
                        }
                    }
                    /*diagonal hacia arriba izquierda*/
                    if (F6.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (E5.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "F6");
                            comprobacion = true;
                        }
                        if ((D4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E5.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F6");
                            pintar("negro", "E5");
                            comprobacion = true;
                        }
                        if ((C3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E5.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F6");
                            pintar("negro", "E5");
                            pintar("negro", "D4");
                            comprobacion = true;
                        }
                        if ((B2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E5.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F6");
                            pintar("negro", "E5");
                            pintar("negro", "D4");
                            pintar("negro", "C3");
                            comprobacion = true;
                        }
                        if ((A1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E5.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F6");
                            pintar("negro", "E5");
                            pintar("negro", "D4");
                            pintar("negro", "C3");
                            pintar("negro", "B2");
                            comprobacion = true;
                        }
                    }

                }
                if (colorJ == "blanco")
                {
                    /*horizontal izquierda*/
                    if (F7.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (E7.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "F7");
                            comprobacion = true;
                        }
                        if ((D7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E7.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F7");
                            pintar("blanco", "E7");
                            comprobacion = true;
                        }
                        if ((C7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E7.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F7");
                            pintar("blanco", "E7");
                            pintar("blanco", "D7");
                            comprobacion = true;
                        }
                        if ((B7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E7.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F7");
                            pintar("blanco", "E7");
                            pintar("blanco", "D7");
                            pintar("blanco", "C7");
                            comprobacion = true;
                        }
                        if ((A7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E7.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F7");
                            pintar("blanco", "E7");
                            pintar("blanco", "D7");
                            pintar("blanco", "C7");
                            pintar("blanco", "B7");
                            comprobacion = true;
                        }
                    }
                    /*vertical arriba*/
                    if (G6.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (G5.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "G6");
                            comprobacion = true;
                        }
                        if ((G4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G5.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G6");
                            pintar("blanco", "G5");
                            comprobacion = true;
                        }
                        if ((G3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G5.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G6");
                            pintar("blanco", "G5");
                            pintar("blanco", "G4");
                            comprobacion = true;
                        }
                        if ((G2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G5.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G6");
                            pintar("blanco", "G5");
                            pintar("blanco", "G4");
                            pintar("blanco", "G3");
                            comprobacion = true;
                        }
                        if ((G1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G5.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G6");
                            pintar("blanco", "G5");
                            pintar("blanco", "G4");
                            pintar("blanco", "G3");
                            pintar("blanco", "G2");
                            comprobacion = true;
                        }
                    }
                    /*diagonal hacia arriba izquierda*/
                    if (F6.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (E5.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "F6");
                            comprobacion = true;
                        }
                        if ((D4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E5.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F6");
                            pintar("blanco", "E5");
                            comprobacion = true;
                        }
                        if ((C3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E5.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F6");
                            pintar("blanco", "E5");
                            pintar("blanco", "D4");
                            comprobacion = true;
                        }
                        if ((B2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E5.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F6");
                            pintar("blanco", "E5");
                            pintar("blanco", "D4");
                            pintar("blanco", "C3");
                            comprobacion = true;
                        }
                        if ((A1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E5.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F6");
                            pintar("blanco", "E5");
                            pintar("blanco", "D4");
                            pintar("blanco", "C3");
                            pintar("blanco", "B2");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true)
                {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
            }

            if (Posicion == "H7")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {
                    /*horizontal izquierda*/
                    if (G7.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (F7.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "G7");
                            comprobacion = true;
                        }
                        if ((E7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F7.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G7");
                            pintar("negro", "F7");
                            comprobacion = true;
                        }
                        if ((D7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F7.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G7");
                            pintar("negro", "F7");
                            pintar("negro", "E7");
                            comprobacion = true;
                        }
                        if ((C7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F7.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G7");
                            pintar("negro", "F7");
                            pintar("negro", "E7");
                            pintar("negro", "D7");
                            comprobacion = true;
                        }
                        if ((B7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F7.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G7");
                            pintar("negro", "F7");
                            pintar("negro", "E7");
                            pintar("negro", "D7");
                            pintar("negro", "C7");
                            comprobacion = true;
                        }
                        if ((A7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F7.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G7");
                            pintar("negro", "F7");
                            pintar("negro", "E7");
                            pintar("negro", "D7");
                            pintar("negro", "C7");
                            pintar("negro", "B7");
                            comprobacion = true;
                        }
                    }
                    /*vertical arriba*/
                    if (H6.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (H5.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "H6");
                            comprobacion = true;
                        }
                        if ((H4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H5.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "H6");
                            pintar("negro", "H5");
                            comprobacion = true;
                        }
                        if ((H3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H5.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "H6");
                            pintar("negro", "H5");
                            pintar("negro", "H4");
                            comprobacion = true;
                        }
                        if ((H2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H5.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "H6");
                            pintar("negro", "H5");
                            pintar("negro", "H4");
                            pintar("negro", "H3");
                            comprobacion = true;
                        }
                        if ((H1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H5.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "H6");
                            pintar("negro", "H5");
                            pintar("negro", "H4");
                            pintar("negro", "H3");
                            pintar("negro", "H2");
                            comprobacion = true;
                        }
                    }

                }
                if (colorJ == "blanco")
                {
                    /*horizontal izquierda*/
                    if (G7.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (F7.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "G7");
                            comprobacion = true;
                        }
                        if ((E7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F7.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G7");
                            pintar("blanco", "F7");
                            comprobacion = true;
                        }
                        if ((D7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F7.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G7");
                            pintar("blanco", "F7");
                            pintar("blanco", "E7");
                            comprobacion = true;
                        }
                        if ((C7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F7.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G7");
                            pintar("blanco", "F7");
                            pintar("blanco", "E7");
                            pintar("blanco", "D7");
                            comprobacion = true;
                        }
                        if ((B7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F7.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G7");
                            pintar("blanco", "F7");
                            pintar("blanco", "E7");
                            pintar("blanco", "D7");
                            pintar("blanco", "C7");
                            comprobacion = true;
                        }
                        if ((A7.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E7.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F7.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G7");
                            pintar("blanco", "F7");
                            pintar("blanco", "E7");
                            pintar("blanco", "D7");
                            pintar("blanco", "C7");
                            pintar("blanco", "B7");
                            comprobacion = true;
                        }
                    }
                    /*vertical arriba*/
                    if (H6.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (H5.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "H6");
                            comprobacion = true;
                        }
                        if ((H4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H5.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "H6");
                            pintar("blanco", "H5");
                            comprobacion = true;
                        }
                        if ((H3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H5.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "H6");
                            pintar("blanco", "H5");
                            pintar("blanco", "H4");
                            comprobacion = true;
                        }
                        if ((H2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H5.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "H6");
                            pintar("blanco", "H5");
                            pintar("blanco", "H4");
                            pintar("blanco", "H3");
                            comprobacion = true;
                        }
                        if ((H1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H5.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "H6");
                            pintar("blanco", "H5");
                            pintar("blanco", "H4");
                            pintar("blanco", "H3");
                            pintar("blanco", "H2");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true)
                {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
            }


            if (Posicion == "A8")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {

                    /*horizontal derecha*/
                    if (B8.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (C8.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "B8");
                            comprobacion = true;
                        }
                        if ((D8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C8.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B8");
                            pintar("negro", "C8");
                            comprobacion = true;
                        }

                        if ((E8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C8.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B8");
                            pintar("negro", "C8");
                            pintar("negro", "D8");
                            comprobacion = true;
                        }
                        if ((F8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C8.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B8");
                            pintar("negro", "C8");
                            pintar("negro", "D8");
                            pintar("negro", "E8");
                            comprobacion = true;
                        }
                        if ((G8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C8.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B8");
                            pintar("negro", "C8");
                            pintar("negro", "D8");
                            pintar("negro", "E8");
                            pintar("negro", "F8");
                            comprobacion = true;
                        }
                        if ((G8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C8.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B8");
                            pintar("negro", "C8");
                            pintar("negro", "D8");
                            pintar("negro", "E8");
                            pintar("negro", "F8");
                            pintar("negro", "G8");
                            comprobacion = true;
                        }
                    }
                    /*vertical arriba*/
                    if (A7.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (A6.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "A7");
                            comprobacion = true;
                        }
                        if ((A5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "A7");
                            pintar("negro", "A6");
                            comprobacion = true;
                        }
                        if ((A4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "A7");
                            pintar("negro", "A6");
                            pintar("negro", "A5");
                            comprobacion = true;
                        }
                        if ((A3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "A7");
                            pintar("negro", "A6");
                            pintar("negro", "A5");
                            pintar("negro", "A4");
                            comprobacion = true;
                        }
                        if ((A2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "A7");
                            pintar("negro", "A6");
                            pintar("negro", "A5");
                            pintar("negro", "A4");
                            pintar("negro", "A3");
                            comprobacion = true;
                        }
                        if ((A1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "A7");
                            pintar("negro", "A6");
                            pintar("negro", "A5");
                            pintar("negro", "A4");
                            pintar("negro", "A3");
                            pintar("negro", "A2");
                            comprobacion = true;
                        }
                    }


                }
                if (colorJ == "blanco")
                {
                    /*horizontal derecha*/
                    if (B8.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (C8.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "B8");
                            comprobacion = true;
                        }
                        if ((D8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C8.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B8");
                            pintar("blanco", "C8");
                            comprobacion = true;
                        }

                        if ((E8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C8.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B8");
                            pintar("blanco", "C8");
                            pintar("blanco", "D8");
                            comprobacion = true;
                        }
                        if ((F8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C8.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B8");
                            pintar("blanco", "C8");
                            pintar("blanco", "D8");
                            pintar("blanco", "E8");
                            comprobacion = true;
                        }
                        if ((G8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C8.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B8");
                            pintar("blanco", "C8");
                            pintar("blanco", "D8");
                            pintar("blanco", "E8");
                            pintar("blanco", "F8");
                            comprobacion = true;
                        }
                        if ((G8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C8.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B8");
                            pintar("blanco", "C8");
                            pintar("blanco", "D8");
                            pintar("blanco", "E8");
                            pintar("blanco", "F8");
                            pintar("blanco", "G8");
                            comprobacion = true;
                        }


                    }
                    /*vertical arriba*/
                    if (A7.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (A6.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "A7");
                            comprobacion = true;
                        }
                        if ((A5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "A7");
                            pintar("blanco", "A6");
                            comprobacion = true;
                        }
                        if ((A4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "A7");
                            pintar("blanco", "A6");
                            pintar("blanco", "A5");
                            comprobacion = true;
                        }
                        if ((A3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "A7");
                            pintar("blanco", "A6");
                            pintar("blanco", "A5");
                            pintar("blanco", "A4");
                            comprobacion = true;
                        }
                        if ((A2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "A7");
                            pintar("blanco", "A6");
                            pintar("blanco", "A5");
                            pintar("blanco", "A4");
                            pintar("blanco", "A3");
                            comprobacion = true;
                        }
                        if ((A1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (A3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "A7");
                            pintar("blanco", "A6");
                            pintar("blanco", "A5");
                            pintar("blanco", "A4");
                            pintar("blanco", "A3");
                            pintar("blanco", "A2");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true)
                {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
            }

            if (Posicion == "B8")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {

                    /*horizontal derecha*/
                    if (C8.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (D8.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "C8");
                            comprobacion = true;
                        }

                        if ((E8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D8.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C8");
                            pintar("negro", "D8");
                            comprobacion = true;
                        }
                        if ((F8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D8.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C8");
                            pintar("negro", "D8");
                            pintar("negro", "E8");
                            comprobacion = true;
                        }
                        if ((G8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D8.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C8");
                            pintar("negro", "D8");
                            pintar("negro", "E8");
                            pintar("negro", "F8");
                            comprobacion = true;
                        }
                        if ((G8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D8.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C8");
                            pintar("negro", "D8");
                            pintar("negro", "E8");
                            pintar("negro", "F8");
                            pintar("negro", "G8");
                            comprobacion = true;
                        }
                    }
                    /*vertical arriba*/
                    if (B7.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (B6.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "B7");
                            comprobacion = true;
                        }
                        if ((B5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B7");
                            pintar("negro", "B6");
                            comprobacion = true;
                        }
                        if ((B4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B7");
                            pintar("negro", "B6");
                            pintar("negro", "B5");
                            comprobacion = true;
                        }
                        if ((B3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B7");
                            pintar("negro", "B6");
                            pintar("negro", "B5");
                            pintar("negro", "B4");
                            comprobacion = true;
                        }
                        if ((B2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B7");
                            pintar("negro", "B6");
                            pintar("negro", "B5");
                            pintar("negro", "B4");
                            pintar("negro", "B3");
                            comprobacion = true;
                        }
                        if ((B1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "B7");
                            pintar("negro", "B6");
                            pintar("negro", "B5");
                            pintar("negro", "B4");
                            pintar("negro", "B3");
                            pintar("negro", "B2");
                            comprobacion = true;
                        }
                    }

                }
                if (colorJ == "blanco")
                {
                    /*horizontal derecha*/
                    if (C8.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (D8.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "C8");
                            comprobacion = true;
                        }

                        if ((E8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D8.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C8");
                            pintar("blanco", "D8");
                            comprobacion = true;
                        }
                        if ((F8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D8.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C8");
                            pintar("blanco", "D8");
                            pintar("blanco", "E8");
                            comprobacion = true;
                        }
                        if ((G8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E8.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C8");
                            pintar("blanco", "D8");
                            pintar("blanco", "E8");
                            pintar("blanco", "F8");
                            comprobacion = true;
                        }
                        if ((G8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D3.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C8");
                            pintar("blanco", "D8");
                            pintar("blanco", "E8");
                            pintar("blanco", "F8");
                            pintar("blanco", "G8");
                            comprobacion = true;
                        }


                    }
                    /*vertical arriba*/
                    if (B7.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (B6.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "B7");
                            comprobacion = true;
                        }
                        if ((B5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B7");
                            pintar("blanco", "B6");
                            comprobacion = true;
                        }
                        if ((B4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B7");
                            pintar("blanco", "B6");
                            pintar("blanco", "B5");
                            comprobacion = true;
                        }
                        if ((B3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B7");
                            pintar("blanco", "B6");
                            pintar("blanco", "B5");
                            pintar("blanco", "B4");
                            comprobacion = true;
                        }
                        if ((B2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B7");
                            pintar("blanco", "B6");
                            pintar("blanco", "B5");
                            pintar("blanco", "B4");
                            pintar("blanco", "B3");
                            comprobacion = true;
                        }
                        if ((B1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "B7");
                            pintar("blanco", "B6");
                            pintar("blanco", "B5");
                            pintar("blanco", "B4");
                            pintar("blanco", "B3");
                            pintar("blanco", "B2");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true)
                {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
            }

            if (Posicion == "C8")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {
                    /*horizontal izquierda*/
                    if (B8.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (A8.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "B8");
                            comprobacion = true;
                        }
                    }
                    /*horizontal derecha*/
                    if (D8.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (E8.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "D8");
                            comprobacion = true;
                        }
                        if ((F8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E8.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D8");
                            pintar("negro", "E8");
                            comprobacion = true;
                        }
                        if ((G8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E8.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D8");
                            pintar("negro", "E8");
                            pintar("negro", "F8");
                            comprobacion = true;
                        }
                        if ((G8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E3.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D8");
                            pintar("negro", "E8");
                            pintar("negro", "F8");
                            pintar("negro", "G8");
                            comprobacion = true;
                        }
                    }
                    /*vertical arriba*/
                    if (C7.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (C6.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "C7");
                            comprobacion = true;
                        }
                        if ((C5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C7");
                            pintar("negro", "C6");
                            comprobacion = true;
                        }
                        if ((C4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C7");
                            pintar("negro", "C6");
                            pintar("negro", "C5");
                            comprobacion = true;
                        }
                        if ((C3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C7");
                            pintar("negro", "C6");
                            pintar("negro", "C5");
                            pintar("negro", "C4");
                            comprobacion = true;
                        }
                        if ((C2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C7");
                            pintar("negro", "C6");
                            pintar("negro", "C5");
                            pintar("negro", "C4");
                            pintar("negro", "C3");
                            comprobacion = true;
                        }
                        if ((C1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C7");
                            pintar("negro", "C6");
                            pintar("negro", "C5");
                            pintar("negro", "C4");
                            pintar("negro", "C3");
                            pintar("negro", "C2");
                            comprobacion = true;
                        }
                    }

                }
                if (colorJ == "blanco")
                {
                    /*horizontal izquierda*/
                    if (B8.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (A8.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "B8");
                            comprobacion = true;
                        }
                    }

                    /*horizontal derecha*/
                    if (D8.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (E8.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "D8");
                            comprobacion = true;
                        }
                        if ((F8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E8.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D8");
                            pintar("blanco", "E8");
                            comprobacion = true;
                        }
                        if ((F8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E8.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D8");
                            pintar("blanco", "E8");
                            pintar("blanco", "F8");
                            comprobacion = true;
                        }
                        if ((H8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E8.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D8");
                            pintar("blanco", "E8");
                            pintar("blanco", "F8");
                            pintar("blanco", "G8");
                            comprobacion = true;
                        }


                    }
                    /*vertical arriba*/
                    if (C7.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (C6.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "C7");
                            comprobacion = true;
                        }
                        if ((C5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C7");
                            pintar("blanco", "C6");
                            comprobacion = true;
                        }
                        if ((C4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C7");
                            pintar("blanco", "C6");
                            pintar("blanco", "C5");
                            comprobacion = true;
                        }
                        if ((C3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C7");
                            pintar("blanco", "C6");
                            pintar("blanco", "C5");
                            pintar("blanco", "C4");
                            comprobacion = true;
                        }
                        if ((C2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C7");
                            pintar("blanco", "C6");
                            pintar("blanco", "C5");
                            pintar("blanco", "C4");
                            pintar("blanco", "C3");
                            comprobacion = true;
                        }
                        if ((C1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "C7");
                            pintar("blanco", "C6");
                            pintar("blanco", "C5");
                            pintar("blanco", "C4");
                            pintar("blanco", "C3");
                            pintar("blanco", "C2");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true)
                {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
            }

            if (Posicion == "D8")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {
                    /*horizontal izquierda*/
                    if (C8.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (B8.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "C8");
                            comprobacion = true;
                        }
                        if ((A8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B8.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "C8");
                            pintar("negro", "B8");
                            comprobacion = true;
                        }
                    }
                    /*horizontal derecha*/
                    if (E8.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (F8.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "E8");
                            comprobacion = true;
                        }
                        if ((G8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F8.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E8");
                            pintar("negro", "F8");
                            comprobacion = true;
                        }
                        if ((G8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H8.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("negro", "E8");
                            pintar("negro", "F8");
                            pintar("negro", "G8");
                            comprobacion = true;
                        }
                    }
                    /*vertical arriba*/
                    if (D7.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (D6.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "D7");
                            comprobacion = true;
                        }
                        if ((D5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D7");
                            pintar("negro", "D6");
                            comprobacion = true;
                        }
                        if ((D4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D7");
                            pintar("negro", "D6");
                            pintar("negro", "D5");
                            comprobacion = true;
                        }
                        if ((D3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D7");
                            pintar("negro", "D6");
                            pintar("negro", "D5");
                            pintar("negro", "D4");
                            comprobacion = true;
                        }
                        if ((D2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D7");
                            pintar("negro", "D6");
                            pintar("negro", "D5");
                            pintar("negro", "D4");
                            pintar("negro", "D3");
                            comprobacion = true;
                        }
                        if ((D1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D7");
                            pintar("negro", "D6");
                            pintar("negro", "D5");
                            pintar("negro", "D4");
                            pintar("negro", "D3");
                            pintar("negro", "D2");
                            comprobacion = true;
                        }
                    }

                }
                if (colorJ == "blanco")
                {
                    /*horizontal izquierda*/
                    if (C8.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (B8.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "C8");
                            comprobacion = true;
                        }
                        if ((B8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (A8.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("blanco", "C8");
                            pintar("blanco", "B8");
                            comprobacion = true;
                        }
                    }

                    /*horizontal derecha*/
                    if (E8.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (F8.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "E8");
                            comprobacion = true;
                        }
                        if ((F8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G8.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("blanco", "E8");
                            pintar("blanco", "F8");
                            comprobacion = true;
                        }
                        if ((H8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G8.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E8");
                            pintar("blanco", "F8");
                            pintar("blanco", "G8");
                            comprobacion = true;
                        }
                    }
                    /*vertical arriba*/
                    if (D7.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (D6.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "D7");
                            comprobacion = true;
                        }
                        if ((D5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D7");
                            pintar("blanco", "D6");
                            comprobacion = true;
                        }
                        if ((D4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D7");
                            pintar("blanco", "D6");
                            pintar("blanco", "D5");
                            comprobacion = true;
                        }
                        if ((D3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D7");
                            pintar("blanco", "D6");
                            pintar("blanco", "D5");
                            pintar("blanco", "D4");
                            comprobacion = true;
                        }
                        if ((D2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D7");
                            pintar("blanco", "D6");
                            pintar("blanco", "D5");
                            pintar("blanco", "D4");
                            pintar("blanco", "D3");
                            comprobacion = true;
                        }
                        if ((D1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D7");
                            pintar("blanco", "D6");
                            pintar("blanco", "D5");
                            pintar("blanco", "D4");
                            pintar("blanco", "D3");
                            pintar("blanco", "D2");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true)
                {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
            }

            if (Posicion == "E8")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {
                    /*horizontal izquierda*/
                    if (D8.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (C8.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "D8");
                            comprobacion = true;
                        }
                        if ((B8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C8.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D8");
                            pintar("negro", "C8");
                            comprobacion = true;
                        }
                        if ((A8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C8.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "D3");
                            pintar("negro", "C3");
                            pintar("negro", "B3");
                            comprobacion = true;
                        }
                    }
                    /*horizontal derecha*/
                    if (F8.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (G8.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "F8");
                            comprobacion = true;
                        }
                        if ((H8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G8.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F8");
                            pintar("negro", "G8");
                            comprobacion = true;
                        }
                    }
                    /*vertical arriba*/
                    if (E7.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (E6.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "E7");
                            comprobacion = true;
                        }
                        if ((E5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E7");
                            pintar("negro", "E6");
                            comprobacion = true;
                        }
                        if ((E4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E7");
                            pintar("negro", "E6");
                            pintar("negro", "E5");
                            comprobacion = true;
                        }
                        if ((E3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E7");
                            pintar("negro", "E6");
                            pintar("negro", "E5");
                            pintar("negro", "E4");
                            comprobacion = true;
                        }
                        if ((E2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E7");
                            pintar("negro", "E6");
                            pintar("negro", "E5");
                            pintar("negro", "E4");
                            pintar("negro", "E3");
                            comprobacion = true;
                        }
                        if ((E1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E7");
                            pintar("negro", "E6");
                            pintar("negro", "E5");
                            pintar("negro", "E4");
                            pintar("negro", "E3");
                            pintar("negro", "E2");
                            comprobacion = true;
                        }
                    }

                }
                if (colorJ == "blanco")
                {
                    /*horizontal izquierda*/
                    if (D8.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (C8.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "D8");
                            comprobacion = true;
                        }
                        if ((B8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C8.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D8");
                            pintar("blanco", "C8");
                            comprobacion = true;
                        }
                        if ((A8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C8.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "D8");
                            pintar("blanco", "C8");
                            pintar("blanco", "B8");
                            comprobacion = true;
                        }
                    }

                    /*horizontal derecha*/
                    if (E8.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (G8.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "F8");
                            comprobacion = true;
                        }
                        if ((H8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G8.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F8");
                            pintar("blanco", "G8");
                            comprobacion = true;
                        }
                    }
                    /*vertical arriba*/
                    if (E7.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (E6.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "E7");
                            comprobacion = true;
                        }
                        if ((E5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E7");
                            pintar("blanco", "E6");
                            comprobacion = true;
                        }
                        if ((E4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E7");
                            pintar("blanco", "E6");
                            pintar("blanco", "E5");
                            comprobacion = true;
                        }
                        if ((E3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E7");
                            pintar("blanco", "E6");
                            pintar("blanco", "E5");
                            pintar("blanco", "E4");
                            comprobacion = true;
                        }
                        if ((E2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E7");
                            pintar("blanco", "E6");
                            pintar("blanco", "E5");
                            pintar("blanco", "E4");
                            pintar("blanco", "E3");
                            comprobacion = true;
                        }
                        if ((E1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E7");
                            pintar("blanco", "E6");
                            pintar("blanco", "E5");
                            pintar("blanco", "E4");
                            pintar("blanco", "E3");
                            pintar("blanco", "E2");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true)
                {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
            }

            if (Posicion == "F8")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {
                    /*horizontal izquierda*/
                    if (E8.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (D8.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "E8");
                            comprobacion = true;
                        }
                        if ((C8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D8.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E8");
                            pintar("negro", "D8");
                            comprobacion = true;
                        }
                        if ((B8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D8.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E8");
                            pintar("negro", "D8");
                            pintar("negro", "C8");
                            comprobacion = true;
                        }
                        if ((A8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D8.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "E8");
                            pintar("negro", "D8");
                            pintar("negro", "C8");
                            pintar("negro", "B8");
                            comprobacion = true;
                        }
                    }
                    /*horizontal derecha*/
                    if (G8.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (H8.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "G8");
                            comprobacion = true;
                        }
                    }
                    /*vertical arriba*/
                    if (F7.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (F6.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "F7");
                            comprobacion = true;
                        }
                        if ((F5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F7");
                            pintar("negro", "F6");
                            comprobacion = true;
                        }
                        if ((F4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F7");
                            pintar("negro", "F6");
                            pintar("negro", "F5");
                            comprobacion = true;
                        }
                        if ((F3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F7");
                            pintar("negro", "F6");
                            pintar("negro", "F5");
                            pintar("negro", "F4");
                            comprobacion = true;
                        }
                        if ((F2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F7");
                            pintar("negro", "F6");
                            pintar("negro", "F5");
                            pintar("negro", "F4");
                            pintar("negro", "F3");
                            comprobacion = true;
                        }
                        if ((F1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F7");
                            pintar("negro", "F6");
                            pintar("negro", "F5");
                            pintar("negro", "F4");
                            pintar("negro", "F3");
                            pintar("negro", "F2");
                            comprobacion = true;
                        }
                    }

                }
                if (colorJ == "blanco")
                {
                    /*horizontal izquierda*/
                    if (E8.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (D8.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "E8");
                            comprobacion = true;
                        }
                        if ((C8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D8.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E8");
                            pintar("blanco", "D8");
                            comprobacion = true;
                        }
                        if ((B8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D8.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E8");
                            pintar("blanco", "D8");
                            pintar("blanco", "C8");
                            comprobacion = true;
                        }
                        if ((A8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D8.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "E8");
                            pintar("blanco", "D8");
                            pintar("blanco", "C8");
                            pintar("blanco", "B8");
                            comprobacion = true;
                        }
                    }

                    /*horizontal derecha*/
                    if (G8.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (H8.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "G8");
                            comprobacion = true;
                        }
                    }
                    /*vertical arriba*/
                    if (F7.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (F6.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "F7");
                            comprobacion = true;
                        }
                        if ((F5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F7");
                            pintar("blanco", "F6");
                            comprobacion = true;
                        }
                        if ((F4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F7");
                            pintar("blanco", "F6");
                            pintar("blanco", "F5");
                            comprobacion = true;
                        }
                        if ((F3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F7");
                            pintar("blanco", "F6");
                            pintar("blanco", "F5");
                            pintar("blanco", "F4");
                            comprobacion = true;
                        }
                        if ((F2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F7");
                            pintar("blanco", "F6");
                            pintar("blanco", "F5");
                            pintar("blanco", "F4");
                            pintar("blanco", "F3");
                            comprobacion = true;
                        }
                        if ((F1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F7");
                            pintar("blanco", "F6");
                            pintar("blanco", "F5");
                            pintar("blanco", "F4");
                            pintar("blanco", "F3");
                            pintar("blanco", "F2");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true)
                {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
            }

            if (Posicion == "G8")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {
                    /*horizontal izquierda*/
                    if (F8.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (E8.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "F8");
                            comprobacion = true;
                        }
                        if ((D8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E8.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F8");
                            pintar("negro", "E8");
                            comprobacion = true;
                        }
                        if ((C8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E8.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F8");
                            pintar("negro", "E8");
                            pintar("negro", "D8");
                            comprobacion = true;
                        }
                        if ((B8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E8.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F8");
                            pintar("negro", "E8");
                            pintar("negro", "D8");
                            pintar("negro", "C8");
                            comprobacion = true;
                        }
                        if ((A8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E8.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "F8");
                            pintar("negro", "E8");
                            pintar("negro", "D8");
                            pintar("negro", "C8");
                            pintar("negro", "B8");
                            comprobacion = true;
                        }
                    }

                    /*vertical arriba*/
                    if (G7.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (G6.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "G7");
                            comprobacion = true;
                        }
                        if ((G5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G7");
                            pintar("negro", "G6");
                            comprobacion = true;
                        }
                        if ((G4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G7");
                            pintar("negro", "G6");
                            pintar("negro", "G5");
                            comprobacion = true;
                        }
                        if ((G3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G7");
                            pintar("negro", "G6");
                            pintar("negro", "G5");
                            pintar("negro", "G4");
                            comprobacion = true;
                        }
                        if ((G2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G7");
                            pintar("negro", "G6");
                            pintar("negro", "G5");
                            pintar("negro", "G4");
                            pintar("negro", "G3");
                            comprobacion = true;
                        }
                        if ((G1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G7");
                            pintar("negro", "G6");
                            pintar("negro", "G5");
                            pintar("negro", "G4");
                            pintar("negro", "G3");
                            pintar("negro", "G2");
                            comprobacion = true;
                        }
                    }

                }
                if (colorJ == "blanco")
                {
                    /*horizontal izquierda*/
                    if (F8.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (E8.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "F8");
                            comprobacion = true;
                        }
                        if ((D8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E8.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F8");
                            pintar("blanco", "E8");
                            comprobacion = true;
                        }
                        if ((C8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E8.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F8");
                            pintar("blanco", "E8");
                            pintar("blanco", "D8");
                            comprobacion = true;
                        }
                        if ((B8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E8.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F8");
                            pintar("blanco", "E8");
                            pintar("blanco", "D8");
                            pintar("blanco", "C8");
                            comprobacion = true;
                        }
                        if ((A8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E8.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "F8");
                            pintar("blanco", "E8");
                            pintar("blanco", "D8");
                            pintar("blanco", "C8");
                            pintar("blanco", "B8");
                            comprobacion = true;
                        }
                    }
                    /*vertical arriba*/
                    if (G7.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (G6.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "G7");
                            comprobacion = true;
                        }
                        if ((G5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G7");
                            pintar("blanco", "G6");
                            comprobacion = true;
                        }
                        if ((G4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G7");
                            pintar("blanco", "G6");
                            pintar("blanco", "G5");
                            comprobacion = true;
                        }
                        if ((G3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G7");
                            pintar("blanco", "G6");
                            pintar("blanco", "G5");
                            pintar("blanco", "G4");
                            comprobacion = true;
                        }
                        if ((G2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G7");
                            pintar("blanco", "G6");
                            pintar("blanco", "G5");
                            pintar("blanco", "G4");
                            pintar("blanco", "G3");
                            comprobacion = true;
                        }
                        if ((G1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (G3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (G6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G7");
                            pintar("blanco", "G6");
                            pintar("blanco", "G5");
                            pintar("blanco", "G4");
                            pintar("blanco", "G3");
                            pintar("blanco", "G2");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true)
                {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
            }

            if (Posicion == "H8")
            {
                Boolean comprobacion = false;
                if (colorJ == "negro")
                {
                    /*horizontal izquierda*/
                    if (G8.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (F8.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "G8");
                            comprobacion = true;
                        }
                        if ((E8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F8.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G8");
                            pintar("negro", "F8");
                            comprobacion = true;
                        }
                        if ((D8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F8.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G8");
                            pintar("negro", "F8");
                            pintar("negro", "E8");
                            comprobacion = true;
                        }
                        if ((C8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F8.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G8");
                            pintar("negro", "F8");
                            pintar("negro", "E8");
                            pintar("negro", "D8");
                            comprobacion = true;
                        }
                        if ((B8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F8.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G8");
                            pintar("negro", "F8");
                            pintar("negro", "E8");
                            pintar("negro", "D8");
                            pintar("negro", "C8");
                            comprobacion = true;
                        }
                        if ((A8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F8.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G8");
                            pintar("negro", "F8");
                            pintar("negro", "E8");
                            pintar("negro", "D8");
                            pintar("negro", "C8");
                            pintar("negro", "B8");
                            comprobacion = true;
                        }
                    }

                    /*vertical arriba*/
                    if (H7.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (H6.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "H7");
                            comprobacion = true;
                        }
                        if ((H5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "H7");
                            pintar("negro", "H6");
                            comprobacion = true;
                        }
                        if ((H4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "H7");
                            pintar("negro", "H6");
                            pintar("negro", "H5");
                            comprobacion = true;
                        }
                        if ((H3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "H7");
                            pintar("negro", "H6");
                            pintar("negro", "H5");
                            pintar("negro", "H4");
                            comprobacion = true;
                        }
                        if ((H2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "H7");
                            pintar("negro", "H6");
                            pintar("negro", "H5");
                            pintar("negro", "H4");
                            pintar("negro", "H3");
                            comprobacion = true;
                        }
                        if ((H1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "H7");
                            pintar("negro", "H6");
                            pintar("negro", "H5");
                            pintar("negro", "H4");
                            pintar("negro", "H3");
                            pintar("negro", "H2");
                            comprobacion = true;
                        }
                    }
                    /*diagonal hacia arriba izquierda*/
                    if (G7.BackColor == Color.FromArgb(225, 225, 225, 225))
                    {
                        if (F6.BackColor == Color.FromArgb(0, 0, 0, 0))
                        {
                            pintar("negro", "G7");
                            comprobacion = true;
                        }
                        if ((E5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G7");
                            pintar("negro", "F6");
                            comprobacion = true;
                        }
                        if ((D4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G7");
                            pintar("negro", "F6");
                            pintar("negro", "E5");
                            comprobacion = true;
                        }
                        if ((C3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G7");
                            pintar("negro", "F6");
                            pintar("negro", "E5");
                            pintar("negro", "D4");
                            comprobacion = true;
                        }
                        if ((B2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G7");
                            pintar("negro", "F6");
                            pintar("negro", "E5");
                            pintar("negro", "D4");
                            pintar("negro", "C3");
                            comprobacion = true;
                        }
                        if ((A1.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F6.BackColor == Color.FromArgb(225, 225, 225, 225)))
                        {
                            pintar("negro", "G7");
                            pintar("negro", "F6");
                            pintar("negro", "E5");
                            pintar("negro", "D4");
                            pintar("negro", "C3");
                            pintar("negro", "B2");
                            comprobacion = true;
                        }
                    }

                }
                if (colorJ == "blanco")
                {
                    /*horizontal izquierda*/
                    if (G8.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (F8.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "G8");
                            comprobacion = true;
                        }
                        if ((E8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F8.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G8");
                            pintar("blanco", "F8");
                            comprobacion = true;
                        }
                        if ((D8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F8.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G8");
                            pintar("blanco", "F8");
                            pintar("blanco", "E8");
                            comprobacion = true;
                        }
                        if ((C8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F8.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G8");
                            pintar("blanco", "F8");
                            pintar("blanco", "E8");
                            pintar("blanco", "D8");
                            comprobacion = true;
                        }
                        if ((B8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F8.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G8");
                            pintar("blanco", "F8");
                            pintar("blanco", "E8");
                            pintar("blanco", "D8");
                            pintar("blanco", "C8");
                            comprobacion = true;
                        }
                        if ((A8.BackColor == Color.FromArgb(225, 225, 225, 225)) && (B8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (C8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E8.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F8.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G8");
                            pintar("blanco", "F8");
                            pintar("blanco", "E8");
                            pintar("blanco", "D8");
                            pintar("blanco", "C8");
                            pintar("blanco", "B8");
                            comprobacion = true;
                        }
                    }
                    /*vertical arriba*/
                    if (H7.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (H6.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "H7");
                            comprobacion = true;
                        }
                        if ((H5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "H7");
                            pintar("blanco", "H6");
                            comprobacion = true;
                        }
                        if ((H4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "H7");
                            pintar("blanco", "H6");
                            pintar("blanco", "H5");
                            comprobacion = true;
                        }
                        if ((H3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "H7");
                            pintar("blanco", "H6");
                            pintar("blanco", "H5");
                            pintar("blanco", "H4");
                            comprobacion = true;
                        }
                        if ((H2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "H7");
                            pintar("blanco", "H6");
                            pintar("blanco", "H5");
                            pintar("blanco", "H4");
                            pintar("blanco", "H3");
                            comprobacion = true;
                        }
                        if ((H1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (H3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (H6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "H7");
                            pintar("blanco", "H6");
                            pintar("blanco", "H5");
                            pintar("blanco", "H4");
                            pintar("blanco", "H3");
                            pintar("blanco", "H2");
                            comprobacion = true;
                        }
                    }
                    /*diagonal hacia arriba izquierda*/
                    if (G7.BackColor == Color.FromArgb(0, 0, 0, 0))
                    {
                        if (F6.BackColor == Color.FromArgb(225, 225, 225, 225))
                        {
                            pintar("blanco", "G7");
                            comprobacion = true;
                        }
                        if ((E5.BackColor == Color.FromArgb(225, 225, 225, 225)) && (F6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G7");
                            pintar("blanco", "F6");
                            comprobacion = true;
                        }
                        if ((D4.BackColor == Color.FromArgb(225, 225, 225, 225)) && (E5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G7");
                            pintar("blanco", "F6");
                            pintar("blanco", "E5");
                            comprobacion = true;
                        }
                        if ((C3.BackColor == Color.FromArgb(225, 225, 225, 225)) && (D4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G7");
                            pintar("blanco", "F6");
                            pintar("blanco", "E5");
                            pintar("blanco", "D4");
                            comprobacion = true;
                        }
                        if ((B2.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G7");
                            pintar("blanco", "F6");
                            pintar("blanco", "E5");
                            pintar("blanco", "D4");
                            pintar("blanco", "C3");
                            comprobacion = true;
                        }
                        if ((A1.BackColor == Color.FromArgb(225, 225, 225, 225)) && (C3.BackColor == Color.FromArgb(0, 0, 0, 0)) && (B2.BackColor == Color.FromArgb(0, 0, 0, 0)) && (D4.BackColor == Color.FromArgb(0, 0, 0, 0)) && (E5.BackColor == Color.FromArgb(0, 0, 0, 0)) && (F6.BackColor == Color.FromArgb(0, 0, 0, 0)))
                        {
                            pintar("blanco", "G7");
                            pintar("blanco", "F6");
                            pintar("blanco", "E5");
                            pintar("blanco", "D4");
                            pintar("blanco", "C3");
                            pintar("blanco", "B2");
                            comprobacion = true;
                        }
                    }
                }
                if (comprobacion == true)
                {
                    if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                    {
                        contadorJ1 += 1;
                        movJ1.Text = "Movimientos: " + contadorJ1;
                    }
                    else
                    {
                        contadorJ2 += 1;
                        movJ2.Text = "Movimientos: " + contadorJ2;
                    }

                    pintar(colorJ, Posicion);
                }
            }
        }

        protected void D5_Click(object sender, EventArgs e)
        {
            

        }
        protected void D6_Click(object sender, EventArgs e)
        {
            if (D6.BackColor == Color.FromArgb(147, 200, 90))
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    Reglas(colorJ1, "D6");
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    Reglas(colorJ2, "D6");
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
            else
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
        }
        protected void D7_Click(object sender, EventArgs e)
        {
            if (D7.BackColor == Color.FromArgb(147, 200, 90))
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    Reglas(colorJ1, "D7");
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    Reglas(colorJ2, "D7");
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
            else
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
        }
        protected void D8_Click(object sender, EventArgs e)
        {
            if (D8.BackColor == Color.FromArgb(147, 200, 90))
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    Reglas(colorJ1, "D8");
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    Reglas(colorJ2, "D8");
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
            else
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
        }
        
        protected void D4_Click(object sender, EventArgs e)
        {
           
        }
        protected void E1_Click(object sender, EventArgs e)
        {
            if (E1.BackColor == Color.FromArgb(147, 200, 90))
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    Reglas(colorJ1, "E1");
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    Reglas(colorJ2, "E1");
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
            else
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
        }
        protected void E2_Click(object sender, EventArgs e)
        {
            if (E2.BackColor == Color.FromArgb(147, 200, 90))
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    Reglas(colorJ1, "E2");
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    Reglas(colorJ2, "E2");
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
            else
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
        }
        protected void E3_Click(object sender, EventArgs e)
        {
            if (E3.BackColor == Color.FromArgb(147, 200, 90))
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    Reglas(colorJ1, "E3");
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    Reglas(colorJ2, "E3");
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
            else
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
        }
        protected void E5_Click(object sender, EventArgs e)
        {
           

        }
        protected void E6_Click(object sender, EventArgs e)
        {
            if (E6.BackColor == Color.FromArgb(147, 200, 90))
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    Reglas(colorJ1, "E6");
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    Reglas(colorJ2, "E6");
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
            else
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
        }
        protected void E7_Click(object sender, EventArgs e)
        {
            if (E7.BackColor == Color.FromArgb(147, 200, 90))
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    Reglas(colorJ1, "E7");
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    Reglas(colorJ2, "E7");
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
            else
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
        }
        protected void E8_Click(object sender, EventArgs e)
        {
            if (E8.BackColor == Color.FromArgb(147, 200, 90))
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    Reglas(colorJ1, "E8");
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    Reglas(colorJ2, "E8");
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
            else
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
        }

        protected void E4_Click(object sender, EventArgs e)
        {
            

        }
        protected void F1_Click(object sender, EventArgs e)
        {
            if (F1.BackColor == Color.FromArgb(147, 200, 90))
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    Reglas(colorJ1, "F1");
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    Reglas(colorJ2, "F1");
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
            else
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
        }
        protected void F2_Click(object sender, EventArgs e)
        {
            if (F2.BackColor == Color.FromArgb(147, 200, 90))
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    Reglas(colorJ1, "F2");
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    Reglas(colorJ2, "F2");
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
            else
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
        }
        protected void F3_Click(object sender, EventArgs e)
        {
            if (F3.BackColor == Color.FromArgb(147, 200, 90))
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    Reglas(colorJ1, "F3");
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    Reglas(colorJ2, "F3");
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
            else
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
        }
        protected void F5_Click(object sender, EventArgs e)
        {
            if (F5.BackColor == Color.FromArgb(147, 200, 90))
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    Reglas(colorJ1, "F5");
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    Reglas(colorJ2, "F5");
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
            else
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
                    }
        protected void F6_Click(object sender, EventArgs e)
        {
            if (F6.BackColor == Color.FromArgb(147, 200, 90))
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    Reglas(colorJ1, "F6");
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    Reglas(colorJ2, "F6");
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
            else
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
        }
        protected void F7_Click(object sender, EventArgs e)
        {
            if (F7.BackColor == Color.FromArgb(147, 200, 90))
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    Reglas(colorJ1, "F7");
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    Reglas(colorJ2, "F7");
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
            else
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
        }
        protected void F8_Click(object sender, EventArgs e)
        {
            if (F8.BackColor == Color.FromArgb(147, 200, 90))
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    Reglas(colorJ1, "F8");
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    Reglas(colorJ2, "F8");
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
            else
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
        }

        protected void F4_Click(object sender, EventArgs e)
        {
            if (F4.BackColor == Color.FromArgb(147, 200, 90))
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    Reglas(colorJ1, "F4");
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    Reglas(colorJ2, "F4");
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
            else
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
        }
        protected void G1_Click(object sender, EventArgs e)
        {
            if (G1.BackColor == Color.FromArgb(147, 200, 90))
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    Reglas(colorJ1, "G1");
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    Reglas(colorJ2, "G1");
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
            else
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
        }
        protected void G2_Click(object sender, EventArgs e)
        {
            if (G2.BackColor == Color.FromArgb(147, 200, 90))
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    Reglas(colorJ1, "G2");
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    Reglas(colorJ2, "G2");
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
            else
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
        }
        protected void G3_Click(object sender, EventArgs e)
        {
            if (G3.BackColor == Color.FromArgb(147, 200, 90))
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    Reglas(colorJ1, "G3");
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    Reglas(colorJ2, "G3");
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
            else
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
        }
        protected void G5_Click(object sender, EventArgs e)
        {
            if (G5.BackColor == Color.FromArgb(147, 200, 90))
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    Reglas(colorJ1, "G5");
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    Reglas(colorJ2, "G5");
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
            else
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
        }
        protected void G6_Click(object sender, EventArgs e)
        {
            if (G6.BackColor == Color.FromArgb(147, 200, 90))
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    Reglas(colorJ1, "G6");
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    Reglas(colorJ2, "G6");
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
            else
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
        }
        protected void G7_Click(object sender, EventArgs e)
        {
            if (G7.BackColor == Color.FromArgb(147, 200, 90))
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    Reglas(colorJ1, "G7");
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    Reglas(colorJ2, "G7");
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
            else
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }

        }
        protected void G8_Click(object sender, EventArgs e)
        {
            if (G8.BackColor == Color.FromArgb(147, 200, 90))
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    Reglas(colorJ1, "G8");
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    Reglas(colorJ2, "G8");
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
            else
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
        }

        protected void G4_Click(object sender, EventArgs e)
        {
            if (G4.BackColor == Color.FromArgb(147, 200, 90))
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    Reglas(colorJ1, "G4");
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    Reglas(colorJ2, "G4");
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
            else
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
        }
        protected void H1_Click(object sender, EventArgs e)
        {
            if (H1.BackColor == Color.FromArgb(147, 200, 90))
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    Reglas(colorJ1, "H1");
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    Reglas(colorJ2, "H1");
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
            else
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
        }
        protected void H2_Click(object sender, EventArgs e)
        {
            if (H2.BackColor == Color.FromArgb(147, 200, 90))
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    Reglas(colorJ1, "H2");
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    Reglas(colorJ2, "H2");
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
            else
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }

        }
        protected void H3_Click(object sender, EventArgs e)
        {
            if (H3.BackColor == Color.FromArgb(147, 200, 90))
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    Reglas(colorJ1, "H3");
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    Reglas(colorJ2, "H3");
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
            else
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }

        }
        protected void H5_Click(object sender, EventArgs e)
        {
            if (H5.BackColor == Color.FromArgb(147, 200, 90))
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    Reglas(colorJ1, "H5");
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    Reglas(colorJ2, "H5");
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
            else
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
        }
        protected void H6_Click(object sender, EventArgs e)
        {
            if (H6.BackColor == Color.FromArgb(147, 200, 90))
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    Reglas(colorJ1, "H6");
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    Reglas(colorJ2, "H6");
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
            else
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
        }
        protected void H7_Click(object sender, EventArgs e)
        {
            if (H7.BackColor == Color.FromArgb(147, 200, 90))
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    Reglas(colorJ1, "H7");
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    Reglas(colorJ2, "H7");
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
            else
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
        }

        protected void H8_Click(object sender, EventArgs e)
        {
            if (H8.BackColor == Color.FromArgb(147, 200, 90))
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    Reglas(colorJ1, "H8");
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    Reglas(colorJ2, "H8");
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
            else
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
        }

        protected void H4_Click(object sender, EventArgs e)
        {
            if (H4.BackColor == Color.FromArgb(147, 200, 90))
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    Reglas(colorJ1, "H4");
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    Reglas(colorJ2, "H4");
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
            else
            {
                if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
                {
                    txtJugador1.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador2.BackColor = Color.FromArgb(204, 244, 251);
                }
                else
                {
                    txtJugador2.BackColor = Color.FromArgb(225, 225, 225, 225);
                    txtJugador1.BackColor = Color.FromArgb(204, 244, 251);
                }
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            int s = 0;
            path = Interaction.InputBox("Ingrese el nombre con el cual desea guardarlo","Guardar como ...","",-1,-1);
                
            
            posiciones = Guardar();
            XmlWriter xmlWriter = XmlWriter.Create(Server.MapPath("~/XML/" + path +".xml"));
            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("tablero");
                foreach (string localizacion in posiciones)
                {
                if (localizacion != null) {
                    if (s == 2)
                    {
                        s = 0;
                    }
                    if (s == 0)
                    {
                        xmlWriter.WriteStartElement("ficha");
                        xmlWriter.WriteStartElement("color");
                        xmlWriter.WriteString(localizacion);
                        xmlWriter.WriteEndElement();
                    }
                    if (s == 1)
                    {
                        int s2 = 0;
                        foreach (var letras in localizacion)
                        {
                            if (s2 == 0)
                            {
                                xmlWriter.WriteStartElement("columna");
                                xmlWriter.WriteString(letras + "");
                                xmlWriter.WriteEndElement();
                            }
                            if (s2 == 1)
                            {
                                xmlWriter.WriteStartElement("fila");
                                xmlWriter.WriteString(letras + "");
                                xmlWriter.WriteEndElement();
                                xmlWriter.WriteEndElement();
                            }
                            s2++;
                        }
                    }
                    s++;
                }
                

                }
            if (txtJugador1.BackColor == Color.FromArgb(204, 244, 251))
            {
                xmlWriter.WriteStartElement("siguienteTiro");
                xmlWriter.WriteStartElement("color");
                xmlWriter.WriteString(colorJ1 + "");
                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndElement();
            }
            else
            {
                xmlWriter.WriteStartElement("siguienteTiro");
                xmlWriter.WriteStartElement("color");
                xmlWriter.WriteString(colorJ2 + "");
                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndElement();
            }
            
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndDocument();
            xmlWriter.Close();
            System.Windows.MessageBox.Show("Su partida se ha guardado exitosamente");
        }

        protected void btnMenu_Click(object sender, EventArgs e)
        {
            lista = txtJugador1.Text.Split('(');
            user = lista[0].Trim();
            HttpContext.Current.Response.Redirect("Menu.aspx?parametro=" + user);
        }
    }

    
}