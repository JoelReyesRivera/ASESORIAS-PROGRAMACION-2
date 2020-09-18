using System;
using System.Collections.Generic;
using System.Text;

namespace Tickets
{
    public class Proyeccion
    {
        private string nombrePelicula;
        private int idSala;
        private int idProyeccion;
        //DateTime fecha;

        public Proyeccion(string nomPeli, int idSala, int idProyeccion)
        {
            this.idSala = idSala;
            this.nombrePelicula = nomPeli;
            this.idProyeccion = idProyeccion;
        }

        public string pNomPeli
        {
            get { return nombrePelicula; }
            set { nombrePelicula = value; }
        }

        public int pIdProyeccion
        {
            get { return idProyeccion; }
        }

        public int pIdSala
        {
            get { return idSala; }
            set { idSala = value; }
        }

    }
}
