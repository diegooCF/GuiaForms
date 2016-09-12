using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ejemplar
    {
        public Libro Libro { get; set; }
        public int CodigoEjemplar { get; set; }
        private enum Estado { Libre, Prestado, Desaparecido }

        public Ejemplar(int pCodigoEjemplar, Libro pLibro)
        {
            CodigoEjemplar = pCodigoEjemplar;
            Libro = pLibro;
        }
    }
}
