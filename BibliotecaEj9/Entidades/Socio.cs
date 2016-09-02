using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Socio
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public bool Moroso { get; set; }

        private int cantidadLibros;
        public int CantidadLibros
        {
            get
            {
                return cantidadLibros;
            }
            set
            {
                cantidadLibros = value;
            }
        }

        public Socio() { }
        public Socio(int pCodigo, string pNombre, string pDireccion)
        {
            Codigo = pCodigo;
            Nombre = pNombre;
            Direccion = pDireccion;
            Moroso = false;
            cantidadLibros = 0;
        }
    }
}
