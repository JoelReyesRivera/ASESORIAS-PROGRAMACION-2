using System;
using System.Collections.Generic;
using System.Text;

namespace Tickets
{
    public class Manejadora_Sala
    {
        private Sala[] salas;
        int cont = 0;

        public Manejadora_Sala()
        {
            salas = new Sala[10];
            AgregarBase();
        }

        public void AgregarBase()
        {
            AgregaSala(1,5,10,false);
            AgregaSala(2, 10, 7, false);
            AgregaSala(3,12,5,true);
            AgregaSala(10, 7, 7, false);

        }

        public void AgregaSala(int claveSala, byte noFilas, byte noColumnas, bool tipo)
        {
            if (Lleno())
            {
                return;
            }
            salas[cont] = new Sala(claveSala,noFilas,noColumnas,tipo);
            cont++;
        }

        public string ImprimeSala()
        {
            string temp = "";

            if (cont == 0)
                return null;

            foreach(Sala value in salas)
            {
                temp += value;
            }
            return temp;
        }

        public Sala BuscarSala(char claveSala)
        {
            Sala temp = null;
            for (int i = 0; i < cont; i++)
            {
                if (salas[i].pIdSala == claveSala)
                    return salas[i];
            }
            return temp;
        }

        private bool Lleno()
        {
            return cont == salas.Length;
        }
    }
}
