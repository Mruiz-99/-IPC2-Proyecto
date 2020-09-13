using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Drawing.Imaging;
using System.Configuration;
using System.Web.Configuration;
using System.Windows;

namespace _IPC2_Proyecto
{
    public class RegistrarDatos
    {
        private int Id;
        private string nombres;
        private string apellidos;
        private string usuario;
        private string password;
        private string fechaNacimiento;
        private string pais;
        private string correo;
        private SqlCommand cmd;
        private SqlDataReader dr;
        private string cadenaSql;

        static string conexion = ConfigurationManager.AppSettings["strConexion"];
        SqlConnection cnn = new SqlConnection(conexion);


        public void conectar()
        {
            if (cnn.State != ConnectionState.Open)
            {
                cnn.Open();
            }
        }

        public void desconectar()
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
        }

        public int getId() {
            return Id;
        }
        public string getNombre()
        {
            return nombres;
        }
        public string getApellidos()
        {
            return apellidos;
        }
        public string getUsuario()
        {
            return usuario;
        }
        public string getPassword()
        {
            return password;
        }
        public string getFecha()
        {
            return fechaNacimiento;
        }
        public string getPais()
        {
            return pais;
        }
        public string getCorreo()
        {
            return correo;
        }

        public void setNombre(string n) {
            nombres = n;
        }

        public void setApellidos(string a)
        {
            apellidos = a;
        }

        public void setUsuario(string usu)
        {
            usuario = usu;
        }

        public void setPassword(string pas)
        {
            password = pas;
        }

        public void setFecha(string fecha)
        {
            fechaNacimiento = fecha;
        }
        public void setPais(string pa)
        {
            pais = pa;
        }
        public void setCorreo(string co)
        {
            correo = co;
        }

        public void GuardarRegistro() {
            cmd = new SqlCommand();
            cadenaSql = "select nombre_usuario from usuarios where nombre_usuario = '" + usuario+"' ";
            conectar();
            cmd = new SqlCommand(cadenaSql, cnn);
            dr = cmd.ExecuteReader();
            
            if (dr.Read())
            {
                desconectar();
                MessageBox.Show("Error, actualmente existe un nombre de usuario igual, ingrese otro usuario");
            }
            else {

                desconectar();
                cmd = new SqlCommand();
                cadenaSql = "insert into usuarios values('" + nombres + "','" + apellidos + "','" + usuario + "','" + password + "','" + fechaNacimiento + "','" + pais + "','" + correo + "')";
                conectar();
                cmd = new SqlCommand(cadenaSql, cnn);
                cmd.ExecuteNonQuery();
                desconectar();
                HttpContext.Current.Response.Redirect("Login.aspx");
                MessageBox.Show("Proceso exitoso, el registro a sido guardado en el sistema");
            }
        }

        public void Login(string user, string pass) {
            cmd = new SqlCommand();
            cadenaSql = "select nombre_usuario from usuarios where nombre_usuario='" + user + "' and pass='" + pass + "' ";
            conectar();
            cmd = new SqlCommand(cadenaSql, cnn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                    HttpContext.Current.Response.Redirect("Menu.aspx");
                    desconectar();
                
            }
            else {
                MessageBox.Show("Error, el ingreso de usuario o contraseña es incorrecto");
                desconectar();
            }
            
        }
    }
}