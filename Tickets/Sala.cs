using System;
using System.Collections.Generic;
using System.Text;

namespace Tickets
{
    public class Sala
    {
        private int idSala;
        private byte noFilas;
        private byte noColumnas;
        private bool tipoSala;
        private Asiento[,] asientos; 

        public Sala(int claveSala, byte noFilas, byte noColumnas, bool tipo)
        {
            this.idSala = claveSala;
            this.noFilas = noFilas;
            this.noColumnas = noColumnas;
            this.tipoSala = tipo;
            this.asientos = new Asiento[noFilas,noColumnas];
        }

        public int pIdSala
        {
            get
            {
                return idSala;
            }
        }

        public byte pNoFilas
        {
            get
            {
                return noFilas;
            }
            set
            {
                noFilas = value;
            }
        }

        public byte pColumnas
        {
            get
            {
                return noColumnas;
            }
            set
            {
                noColumnas = value;
            }
        }

        public bool pTipoSala
        {
            get
            {
                return tipoSala;
            }
            set
            {
                tipoSala = value;
            }
        }

        public Asiento[,] pAsientos
        {
            get
            { return asientos;}
            set
            {
                asientos = value;
            }
        }

        public int Capacidad_Asientos()
        {
            return (noFilas * noColumnas);
        }

        override
        public string ToString()
        {
            string tipoSala = pTipoSala ? "VIP" : "NORMAL";
            string temp = String.Format("NÚMERO DE SALA: {0}\nNÚMERO DE ASIENTOS: {1}\nTIPO DE SALA: {2}", pIdSala, Capacidad_Asientos(),tipoSala);
            return temp;
        }
    }
}
