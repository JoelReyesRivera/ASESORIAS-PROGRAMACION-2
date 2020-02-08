using System;


namespace Práctica_1
{
    class Arreglos_Ciclos
    {
        public static int[] vector1;

        static void Main(string[] args)
        {
            int size = 0;
            while (size <=0)
            {
                Console.WriteLine("INGRESE LA LONGITUD DEL ARREGLO");
                size = Convert.ToInt32(Console.ReadLine());

            }
            vector1 = new int[size];
            LlenaArreglo();
            ImprimirArreglo();
            IncrementarValores();
            ImprimirArreglo();
            Console.ReadKey();
        }

        public static void LlenaArreglo()
        {
            for (int i = 0; i< vector1.Length; i++)
            {
                Console.WriteLine("INGRESE EL NÚMERO{0}",(i+1));
                vector1[i] = Convert.ToInt32(Console.ReadLine());
            } 
        }
        //METODO PARA IMPRIMIR EL ARREGLO
        public static void ImprimirArreglo()
        {
            Console.WriteLine("VECTOR 1");
            for (int i = 0; i < vector1.Length; i++)
            {
                Console.WriteLine(" VALOR {0} ES : {1} ", (i+1),vector1[i]);
            }
        }
        //METODO PARA INCREMENTAR EN 5 CADA VALOR DEL ARREGLO
        public static void IncrementarValores()
        {
            for (int i = 0; i< vector1.Length; i++)
            {
                vector1[i] += 5;
            }
        }

    }
}
