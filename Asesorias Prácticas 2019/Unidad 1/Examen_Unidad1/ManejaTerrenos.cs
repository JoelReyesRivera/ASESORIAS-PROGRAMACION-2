using System;
using System.Collections.Generic;
using System.Text;

namespace Examen_Unidad1
{
    public class ManejaTerrenos
    {
        Terreno[] terrenos;
        int pos = 0;
        public ManejaTerrenos()
        {
            terrenos = new Terreno[10];
            AgregaTerreno("112-232-434","JORGE OSUNA",50,40);
            AgregaTerreno("123-542-796", "JOEL REYES", 32.4, 19);
            AgregaTerreno("653-194-350", "CRISTINA BELTRAN", 12.6, 20.7);
            AgregaTerreno("943-124-657", "CARLOS QUINTANA", 60, 102.5);
            AgregaTerreno("873-345-125", "OLIVER RODRIGUEZ", 30, 25.9);
            AgregaTerreno("893-365-655", "OLIVER RODRIGUEZ", 15, 30.6);
            AgregaTerreno("767-234-879", "CRISTINA BELTRAN", 26.6, 35.6);
            AgregaTerreno("653-194-350", "CRISTINA BELTRAN", 40.2, 50);
        }

        public void AgregaTerreno(string clave, string nombre, double ancho, double largo){
            terrenos[pos] = new Terreno(clave, nombre,ancho,largo);
            pos++;
        }

        public string BuscarTerreno(string clave)
        {
            string temp = "NO SE ENCONTRÓ NINGÚN TERRENO";
            foreach(Terreno value in terrenos)
            {
                if(value!=null)
                    if (value.pClaveCatastral.Equals(clave))
                        temp = value.ToString();
            }
            return temp;
        }

        public string[] BuscaDuplicados()
        {
            string[] temp= new string[terrenos.Length];
            int posTemp = 0;
            Console.WriteLine(pos);
            for(int i=0; i < pos; i++)
            {
                int contador = 0;
                for(int j=0; j < pos; j++)
                {
                    if (terrenos[i].pNombre.Equals(terrenos[j].pNombre))
                        contador++;
                }
                if (contador >= 2 && !BuscaNombres(temp, terrenos[i].pNombre,posTemp))
                {
                    temp[posTemp] = terrenos[i].pNombre;
                    posTemp++;
                }
            }
            return temp;
        }

        private bool BuscaNombres(string[] nombres, string nombre, int posTemp)
        {
            bool flag = false;

            for (int i = 0; i < posTemp; i++)
            {
                if (nombres[i].Equals(nombre))
                    return true;
            }
            return flag;
        }

    }
}
