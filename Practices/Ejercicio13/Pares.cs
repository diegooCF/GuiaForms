using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Pares
    {
        private static List<int> listPares = new List<int>(20);      

        public static List<int> getListPares()
        {
            return listPares;
        }
        public static void addToPares(int num)
        {
            listPares.Add(num);
        }
    }
}
