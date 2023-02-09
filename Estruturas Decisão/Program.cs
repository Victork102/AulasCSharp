using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estruturas_Decisão
{
    class Program
    {
        static void Main(string[] args)

        {

            // IF - ELSE

            Console.WriteLine("Qual a sua idade?");

            UInt32 idade = Convert.ToUInt32(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine("Você é maior de idade!");
            }
            else // Opcional
            {
                Console.WriteLine("Você é menor de idade!");
            }


            // IF - ELSE IF


            Console.WriteLine("Qual a sua renda média?");
            UInt32 salario = Convert.ToUInt32(Console.ReadLine());


            if(salario < 1000)
            {
                Console.WriteLine("Você ganha menos que um salário minimo.");
            }else if(salario < 2000) // quantos forem necessários
            {
                Console.WriteLine("Você ganha menos que dois salários mínimos.");
            }else if(salario < 5000)
            {
                Console.WriteLine("Você gamnha menos que cinco salários mínimos");
            }else  //Opcional
            {
                Console.WriteLine("Você ganha mais de cinco salários mínimos!");
            }

            // Switch


            Console.WriteLine("Digite uma letra:");
            char letra = Console.ReadKey(true).KeyChar;

            switch(letra)
            {
                case 'm':
                        Console.WriteLine("Você digitou M de Maria.");
                    break;
                case'f':
                    Console.WriteLine("Você digitou F de Fernanda");
                    break;
                default:
                    Console.WriteLine("Você digitou " + letra);
                    break;

            }

            Console.ReadKey();
        }
    }
}
