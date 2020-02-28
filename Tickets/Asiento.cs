using System;
using System.Collections.Generic;
using System.Text;

namespace Tickets
{
    public class Asiento
    {
        private char noColumna;
        private byte noFila;
        private char idSala;
        private int idAsiento=100;

        public Asiento(byte fila,char columna, char idSala)
        {
            idAsiento++;
            this.idSala = idSala;
            this.noFila = fila;
            this.noColumna = columna;
        }

        public int pIdAsiento
        {
            get{ return idAsiento;}
        }

        public char pNoColumna
        {
            get
            {
                return noColumna;
            }
            set
            {
                noColumna = value;
            }
        }

        public byte pNoFila
        {
            get{
                return noFila;
            }
            set
            {
                noFila = value;
            }
        }

        public char pIdSala
        {
            get
            {
                return idSala;
            }
            set
            {
                idSala = value;
            }
        }


    }
}
