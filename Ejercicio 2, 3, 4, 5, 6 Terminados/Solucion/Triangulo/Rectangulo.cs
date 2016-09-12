using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class Rectangulo
    {
        public int Lado1 { get; set; }
        public int Lado2 { get; set; }

        public Rectangulo(int lado1, int lado2)
        {
            Lado1 = lado1;
            Lado2 = lado2;
        }

        public double getArea()
        {
            return Lado1 * Lado2;
        }

        public double getPerimetro()
        {
            return (Lado1 * 2) + (Lado2 * 2);
        }

        public bool esCuadrado()
        {
            if (Lado1 == Lado2)
                return true;
            else
                return false;
        }
    }
}
