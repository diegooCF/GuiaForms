using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public static class Libro
    {
        public static void addEjemplar(Entidades.Libro pLibro, Entidades.Ejemplar pEjemplar)
        {
            pLibro.ListaEjemplares.Add(pEjemplar);
        }
    }
}
