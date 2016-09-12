using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class Circunferencia
    {
        public int Radio { get; set; }

        public Circunferencia(int radio)
        {
            Radio = radio;
        }

        public double getArea()
        {
            return (Math.Pow(Radio, Radio) * Math.PI);
        }
        public double getPerimetro()
        {
            return 2 * Radio * Math.PI;
        }
    }
}
