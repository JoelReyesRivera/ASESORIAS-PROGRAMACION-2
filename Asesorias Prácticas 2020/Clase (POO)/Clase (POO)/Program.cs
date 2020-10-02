using System;

namespace Clase__POO_
{
    class Program
    {
        static void Main(string[] args)
        {
            CapaDeNegocio capaDeNegocio = new CapaDeNegocio(20);
            int opcion = -1;

            while (opcion != 0)
            {
                Console.WriteLine("MENU PRINCIPAL");
                Console.WriteLine("1- AGREGAR\n2- VER AUTOS\n3- MODIFICAR COLOR\n0- SALIR");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    default:
                        Console.WriteLine("NO SE SELECCIONO NINGUNA OPCION");
                        break;
                    case 1:
                        capaDeNegocio.AgregarAuto();
                        break;
                    case 2:
                        Console.WriteLine(capaDeNegocio.VerAutos());
                        break;
                    case 3:
                        capaDeNegocio.Modificar();
                        break;
                    case 0:
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
