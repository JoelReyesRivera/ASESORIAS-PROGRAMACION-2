using System;
using System.Collections.Generic;
using System.Text;

namespace Clase__POO_
{
    public class Utileria   
    {
        public static int LeerEntero()
        {
            int numero = int.MaxValue;
            while (numero == int.MaxValue)
            {
                try
                {
                    numero = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    numero = int.MaxValue;
                    Console.WriteLine("INGRESA UN NÚMERO ENTERO");
                }
            }
            return numero;
        }
        public static String LeerString()
        {
            String cadena = "";
            while (String.IsNullOrEmpty(cadena))
            {
                cadena = Console.ReadLine().Trim();
                if (String.IsNullOrEmpty(cadena))
                {
                    Console.WriteLine("INGRESE EL TEXTO");
                }
            }
            return cadena.ToUpper();
        }

        public static float LeerFloat()
        {
            float numero = float.MaxValue;
            while (numero == float.MaxValue)
            {
                try
                {
                    numero = float.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    numero = float.MaxValue;
                    Console.WriteLine("INGRESA UN NÚMERO DECIMAL");
                }
            }
            return numero;
        }
    }
}
