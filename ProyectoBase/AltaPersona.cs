using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoBase.Entidades;

namespace ProyectoBase
{
    public partial class AltaPersona : Form
    {
        public AltaPersona()
        {
            InitializeComponent();
        }

        private void AltaPersona_Load(object sender, EventArgs e)
        {
            LimpiarCampos();

            txtCantidadHijos.Enabled = false;

            CargarComboTiposDocumento();
            CargarComboCarreras();
            CargarGrilla();

        }

        private void CargarComboTiposDocumento()
        {
                string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
                SqlConnection cn = new SqlConnection(cadenaConexion);
                try
                {
                    SqlCommand cmd = new SqlCommand();

                    string consulta = "SELECT * FROM tipo_documentos";
                    cmd.Parameters.Clear();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = consulta;

                    cn.Open();
                    cmd.Connection = cn;

                    DataTable tabla = new DataTable();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla);

                cmbTipoDoc.DataSource = tabla;
                cmbTipoDoc.DisplayMember = "Nombre";
                cmbTipoDoc.ValueMember = "Id";
                cmbTipoDoc.SelectedIndex = -1;
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
        private void CargarComboCarreras()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM carreras";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                cmbCarrera.DataSource = tabla;
                cmbCarrera.DisplayMember = "Nombre";
                cmbCarrera.ValueMember = "Id";
                cmbCarrera.SelectedIndex = -1;
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


        private void btnGuardarPersona_Click(object sender, EventArgs e)
        {
            Persona p = new Persona();
            p.NombreDePersona = txtNombre.Text.Trim();
            p.ApellidoDePersona = txtApellido.Text.Trim();
            p.FechaNacimientoPersona = DateTime.Parse(txtFechaNacimiento.Text);
            
            if(rbMasculino.Checked)
            {
                p.SexoPersona = 1;
            }    
            else if(rbFemenino.Checked)
            {
                p.SexoPersona = 2;
            }
            else
            {
                p.SexoPersona = 3;
            }

            p.TipoDocumentoDePersona = (int)cmbTipoDoc.SelectedValue;
            p.DocumentoDePersona = txtNumeroDoc.Text.Trim();
            p.CallePersona = txtCalle.Text.Trim();
            p.NumeroCallePersona = txtNroCalle.Text.Trim();
            if(chkSoltero.Checked)
            {
                p.SolteroPersona = true;
            }
            else
            {
                p.SolteroPersona = false;
            }
            if(chkCasado.Checked)
            {
                p.CasadoPersona = true;
            }
            else
            {
                p.CasadoPersona = false;
            }
            if(chkHijos.Checked)
            {
                p.HijosPersona = true;
            }
            else
            {
                p.HijosPersona = false;
            }

            if(txtCantidadHijos.Text.Equals(""))
            {
                p.CantidadHijosPersona = 0;
            }
            else
            {
                p.CantidadHijosPersona = int.Parse(txtCantidadHijos.Text);
            }
            p.CarreraPersona = (int)cmbCarrera.SelectedValue;

            bool resultado = AgregarPersonaBD(p);
            if(resultado)
            {
                MessageBox.Show("Persona agregada con exito");
                LimpiarCampos();
                CargarComboCarreras();
                CargarComboTiposDocumento();
                CargarGrilla();
            }
            else
            {
                MessageBox.Show("Error al cargar persona");
            }
        }

        private bool AgregarPersonaBD(Persona per)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO personas (Nombre, Apellido, FechaNacimiento, IdSexo, IdTipoDocumento, NumeroDocumento, Calle, NumeroCalle, Soltero, Casado, Hijos, CantidadHijos, IdCarrera) VALUES (@nombrePer, @apellido, @fechaNac, @idSexo, @idTipoDoc, @numeroDoc, @calle, @numeroCalle, @soltero,  @casado, @hijos, @cantidadHijos, @idCarrera)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombrePer", per.NombreDePersona);
                cmd.Parameters.AddWithValue("@apellido", per.ApellidoDePersona);
                cmd.Parameters.AddWithValue("@fechaNac", per.FechaNacimientoPersona);
                cmd.Parameters.AddWithValue("@idSexo", per.SexoPersona);
                cmd.Parameters.AddWithValue("@idTipoDoc", per.TipoDocumentoDePersona);
                cmd.Parameters.AddWithValue("@numeroDoc", per.DocumentoDePersona);
                cmd.Parameters.AddWithValue("@calle", per.CallePersona);
                cmd.Parameters.AddWithValue("@numeroCalle", per.NumeroCallePersona);
                cmd.Parameters.AddWithValue("@soltero", per.SolteroPersona);
                cmd.Parameters.AddWithValue("@casado", per.CasadoPersona);
                cmd.Parameters.AddWithValue("@hijos", per.HijosPersona);
                cmd.Parameters.AddWithValue("@cantidadHijos", per.CantidadHijosPersona);
                cmd.Parameters.AddWithValue("@idCarrera", per.CarreraPersona);
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
        private void AgregarPersona(Persona per)
        {
            DataGridViewRow fila = new DataGridViewRow();

            DataGridViewTextBoxCell celdaNombre = new DataGridViewTextBoxCell();
            celdaNombre.Value = per.NombreDePersona;
            fila.Cells.Add(celdaNombre);

            DataGridViewTextBoxCell celdaApellido = new DataGridViewTextBoxCell();
            celdaApellido.Value = per.ApellidoDePersona;
            fila.Cells.Add(celdaApellido);

            DataGridViewTextBoxCell celdaDocumento = new DataGridViewTextBoxCell();
            celdaDocumento.Value = per.DocumentoDePersona;
            fila.Cells.Add(celdaDocumento);

            gdrPersonas.Rows.Add(fila);

            MessageBox.Show("Persona agregada con exito");
            LimpiarCampos();
            txtNombre.Focus();
        }

        private void chkHijos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHijos.Checked)
            {
                txtCantidadHijos.Enabled = true;
            }
            else
            {
                txtCantidadHijos.Enabled = false;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtFechaNacimiento.Text = "";
            txtNumeroDoc.Text = "";
            txtNroCalle.Text = "";
            txtCalle.Text = "";
            rbMasculino.Checked = true;
            chkCasado.Checked = false;
            chkHijos.Checked = false;
            chkSoltero.Checked = false;
        }

        private bool ExisteEnGrilla(string criterioABuscar)
        { 
            bool resultado = false;
            for (int i = 0; i<gdrPersonas.Rows.Count; i++)
			{
                if (gdrPersonas.Rows[i].Cells["Documento"].Value.Equals(criterioABuscar))
                {
                    resultado = true;
                    break;
                }
			}
            return resultado;
        }
        private void CargarGrilla()

        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT Nombre, Apellido, IdTipoDocumento, NumeroDocumento FROM personas";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                gdrPersonas.DataSource = tabla;
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
    }
}
