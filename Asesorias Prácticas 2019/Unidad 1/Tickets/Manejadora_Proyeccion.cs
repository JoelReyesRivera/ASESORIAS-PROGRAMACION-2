using System;
using System.Collections.Generic;
using System.Text;

namespace Tickets
{
    class Manejadora_Proyeccion
    {
        Proyeccion[] proyecciones;
        int contador;

        public Manejadora_Proyeccion()
        {
            proyecciones = new Proyeccion[10];
            contador = 0;
        }

        public bool agregaProyeccion(int idSala, string pelicula)
        {
            if (contador == proyecciones.Length)
            {
                return false;
            }
            proyecciones[contador] = new Proyeccion( pelicula, idSala, contador);
            return true;
        }

        public int buscarProyeccion(int idSala, string pelicula)
        {
            for (int i = 0; i < proyecciones.Length; i++)
            {
                if (proyecciones[i] != null)
                {
                    if (proyecciones[i].pIdSala == idSala || proyecciones[i].pNomPeli == pelicula)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        public String verProyecciones()
        {
            string Temp = "";
            for (int i = 0; i < proyecciones.Length; i++)
            {
                if (proyecciones[i] != null)
                {
                    Temp += "\n" + proyecciones[i].ToString();
                }
            }
            return Temp;
        }
    }
}

