using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasess
{
    class cliente : Persona
    {
        private string codigo;

        public string Codigo { get => codigo; set => codigo = value; }

        public void crearcodigo()
        {
            this.codigo = "C" + this.Nombre +(0, 3);
        }
    }
}
