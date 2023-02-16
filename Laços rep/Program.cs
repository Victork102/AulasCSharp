using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laços_rep
{
    class Program
    {
        static void Main(string[] args)
        {
           

            // for

            for(int i = 0/*Inicialização*/;i < 11/*Condição*/;i++/*Alteração da variável*/ )
            {
                Console.WriteLine(i);

            }

            Console.WriteLine("");

            // while

            int j = 0;
            while (j<=100/*condição*/)
            {
                Console.WriteLine(j);
                j += 10;
            }

            Console.WriteLine("");

            // do ... while

            int k = 0;
            do
            {
                Console.WriteLine(k);
                k += 100;
                

            } while (k<=1000/*condição*/);



            //  foreach

            string[] nomes = { "Guilherme", "João", "Maria", "Paula" };

            foreach (string nome in nomes/*função array*/) 
            {
                Console.WriteLine(nome);
            }


            Console.ReadKey();
        }
    }
}
