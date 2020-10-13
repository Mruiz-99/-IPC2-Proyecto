using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;
using System.Xml;

namespace _IPC2_Proyecto
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        string usuario;
        string[] lista;
        
        string[,] posiciones = new string[64, 3];
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                if (Request.Params["parametro"] != null)
                {
                    usuario = Request.Params["parametro"];
                    user.Text = "Bienvenido:  " + usuario;

                }
            } 
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            HttpContext.Current.Response.Redirect("Login.aspx");
        }

        protected void btnCargar_Click(object sender, EventArgs e)
        {
            
            if (archivoXML.HasFile)
            {
                string extension = System.IO.Path.GetExtension(archivoXML.FileName);
                if (extension == ".xml" || extension == ".XML")
                {
                    if (!File.Exists(Server.MapPath("~/XML/" + archivoXML.FileName)))
                    {
                        archivoXML.SaveAs(Server.MapPath("~/XML/" + archivoXML.FileName));
                        
                    }
                    lista = user.Text.Split(':');
                    usuario = lista[1].Trim();
                    HttpContext.Current.Response.Redirect("Juego.aspx?parametro=" + archivoXML.FileName + "," + usuario);
                }
                else {
                    MessageBox.Show("Error, debes seleccionar un archivo con expension .xml");
                }
            }
            else {
                MessageBox.Show("Error, debes seleccionar un archivo");
            }
        }

        protected void btn1Jugador_Click(object sender, EventArgs e)
        {
            lista = user.Text.Split(':');
            usuario = lista[1].Trim();
            HttpContext.Current.Response.Redirect("Juego.aspx?parametro=" + "maquina" + "," + usuario);
        }

        protected void btn2Jugadores_Click(object sender, EventArgs e)
        {
            lista = user.Text.Split(':');
            usuario = lista[1].Trim();
            HttpContext.Current.Response.Redirect("Juego.aspx?parametro=" + "individual" + "," + usuario);
        }
    }
}