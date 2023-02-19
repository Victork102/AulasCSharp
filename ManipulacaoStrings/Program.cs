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

            string nomeCompleto2 = String.Concat(nome," ", sobrenome);
            Console.WriteLine(nomeCompleto2);



            //Substituição


            string endereço = "Rua das Rosas Verdes";

            endereço = endereço.Replace("Verdes", "Vermelhas");

            Console.WriteLine(endereço);

            //Remoção

            endereço = endereço.Replace("Vermelhas", "");

            Console.WriteLine(endereço);

            endereço = "Rua das Rosas Verdes";

            endereço = endereço.Remove(0,4);

            Console.WriteLine(endereço);


            //Capitalização


            nome = nome.ToUpper();

            Console.WriteLine(nome);

            nome = nome.ToLower();

            Console.WriteLine(nome);



            //Contém


            nome = "Guilherme";
            bool contem = nomeCompleto.Contains("Guilherme");

            Console.WriteLine(contem);

            contem = nomeCompleto.Contains("Marcos");

            Console.WriteLine(contem);


            //Localizar Index

            endereço = "Rua das Rosas";

            int indice = endereço.IndexOf("das");
            int indice2 = endereço.LastIndexOf("das");


            Console.WriteLine(indice);
            Console.WriteLine(indice2);


            // Dividir Strings



            string[] divisores = { "das " };

            string[] resDivisao = endereço.Split(divisores, StringSplitOptions.None);

            foreach(string texto in resDivisao)
            {
                Console.WriteLine(texto);
            }

            //Número de caracteres

            int numeroCaracteres = endereço.Length;


            Console.WriteLine(numeroCaracteres);

            //Substring

            string nomeRua = endereço.Substring(8, 5);

            Console.WriteLine(nomeRua);



            //Formatação Composta


            string endereço2 = "Rua das {0} {1}";

            Console.WriteLine(endereço2, "Bananas", "Maduras");

            string rua = String.Format(endereço2, "Grandes", "Aves");

            Console.WriteLine(rua);







            Console.ReadKey();

        }
    }
}
