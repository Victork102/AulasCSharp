using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLogin
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                int attempt = 1;

                while (attempt <= 3)
                {


                    {

                        Console.WriteLine("Digite o Usuário:");

                        string user = Console.ReadLine();

                        Console.WriteLine("Digite a senha:");

                        string senha = "";




                        while (true)
                        {

                            ConsoleKeyInfo passInput = Console.ReadKey(true);

                            if (passInput.Key == ConsoleKey.Enter)
                            {

                                break;
                            }
                            else
                            {

                                senha += passInput.KeyChar;

                            }


                        }

                        if (user == "Valéria" && senha == "1234")
                        {

                            Console.WriteLine("Usiário Logado com sucesso!");
                            break;
                        }
                        else
                        {

                            attempt++;
                            Console.WriteLine("Usuário/Senha incorreto!");


                        }





                    }



                }

                Console.WriteLine("Número máximo de tentativas excedido!");
                break;

            }
            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadKey(true);
        }
    } 
}
