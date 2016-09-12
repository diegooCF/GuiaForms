using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    public class Piso
    {
        public int Codigo { get; set; }
        public List<Plaza> Plazas { get; set; }
        public Piso(int Codigo)
        {
            this.Codigo = Codigo;
            inicializarLista();
        }

        private void inicializarLista()
        {
            Plazas = new List<Plaza>(3);
            Plazas.Add(new Plaza(1, true));
            Plazas.Add(new Plaza(2, true));
            Plazas.Add(new Plaza(3, true));   
        }
        public bool hayLugar(Auto auto, out int plazaOcupada)
        {
            foreach (var item in Plazas)
            {
                if (item.Disponible == true)
                {
                    item.ocupaAuto(auto);
                    plazaOcupada = item.Numero;
                    return true;
                }
            }
            plazaOcupada = -1;
            return false;
        }
    }
}
