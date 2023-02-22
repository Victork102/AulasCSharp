using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SextoProjeto
{
	internal class Program
	{
		static string FilePath = @"Database.txt";
		static string StartTag;
		static string EndTag;
		static string tagName;
		static string tagBirth;
		static string tagStreetName;
		static string tagHouseNum;
		static string tagDoc;
		static string[] FileContent = File.ReadAllLines(FilePath);
		static List<userData_Struct> UserList = new List<userData_Struct>();



		public static void InitializeTags()
		{
			StartTag = "##### INICIO #####";
			EndTag = "##### FIM ##### \r\n";
			tagName = "NOME: ";
			tagBirth = "DATA_DE_NASCIMENTO: ";
			tagStreetName = "NOME_DA_RUA: ";
			tagHouseNum = "NUMERO_CASA: ";
			tagDoc = "NÚMERO_DO_DOCUMENTO: ";

		}

		public struct userData_Struct
		{
			public String fullName;
			public DateTime birthday;
			public String streetName;
			public UInt16 houseNum;
			public string numDoc;


		}

		public enum results_e
		{
			Success = 0,
			Exit = 1,
			Exception = 2
		}

		public static void PrintMessage(string message)
		{
			Console.WriteLine(message);
			Console.WriteLine("Pressione qualquer tecla para continuar");
			Console.ReadKey();
			Console.Clear();
		}

		public static results_e PegaString(ref string minhaString, string mensagem)
		{
			results_e retorno;
			Console.WriteLine(mensagem);
			string temp = Console.ReadLine();
			if (temp == "s" || temp == "S")
			{
				retorno = results_e.Exit;
			}
			else
			{
				minhaString = temp;
				retorno = results_e.Success;
			}
			Console.Clear();
			return retorno;
		}

		public static results_e PegaData(ref DateTime data, string mensagem)
		{
			results_e retorno;
			do
			{
				try
				{
					Console.WriteLine(mensagem);
					string temp = Console.ReadLine();
					if (temp == "s" || temp == "S")
					{
						retorno = results_e.Exit;
					}
					else
					{
						data = Convert.ToDateTime(temp);
						retorno = results_e.Success;
					}
				}
				catch (Exception e)
				{
					Console.WriteLine("EXCEÇÂO: " + e.Message);
					PrintMessage("Pressione qualquer tecla para continuar");
					retorno = results_e.Exception;
				}

			} while (retorno == results_e.Exception);
			Console.Clear();
			return retorno;
		}

		public static results_e PegaNum(ref UInt16 num, string mensagem)
		{
			results_e retorno;
			do
			{
				try
				{
					Console.WriteLine(mensagem);
					string temp = Console.ReadLine();
					if (temp == "s" || temp == "S")
					{
						retorno = results_e.Exit;
					}
					else
					{
						num = Convert.ToUInt16(temp);
						retorno = results_e.Success;
					}
				}
				catch (Exception e)
				{
					Console.WriteLine("EXCEÇÂO: " + e.Message);
					PrintMessage("Pressione qualquer tecla para continuar");
					retorno = results_e.Exception;
				}

			} while (retorno == results_e.Exception);
			Console.Clear();
			return retorno;
		}

		public static results_e CadastraUsuário(ref List<userData_Struct> ListaUsuarios)
		{
			userData_Struct userData;
			userData.fullName = "";
			userData.birthday = new DateTime();
			userData.streetName = "";
			userData.houseNum = 0;
			userData.numDoc = "";

			if (PegaString(ref userData.fullName, "Digite o nome completo ou digite S para sair:") == results_e.Exit)
			{
				return results_e.Exit;
			}
			if (PegaData(ref userData.birthday, "Digite a data de nascimento (DD/MM/YYY) ou digite S para sair:") == results_e.Exit)
			{
				return results_e.Exit;
			}
			if (PegaString(ref userData.streetName, "Digite o nome da rua:") == results_e.Exit)
			{
				return results_e.Exit;
			}
			if (PegaNum(ref userData.houseNum, "Digite o número do imóvel:") == results_e.Exit)
			{
				return results_e.Exit;
			}
			if (PegaString(ref userData.numDoc, "Digite o número do documento:") == results_e.Exit)
			{
				return results_e.Exit;
			}

			ListaUsuarios.Add(userData);
			return results_e.Success;

		}

		public static void GravaDados(string caminho, List<userData_Struct> ListaUsuarios)
		{
			try
			{
				string conteudoArquivo = "";

				foreach (userData_Struct cadastro in ListaUsuarios)
				{
					conteudoArquivo += StartTag + "\r\n";
					conteudoArquivo += tagName + cadastro.fullName + "\r\n";
					conteudoArquivo += tagBirth + cadastro.birthday.ToString("dd/MM/yyyy" + "\r\n");
					conteudoArquivo += tagStreetName + cadastro.streetName + "\r\n";
					conteudoArquivo += tagHouseNum + cadastro.houseNum + "\r\n";
					conteudoArquivo += tagDoc + cadastro.numDoc + "\r\n";
					conteudoArquivo += EndTag + "\r\n";
				}
				File.AppendAllText(caminho, conteudoArquivo);
				conteudoArquivo = "";
				
			}
			catch (Exception e)
			{
				Console.WriteLine("EXCEÇÂO: " + e.Message);

			}
		}
		public static void CarregaDados(string caminho, ref List<userData_Struct> ListaUsuarios)
		{
			try
			{
				if (File.Exists(caminho))
				{

					// Initialize
					FileContent = File.ReadAllLines(caminho);
					userData_Struct dadosCadastro;

					dadosCadastro.fullName = "";
					dadosCadastro.birthday = new DateTime();
					dadosCadastro.streetName = "";
					dadosCadastro.houseNum = 0;
					dadosCadastro.numDoc = "";

					foreach (string linha in FileContent)
					{
						if (linha.Contains(StartTag))
						{
							continue;
						}
						if (linha.Contains(EndTag))
						{
							ListaUsuarios.Add(dadosCadastro);

						}
						if (linha.Contains(tagName))
						{
							dadosCadastro.fullName = linha.Replace(tagName, "");
						}
						if (linha.Contains(tagBirth))
						{
							dadosCadastro.birthday = Convert.ToDateTime(linha.Replace(tagBirth, ""));
						}
						if (linha.Contains(tagStreetName))
						{
							dadosCadastro.streetName = linha.Replace(tagStreetName, "");
						}
						if (linha.Contains(tagHouseNum))
						{
							dadosCadastro.houseNum = Convert.ToUInt16(linha.Replace(tagHouseNum, ""));
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

		public static void SearchUser(List<userData_Struct> UserDataSearch)
		{

			

			Console.WriteLine("Digite o Numero do Documento para buscar um usuario, ou digite S para sair");
			string temp = Console.ReadLine();
			if (temp.ToLower() == "s")
			{
				return;
			}
			else
			{

				foreach (string line in FileContent)
					{

					userData_Struct userData = new userData_Struct();

						if (line.Contains(StartTag))
						{
							continue;
						}
						if(line.Contains(EndTag))
					{
						UserDataSearch.Add(userData) ;
					}
						if (line.Contains(tagName))
						{
						userData.fullName = line;
					}
						if (line.Contains(tagBirth))
						{
							userData.birthday = Convert.ToDateTime(line.Replace(tagBirth, ""));
						}
						if (line.Contains(tagStreetName))
						{
							userData.streetName = line.Replace(tagStreetName, "");
						}
						if (line.Contains(tagHouseNum))
						{
							userData.houseNum = Convert.ToUInt16(line.Replace(tagHouseNum, ""));
						}
						if (line.Contains(tagDoc))
						{
						userData.numDoc = line.Replace(tagDoc, "");
						}
					}
				
				List<userData_Struct> userDataTemp = UserDataSearch.Where(x => x.numDoc.Contains(temp)).ToList();
				if (userDataTemp.Count > 0)
				{
					foreach (userData_Struct user in userDataTemp)
					{
						Console.WriteLine(tagDoc + user.numDoc);
						Console.WriteLine(tagName + user.fullName);
						Console.WriteLine(tagBirth + user.birthday.ToString("dd/MM/yyyy"));
						Console.WriteLine(tagStreetName + user.streetName);
						Console.WriteLine(tagHouseNum + user.houseNum);
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

		public static void DeleteUser(ref List<userData_Struct> ListaUsuarios)
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
				List<userData_Struct> ListaUsuariosTemp = ListaUsuarios.Where(x => x.numDoc == temp).ToList();
				if (ListaUsuariosTemp.Count > 0)
				{
					foreach (userData_Struct user in ListaUsuariosTemp)
					{
						ListaUsuariosTemp.Remove(user);
						userDeleted = true;
					}
				}
				if (userDeleted)
				{
					GravaDados(FilePath, ListaUsuarios);
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



				CarregaDados(FilePath, ref UserList);

				do
				{
					Console.WriteLine("Digite C para cadastrar novo usuário, B para buscar um usuário, E para excluir um usuário ou digite S para sair");
					opcao = Console.ReadKey(true).KeyChar.ToString().ToLower();

					if (opcao == "c")
					{
						// Cadastrar Usuário

						if (File.Exists(FilePath) == false)
						{
							FileStream database = File.Create(FilePath);
							database.Close();

						}
						if (CadastraUsuário(ref UserList) == results_e.Success)
						{
							GravaDados(FilePath, UserList);
						}


					}
					else if (opcao == "s")
					{
						//Exit
						PrintMessage("Encerrando Programa");
					}
					else if (opcao == "b")
					{
					// Buscar usuario
					
					SearchUser(UserList);
					}
					else if (opcao == "e")
					{
					//Excluir usuario
					DeleteUser(ref UserList);
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
