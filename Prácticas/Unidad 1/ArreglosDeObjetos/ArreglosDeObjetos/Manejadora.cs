using System;
using System.Collections.Generic;
using System.Text;

namespace ArreglosDeObjetos
{
    class Manejadora
    {
        Producto[] productos;
        int contador;
        //CONSTRUCTOR
        public Manejadora(int Cantidad)
        {
            productos = new Producto[Cantidad];
            contador = 0;
        }

        //AGREGAR PRODUCTO
        public void AgregarProducto(int clave, string descripcion, float precioUnitario, int existencia)
        {
            if (contador == productos.Length)
            {
                return;
            }
            productos[contador] = new Producto(clave, descripcion, precioUnitario, existencia);
            contador++;
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
        //RESTAR X CANTIDAD A LA EXISTENCIA DE UN PRODUCTO
        public void RestaExistencia(int clave, int cantidad)
        {
            for (int i = 0; i < productos.Length; i++)
            {
                if (productos[i] != null)
                {
                    if (productos[i].pClave == clave)
                    {
                        productos[i].pExistencia=productos[i].pExistencia-cantidad;
                    }
                }
            }
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
        //ARREGLO LLENO
        public bool Lleno()
        {
            return contador == productos.Length;
        }
    }
}
