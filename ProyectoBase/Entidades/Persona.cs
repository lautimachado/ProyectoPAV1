using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBase.Entidades
{
    public class Persona
    {
        private string Nombre;
        private string Apellido;
        private string Documento;
        private DateTime FechaNacimiento;
        private int IdSexo;
        private int IdTipoDocumento;
        private string Calle;
        private string NumeroCalle;
        private bool Soltero;
        private bool Casado;
        private bool Hijos;
        private int CantidadHijos;
        private int IdCarrera;

        public Persona(string nombrePersona, string apellidoPersona, string documentoPersona)
        {
            Nombre = nombrePersona;
            Apellido = apellidoPersona;
            Documento = documentoPersona;
        }
        public Persona()
        {

        }

        public string NombreDePersona
        {
            get => Nombre;
            set => Nombre = value;
        }

        public string ApellidoDePersona
        {
            get => Apellido;
            set => Apellido = value;
        }

        public string DocumentoDePersona
        {
            get => Documento;
            set => Documento = value;
        }
        public DateTime FechaNacimientoPersona
        {
            get => FechaNacimiento;
            set => FechaNacimiento = value;
        }
        public int SexoPersona
        {
            get => IdSexo;
            set => IdSexo = value;
        }
        public int TipoDocumentoDePersona
        {
            get => IdTipoDocumento;
            set => IdTipoDocumento = value;
        }
        public string CallePersona
        {
            get => Calle;
            set => Calle = value;
        }
        public string NumeroCallePersona
        {
            get => NumeroCalle;
            set => NumeroCalle = value;
        }
        public bool SolteroPersona
        {
            get => Soltero;
            set => Soltero = value;
        }
        public bool CasadoPersona
        {
            get => Casado;
            set => Casado = value;
        }
        public bool HijosPersona
        {
            get => Hijos;
            set => Hijos = value;
        }
        public int CantidadHijosPersona
        {
            get => CantidadHijos;
            set => CantidadHijos = value;
        }
        public int CarreraPersona
        {
            get => IdCarrera;
            set => IdCarrera = value;
        }

    }

}
