using System;

namespace Examen_Unidad1
{
    public class AplTerrenos
    {
        ManejaTerrenos manejadora;
        public AplTerrenos()
        {
            manejadora = new ManejaTerrenos();
            Menu();
        }
        static void Main(string[] args)
        {
            new AplTerrenos();
        }
    
        public void Menu()
        {
            int key = 0;
            try
            {
                do
                {
                    Console.WriteLine("\n----Menú----");
                    Console.WriteLine("Ingrese una opción a realizar.\n");
                    Console.WriteLine("1.-Buscar Terrenos.");
                    Console.WriteLine("2.-Buscar Usuarios con más de un terreno.");
                    Console.WriteLine("3.-Salir");
                    key = Convert.ToInt32(Console.ReadLine());

                    switch (key)
                    {
                        case 1:
                            Console.WriteLine("Ingrese la Clave Catastral del Terreno");
                            string clave = Console.ReadLine();

                            if (Rutinas.ValidarBlancos(clave))
                            {
                                Console.WriteLine("No ha ingresado ningún caracter.\n");
                                break;
                            }

                            Console.WriteLine(manejadora.BuscarTerreno(clave));
                            break;
                        case 2:
                            string[] terrenosDuplicados = manejadora.BuscaDuplicados();
                            foreach(string nom in terrenosDuplicados)
                            { Console.Write(nom+"\n"); }
                            break;
                        default:
                            break;
                    }
                }while(key!=3);
            }
            catch (FormatException)
            {
                Console.WriteLine("Tipo de dato invalido, intentelo nuevamente.\n");
                Menu();
            }
            


        }
    }
}
