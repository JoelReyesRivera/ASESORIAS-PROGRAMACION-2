using System;
using System.Collections.Generic;

namespace ClasesGenericas
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, String> diccionario = new Dictionary<int, string>();
            List<String> list = new List<string>();

            diccionario.Add(1, "VALOR 1");
            diccionario.Add(2, "VALOR 2");
            diccionario.Add(3, "VALOR 3");
            diccionario.Add(4, "VALOR 4");

            list.Add("A");
            list.Add("B");
            list.Add("C");
            list.Add("D");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }
    }
}
