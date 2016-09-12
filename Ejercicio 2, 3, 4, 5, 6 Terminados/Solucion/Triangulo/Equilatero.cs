using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class Equilatero : Triangulo
    {
        public int Lado { get; set; }
        public double EquilateroArea { get; set; }
        public double EquilateroPerimetro { get; set; }

        public Equilatero(int Lado)
        {
            this.Lado = Lado;
            Area();
            Perimetro();
        }
        public void Area()
        {
            EquilateroArea = (Math.Sqrt(3 * Lado)) / 2;
        }
        public void Perimetro()
        {
            EquilateroPerimetro = Lado * 3;
        }
    }
}
