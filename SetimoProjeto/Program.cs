using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SextoProjeto
{
	internal class Program
	{
		static string caminhoArquivo = @"Database.txt";
		static string delimitadorInicio;
		static string delimitadorFim;
		static string tagNome;
		static string tagNasc;
		static string tagNomeRua;
		static string tagNumCasa;
		static string tagDoc;
		static string[] conteudoArquivo = File.ReadAllLines(caminhoArquivo);
		static List<dadosCadastrais_Struct> ListaUsuarios = new List<dadosCadastrais_Struct>();



		public static void InitializeTags()
		{
			delimitadorInicio = "##### INICIO #####";
			delimitadorFim = "##### FIM ##### \r\n";
			tagNome = "NOME: ";
			tagNasc = "DATA_DE_NASCIMENTO: ";
			tagNomeRua = "NOME_DA_RUA: ";
			tagNumCasa = "NUMERO_CASA: ";
			tagDoc = "NÚMERO_DO_DOCUMENTO: ";

		}

		public struct dadosCadastrais_Struct
		{
			public String nomeCompleto;
			public DateTime dataNasc;
			public String nomeRua;
			public UInt16 numCasa;
			public string numDoc;


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
			cadastroUsuario.numDoc = "";

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
			if (PegaString(ref cadastroUsuario.numDoc, "Digite o número do documento:") == resultado_e.Sair)
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
					conteudoArquivo += tagDoc + cadastro.numDoc + "\r\n";
					conteudoArquivo += delimitadorFim + "\r\n";
				}
				File.AppendAllText(caminho, conteudoArquivo);
				conteudoArquivo = "";
				
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
					conteudoArquivo = File.ReadAllLines(caminho);
					dadosCadastrais_Struct dadosCadastro;

					dadosCadastro.nomeCompleto = "";
					dadosCadastro.dataNasc = new DateTime();
					dadosCadastro.nomeRua = "";
					dadosCadastro.numCasa = 0;
					dadosCadastro.numDoc = "";

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
						if (linha.Contains(tagDoc))
						{
							dadosCadastro.numDoc = linha.Replace(tagDoc, "");
						}
					}

				}
			}
			catch (Exception e)
			{
				Console.WriteLine("EXCEÇÂO: " + e.Message);

			}
		}

		public static void BuscaUser(List<dadosCadastrais_Struct> ListaUsuarios)
		{

			

			Console.WriteLine("Digite o Numero do Documento para buscar um usuario, ou digite S para sair");
			string temp = Console.ReadLine();
			if (temp.ToLower() == "s")
			{
				return;
			}
			else
			{

				foreach (string linha in conteudoArquivo)
					{

					dadosCadastrais_Struct dadosCadastro = new dadosCadastrais_Struct();

						if (linha.Contains(delimitadorInicio))
						{
							continue;
						}
						if(linha.Contains(delimitadorFim))
					{
						ListaUsuarios.Add(dadosCadastro) ;
					}
						if (linha.Contains(tagNome))
						{
						dadosCadastro.nomeCompleto = linha;
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
						if (linha.Contains(tagDoc))
						{
						dadosCadastro.numDoc = linha.Replace(tagDoc, "");
						}
					}
				
				List<dadosCadastrais_Struct> listaUsuariosTemp = ListaUsuarios.Where(x => x.numDoc.Contains(temp)).ToList();
				if (listaUsuariosTemp.Count > 0)
				{
					foreach (dadosCadastrais_Struct user in listaUsuariosTemp)
					{
						Console.WriteLine(tagDoc + user.numDoc);
						Console.WriteLine(tagNome + user.nomeCompleto);
						Console.WriteLine(tagNasc + user.dataNasc.ToString("dd/MM/yyyy"));
						Console.WriteLine(tagNomeRua + user.nomeRua);
						Console.WriteLine(tagNumCasa + user.numCasa);
						Console.WriteLine("");

					}
				}
				else
				{
					Console.WriteLine("Nenhum Usuário possui o documento N°" + temp);

				}
				PrintMessage("");
			}
		}

		public static void DeleteUser(ref List<dadosCadastrais_Struct> ListaUsuarios)
		{
			Console.WriteLine("Digite o N° do documento para excluir o usuário ou pressione S para sair");
			string temp = Console.ReadLine();
			bool userDeleted = false;
			if(temp.ToLower() == "s")
			{
				return;
			}
			else
			{
				List<dadosCadastrais_Struct> ListaUsuariosTemp = ListaUsuarios.Where(x => x.numDoc == temp).ToList();
				if (ListaUsuariosTemp.Count > 0)
				{
					foreach (dadosCadastrais_Struct user in ListaUsuariosTemp)
					{
						ListaUsuariosTemp.Remove(user);
						userDeleted = true;
					}
				}
				if (userDeleted)
				{
					GravaDados(caminhoArquivo, ListaUsuarios);
					Console.WriteLine(ListaUsuariosTemp + " usuário(s) com documento " + temp + " excluido(s)");
				}
				else
				{
					Console.WriteLine("Nenhum Usuário possui o documento N°" + temp);
				}
			}
			PrintMessage("");
		}

			static void Main(string[] args)
			{
				

				string opcao = "";

				InitializeTags();



				CarregaDados(caminhoArquivo, ref ListaUsuarios);

				do
				{
					Console.WriteLine("Digite C para cadastrar novo usuário, B para buscar um usuário, E para excluir um usuário ou digite S para sair");
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
					else if (opcao == "b")
					{
					// Buscar usuario
					
					BuscaUser(ListaUsuarios);
					}
					else if (opcao == "e")
					{
					//Excluir usuario
					DeleteUser(ref ListaUsuarios);
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
