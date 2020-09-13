using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _IPC2_Proyecto
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        RegistrarDatos ingresar = new RegistrarDatos();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrarse_Click(object sender, EventArgs e)
        {
            HttpContext.Current.Response.Redirect("RegistroUsuario.aspx");
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            ingresar.Login(txtUsuario.Text ,txtPassword.Text);
        }
    }
}