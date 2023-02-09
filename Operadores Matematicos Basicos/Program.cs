using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_Matematicos_Basicos
{
    class Program
    {
        static void Main(string[] args)
        {

            // Soma - '+'
            double num1 = 15.5;
            double num2 = 10;
            double soma = num1 + num2;

            Console.WriteLine("O resultado da soma de " + num1 + " e " + num2 + " é: " + soma);

            // Subtração - '-'

            double sub = num1 - num2;
            Console.WriteLine("O resultado da subtração de " + num1 + " e " + num2 + " é: " + sub);

            // Multiplicação - '*'

            double resmult = num1 * num2;

            Console.WriteLine("O resultado da multiplicação de " + num1 + " e " + num2 + " é: " + resmult);

            // Divisão - '/'

            double resdiv = num1 / num2;

            Console.WriteLine("O resultado da divisão de " + num1 + " e " + num2 + " é: " + resdiv);

            // Resto Divisão - '%'

            double restodiv = num1 % num2;

            Console.WriteLine("O resto da divisão de " + num1 + " e " + num2 + " é: " + restodiv);

            // Soma/Subtração/Multiplicação/´Divisão ao valor de uma variável

            double num3 = 10;
            Console.WriteLine(num3);
            num3 = num3 + 10;
            Console.WriteLine(num3);
            num3 += 10;
            Console.WriteLine(num3);
            num3 -= 15;
            Console.WriteLine(num3);
            num3 *= 2;
            Console.WriteLine(num3);
            num3 /= 2;
            Console.WriteLine(num3);

            // Incremento -'++'

            int num4 = 0;
            Console.WriteLine(num4);
            num4++;
            Console.WriteLine(num4);

            // Decfremento - '--'

            num4--;
            Console.WriteLine(num4);



            Console.ReadKey(true);

        }
    }
}
