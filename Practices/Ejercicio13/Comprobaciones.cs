using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    public static class Comprobaciones
    {
        public static bool checkNum(int num)
        {
            if ((num % 2) == 0)
                return true;
            else
                return false;
        }

        public static bool esCero(int num)
        {
            if (num == 0)
                return true;
            else
                return false;
        }
    }
}
