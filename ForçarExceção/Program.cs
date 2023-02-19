using System;

namespace ForçarExceção
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

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
