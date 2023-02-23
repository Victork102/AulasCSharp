using System;
using System.Collections.Generic;

namespace OitavoProjeto
{
	class UI
	{
		// Atributos

		Database database;

		// Constructor

		public UI(Database pDatabase)
		{
			database = pDatabase;
		}

		// Métodos
		public enum results_e
		{
			Success = 0,
			Exit = 1,
			Exception = 2
		}
		public void PrintMessage(string message)
		{
			Console.WriteLine(message);
			Console.WriteLine("Pressione qualquer tecla para continuar");
			Console.ReadKey();
			Console.Clear();
		}
		public results_e CatchString(ref string inputString, string message)
		{
			results_e ReturnResult;
			Console.WriteLine(message);
			string temp = Console.ReadLine();
			if (temp == "s" || temp == "S")
			{
				ReturnResult = results_e.Exit;
			}
			else
			{
				inputString = temp;
				ReturnResult = results_e.Success;
			}
			Console.Clear();
			return ReturnResult;
		}
		public results_e CatchDate(ref DateTime date, string message)
		{
			results_e ReturnResult;
			do
			{
				try
				{
					Console.WriteLine(message);
					string temp = Console.ReadLine();
					if (temp == "s" || temp == "S")
					{
						ReturnResult = results_e.Exit;
					}
					else
					{
						date = Convert.ToDateTime(temp);
						ReturnResult = results_e.Success;
					}
				}
				catch (Exception e)
				{
					PrintMessage("EXCEÇÂO: " + e.Message);
					ReturnResult = results_e.Exception;
				}

			} while (ReturnResult == results_e.Exception);
			Console.Clear();
			return ReturnResult;
		}
		public results_e CatchNum(ref UInt16 num, string message)
		{
			results_e ReturnResult;
			do
			{
				try
				{
					Console.WriteLine(message);
					string temp = Console.ReadLine();
					if (temp == "s" || temp == "S")
					{
						ReturnResult = results_e.Exit;
					}
					else
					{
						num = Convert.ToUInt16(temp);
						ReturnResult = results_e.Success;
					}
				}
				catch (Exception e)
				{
					PrintMessage("EXCEÇÂO: " + e.Message);
					ReturnResult = results_e.Exception;
				}

			} while (ReturnResult == results_e.Exception);
			Console.Clear();
			return ReturnResult;
		}
		public void PrintUserDataOnScreen(UserData pUserData)
		{
			Console.WriteLine("Nome: " + pUserData.Name);
			Console.WriteLine("Número do Documento: " + pUserData.NumDoc);
			Console.WriteLine("Data de Nascimento: " + pUserData.Birthday);
			Console.WriteLine("Endereço: " + pUserData.StreetName + ", " + pUserData.NumHouse);
		}
		public void PrintUserDataOnScreen(List<UserData> pUserData)
		{
			foreach (UserData user in pUserData)
			{
				PrintUserDataOnScreen(user);
			}
		}

		public results_e RegisterUser()
		{
			Console.Clear();
			string fullName = "";
			string numDoc = "";
			DateTime birthDay = new DateTime();
			string streetName = "";
			UInt16 numHouse = 0;

			if (CatchString(ref fullName, "Digite o nome completo ou digite S para sair:") == results_e.Exit)
			{
				return results_e.Exit;
			}
			if (CatchString(ref numDoc, "Digite o número do documento:") == results_e.Exit)
			{
				return results_e.Exit;
			}
			if (CatchDate(ref birthDay, "Digite a data de nascimento (DD/MM/YYY) ou digite S para sair:") == results_e.Exit)
			{
				return results_e.Exit;
			}
			if (CatchString(ref streetName, "Digite o nome da rua:") == results_e.Exit)
			{
				return results_e.Exit;
			}
			if (CatchNum(ref numHouse, "Digite o número do imóvel:") == results_e.Exit)
			{
				return results_e.Exit;
			}



			UserData registerUser = new UserData(fullName, numDoc, birthDay, streetName, numHouse);
			database.AddUser(registerUser);


			Console.Clear();
			Console.WriteLine("Adicionando Usuario: ");
			PrintUserDataOnScreen(registerUser);
			PrintMessage("");


			return results_e.Success;
		}

		public void SearchUser()
		{
			Console.Clear();
			Console.WriteLine("Digite o Numero do Documento para buscar um usuario, ou digite S para sair");
			string temp = Console.ReadLine();
			if (temp.ToLower() == "s")
			{
				return;
			}
			else
			{
				List<UserData> UserListTemp = database.SearchList(temp);
				Console.Clear();
				if (UserListTemp != null)
				{
					Console.WriteLine("Usuário(s) com documento " + temp + " encontrado(s)");
					PrintUserDataOnScreen(UserListTemp);
					PrintMessage("");
				}
				else
				{
					Console.WriteLine("Nenhum usuário com o documento " + temp + " foi encontrado");
					PrintMessage("");
				}
			}

		}

		public void RemoveUser()
		{
			Console.Clear();
			Console.WriteLine("Digite o Numero do Documento para remover um usuario, ou digite S para sair");
			string temp = Console.ReadLine();
			if (temp.ToLower() == "s")
			{
				return;
			}
			else
			{
				List<UserData> UserListTemp = database.SearchList(temp);
				Console.Clear();
				if (UserListTemp != null)
				{
					Console.WriteLine("Removendo usuário(s) com documento " + temp + "...");
					PrintUserDataOnScreen(UserListTemp);
					PrintMessage("");
				}
				else
				{
					Console.WriteLine("Nenhum usuário com o documento " + temp + " foi encontrado");
					PrintMessage("");
				}
			}

		}

		public void Exit()
		{
			Console.Clear();
			PrintMessage("Encerrando Programa");
		}

		public void InvalidOption()
		{
			Console.Clear();
			PrintMessage("Opção Inválida");
		}

		public void InitializeUI()
		{
			string temp;
			do
			{
				
				Console.WriteLine("Digite C para Cadastrar novo usuário.");
				Console.WriteLine("Digite B para buscar usuario através do documento.");
				Console.WriteLine("Digite R para remover usuario através do documento.");
				Console.WriteLine("Digite S para sair.");

				temp = Console.ReadKey(true).KeyChar.ToString().ToLower();

				switch (temp)
				{
					case "c":
						// Cadastrar

						RegisterUser();

						break;
					case "b":
						// Buscar

						SearchUser();

						break;
					case "r":
						// Remover

						RemoveUser();

						break;

					case "s":
						// Sair

						Exit();

						break;
					default:
						// Opção Invalida

						InvalidOption();

						break;
				}

			} while (temp != "s");
		}
	}
}
