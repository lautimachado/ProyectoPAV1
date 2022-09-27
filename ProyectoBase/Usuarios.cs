using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBase
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }
        private void CargarGrilla()

            {
                string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
                SqlConnection cn = new SqlConnection(cadenaConexion);
                try
                {
                    SqlCommand cmd = new SqlCommand();

                    string consulta = "SELECT * FROM usuarios";
                    cmd.Parameters.Clear();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = consulta;

                    cn.Open();
                    cmd.Connection = cn;

                    DataTable tabla = new DataTable();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla);

                grdUsuarios.DataSource = tabla;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al consultar el usuario");
                }
                finally
                {
                    cn.Close();
                }
            
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            
        }
        private void LimpiarCampos()
        {
            txtNombreDeUsuario.Text = "";
            txtPassword.Text = "";
            txtRepetirPassword.Text = "";
        }

        private void btnAltaUsuario_Click(object sender, EventArgs e)
        {
            if(txtNombreDeUsuario.Text.Equals(""))
            {
                MessageBox.Show("Ingrese nombre de usuario");
            }
            else
            {
                if(txtPassword.Text.Equals(""))
                {
                    MessageBox.Show("Ingrese contraseña");
                }    
                else
                {
                    if (txtRepetirPassword.Text.Equals(""))
                    {
                        MessageBox.Show("Repita contraseña");
                    }
                    else
                    {
                        if(txtRepetirPassword.Text.Equals(txtPassword.Text))
                        {
                            if (ExisteEnGrilla(txtNombreDeUsuario.Text) == true)
                            {
                                MessageBox.Show("Usuario ya existe");
                            }
                            else
                            {
                                InsertarUsuario(txtNombreDeUsuario.Text, txtPassword.Text);
                                MessageBox.Show("Usuario dado de alta");
                                CargarGrilla();
                                LimpiarCampos();
                                txtNombreDeUsuario.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Contraseñas no coinciden");
                        }    
                    }
                }
            }
        }
        private bool ExisteEnGrilla(string criterioABuscar)
        {
            bool resultado = false;
            for (int i = 0; i < grdUsuarios.Rows.Count; i++)
            {
                if (grdUsuarios.Rows[i].Cells["Usuario"].Value.Equals(criterioABuscar))
                {
                    resultado = true;
                    break;
                }
            }
            return resultado;
        }
        private bool InsertarUsuario(string nombreDeUsuario, string password)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO usuarios VALUES (@nombreUsu, @password)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreUsu", nombreDeUsuario);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();

                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }

    }
}
