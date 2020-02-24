using System;

namespace ArreglosDeObjetos
{
    class Program
    {
        public Program()
        {
            MenuPrincipal();
        }
        static void Main(string[] args)
        {
            new Program();//OBJETO ANÓNIMO, SOLO SE UTILZA PARA EJECUTAR SU CONSTRUCTOR
        }

        public void MenuPrincipal()
        {
            Console.WriteLine("CANTIDAD DE PRODUCTOS");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            Manejadora manejadora = new Manejadora(cantidad);
            int opcion = -1;
            while (opcion!=0)
            {
                Console.WriteLine("\n----- MENU PRINCIPAL -----");
                Console.WriteLine("1.- AGREGAR PRODUCTO\n2.- VER PRODUCTOS\n3.- REALIZAR COMPRA\n4.- Eliminar Producto\n0.- SALIR");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        if (manejadora.Lleno())
                        {
                            Console.WriteLine("NO SE PUDO AGREGAR, ARREGLO LLENO");
                            break;
                        }
                        String descripcion;
                        int existencia, clave;
                        float precio;
                        Console.WriteLine("CLAVE:");
                        clave = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("DESCRIPCIÓN:");
                        descripcion =(Console.ReadLine()).ToUpper();
                        Console.WriteLine("PRECIO:");
                        precio = float.Parse(Console.ReadLine());
                        Console.WriteLine("EXISTENCIA:");
                        existencia = Convert.ToInt32(Console.ReadLine());
                        manejadora.AgregarProducto(clave, descripcion, precio, existencia);
                        Console.WriteLine("SE AGREGÓ CORRECTAMENTE");
                        break;
                    case 2:
                        Console.WriteLine(manejadora.VerProductos());
                        break;
                    case 3:
                        break;
                    case 4:
                        Console.WriteLine(manejadora.VerProductos());
                        Console.WriteLine("\nCLAVE DEL PRODUCTO:");
                        clave = Convert.ToInt32(Console.ReadLine());
                        if(manejadora.EliminarProducto(clave)==1)
                            Console.WriteLine("PRODUCTO ELIMINADO EXITOSAMENTE");
                        break;
                    case 0:
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("ELIJA UNA DE LAS OPCIONES");
                        break;
                }
            }
        }
    }
}
