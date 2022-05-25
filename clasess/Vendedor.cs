using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasess
{
    public class Vendedor:Persona
    {
        private double sueldo;
        private string tipocontrato;
        string persona;

        public double Sueldo { get => sueldo; set => sueldo = value; }
        public string Tipocontrato { get => tipocontrato; set => tipocontrato = value; }

        public void calcularsueldo(double sueldobase)
        {
            if (persona=="N")
            {
                double sueldo = sueldobase + 120000;
            }
            else if (persona=="A")
            {
                double sueldo = sueldobase + 400000;
            }
            else
            {
                sueldo = 0;
            }
        }
    }
}
