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

            // Operador Maior e Menor > e <

            int var4 = 10;
            int var5 = 20;
            Console.WriteLine("O valor " + var4 + " é maior que " + var5 + "? " + (var4>var5));
            Console.WriteLine("O valor " + var4 + " é menor que " + var5 + "? " + (var4 < var5));

            // Operador Maior ou igual e Menor ou Igual >= e <=

            Console.WriteLine("O valor " + var4 + " é maior ou igual a " + var5 + "? " + (var4 >= var5));
            Console.WriteLine("O valor " + var4 + " é menor ou igual a " + var5 + "? " + (var4 <= var5));
            Console.WriteLine("O valor " + var4 + " é maior ou igual a " + var4 + "? " + (var4 >= var4));
            Console.WriteLine("O valor " + var5 + " é menor ou igual a " + var5 + "? " + (var5 <= var5));

            // Operador Igual a ==

            bool resIgual = var4 == var4;
            Console.WriteLine("O valor " + var4 + " é igual a " + var4 + "? " + resIgual);
            resIgual = var4 == var5;
            Console.WriteLine("O valor " + var4 + " é igual a " + var5 + "? " + resIgual);

            Console.ReadKey();

        }
    }
}
