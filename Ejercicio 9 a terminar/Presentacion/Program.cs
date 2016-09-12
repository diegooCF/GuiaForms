using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    static class Program
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

        private static List<Entidades.Libro> listaLibros = new List<Entidades.Libro>
        {
            new Entidades.Libro(110, "El Codigo Da vinci", "Dan Brown"),
            new Entidades.Libro(111, "Programacion Basica C#", "Lord Baldomero"),
            new Entidades.Libro(112, "Ficciones", "Borges")
        };
        public static List<Entidades.Libro> ListaLibros
        {
            get
            {
                return listaLibros;
            }

            set
            {
                listaLibros = value;
            }
        }

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ListaSocios.Add(new Entidades.Socio(1, "Diego", "Combate de los Pozos 1600"));
            ListaSocios.Add(new Entidades.Socio(2, "Jose", "Avenida Warnes 3500"));
            ListaSocios.Add(new Entidades.Socio(3, "Pepito", "Chile 2323"));
            ListaSocios.Add(new Entidades.Socio(4, "Jorge", "Avenida Carabobo 1654"));
            ListaSocios.Add(new Entidades.Socio(5, "Augusto", "Avenida Boedo 787"));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmInicio());
        }
    }
}
