using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    public class Auto
    {
        public string Patente { get; set; }

        public Auto()
        {
            Patente = "";
        }
        public Auto(string Patente)
        {
            this.Patente = Patente;
        }
    }
}
