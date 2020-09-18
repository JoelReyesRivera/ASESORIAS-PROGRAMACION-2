using System;
using System.Collections.Generic;
using System.Text;

namespace Articulos_Visual
{
    public class Producto
    {
        //private int clave;
        private String descripcion;
        private float precioUnitario;
        private int existencia;
        private bool activo;

        //CONSTRUCTOR, (NO SE DEBE IMPLEMENTAR UN CONSTRUCTOR VACÍO)
        public Producto(string descripcion, float precioUnitario, int existencia, bool activo)
        {
            //this.clave = clave;
            this.descripcion = descripcion;
            this.precioUnitario = precioUnitario;
            this.existencia = existencia;
            this.activo = activo;
        }
        //PROPIEDADES
        /*public int pClave
        {
            get
            {
                return clave;
            }
        }*/
        public float pPrecioUnitario
        {
            get
            {
                return precioUnitario;
            }
            set
            {
                precioUnitario = value;
            }
        }
        public int pExistencia
        {
            get
            {
                return existencia;
            }
            set
            {
                existencia = value;
            }
        }
        public String pDescripcion
        {
            get
            {
                return descripcion;
            }
            set
            {
                descripcion = value;
            }
        }

        public bool pActivo
        {
            get
            {
                return activo;
            }
            set
            {
                activo = value;
            }
        }

        //REPRESENTACION EN STRING DEL OBJETO
        override
        public String ToString()
        {
            return "\nDESCRIPCIÓN: " + descripcion + "\nPRECIO UNITARIO: $" + precioUnitario + "\nEXISTENCIA: " + existencia; 
        }
    }

}
