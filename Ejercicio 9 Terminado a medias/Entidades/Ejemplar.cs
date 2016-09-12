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
        public Estado estado;
        public enum Estado { Libre, Prestado, Desaparecido }

        public Ejemplar(int pCodigoEjemplar, Libro pLibro)
        {
            estado = Estado.Libre;
            CodigoEjemplar = pCodigoEjemplar;
            Libro = pLibro;
        }

        public void alquilado()
        {
            estado = Estado.Prestado;
        }
        public void disponible()
        {
            estado = Estado.Libre;
        }
    }
}
