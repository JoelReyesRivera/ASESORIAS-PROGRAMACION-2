using System;
using System.Collections.Generic;
using System.Text;

namespace Tickets
{
    public class Proyeccion
    {
        private string nombrePelicula;
        private int idSala;
        //DateTime fecha;

        public Proyeccion(string nomPeli, int idSala)
        {
            this.idSala = idSala;
            this.nombrePelicula = nomPeli;
        }

        public string pNomPeli
        {
            get { return nombrePelicula; }
            set { nombrePelicula = value; }
        }

        public int pIdSala
        {
            get { return idSala; }
            set { idSala = value; }
        }

    }
}
