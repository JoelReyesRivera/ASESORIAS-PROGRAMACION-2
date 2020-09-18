using System;
using System.Collections.Generic;
using System.Text;

namespace Tickets
{

    class CapaDeNegocio
    {
        public Manejadora_Sala salas;
        public Manejadora_Boletos boletos;
        public Manejadora_Proyeccion proyecciones;

        public CapaDeNegocio(Manejadora_Sala salas, Manejadora_Boletos boletos, Manejadora_Proyeccion proyecciones)
        {
            this.salas = salas;
            this.boletos = boletos;
            this.proyecciones = proyecciones;
        }

        public void agregarSala()
        {
            Console.WriteLine("CLAVE:");
            int clave = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("NUMERO DE COLUMAS:");
            byte columnas = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("NUMERO DE FILAS:");
            byte filas = Convert.ToByte(Console.ReadLine());
            salas.AgregaSala(clave,filas,columnas,true);
        }

        public void agregarBoleto()
        {
            Console.WriteLine("USUARIO:");
            string usuario =Console.ReadLine();
            Console.WriteLine("ID PROYECCIÓN:");
            int idProyeccion = Convert.ToByte(Console.ReadLine());
            boletos.agregaBoleto(usuario,idProyeccion);
        }

        public void agregarProyeccion()
        {
            Console.WriteLine("SALA:");
            int sala = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("PELICULA:");
            string pelicula = Console.ReadLine();
            proyecciones.agregaProyeccion(sala,pelicula);
        }

        public String verBoletos()
        {
            return boletos.verBoletos();
        }

        public String verProyecciones()
        {
            return proyecciones.verProyecciones();
        }

        public String verSalas()
        {
            return salas.ImprimeSala();
        }
    }
}
