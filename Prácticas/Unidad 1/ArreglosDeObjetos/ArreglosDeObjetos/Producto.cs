using System;
using System.Collections.Generic;
using System.Text;

namespace ArreglosDeObjetos
{
    class Producto
    {
        int clave;
        String descripcion;
        float precioUnitario;
        int existencia;

        //CONSTRUCTOR, (NO SE DEBE IMPLEMENTAR UN CONSTRUCTOR VACÍO)
        public Producto(int clave, string descripcion, float precioUnitario, int existencia)
        {
            this.clave = clave;
            this.descripcion = descripcion;
            this.precioUnitario = precioUnitario;
            this.existencia = existencia;
        }
        //PROPIEDADES
        public int pClave
        {
            get
            {
                return clave;
            }
            set
            {
                clave = value;
            }
        }
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
        //REPRESENTACION EN STRING DEL OBJETO
        public String ToString()
        {
            return "CLAVE: " + clave + "\nDESCRIPCIÓN: " + descripcion + "\nPRECIO UNITARIO: $" + precioUnitario + "\nEXISTENCIA: " + existencia; 
        }
    }

}
