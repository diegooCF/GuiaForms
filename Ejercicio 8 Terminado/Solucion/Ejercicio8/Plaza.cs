using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    public class Plaza
    {
        public int Numero { get; set; }
        public bool Disponible { get; set; }
        public Auto Auto { get; set; }
        
        public Plaza(int Numero, bool Disponible)
        {
            this.Numero = Numero;
            this.Disponible = Disponible;
        }
        public void ocupaAuto(Auto Auto)
        {
            this.Auto = Auto;
            Disponible = false;
        }
        public void saleAuto()
        {
            this.Auto = null;
            Disponible = true;
        }
    }
}
