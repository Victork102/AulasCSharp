using System;
using System.Collections.Generic;
using System.IO;

namespace SextoProjeto
{
	internal class Program
	{
		static string delimitadorInicio;
		static string delimitadorFim;
		static string tagNome;
		static string tagNasc;
		static string tagNomeRua;
		static string tagNumCasa;

		public static void InitializeTags()
		{
			delimitadorInicio = "##### INICIO #####";
			delimitadorFim = "##### FIM ##### \r\n";
			tagNome = "NOME: ";
			tagNasc = "DATA_DE_NASCIMENTO: ";
			tagNomeRua = "NOME_DA_RUA: ";
			tagNumCasa = "NUMERO_CASA: ";
		}

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

		public static resultado_e CadastraUsuário(ref List<dadosCadastrais_Struct> ListaUsuarios)
		{
			dadosCadastrais_Struct cadastroUsuario;
			cadastroUsuario.nomeCompleto = "";
			cadastroUsuario.dataNasc = new DateTime();
			cadastroUsuario.nomeRua = "";
			cadastroUsuario.numCasa = 0;

			if (PegaString(ref cadastroUsuario.nomeCompleto, "Digite o nome completo ou digite S para sair:") == resultado_e.Sair)
			{
				return resultado_e.Sair;
			}
			if (PegaData(ref cadastroUsuario.dataNasc, "Digite a data de nascimento (DD/MM/YYY) ou digite S para sair:") == resultado_e.Sair)
			{
				return resultado_e.Sair;
			}
			if (PegaString(ref cadastroUsuario.nomeRua, "Digite o nome da rua:") == resultado_e.Sair)
			{
				return resultado_e.Sair;
			}
			if (PegaNum(ref cadastroUsuario.numCasa, "Digite o número do imóvel:") == resultado_e.Sair)
			{
				return resultado_e.Sair;
			}

			ListaUsuarios.Add(cadastroUsuario);
			return resultado_e.Sucesso;

		}

		public static void GravaDados(string caminho, List<dadosCadastrais_Struct> ListaUsuarios)
		{
			try
			{
				string conteudoArquivo = "";

				foreach (dadosCadastrais_Struct cadastro in ListaUsuarios)
				{
					conteudoArquivo += delimitadorInicio + "\r\n";
					conteudoArquivo += tagNome + cadastro.nomeCompleto + "\r\n";
					conteudoArquivo += tagNasc + cadastro.dataNasc.ToString("dd/MM/yyyy" + "\r\n");
					conteudoArquivo += tagNomeRua + cadastro.nomeRua + "\r\n";
					conteudoArquivo += tagNumCasa + cadastro.numCasa + "\r\n";
					conteudoArquivo += delimitadorFim + "\r\n";
				}
				File.WriteAllText(caminho, conteudoArquivo);
			}
			catch (Exception e)
			{
				Console.WriteLine("EXCEÇÂO: " + e.Message);

			}
		}
		public static void CarregaDados(string caminho, ref List<dadosCadastrais_Struct> ListaUsuarios)
		{
			try
			{
				if (File.Exists(caminho))
				{

					// Initialize
					string[] conteudoArquivo = File.ReadAllLines(caminho);
					dadosCadastrais_Struct dadosCadastro;

					dadosCadastro.nomeCompleto = "";
					dadosCadastro.dataNasc = new DateTime();
					dadosCadastro.nomeRua = "";
					dadosCadastro.numCasa = 0;

					foreach (string linha in conteudoArquivo)
					{
						if (linha.Contains(delimitadorInicio))
						{
							continue;
						}
						if (linha.Contains(delimitadorFim))
						{
							ListaUsuarios.Add(dadosCadastro);

						}
						if (linha.Contains(tagNome))
						{
							dadosCadastro.nomeCompleto = linha.Replace(tagNome, "");
						}
						if (linha.Contains(tagNasc))
						{
							dadosCadastro.dataNasc = Convert.ToDateTime(linha.Replace(tagNasc, ""));
						}
						if (linha.Contains(tagNomeRua))
						{
							dadosCadastro.nomeRua = linha.Replace(tagNomeRua, "");
						}
						if (linha.Contains(tagNumCasa))
						{
							dadosCadastro.numCasa = Convert.ToUInt16(linha.Replace(tagNumCasa, ""));
						}
					}

				}
			}
			catch (Exception e)
			{
				Console.WriteLine("EXCEÇÂO: " + e.Message);

			}
		}



		static void Main(string[] args)
		{
			List<dadosCadastrais_Struct> ListaUsuarios = new List<dadosCadastrais_Struct>();

			string opcao = "";

			InitializeTags();

			string caminhoArquivo = @"Database.txt";

			CarregaDados(caminhoArquivo, ref ListaUsuarios);

			do
			{
				Console.WriteLine("Digite C para cadastrar novo usuário ou digite S para sair");
				opcao = Console.ReadKey(true).KeyChar.ToString().ToLower();

				if (opcao == "c")
				{
					// Cadastrar Usuário

					if (File.Exists(caminhoArquivo) == false)
					{
						FileStream database = File.Create(caminhoArquivo);
						database.Close();

					}
					if (CadastraUsuário(ref ListaUsuarios) == resultado_e.Sucesso)
					{
						GravaDados(caminhoArquivo, ListaUsuarios);
					}


				}
				else if (opcao == "s")
				{
					//Sair
					PrintMessage("Encerrando Programa");
				}
			//	else if (opcao == "v")
			//	{

				


			//	}
			////} while (opcao != "s");
				else
			{
				//Opção Inválida
				PrintMessage("Opção Inválida");
			}
		} while (opcao != "s");
		}
}
}
