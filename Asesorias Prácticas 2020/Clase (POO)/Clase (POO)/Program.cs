using System;

namespace Clase__POO_
{
    class Program
    {
        static void Main(string[] args)
        {
            ManejaAuto manejadora = new ManejaAuto(10);
            Console.WriteLine("\n IMPRESION ANTES DE AGREGAR\n" +  manejadora.toString());

            manejadora.AgregarAuto("A-124", "ACCORD", "HONDA", "AZUL", 100000);
            Console.WriteLine("\nIMPRESION DESPUES DE AGREGAR UN AUTO" + manejadora.toString());

            manejadora.AgregarAuto("A-126", "ACCORD", "HONDA", "AZUL", 100000);
            manejadora.ModificarColor("A-124","ROJO");

            Console.WriteLine("\nIMPRESION DESPUES DE AGREGAR Y MODIFICAR UN AUTO" + manejadora.toString());

            Auto auto = manejadora.ObtenerAuto("A-124");
            Console.WriteLine("\nIMPRESION AL BUSCAR AUTO");
            if (auto == null)
            {
                Console.WriteLine("\n NULO");
            }
            else
            {
                Console.WriteLine("\n" + auto.toString());

            }
            Console.ReadKey();
        }
    }
}
