using System;
using System.Collections.Generic;
using System.Text;

namespace Tickets
{
    class MainClass
    {
        Manejadora_Boletos boletos;
        Manejadora_Proyeccion proyecciones;
        Manejadora_Sala salas;
        CapaDeNegocio capaDeNegocio;
        public MainClass()
        {
            boletos = new Manejadora_Boletos();
            proyecciones = new Manejadora_Proyeccion();
            salas = new Manejadora_Sala();
            capaDeNegocio = new CapaDeNegocio(salas, boletos, proyecciones);
            MenuPrincipal(capaDeNegocio);
        }
        static void Main(string[] args)
        {
            new MainClass();
        }

        public void MenuPrincipal(CapaDeNegocio capaDeNegocio)
        {
            int opcion = -1;
            do
            {
                Console.WriteLine("----- MENU PRINCIPAL ------");
                Console.WriteLine("1- MENU BOLETOS\n2.- MENU SALAS\n3.- MENU PROYECCIONES\n0.- SALIR");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        MenuBoletos(capaDeNegocio);
                        break;
                    case 2:
                        MenuSalas(capaDeNegocio);
                        break;
                    case 3:
                        MenuProyecciones(capaDeNegocio);
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("INGRESE UNA DE LAS OPCIONES");
                        break;
                }
            } while (opcion != 0);
        } 

        public void MenuBoletos(CapaDeNegocio capaDeNegocio)
        {
            int opcion = -1;
            do
            {
                Console.WriteLine("----- MENU BOLETO ------");
                Console.WriteLine("1- AGREGAR BOLETO\n2.- VER BOLETOS\n0.- SALIR");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        capaDeNegocio.agregarBoleto();
                        break;
                    case 2:
                        Console.WriteLine(capaDeNegocio.verBoletos());
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("INGRESE UNA DE LAS OPCIONES");
                        break;
                }
            } while (opcion != 0);
        }

        public void MenuSalas(CapaDeNegocio capaDeNegocio)
        {
            int opcion = -1;
            do
            {
                Console.WriteLine("----- MENU SALA ------");
                Console.WriteLine("1- AGREGAR SALA\n2.- VER SALAS\n0.- SALIR");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        capaDeNegocio.agregarSala();
                        break;
                    case 2:
                        Console.WriteLine(capaDeNegocio.verSalas()); 
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("INGRESE UNA DE LAS OPCIONES");
                        break;
                }
            } while (opcion != 0);
        }

        public void MenuProyecciones(CapaDeNegocio capaDeNegocio)
        {
        int opcion = -1;
        do
        {
            Console.WriteLine("----- MENU PROYECCION ------");
            Console.WriteLine("1- AGREGAR PROYECCION\n2.- VER PROYECCIONES\n0.- SALIR");
            opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                        capaDeNegocio.agregarProyeccion();
                    break;
                case 2:
                        Console.WriteLine(capaDeNegocio.verProyecciones());
                    break;
               case 0:
                    break;
                    default:
                    Console.WriteLine("INGRESE UNA DE LAS OPCIONES");
                    break;
            }
        } while (opcion != 0);
    }

    }
}
