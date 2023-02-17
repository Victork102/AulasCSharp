using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulacaoStrings
{
    class Program
    {
        static void Main(string[] args)
        {


            // Indexação Caracter

            string nome = "Guilherme";
            char letra = nome[4];


            Console.WriteLine(letra);


            // Concatenação


            string sobrenome = "Silva";

            string nomeCompleto = nome + " " + sobrenome;

            Console.WriteLine(nomeCompleto);
            
            

            Console.ReadKey();

        }
    }
}
