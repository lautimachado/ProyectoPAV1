using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBase.Entidades
{
    public class Usuario
    {
        private string NombreUsuario;
        private string Password;

        public Usuario(string nombreUsuario, string password)
        {
            NombreUsuario = nombreUsuario;
            Password = password;
        }

        public string NombreDeUsuario
        {
            get => NombreUsuario;
            set => NombreUsuario = value;
        }

        public string Pass
        { 
            get => Password; 
            set => Password = value; 
        }
    }
}
