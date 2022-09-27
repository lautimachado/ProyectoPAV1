using ProyectoBase.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBase
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal(Usuario usu )
        {
            InitializeComponent();
            lblBienvenido.Text = "Bienvenido " + usu.NombreDeUsuario;
            lblBienvenido.Visible = true;
        }

        private void altaPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaPersona ventana = new AltaPersona();
            ventana.Show();

        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios ventana = new Usuarios();
            ventana.Show();
        }
    }
}
