using System;

namespace TratamentoExcecoes
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite um número:");

            



            try // Obrigatório. Sempre é executado.
            {   

                int num = Convert.ToInt32(Console.ReadLine());
                int resultado = 10 / num;

                Console.WriteLine(resultado);
            }
            catch (DivideByZeroException e)  // tipo da exceção a ser tratada. Obrigatório. Executado apenas em caso de exceção.
            {
                Console.WriteLine("Erro: "+ e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
            finally // Opcional. Caso exista, sempre é executado.
            {
                Console.WriteLine("Pressione qualquer tecla para sair.");
                Console.ReadKey();
            }








            
        }
    }
}
