using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoBase.Entidades;

namespace ProyectoBase
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals("") || txtContraseña.Text.Equals(""))
            {
                MessageBox.Show("Ingrese nombre de usuario y password");
            }
            else
            {
                string nombreDeUsuario = txtUsuario.Text;
                string password = txtContraseña.Text;
                bool resultado = false;

                try
                {
                    resultado = ValidarUsuario(nombreDeUsuario, password);
                    if (resultado == true)
                    {
                        Usuario usu = new Usuario(nombreDeUsuario, password);
                        frmPrincipal ventana = new frmPrincipal(usu);
                        ventana.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario inexistente");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al consultar");
                }
            }
        }

        private bool ValidarUsuario(string nombreDeUsuario, string password)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM usuarios WHERE NombreUsuario LIKE @nombreUsu AND Password LIKE @pass";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreUsu", nombreDeUsuario);
                cmd.Parameters.AddWithValue("@pass", password);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                if (tabla.Rows.Count == 1)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }
                return resultado;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al consultar el usuario");
                return false;
            }
            finally
            {
               cn.Close();
            }

        }
    }
}
