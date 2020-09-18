using System;
using System.Collections.Generic;
using System.Text;

namespace Examen_Unidad1
{
    public class Terreno
    {
        private string ClaveCatastral;
        private string NombreDueno;
        private double Largo;
        private double Ancho;

        public Terreno(string clave, string nombre, double ancho, double largo)
        {
            this.ClaveCatastral = clave;
            this.NombreDueno = nombre;
            this.Largo = largo;
            this.Ancho = ancho;
        }

        public string pClaveCatastral
        {
            get { return this.ClaveCatastral; }
        }

        public string pNombre
        {
            get
            { return this.NombreDueno; }

            set
            { this.NombreDueno = value; }
        }

        public double pLargo
        {
            get
            { return this.Largo; }

            set
            { this.Largo= value; }
        }

        public double pAncho{
            get
            { return this.Ancho; }

            set
            { this.Ancho = value; }
        }

        override
        public string ToString()
        {
            string temp = String.Format("Clave Catastral: {0}\nNombre del propietario: {1}" +
                "\nLargo: {2}m\nAncho: {3}m\n",pClaveCatastral,pNombre,pLargo,pAncho);
            return temp;
        }
    }
}
