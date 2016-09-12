using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    public static class Componentes
    {
        //Valores iniciales del sistema
        private static List<Piso> Pisos = new List<Piso>(3);
        public static List<Piso> getPisos(){ return Pisos; }
        public static void Initialize()
        {
            Pisos.Add(new Piso(1));
            Pisos.Add(new Piso(2));
            Pisos.Add(new Piso(3));
        }             
        
        public static void getCoordenadasDePlaza(string patente, out int numPiso, out int numPlaza)
        {
            foreach (var piso in getPisos())
            {
                foreach (var plaza in piso.Plazas)
                {
                    if(plaza.Disponible == false && patente == plaza.Auto.Patente)
                    {
                        numPiso = piso.Codigo;
                        numPlaza = plaza.Numero;
                        return;
                    }
                }
            }
            numPiso = 0;
            numPlaza = 0;
        }
    }
}
