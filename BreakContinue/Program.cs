using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            int loop = 0;
            while (true)
            {
                Console.WriteLine("Loop Count: " + loop);
                Console.WriteLine("Pressione C para continuar");
                Console.WriteLine("Pressione B para break");
                loop++;

                string tecla = Console.ReadKey(true).KeyChar.ToString();


                if (tecla == "c")
                {
                    Console.Clear(); // Limpa o Console
                    continue; // Continua o loop, seguindo para a próxima iteração
                    
                }
                else if (tecla == "b")
                {
                    break; // encerra o loop
                }
                else
                {
                    Console.WriteLine("Tecla desconhecida");
                }





                Console.WriteLine("Pressione qualquer tecla para continuar");
                Console.ReadKey(true);
                Console.Clear();
            }
            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadKey();
        }

    }
}
