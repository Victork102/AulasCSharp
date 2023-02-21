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
			public UInt16 numCasa;

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

		public static resultado_e PegaString(ref string minhaString, string mensagem)
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
					if (temp == "s" || temp == "S")
					{
						retorno = resultado_e.Sair;
					}
					else
					{
						data = Convert.ToDateTime(temp);
						retorno = resultado_e.Sucesso;
					}
				}
				catch (Exception e)
				{
					Console.WriteLine("EXCEÇÂO: " + e.Message);
					PrintMessage("Pressione qualquer tecla para continuar");
					retorno = resultado_e.Excecao;
				}

			} while (retorno == resultado_e.Excecao);
			Console.Clear();
			return retorno;
		}

		public static resultado_e PegaNum(ref UInt16 num, string mensagem)
		{
			resultado_e retorno;
			do
			{
				try
				{
					Console.WriteLine(mensagem);
					string temp = Console.ReadLine();
					if (temp == "s" || temp == "S")
					{
						retorno = resultado_e.Sair;
					}
					else
					{
						num = Convert.ToUInt16(temp);
						retorno = resultado_e.Sucesso;
					}
				}
				catch (Exception e)
				{
					Console.WriteLine("EXCEÇÂO: " + e.Message);
					PrintMessage("Pressione qualquer tecla para continuar");
					retorno = resultado_e.Excecao;
				}

			} while (retorno == resultado_e.Excecao);
			Console.Clear();
			return retorno;
		}

		public static void CadastraUsuário(ref List<dadosCadastrais_Struct> ListaUsuarios)
		{
			dadosCadastrais_Struct cadastroUsuario;
			cadastroUsuario.nomeCompleto = "";
			cadastroUsuario.dataNasc = new DateTime();
			cadastroUsuario.nomeRua = "";
			cadastroUsuario.numCasa = 0;

			if (PegaString(ref cadastroUsuario.nomeCompleto, "Digite o nome completo ou digite S para sair:") != resultado_e.Sucesso) 
			{
				return;
			}
			if (PegaData(ref cadastroUsuario.dataNasc, "Digite a data de nascimento (DD/MM/YYY) ou digite S para sair:") != resultado_e.Sucesso) 
			{
				return;
			}
			if (PegaString(ref cadastroUsuario.nomeRua,"Digite o nome da rua:") != resultado_e.Sucesso)
			{
				return;
			}
			if (PegaNum(ref cadastroUsuario.numCasa,"Digite o número do imóvel:")!= resultado_e.Sucesso){
				return;
			}

			ListaUsuarios.Add(cadastroUsuario);

		}

		static void Main(string[] args)
		{
			List<dadosCadastrais_Struct> ListaUsuarios = new List<dadosCadastrais_Struct>();

			string opcao = "";

			do
			{
				Console.WriteLine("Digite C para cadastrar novo usuário, V para visualizar usuários cadastrados ou digite S para sair");
				opcao = Console.ReadKey(true).KeyChar.ToString().ToLower();

				if (opcao == "c")
				{
					// Cadastrar Usuário

					CadastraUsuário(ref ListaUsuarios);


				}
				else if (opcao == "s")
				{
					//Sair
					PrintMessage("Encerrando Programa");
				}
				else if (opcao == "v")
				{
					foreach(dadosCadastrais_Struct a in ListaUsuarios)
					{
						Console.WriteLine("======================");
						Console.WriteLine(a.nomeCompleto);
						Console.WriteLine(a.dataNasc);
						Console.WriteLine(a.nomeRua);
						Console.WriteLine(a.numCasa);
						
					}
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
