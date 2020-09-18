using System;

namespace Fundamentos_Programación
{
    class Program
    {
        static void Main(string[] args)
        {
            /*CREAR UN METODO QUE RECIBA UN STRING COMO PARAMETRO Y DEVULEVA 
             * TRUE SI ES PALINDROMA, DE LO CONTRARIO QUE RETORNE FALSE
             */
            Console.WriteLine("----- FUNDAMENTOS DE PROGRAMACIÓN ------- ");
            Console.WriteLine("OBTENER PALÍNDROMA");
            Console.WriteLine("ESCRIBE UNA CADENA DE TEXTO");
            string cadena = Console.ReadLine().Replace(" ", "");
            Console.WriteLine(Palindroma(cadena));
            Console.ReadKey();

        }
        public static bool Palindroma(string cadena)
        {
            string cadenaVolteada = "";
            //VOLTEAR LA CADENA
            for (int i = cadena.Length - 1; i >= 0; i--)
            {
                cadenaVolteada += (cadena[i]);
            }
            if (cadenaVolteada == cadena)
            {
                return true;
            }
            return false;
        }
    }
}
