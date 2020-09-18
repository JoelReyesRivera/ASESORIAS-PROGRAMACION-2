using System;
using System.Collections.Generic;
using System.Text;

namespace ArreglosDeObjetos
{
    class Manejadora
    {
        private Producto[] productos;
        private int contador;
        //CONSTRUCTOR
        public Manejadora(int Cantidad)
        {
            productos = new Producto[Cantidad];
            contador = 0;
        }

        //AGREGAR PRODUCTO
        public void AgregarProducto(int clave, string descripcion, float precioUnitario, int existencia)
        {
            if (Lleno())
            {
                return;
            }
            productos[contador] = new Producto(clave, descripcion, precioUnitario, existencia);
            contador++;
        }

        //ELIMINAR PRODUCTO
        public int EliminarProducto(int clave)
        {
            int temp = BuscaProducto(clave);
            if (temp == -1)
                return -1;
            productos[temp] = null;

            for(int i = temp; i < productos.Length; i++)
            {
                if ((i + 1) == productos.Length)
                {
                    productos[i] = null;
                    contador--;
                    break;
                }
                productos[i] = productos[i + 1];
            }
            return 1;
        }

       //OBTENER LA EXISTENCIA DE UN PRODUCTO
       public int ObtenerExistencia(int clave)
        {
           for(int i = 0; i < productos.Length; i++)
            {
                if (productos[i] != null)
                {
                    if (productos[i].pClave == clave)
                    {
                        return productos[i].pExistencia;
                    }
                }
            }
            return -1;
        }

        //OBTENER PRECIO UNITARIO
        public float ObtenerPrecio(int clave)
        {
            for (int i = 0; i < productos.Length; i++)
            {
                if (productos[i] != null)
                {
                    if (productos[i].pClave == clave)
                    {
                        return productos[i].pPrecioUnitario;
                    }
                }
            }
            return -1;
        }

        //RETORNAR UNA CADENA CON LOS OBJETOS REPRESENTADOS EN STRING
        public String VerProductos()
        {
            String cadena = "PRODUCTOS";
            for (int i = 0; i < productos.Length; i++)
            {
                if (productos[i] != null)
                {
                    cadena += "\n-------------------------------\nPRODUCTO " + (i + 1);
                    cadena += "\n" + productos[i].ToString();
                }
            }
            return cadena;
        }

        //BUSCAR PRODUCTO
        public int BuscaProducto(int clave)
        {
            int temp = -1;
            for(int i = 0; i < contador; i++)
            {
                if (productos[i].pClave == clave)
                    return i;
            }
            return temp;
        }

        //ARREGLO LLENO
        public bool Lleno()
        {
            return contador == productos.Length;
        }
    }
}
