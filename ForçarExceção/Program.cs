using System;

namespace ForçarExceção
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Digite um número positivo:");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num < 0)
                {
                    throw new Exception("O número " + num + " é menor que zero!");  // Este é o comando para forçar uma exceção
                }
                else
                {
                    Console.WriteLine("Você digitou o número " + num + ".");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Erro Genérico: " + e.Message);
            }
            finally
            {
                Console.ReadKey();
            }







        }
    }
}
