using System;
using System.Collections.Generic;
using System.Linq;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {


            //Declarar Listas

            List<string> ListaNomes = new List<string>();


            // Adicionar Elementos

            ListaNomes.Add("João"); // Adiciona um unico elemento;
            ListaNomes.Add("Marcos");
            ListaNomes.Add("Matilde");


            string[] nomes = { "Francisco", "José", "Pedro" };

            ListaNomes.AddRange(nomes); //Adiciona o conteúdo de um Array





            foreach (string i in ListaNomes)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("--------------------------------");
            Console.WriteLine("--------------------------------");

            //Remover Elementos

            ListaNomes.Remove("Marcos"); //Remove Item usando o conteúdo


            foreach (string i in ListaNomes)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("--------------------------------");

            ListaNomes.RemoveAt(0);    // Remove Item usando Indice


            foreach (string i in ListaNomes)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine("--------------------------------");
            Console.WriteLine("--------------------------------");


            List<string> ListaNomes2 = new List<string>();


            ListaNomes2.Add("Maria");
            ListaNomes2.Add("Francisco");
            ListaNomes2.Add("Mariano");
            ListaNomes2.Add("Mario");
            ListaNomes2.Add("Francheska");
            ListaNomes2.Add("Tony");
            ListaNomes2.Add("Luigi");

            foreach (string i in ListaNomes2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("--------------------------------");


            //Remover Múltiplos elementos

            ListaNomes2.RemoveRange(1, 2);  // Remove X Itens a partir do indice y {.RemoveRange(y,x)}


            foreach (string i in ListaNomes2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("--------------------------------");
            Console.WriteLine("--------------------------------");



            //Numero de Elementos

            Console.WriteLine("A ListaNomes2 possui: " + ListaNomes2.Count() + " elementos.");


            Console.WriteLine("--------------------------------");
            Console.WriteLine("--------------------------------");

            //Concatenar Listas


            List<string> ListaNomes3 = new List<string>();
            List<string> ListaNomes4 = new List<string>();


            ListaNomes3.Add("Marcos");
            ListaNomes3.Add("Jorge");
            ListaNomes3.Add("Elton");
            ListaNomes3.Add("Maria");
            ListaNomes4.Add("Janete");
            ListaNomes4.Add("Mariano");
            ListaNomes4.Add("Mario");


            foreach (string i in ListaNomes3)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("--------------------------------");

            foreach (string i in ListaNomes4)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("--------------------------------");

            List<string> ListaNomesConcat = new List<string>();
            ListaNomesConcat = ListaNomes3.Concat(ListaNomes4).ToList();  // Concatenação de Listas


            foreach (string i in ListaNomesConcat)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine("--------------------------------");
            Console.WriteLine("--------------------------------");


            //Contém valor


            bool ContemElton = ListaNomesConcat.Contains("Elton");

            Console.WriteLine(ContemElton);


            //Indice elemento


            int Index = ListaNomesConcat.IndexOf("Elton");

            Console.WriteLine(Index);

            Console.WriteLine("--------------------------------");
            Console.WriteLine("--------------------------------");




            //Operador Where


            List<string> ListaNomesWhere = ListaNomesConcat.Where(x => x.StartsWith("M")).ToList();

            foreach(string i in ListaNomesWhere)
            {
                Console.WriteLine(i);
            }

            





            Console.ReadKey();
        }
    }
}
