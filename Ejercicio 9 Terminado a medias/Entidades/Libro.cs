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

        private List<Ejemplar> listaEjemplares = new List<Ejemplar>();
        public List<Ejemplar> ListaEjemplares
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
            ListaEjemplares.Add(new Ejemplar(1, this));
            ListaEjemplares.Add(new Ejemplar(2, this));
            ListaEjemplares.Add(new Ejemplar(3, this));
            ListaEjemplares.Add(new Ejemplar(4, this));
        }
    }
}
