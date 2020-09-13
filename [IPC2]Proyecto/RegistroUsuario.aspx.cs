using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace _IPC2_Proyecto
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        RegistrarDatos registro = new RegistrarDatos();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            if ((txtNombres.Text != "") && (txtApellidos.Text != "") && (txtUsuario.Text != "") && (txtPassword.Text != "")
                && (txtFecha.Text != "") && (txtCorreo.Text != ""))
            {
                registro.setNombre(txtNombres.Text);
                registro.setApellidos(txtApellidos.Text);
                registro.setUsuario(txtUsuario.Text);
                registro.setPassword(txtPassword.Text);
                registro.setFecha(txtFecha.Text);
                registro.setPais(drpPais.SelectedValue);
                registro.setCorreo(txtCorreo.Text);
                
                registro.GuardarRegistro();
            }
            else {
                MessageBox.Show("Error, necesita llenar todos los campos para poder guardar el registro");
            }
            
        }
    }
}