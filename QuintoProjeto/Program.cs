using System;
using System.Collections.Generic;

namespace QuintoProjeto
{
    class Program
    {

        public struct dadosCadastrais_Struct
        {
            public String nomeCompleto;
            public DateTime dataNasc;
            public String nomeRua;
            public int numCasa;

        }

        public enum resultado_e
        {
            Sucesso = 0,
            Sair = 1,
            Excecao = 2
        }

        public static void PrintMessage(string mensagem)
        {
            Console.WriteLine(mensagem);
            Console.WriteLine("Pressione qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }

        public static resultado_e PegaString(string minhaString, string mensagem)
        {
            resultado_e retorno;
            Console.WriteLine(mensagem);
            string temp = Console.ReadLine();
            if (temp == "s" || temp == "S")
            {
                retorno = resultado_e.Sair;
            }
            else
            {
                minhaString = temp;
                retorno = resultado_e.Sucesso;
            }
            Console.Clear();
            return retorno;
        }

        public static resultado_e PegaData(ref DateTime data, string mensagem)
		{
            resultado_e retorno;
            do
            {
                try
                {
                    Console.WriteLine(mensagem);
                    string temp = Console.ReadLine();
                    if (temp = "s" || temp = "S")
					{
                        retorno = resultado_e.Sair;
					}
					else
					{
                        data = Convert.ToDateTime(temp);
                        retorno = resultado_e.Sucesso;
					}
                }
                catch(Exception e)
				{
                    Console.WriteLine("EXCEÇÂO: " + e.Message);
                    PrintMessage("Pressione qualquer tecla para continuar");
                    retorno = resultado_e.Excecao;
				}

            } while (retorno==resultado_e.Excecao);
            Console.Clear();
            return retorno;
		}

        static void Main(string[] args)
        {
            List<dadosCadastrais_Struct> ListaUsuarios = new List<dadosCadastrais_Struct>();

            string opcao = "";

            do
            {
                Console.WriteLine("Digite C para cadastrar novo usuário ou digite S para sair");
                opcao = Console.ReadKey(true).KeyChar.ToString().ToLower();

                if (opcao == "c")
                {
                    // Cadastrar Usuário


                }
                else if (opcao == "S")
                {
                    //Sair
                    PrintMessage("Encerrando Programa");
                }
                else
                {
                    //Opção Inválida
                    PrintMessage("Opção Inválida");
                }
            } while (opcao != "s");
        }
    }
}
