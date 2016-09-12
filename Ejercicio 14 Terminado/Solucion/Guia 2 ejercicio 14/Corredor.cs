using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_2_ejercicio_13
{
    public class Corredor
    {
        public static int autoIncrement = 1;
        public int Id { get; set; }
        public int Segundos{ get; set; }
        public Corredor(string segundos)
        {
            Id = autoIncrement;
            Segundos = Convert.ToInt32(segundos);
            autoIncrement++;
        }
    }
}
