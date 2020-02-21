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
                Console.WriteLine("1.- AGREGAR PRODUCTO\n2.- VER PRODUCTOS\n3.- REALIZAR COMPRA\n0.- SALIR");
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
                        Console.WriteLine(manejadora.VerProductos());
                        Console.WriteLine("\nCLAVE DEL PRODUCTO:");
                        clave = Convert.ToInt32(Console.ReadLine());
                        existencia = manejadora.ObtenerExistencia(clave);
                        if (existencia == -1)
                        {
                            Console.WriteLine("CLAVE INEXISTENTE");
                            break;
                        }
                        Console.WriteLine("CANTIDAD:");     
                        cantidad = Convert.ToInt32(Console.ReadLine());
                        if (existencia-cantidad<0)
                        {
                            Console.WriteLine("EXISTENCIA INSUFICIENTE");
                            break;
                        }
                        manejadora.RestaExistencia(clave,cantidad);
                        float precioUnitario = manejadora.ObtenerPrecio(clave);
                        float importe =precioUnitario * cantidad;
                        Console.WriteLine("\nDETALLES DE COMPRA\nCLAVE: {0}\nPRECIO UNITARIO: ${1}\nCANTIDAD: {2}\nIMPORTE: ${3}", clave,precioUnitario,cantidad,importe);
                        Console.WriteLine("\nCOMPRA EXITOSA");
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
