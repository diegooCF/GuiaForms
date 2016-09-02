using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public static class Socio
    {
        private static List<Entidades.Socio> listaSocios = new List<Entidades.Socio>();
        public static List<Entidades.Socio> ListaSocios
        {
            get
            {
                return listaSocios;
            }

            set
            {
                listaSocios = value;
            }
        }
    }
}
