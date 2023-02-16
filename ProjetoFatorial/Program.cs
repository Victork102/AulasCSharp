using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFatorial
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {

                Console.WriteLine("Digite qualquer número para calcular o Fatorial.");
                Console.WriteLine("Caso contrário, digite S para sair");

                string opcao = Console.ReadLine();

                if (opcao == "s" | opcao == "S")
                {
                    break;
                }
                else
                {
                    UInt64 valor = Convert.ToUInt64(opcao);
                    if (valor == 0)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("O fatorial de 0 é 1.");

                    }
                    else if (valor < 0)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Não existe fatorial de números negativos");
                    }
                    else
                    {
                        UInt64 resultado = 1;

                        Console.Write(valor + "! = ");
                        for (UInt64 i = valor; i > 0; i--)
                        {
                            resultado *= i;
                            if (i == 1)
                            {
                                Console.Write(i + " = " + resultado);

                            }
                            else
                            {

                                Console.Write(i + "x");

                            }

                        }


                    }
                    Console.WriteLine("");
                    Console.WriteLine("Pressione Qualquer tecla para continuar");
                    Console.ReadKey(true);
                    Console.Clear();

                }





               
            }
            Console.ReadKey(true);
        } 
        
    }
}
