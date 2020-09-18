using System;
using System.Collections.Generic;
using System.Text;

namespace Articulos_Visual
{
    public class Manejadora
    {
        private Dictionary<int, Producto> productos;
        //CONSTRUCTOR
        public Manejadora()
        {
            this.productos = new Dictionary<int, Producto>();
        }

        //AGREGAR PRODUCTO
        public bool AgregarProducto(int clave, string descripcion, float precioUnitario, int existencia, bool activo)
        {
            return false;
        }

        //ELIMINAR PRODUCTO
        public int EliminarProducto(int clave)
        {
            return 0;
        }

       //OBTENER LA EXISTENCIA DE UN PRODUCTO
       public int ObtenerExistencia(int clave)
        {
           for(int i = 0; i < productos.Count; i++)
            {
                
            }
            return -1;
        }

        //OBTENER PRECIO UNITARIO
        public float ObtenerPrecio(int clave)
        {
            return 1;
        }

        //BUSCAR PRODUCTO
        public KeyValuePair<int, Producto> BuscaProducto(int clave)
        {
            var temp=new KeyValuePair<int, Producto>();
            for(int i = 0; i < productos.Count; i++)
            {
                
            }
            return temp;
        }

        public bool RestaExistencia(int clave,int numAr)
        {
            bool flag = true;
            var temp = BuscaProducto(clave);
            if (temp.Value.pExistencia - numAr < 0)
                flag = true;

            return flag;
        }

        public bool ValidaProducto(int clave)
        {
            return productos.ContainsKey(clave);
        }
    }
}
