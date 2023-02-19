using System;
using System.Collections.Generic;

namespace Fila_Pilha
{
    class Program
    {
        static void Main(string[] args)
        {
            // Queue / Fila; Tipo FIFO (First In, First Out)


            //Criando Queue


            Queue<string> filaNomes = new Queue<string>();

            // Adicionando Elementos

            filaNomes.Enqueue("Maria");
            filaNomes.Enqueue("José");
            filaNomes.Enqueue("João");
            filaNomes.Enqueue("Marcos");
            filaNomes.Enqueue("Pedro");

            // Removendo Elementos


            string NomeRemov = filaNomes.Dequeue();

            Console.WriteLine(NomeRemov);

            NomeRemov = filaNomes.Dequeue();

            Console.WriteLine(NomeRemov);


            Console.WriteLine("");

            // Espiando Elementos

            string NomePeek = filaNomes.Peek();

            Console.WriteLine(NomePeek);

            Console.WriteLine("");

            // Stack / Pilha; Tipo FILO (First In, Last Out);

            // Declarando Stack

            Stack<string> pilhaNomes = new Stack<string>();

            // Adicionando Elementos

            pilhaNomes.Push("Mariana");
            pilhaNomes.Push("José");
            pilhaNomes.Push("Maria");
            pilhaNomes.Push("Mario");


            // Removendo Elementos

            string nomeRemovido = pilhaNomes.Pop();

            Console.WriteLine(nomeRemovido);


            // Espiar Elementos


            string nomePeek2 = pilhaNomes.Peek();

            Console.WriteLine(nomePeek2);


            //Compartilham os mesmos métodos das Listas
            // Count, Clear, Concat, Contain, etc



            Console.ReadKey();
        }
    }
}
