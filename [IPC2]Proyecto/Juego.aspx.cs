
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
        string color, posicion;
        string  columna, fila;
        int i = -1;
        int j = 0;

        string path;
        string[,] posiciones = new string[60,2];
        string archivoXML;


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack) // to avoid reloading your control on postback
            {
                if (j == 0)
                {
                    j++;
                    if (Request.Params["parametro"] != null)
                    {
                        archivoXML = Request.Params["parametro"];

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
                                        if (xmlReader.ReadString() == "blanco")
                                        {
                                            color = "blanco";
                                        }
                                        else
                                        {
                                            color = "negro";
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
            if (A1.Visible == true)
            {
                if (A1.BackColor == Color.FromArgb(225, 225, 225,225))
                {
                    pintar("negro", "A1");
                }
                else
                {
                    pintar("blanco", "A1");
                }

            }
            else {
                pintar(color,"A1");
            }
            
        }
        protected void A2_Click(object sender, EventArgs e)
        {
            if (A2.Visible == true)
            {
                if (A2.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    pintar("negro", "A2");
                }
                else
                {
                    pintar("blanco", "A2");
                }

            }
            else
            {
                pintar(color, "A2");
            }

        }
        protected void A3_Click(object sender, EventArgs e)
        {
            if (A3.Visible == true)
            {
                if (A3.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    pintar("negro", "A3");
                }
                else
                {
                    pintar("blanco", "A3");
                }

            }
            else
            {
                pintar(color, "A3");
            }

        }
        protected void A4_Click(object sender, EventArgs e)
        {
            if (A4.Visible == true)
            {
                if (A4.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    pintar("negro", "A4");
                }
                else
                {
                    pintar("blanco", "A4");
                }

            }
            else
            {
                pintar(color, "A4");
            }

        }
        protected void A5_Click(object sender, EventArgs e)
        {
            if (A5.Visible == true)
            {
                if (A5.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    pintar("negro", "A5");
                }
                else
                {
                    pintar("blanco", "A5");
                }

            }
            else
            {
                pintar(color, "A5");
            }

        }
        protected void A6_Click(object sender, EventArgs e)
        {
            if (A6.Visible == true)
            {
                if (A6.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    pintar("negro", "A6");
                }
                else
                {
                    pintar("blanco", "A6");
                }

            }
            else
            {
                pintar(color, "A6");
            }

        }
        protected void A7_Click(object sender, EventArgs e)
        {
            if (A7.Visible == true)
            {
                if (A7.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    pintar("negro", "A7");
                }
                else
                {
                    pintar("blanco", "A7");
                }

            }
            else
            {
                pintar(color, "A7");
            }

        }
        protected void A8_Click(object sender, EventArgs e)
        {
            if (A8.Visible == true)
            {
                if (A8.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    pintar("negro", "A8");
                }
                else
                {
                    pintar("blanco", "A8");
                }

            }
            else
            {
                pintar(color, "A8");
            }

        }
        protected void B1_Click(object sender, EventArgs e)
        {
            if (B1.Visible == true)
            {
                if (B1.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    pintar("negro", "B1");
                }
                else
                {
                    pintar("blanco", "B1");
                }

            }
            else
            {
                pintar(color, "B1");
            }

        }
        protected void B2_Click(object sender, EventArgs e)
        {
            if (B2.Visible == true)
            {
                if (B2.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    pintar("negro", "B2");
                }
                else
                {
                    pintar("blanco", "B2");
                }

            }
            else
            {
                pintar(color, "B2");
            }

        }
        protected void B3_Click(object sender, EventArgs e)
        {
            if (B3.Visible == true)
            {
                if (B3.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    pintar("negro", "B3");
                }
                else
                {
                    pintar("blanco", "B3");
                }

            }
            else
            {
                pintar(color, "B3");
            }

        }
        protected void B4_Click(object sender, EventArgs e)
        {
            if (B4.Visible == true)
            {
                if (B4.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    pintar("negro", "B4");
                }
                else
                {
                    pintar("blanco", "B4");
                }

            }
            else
            {
                pintar(color, "B4");
            }

        }
        protected void B5_Click(object sender, EventArgs e)
        {
            if (B5.Visible == true)
            {
                if (B5.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    pintar("negro", "B5");
                }
                else
                {
                    pintar("blanco", "B5");
                }

            }
            else
            {
                pintar(color, "B5");
            }

        }
        protected void B6_Click(object sender, EventArgs e)
        {
            if (B6.Visible == true)
            {
                if (B6.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    pintar("negro", "B6");
                }
                else
                {
                    pintar("blanco", "B6");
                }

            }
            else
            {
                pintar(color, "B6");
            }

        }
        protected void B7_Click(object sender, EventArgs e)
        {
            if (B7.Visible == true)
            {
                if (B7.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    pintar("negro", "B7");
                }
                else
                {
                    pintar("blanco", "B7");
                }

            }
            else
            {
                pintar(color, "B7");
            }

        }
        protected void B8_Click(object sender, EventArgs e)
        {
            if (B8.Visible == true)
            {
                if (B8.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    pintar("negro", "B8");
                }
                else
                {
                    pintar("blanco", "B8");
                }

            }
            else
            {
                pintar(color, "B8");
            }

        }
        protected void C1_Click(object sender, EventArgs e)
        {
            if (C1.Visible == true)
            {
                if (C1.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    pintar("negro", "C1");
                }
                else
                {
                    pintar("blanco", "C1");
                }

            }
            else
            {
                pintar(color, "C1");
            }

        }
        protected void C2_Click(object sender, EventArgs e)
        {
            if (C2.Visible == true)
            {
                if (C2.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    pintar("negro", "C2");
                }
                else
                {
                    pintar("blanco", "C2");
                }

            }
            else
            {
                pintar(color, "C2");
            }

        }
        protected void C3_Click(object sender, EventArgs e)
        {
            if (C3.Visible == true)
            {
                if (C3.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    pintar("negro", "C3");
                }
                else
                {
                    pintar("blanco", "C3");
                }

            }
            else
            {
                pintar(color, "C3");
            }

        }
        protected void C4_Click(object sender, EventArgs e)
        {
            if (C4.Visible == true)
            {
                if (C4.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    pintar("negro", "C4");
                }
                else
                {
                    pintar("blanco", "C4");
                }

            }
            else
            {
                pintar(color, "C4");
            }

        }
        protected void C5_Click(object sender, EventArgs e)
        {
            if (C5.Visible == true)
            {
                if (C5.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    pintar("negro", "C5");
                }
                else
                {
                    pintar("blanco", "C5");
                }

            }
            else
            {
                pintar(color, "C5");
            }

        }
        protected void C6_Click(object sender, EventArgs e)
        {
            if (C6.Visible == true)
            {
                if (C6.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    pintar("negro", "C6");
                }
                else
                {
                    pintar("blanco", "C6");
                }

            }
            else
            {
                pintar(color, "C6");
            }

        }
        protected void C7_Click(object sender, EventArgs e)
        {
            if (C7.Visible == true)
            {
                if (C7.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    pintar("negro", "C7");
                }
                else
                {
                    pintar("blanco", "C7");
                }

            }
            else
            {
                pintar(color, "C7");
            }

        }
        protected void C8_Click(object sender, EventArgs e)
        {
            if (C8.Visible == true)
            {
                if (C8.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    pintar("negro", "C8");
                }
                else
                {
                    pintar("blanco", "C8");
                }

            }
            else
            {
                pintar(color, "C8");
            }

        }
        protected void D1_Click(object sender, EventArgs e)
        {
            if (D1.Visible == true)
            {
                if (D1.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    pintar("negro", "D1");
                }
                else
                {
                    pintar("blanco", "D1");
                }

            }
            else
            {
                pintar(color, "D1");
            }

        }
        protected void D2_Click(object sender, EventArgs e)
        {
            if (D2.Visible == true)
            {
                if (D2.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    pintar("negro", "D2");
                }
                else
                {
                    pintar("blanco", "D2");
                }

            }
            else
            {
                pintar(color, "D2");
            }

        }
        protected void D3_Click(object sender, EventArgs e)
        {
            if (D3.Visible == true)
            {
                if (D3.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    pintar("negro", "D3");
                }
                else
                {
                    pintar("blanco", "D3");
                }

            }
            else
            {
                pintar(color, "D3");
            }

        }
        protected void D5_Click(object sender, EventArgs e)
        {
            if (D5.Visible == true)
            {
                if (D5.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    pintar("negro", "D5");
                }
                else
                {
                    pintar("blanco", "D5");
                }

            }
            else
            {
                pintar(color, "D5");
            }

        }
        protected void D6_Click(object sender, EventArgs e)
        {
            if (D6.Visible == true)
            {
                if (D6.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    pintar("negro", "D6");
                }
                else
                {
                    pintar("blanco", "D6");
                }

            }
            else
            {
                pintar(color, "D6");
            }

        }
        protected void D7_Click(object sender, EventArgs e)
        {
            if (D7.Visible == true)
            {
                if (D7.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    pintar("negro", "D7");
                }
                else
                {
                    pintar("blanco", "D7");
                }

            }
            else
            {
                pintar(color, "D7");
            }

        }
        protected void D8_Click(object sender, EventArgs e)
        {
            if (D8.Visible == true)
            {
                if (D8.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    pintar("negro", "D8");
                }
                else
                {
                    pintar("blanco", "D8");
                }

            }
            else
            {
                pintar(color, "D8");
            }

        }
        
        protected void D4_Click(object sender, EventArgs e)
        {
            if (D4.Visible == true)
            {
                if (D4.BackColor.Equals(Color.FromArgb(225, 225, 225, 225)))
                {
                    pintar("negro", "D4");
                }
                else
                {
                    pintar("blanco", "D4");
                }

            }
            else
            {
                pintar(color, "D4");
            }

        }
        protected void E1_Click(object sender, EventArgs e)
        {
            if (E1.Visible == true)
            {
                if (E1.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    pintar("negro", "E1");
                }
                else
                {
                    pintar("blanco", "E1");
                }

            }
            else
            {
                pintar(color, "E1");
            }

        }
        protected void E2_Click(object sender, EventArgs e)
        {
            if (E2.Visible == true)
            {
                if (E2.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    pintar("negro", "E2");
                }
                else
                {
                    pintar("blanco", "E2");
                }

            }
            else
            {
                pintar(color, "E2");
            }

        }
        protected void E3_Click(object sender, EventArgs e)
        {
            if (E3.Visible == true)
            {
                if (E3.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    pintar("negro", "E3");
                }
                else
                {
                    pintar("blanco", "E3");
                }

            }
            else
            {
                pintar(color, "E3");
            }

        }
        protected void E5_Click(object sender, EventArgs e)
        {
            if (E5.Visible == true)
            {
                if (E5.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    pintar("negro", "E5");
                }
                else
                {
                    pintar("blanco", "E5");
                }

            }
            else
            {
                pintar(color, "E5");
            }

        }
        protected void E6_Click(object sender, EventArgs e)
        {
            if (E6.Visible == true)
            {
                if (E6.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    pintar("negro", "E6");
                }
                else
                {
                    pintar("blanco", "E6");
                }

            }
            else
            {
                pintar(color, "E6");
            }

        }
        protected void E7_Click(object sender, EventArgs e)
        {
            if (E7.Visible == true)
            {
                if (E7.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    pintar("negro", "E7");
                }
                else
                {
                    pintar("blanco", "E7");
                }

            }
            else
            {
                pintar(color, "E7");
            }

        }
        protected void E8_Click(object sender, EventArgs e)
        {
            if (E8.Visible == true)
            {
                if (E8.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    pintar("negro", "E8");
                }
                else
                {
                    pintar("blanco", "E8");
                }

            }
            else
            {
                pintar(color, "E8");
            }

        }

        protected void E4_Click(object sender, EventArgs e)
        {
            if (E4.Visible == true)
            {
                if (E4.BackColor.Equals(Color.FromArgb(225, 225, 225, 225)))
                {
                    pintar("negro", "E4");
                }
                else
                {
                    pintar("blanco", "E4");
                }

            }
            else
            {
                pintar(color, "E4");
            }

        }
        protected void F1_Click(object sender, EventArgs e)
        {
            if (F1.Visible == true)
            {
                if (F1.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    pintar("negro", "F1");
                }
                else
                {
                    pintar("blanco", "F1");
                }

            }
            else
            {
                pintar(color, "F1");
            }

        }
        protected void F2_Click(object sender, EventArgs e)
        {
            if (F2.Visible == true)
            {
                if (F2.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    pintar("negro", "F2");
                }
                else
                {
                    pintar("blanco", "F2");
                }

            }
            else
            {
                pintar(color, "F2");
            }

        }
        protected void F3_Click(object sender, EventArgs e)
        {
            if (F3.Visible == true)
            {
                if (F3.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    pintar("negro", "F3");
                }
                else
                {
                    pintar("blanco", "F3");
                }

            }
            else
            {
                pintar(color, "F3");
            }

        }
        protected void F5_Click(object sender, EventArgs e)
        {
            if (F5.Visible == true)
            {
                if (F5.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    pintar("negro", "F5");
                }
                else
                {
                    pintar("blanco", "F5");
                }

            }
            else
            {
                pintar(color, "F5");
            }

        }
        protected void F6_Click(object sender, EventArgs e)
        {
            if (F6.Visible == true)
            {
                if (F6.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    pintar("negro", "F6");
                }
                else
                {
                    pintar("blanco", "F6");
                }

            }
            else
            {
                pintar(color, "F6");
            }

        }
        protected void F7_Click(object sender, EventArgs e)
        {
            if (F7.Visible == true)
            {
                if (F7.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    pintar("negro", "F7");
                }
                else
                {
                    pintar("blanco", "F7");
                }

            }
            else
            {
                pintar(color, "F7");
            }

        }
        protected void F8_Click(object sender, EventArgs e)
        {
            if (F8.Visible == true)
            {
                if (F8.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    pintar("negro", "F8");
                }
                else
                {
                    pintar("blanco", "F8");
                }

            }
            else
            {
                pintar(color, "F8");
            }

        }

        protected void F4_Click(object sender, EventArgs e)
        {
            if (F4.Visible == true)
            {
                if (F4.BackColor.Equals(Color.FromArgb(225, 225, 225, 225)))
                {
                    pintar("negro", "F4");
                }
                else
                {
                    pintar("blanco", "F4");
                }

            }
            else
            {
                pintar(color, "F4");
            }

        }
        protected void G1_Click(object sender, EventArgs e)
        {
            if (G1.Visible == true)
            {
                if (G1.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    pintar("negro", "G1");
                }
                else
                {
                    pintar("blanco", "G1");
                }

            }
            else
            {
                pintar(color, "G1");
            }

        }
        protected void G2_Click(object sender, EventArgs e)
        {
            if (G2.Visible == true)
            {
                if (G2.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    pintar("negro", "G2");
                }
                else
                {
                    pintar("blanco", "G2");
                }

            }
            else
            {
                pintar(color, "G2");
            }

        }
        protected void G3_Click(object sender, EventArgs e)
        {
            if (G3.Visible == true)
            {
                if (G3.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    pintar("negro", "G3");
                }
                else
                {
                    pintar("blanco", "G3");
                }

            }
            else
            {
                pintar(color, "G3");
            }

        }
        protected void G5_Click(object sender, EventArgs e)
        {
            if (G5.Visible == true)
            {
                if (G5.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    pintar("negro", "G5");
                }
                else
                {
                    pintar("blanco", "G5");
                }

            }
            else
            {
                pintar(color, "G5");
            }

        }
        protected void G6_Click(object sender, EventArgs e)
        {
            if (G6.Visible == true)
            {
                if (G6.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    pintar("negro", "G6");
                }
                else
                {
                    pintar("blanco", "G6");
                }

            }
            else
            {
                pintar(color, "G6");
            }

        }
        protected void G7_Click(object sender, EventArgs e)
        {
            if (G7.Visible == true)
            {
                if (G7.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    pintar("negro", "G7");
                }
                else
                {
                    pintar("blanco", "G7");
                }

            }
            else
            {
                pintar(color, "G7");
            }

        }
        protected void G8_Click(object sender, EventArgs e)
        {
            if (G8.Visible == true)
            {
                if (G8.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    pintar("negro", "G8");
                }
                else
                {
                    pintar("blanco", "G8");
                }

            }
            else
            {
                pintar(color, "G8");
            }

        }

        protected void G4_Click(object sender, EventArgs e)
        {
            if (G4.Visible == true)
            {
                if (G4.BackColor.Equals(Color.FromArgb(225, 225, 225, 225)))
                {
                    pintar("negro", "G4");
                }
                else
                {
                    pintar("blanco", "G4");
                }

            }
            else
            {
                pintar(color, "G4");
            }

        }
        protected void H1_Click(object sender, EventArgs e)
        {
            if (H1.Visible == true)
            {
                if (H1.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    pintar("negro", "H1");
                }
                else
                {
                    pintar("blanco", "H1");
                }

            }
            else
            {
                pintar(color, "H1");
            }

        }
        protected void H2_Click(object sender, EventArgs e)
        {
            if (H2.Visible == true)
            {
                if (H2.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    pintar("negro", "H2");
                }
                else
                {
                    pintar("blanco", "H2");
                }

            }
            else
            {
                pintar(color, "H2");
            }

        }
        protected void H3_Click(object sender, EventArgs e)
        {
            if (H3.Visible == true)
            {
                if (H3.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    pintar("negro", "H3");
                }
                else
                {
                    pintar("blanco", "H3");
                }

            }
            else
            {
                pintar(color, "H3");
            }

        }
        protected void H5_Click(object sender, EventArgs e)
        {
            if (H5.Visible == true)
            {
                if (H5.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    pintar("negro", "H5");
                }
                else
                {
                    pintar("blanco", "H5");
                }

            }
            else
            {
                pintar(color, "H5");
            }

        }
        protected void H6_Click(object sender, EventArgs e)
        {
            if (H6.Visible == true)
            {
                if (H6.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    pintar("negro", "H6");
                }
                else
                {
                    pintar("blanco", "H6");
                }

            }
            else
            {
                pintar(color, "H6");
            }

        }
        protected void H7_Click(object sender, EventArgs e)
        {
            if (H7.Visible == true)
            {
                if (H7.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    pintar("negro", "H7");
                }
                else
                {
                    pintar("blanco", "H7");
                }

            }
            else
            {
                pintar(color, "H7");
            }

        }

        protected void H8_Click(object sender, EventArgs e)
        {
            if (H8.Visible == true)
            {
                if (H8.BackColor == Color.FromArgb(225, 225, 225, 225))
                {
                    pintar("negro", "H8");
                }
                else
                {
                    pintar("blanco", "H8");
                }

            }
            else
            {
                pintar(color, "H8");
            }

        }

        

        protected void H4_Click(object sender, EventArgs e)
        {
            if (H4.Visible == true)
            {
                if (H4.BackColor.Equals(Color.FromArgb(225, 225, 225, 225)))
                {
                    pintar("negro", "H4");
                }
                else
                {
                    pintar("blanco", "H4");
                }

            }
            else
            {
                pintar(color, "H4");
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
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndDocument();
            xmlWriter.Close();
            System.Windows.MessageBox.Show("Su partida se ha guardado exitosamente");
        }

        protected void btnMenu_Click(object sender, EventArgs e)
        {
            HttpContext.Current.Response.Redirect("Menu.aspx");
        }
    }

    
}