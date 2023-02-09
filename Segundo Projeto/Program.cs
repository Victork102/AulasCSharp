using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segundo_Projeto
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Pressione 'A' para alugar.");
            Console.WriteLine("Pressione 'V' para vingança!!");
            Console.WriteLine("Pressione 'S' para sair.");

            char opcao = Convert.ToChar(Console.ReadKey(true).KeyChar);

            if (opcao == 'a' || opcao == 'A')
            {
                Console.WriteLine("Pressione 1 Para alugar Top Gun");
                Console.WriteLine("Pressione 2 para alugar A Bela e a Fera");
                Console.WriteLine("Pressione 3 para alugar Batman");

                char filme = Convert.ToChar(Console.ReadKey(true).KeyChar);

                switch (filme)
                {
                    case '1':
                        Console.WriteLine(" I feel the need, the need for speed.");
                        break;
                    case '2':
                        Console.WriteLine("You have been deceived by your own cold hearth. A curse upon your house and all within it!");
                        Console.WriteLine("Until you can find someone that can love you as you are...");
                        Console.WriteLine("you shall remain forever... A BEAST!!");
                        break;
                    case '3':
                        Console.WriteLine("I'M BATMAN!!");
                        break;
                    default:
                        Console.WriteLine("Opção Inválida!");
                        break;

                }
            }
            else if (opcao == 'v' || opcao == 'V')
            {
                Console.WriteLine("My name is Enrico Montoya, you killed my father. Prepare to die.");
            }
            else if (opcao == 's' || opcao == 'S')
            {
                Console.WriteLine("Até mais!");
            }
            else
                Console.WriteLine("Opção Inválida!");


            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadKey(true);

        }
    }
}
