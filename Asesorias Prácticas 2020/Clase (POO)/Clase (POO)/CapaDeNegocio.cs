using System;
using System.Collections.Generic;
using System.Text;

namespace Clase__POO_
{
    class CapaDeNegocio
    {
        private ManejaAuto manejadora;

        public CapaDeNegocio(int longitud)
        {
            manejadora = new ManejaAuto(longitud);
        }

        public void AgregarAuto()
        {
            string matricula;
            string modelo;
            string marca;
            string color;
            float precio;

            Console.WriteLine("INGRESA LOS DATOS DEL AUTO\nMATRICULA :");
            matricula = Utileria.LeerString();
            if (manejadora.VerificaMatricula(matricula))
            {
                Console.WriteLine("MATRICULA EXISTENTE");
                return;
            }
            Console.WriteLine("MODELO : ");
            modelo = Utileria.LeerString();
            Console.WriteLine("MARCA : ");
            marca = Utileria.LeerString();
            Console.WriteLine("COLOR : ");
            color = Utileria.LeerString();
            Console.WriteLine("PRECIO : ");
            precio = Utileria.LeerFloat();

            manejadora.AgregarAuto(matricula, modelo, marca, color, precio);
        }

        public String VerAutos()
        {
            return manejadora.toString();
        }

        public void Modificar()
        {
            string matricula;
            string color;

            Console.WriteLine("INGRESA LOS DATOS DEL AUTO\nMATRICULA :");
            matricula = Utileria.LeerString();
            if (!manejadora.VerificaMatricula(matricula))
            {
                Console.WriteLine("MATRICULA NO EXISTENTE");
                return;
            }
            Console.WriteLine("COLOR:");
            color = Utileria.LeerString();
            manejadora.ModificarColor(matricula, color);
        }   
    }
}
