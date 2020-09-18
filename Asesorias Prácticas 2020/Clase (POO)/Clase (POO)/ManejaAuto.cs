using System;
using System.Collections.Generic;
using System.Text;

namespace Clase__POO_
{
    class ManejaAuto
    {
        private Auto[] autos;
        int contador = 0;
        int longitud = 0;

        public ManejaAuto(int longitud)
        {
            this.longitud = longitud;
            autos = new Auto[longitud];

        }

        public bool AgregarAuto(string matricula, string modelo, string marca, string color, double precio)
        {
            if (VerificaMatricula(matricula) || contador == longitud)
            {
                return false;
            }
            autos[contador] = new Auto(matricula, modelo, marca, color, precio);
            contador++;
            return true;
        }

        public bool VerificaMatricula(string matricula)
        {
            for (int i = 0; i < contador; i++)
            {
                if (autos[i].pMatricula == matricula)
                {
                    return true;
                }
            }
            return false;
        }

        public Auto ObtenerAuto(string matricula)
        {
            for (int i = 0; i < contador; i++)
            {
                if (autos[i].pMatricula == matricula)
                {
                    return autos[i];
                }
            }
            return null;
        }

        public bool ModificarColor (string matricula, string color)
        {
            for (int i = 0; i < contador; i++)
            {
                if (autos[i].pMatricula == matricula)
                {
                    autos[i].pColor = color;
                    return true;
                }
            }
            return false;
        }

        public string toString()
        {
            string cadena = "";
            if (contador == 0)
                return "VACIO";
            for (int i = 0; i < contador; i++)
            {
                cadena += "\n\n" + autos[i].toString();
            }
            return cadena;
        }
    }
}
