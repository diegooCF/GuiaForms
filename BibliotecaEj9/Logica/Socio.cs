using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public static class Socio
    {
        //Declaracion de metodos

        /// <summary>
        /// Añadir un socio a lista especificada por parametros
        /// </summary>
        /// <param name="listSocios"></param>
        /// <param name="pSocio"></param>
        public static void addSocio(List<Entidades.Socio> listSocios, Entidades.Socio pSocio)
        {
            listSocios.Add(pSocio);
        }

        /// <summary>
        /// Remover un socio de una lista especificada
        /// </summary>
        /// <param name="listSocios"></param>
        /// <param name="pSocio"></param>
        public static void removeSocio(List<Entidades.Socio> listSocios, Entidades.Socio pSocio)
        {
            listSocios.Remove(pSocio);
        }

        /// <summary>
        /// Remover un socio de una lista especificando el codigo
        /// </summary>
        /// <param name="listSocios"></param>
        /// <param name="pCodigo"></param>
        public static void removeSocioById(List<Entidades.Socio> listSocios, int pCodigo)
        {
            foreach (var item in listSocios)
            {
                if(pCodigo == item.Codigo)
                {
                    removeSocio(listSocios, item);
                    break;
                }
            }
        }
        public static void addLibroPrestado(Entidades.Socio pSocio)
        {
            pSocio.CantidadLibros++;
        }
        public static void restLibroPrestado(Entidades.Socio pSocio)
        {
            pSocio.CantidadLibros--;
        }
        public static string getMorosoString(Entidades.Socio pSocio)
        {
            if (pSocio.Moroso == true)
                return "Si";
            else
                return "No";
        }
    }
}
