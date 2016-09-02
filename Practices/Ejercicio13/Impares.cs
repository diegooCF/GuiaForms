using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Impares
    {
        private static List<int> listImpares = new List<int>(20);

        public static List<int> getListImpares()
        {
            return listImpares;
        }
        public static void addToImpares(int num)
        {
            listImpares.Add(num);
        }
    }
}
