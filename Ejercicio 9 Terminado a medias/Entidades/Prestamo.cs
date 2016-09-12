using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Prestamo
    {
        private Socio socio;
        private Ejemplar ejemplar;
        private DateTime fechaPrestamo;
        private DateTime fechaDevolucion;

        public Socio Socio
        {
            get
            {
                return socio;
            }

            set
            {
                socio = value;
            }
        }
        public Ejemplar Ejemplar
        {
            get
            {
                return ejemplar;
            }

            set
            {
                ejemplar = value;
            }
        }
        public DateTime FechaPrestamo
        {
            get
            {
                return fechaPrestamo;
            }

            set
            {
                fechaPrestamo = value;
            }
        }
        public DateTime FechaDevolucion
        {
            get
            {
                return fechaDevolucion;
            }

            set
            {
                fechaDevolucion = value;
            }
        }

        public Prestamo() { }
        public Prestamo(Socio pSocio, Ejemplar pEjemplar, DateTime pFechaPrestamo, DateTime pFechaDevolucion)
        {
            Socio = pSocio;
            Ejemplar = pEjemplar;
            FechaPrestamo = pFechaPrestamo;
            FechaDevolucion = pFechaDevolucion;
        }
    }
}
