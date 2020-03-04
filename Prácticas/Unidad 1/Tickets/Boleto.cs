using System;

namespace Tickets
{
    public class Boleto
    {
        private int idTicket;
        private string nombreUsuario;
        private int idProyeccion;
        private char tipoTicket;
        private int idAsiento;

        public Boleto(string nomUsuario, int idProyeccion, char tipoTicket)
        {
            this.idTicket++;
            this.nombreUsuario = nomUsuario;
            this.idProyeccion = idProyeccion;
            this.tipoTicket = tipoTicket;
        }

        public int pIdTicket 
        { get
            {
                return idTicket;
            }
        }

        public string pNomUsuario
        {
            get
            {
                return nombreUsuario;
            }
            set
            {
                nombreUsuario = value;
            }
        }
        
        public int pIdProyeccion
        {
            get
            {
                return idProyeccion;
            }
            set
            {
                idProyeccion = value;
            }
        }

        public int pIdAsientó
        {
            get
            {
                return idAsiento;
            }
            set
            {
                idAsiento = value;
            }
        }

        public char pTipoTicket
        {
            get { return tipoTicket; }
            set { tipoTicket = value; }
        }

        override
        public string ToString()
        {
           string temp=String.Format("Número de boleto: {0}\nNombre del Cliente: {1}",pIdTicket,pNomUsuario);
            return temp;
        }
    }
}
