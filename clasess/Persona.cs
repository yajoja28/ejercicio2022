using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasess
{
    public class Persona
    {
        private string nombre;
        private string apellidos;
        private string documento;
        private string tipo;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Documento { get => documento; set => documento = value; }
        public string Tipo { get => tipo; set => tipo = value; }
    }
}
