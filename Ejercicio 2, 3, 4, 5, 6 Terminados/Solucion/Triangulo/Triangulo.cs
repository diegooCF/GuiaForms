using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public enum TipoTriangulo
    {
        ESCALENO,
        ISOSCELES,
        EQUILATERO
    }
    public class Triangulo
    {
        public int ladoBase { get; set; }
        public int altura { get; set; }
        public TipoTriangulo tipo { get; set; }
        public int lado1 { get; set; }
        public int lado2 { get; set; }
        public int lado3 { get; set; }

        public Triangulo() { }
        public Triangulo(int ladoBase, int altura)
        {
            this.ladoBase = ladoBase;
            this.altura = altura;
            lado1 = 0;
            lado2 = 0;
            lado3 = 0;
        }
        public Triangulo(int lado1, int lado2, int lado3)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.lado3 = lado3;
            setTipo();
        }
        public double getArea()
        {
            return (ladoBase * altura) / 2;
        }
        public int getPerimetro()
        {
            return lado1 + lado2 + lado3;
        }
        public bool esTriangulo()
        {
            int mayor = 0;
            int[] menores = new int[2];
            if (lado1 > lado2 && lado1 > lado3)
            {
                mayor = lado1;
                menores[0] = lado2;
                menores[1] = lado3;
            }
            else if (lado2 > lado1 && lado2 > lado3)
            {
                mayor = lado2;
                menores[0] = lado1;
                menores[1] = lado3;
            }
            else if (lado3 > lado1 && lado3 > lado2)
            {
                mayor = lado3;
                menores[0] = lado1;
                menores[1] = lado2;
            }
            if ((menores[0] + menores[1]) >= mayor || (lado1 == lado2 && lado2 == lado3))
                return true;
            else
                return false;
        }
        private void setTipo()
        {
            if (lado1 == lado2 && lado2 == lado3)
            {
                tipo = TipoTriangulo.EQUILATERO;
            }
            else if ((lado1 != lado2) && (lado1 != lado3) && (lado2 != lado3))
            {
                tipo = TipoTriangulo.ESCALENO;
            }
            else
            {
                tipo = TipoTriangulo.ESCALENO;
            }
        }
    }
}
