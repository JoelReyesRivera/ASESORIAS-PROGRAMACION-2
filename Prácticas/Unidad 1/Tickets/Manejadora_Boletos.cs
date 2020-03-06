using System;
using System.Collections.Generic;
using System.Text;

namespace Tickets
{
    class Manejadora_Boletos
    {
        Boleto[] boletos;
        int contador;
        public Manejadora_Boletos() { 
      
            this.boletos = new Boleto [10];
            contador = 0;
        }

        public bool agregaBoleto(String nombreUsuario, int idProyeccion)
        {
            if (contador == boletos.Length)
            {
                return false;
            }
            boletos[contador] = new Boleto(nombreUsuario,idProyeccion);
            return true;
        }

        public int buscarBoleto(int idTicket)
        {
            for (int i = 0; i < boletos.Length; i++)
            {
                if (boletos[i] != null)
                {
                    if (boletos[i].pIdTicket == idTicket)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        public String verBoletos()
        {
            string Temp = "";
            for (int i = 0; i < boletos.Length; i++)
            {
                if (boletos[i] != null)
                {
                    Temp += "\n" + boletos[i].ToString();
                }
            }
            return Temp;
        }
    }
}
