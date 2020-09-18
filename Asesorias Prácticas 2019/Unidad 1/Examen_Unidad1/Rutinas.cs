using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Unidad1
{
    public class Rutinas
    {
       public static bool ValidaIntNegativos(int n)
        {
            return n < 0;
        }

        public static bool ValidarBlancos(string res)
        {
            return res.Trim().Equals("");
        }

        public static bool ValidarDoubleNegativos(double d)
        {
            return d < 0;
        }

        public static bool ValidarNull(Object n)
        {
            return n == null;
        }

    }
}
