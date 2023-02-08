using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_Logicos_Numericos_
{
    class Program
    {
        static void Main(string[] args)
        {

            // Negação - ~

            int var1 = 0b11001100;
            int resNeg = ~var1;            
            Console.WriteLine("O resultado da negação de " + Convert.ToString(var1,2) + " é: " + Convert.ToString(resNeg,2));


            // OU (OR) - |

            int var2 = 0b11001100;
            int var3 = 0b11110000;
            int resOR = var2 | var3;

            Console.WriteLine("O resultado da Operação OR entre " + Convert.ToString(var2, 2) + " e " + Convert.ToString(var3, 2) + " é: " + Convert.ToString(resOR, 2));


            // E (AND) - &

            int resE = var2 & var3;
            Console.WriteLine("O resultado da Operação E entre " + Convert.ToString(var2, 2) + " e " + Convert.ToString(var3, 2) + " é: " + Convert.ToString(resE, 2));


            // Ou Exvlusivo (XOR) - ^

            int resXOR = var2 ^ var3;
            Console.WriteLine("O resultado da Operação XOR entre " + Convert.ToString(var2, 2) + " e " + Convert.ToString(var3, 2) + " é: " + Convert.ToString(resXOR, 2));

            Console.ReadKey();

        }
    }
}
