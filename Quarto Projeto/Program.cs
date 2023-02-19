using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quarto_Projeto
{
    class Program
    {


        struct dadosCadastrais_Struct
        {
            public string nomeCompleto;
            public string nomeRua;
            public UInt16 numCasa;
            public UInt16 numDoc;
            
        }


        static void Main(string[] args)
        {

            List<dadosCadastrais_Struct> ListaCadastros = new List<dadosCadastrais_Struct>();
            string opcao;


            do
            {
                // Cabeçalho e seleção de opção


                Console.WriteLine("ListaCadastros de Usuários");
                Console.WriteLine("Pressione C para cadastrar um usuário, pressione V para visualizar os usuários cadastrados ou pressione S para sair.");
                opcao = Console.ReadKey(true).KeyChar.ToString().ToLower();


                if (opcao == "c")
                {
                    // Cadastrar Usuário


                    // Entrada de dados

                    dadosCadastrais_Struct dadosCadastrais;

                    Console.WriteLine("Digite o Nome Completo:");

                    dadosCadastrais.nomeCompleto = Console.ReadLine();

                    Console.WriteLine("Digite o nome da rua:");

                    dadosCadastrais.nomeRua = Console.ReadLine();

                    Console.WriteLine("Informe o número do imóvel:");

                    dadosCadastrais.numCasa = Convert.ToUInt16(Console.ReadLine());

                    Console.WriteLine("Informe o número do documento:");

                    dadosCadastrais.numDoc = Convert.ToUInt16(Console.ReadLine());


                    // Cadastrar na lista

                    ListaCadastros.Add(dadosCadastrais);


                    Console.Clear();
                }
                else if (opcao == "s")
                {
                    // Sair

                    Console.WriteLine("Encerrando Aplicação");

                    
                }
                /*else if(opcao == "v")
                {

                    foreach(dadosCadastrais_Struct i in ListaCadastros )
                    {
                        Console.WriteLine();
                    }
                }*/
                else
                {
                    // Caso usuário pressione qualquer outra tecla

                    Console.WriteLine("Opção Inválida");
                    
                }
            } while (opcao != "s");

            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadKey();



        }
    }
}
