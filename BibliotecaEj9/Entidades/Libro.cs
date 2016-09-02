using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Libro
    {
        public int CodigoLibro { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }

        private List<Entidades.Ejemplar> listaEjemplares = new List<Entidades.Ejemplar>();
        public List<Entidades.Ejemplar> ListaEjemplares
        {
            get
            { return listaEjemplares; }
            set
            { listaEjemplares = value; }
        }
        public Libro(int pCodigoLibro, string pTitulo, string pAutor)
        {
            CodigoLibro = pCodigoLibro;
            Titulo = pTitulo;
            Autor = pAutor;
        }
    }
}
