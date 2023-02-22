//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;

//namespace SextoProjeto
//{
//	internal class Program
//	{
//		static string FilePath = @"Database.txt";
//		static string StartTag;
//		static string EndTag;
//		static string tagName;
//		static string tagBirth;
//		static string tagStreetName;
//		static string tagHouseNum;
//		static string tagDoc;
//		static string[] FileContent = File.ReadAllLines(FilePath);
//		static List<userData_Struct> UserList = new List<userData_Struct>();



//		public static void InitializeTags()
//		{
//			StartTag = "##### INICIO #####";
//			EndTag = "##### FIM ##### \r\n";
//			tagName = "NOME: ";
//			tagBirth = "DATA_DE_NASCIMENTO: ";
//			tagStreetName = "NOME_DA_RUA: ";
//			tagHouseNum = "NUMERO_CASA: ";
//			tagDoc = "NÚMERO_DO_DOCUMENTO: ";

//		}

//		public struct userData_Struct
//		{
//			public String fullName;
//			public DateTime birthday;
//			public String streetName;
//			public UInt16 houseNum;
//			public string numDoc;


//		}

//		public enum results_e
//		{
//			Success = 0,
//			Exit = 1,
//			Exception = 2
//		}

//		public static void PrintMessage(string message)
//		{
//			Console.WriteLine(message);
//			Console.WriteLine("Pressione qualquer tecla para continuar");
//			Console.ReadKey();
//			Console.Clear();
//		}

//		public static results_e CatchString(ref string myString, string message)
//		{
//			results_e ReturnResult;
//			Console.WriteLine(message);
//			string temp = Console.ReadLine();
//			if (temp == "s" || temp == "S")
//			{
//				ReturnResult = results_e.Exit;
//			}
//			else
//			{
//				myString = temp;
//				ReturnResult = results_e.Success;
//			}
//			Console.Clear();
//			return ReturnResult;
//		}

//		public static results_e CatchDate(ref DateTime date, string message)
//		{
//			results_e ReturnResult;
//			do
//			{
//				try
//				{
//					Console.WriteLine(message);
//					string temp = Console.ReadLine();
//					if (temp == "s" || temp == "S")
//					{
//						ReturnResult = results_e.Exit;
//					}
//					else
//					{
//						date = Convert.ToDateTime(temp);
//						ReturnResult = results_e.Success;
//					}
//				}
//				catch (Exception e)
//				{
//					Console.WriteLine("EXCEÇÂO: " + e.Message);
//					PrintMessage("Pressione qualquer tecla para continuar");
//					ReturnResult = results_e.Exception;
//				}

//			} while (ReturnResult == results_e.Exception);
//			Console.Clear();
//			return ReturnResult;
//		}

//		public static results_e CatchNum(ref UInt16 num, string message)
//		{
//			results_e ReturnResult;
//			do
//			{
//				try
//				{
//					Console.WriteLine(message);
//					string temp = Console.ReadLine();
//					if (temp == "s" || temp == "S")
//					{
//						ReturnResult = results_e.Exit;
//					}
//					else
//					{
//						num = Convert.ToUInt16(temp);
//						ReturnResult = results_e.Success;
//					}
//				}
//				catch (Exception e)
//				{
//					Console.WriteLine("EXCEÇÂO: " + e.Message);
//					PrintMessage("Pressione qualquer tecla para continuar");
//					ReturnResult = results_e.Exception;
//				}

//			} while (ReturnResult == results_e.Exception);
//			Console.Clear();
//			return ReturnResult;
//		}

//		public static results_e CadastraUsuário(ref List<userData_Struct> ListaUsuarios)
//		{
//			userData_Struct userData;
//			userData.fullName = "";
//			userData.birthday = new DateTime();
//			userData.streetName = "";
//			userData.houseNum = 0;
//			userData.numDoc = "";

//			if (CatchString(ref userData.fullName, "Digite o nome completo ou digite S para sair:") == results_e.Exit)
//			{
//				return results_e.Exit;
//			}
//			if (CatchDate(ref userData.birthday, "Digite a date de nascimento (DD/MM/YYY) ou digite S para sair:") == results_e.Exit)
//			{
//				return results_e.Exit;
//			}
//			if (CatchString(ref userData.streetName, "Digite o nome da rua:") == results_e.Exit)
//			{
//				return results_e.Exit;
//			}
//			if (CatchNum(ref userData.houseNum, "Digite o número do imóvel:") == results_e.Exit)
//			{
//				return results_e.Exit;
//			}
//			if (CatchString(ref userData.numDoc, "Digite o número do documento:") == results_e.Exit)
//			{
//				return results_e.Exit;
//			}

//			ListaUsuarios.Add(userData);
//			return results_e.Success;

//		}

//		public static void GravaDados(string caminho, List<userData_Struct> ListaUsuarios)
//		{
//			try
//			{
//				string conteudoArquivo = "";

//				foreach (userData_Struct cadastro in ListaUsuarios)
//				{
//					conteudoArquivo += StartTag + "\r\n";
//					conteudoArquivo += tagName + cadastro.fullName + "\r\n";
//					conteudoArquivo += tagBirth + cadastro.birthday.ToString("dd/MM/yyyy" + "\r\n");
//					conteudoArquivo += tagStreetName + cadastro.streetName + "\r\n";
//					conteudoArquivo += tagHouseNum + cadastro.houseNum + "\r\n";
//					conteudoArquivo += tagDoc + cadastro.numDoc + "\r\n";
//					conteudoArquivo += EndTag + "\r\n";
//				}
//				File.AppendAllText(caminho, conteudoArquivo);
//				conteudoArquivo = "";

//			}
//			catch (Exception e)
//			{
//				Console.WriteLine("EXCEÇÂO: " + e.Message);

//			}
//		}
//		public static void LoadData(string caminho, ref List<userData_Struct> ListaUsuarios)
//		{
//			try
//			{
//				if (File.Exists(caminho))
//				{

//					// Initialize
//					FileContent = File.ReadAllLines(caminho);
//					userData_Struct dadosCadastro;

//					dadosCadastro.fullName = "";
//					dadosCadastro.birthday = new DateTime();
//					dadosCadastro.streetName = "";
//					dadosCadastro.houseNum = 0;
//					dadosCadastro.numDoc = "";

//					foreach (string linha in FileContent)
//					{
//						if (linha.Contains(StartTag))
//						{
//							continue;
//						}
//						if (linha.Contains(EndTag))
//						{
//							ListaUsuarios.Add(dadosCadastro);

//						}
//						if (linha.Contains(tagName))
//						{
//							dadosCadastro.fullName = linha.Replace(tagName, "");
//						}
//						if (linha.Contains(tagBirth))
//						{
//							dadosCadastro.birthday = Convert.ToDateTime(linha.Replace(tagBirth, ""));
//						}
//						if (linha.Contains(tagStreetName))
//						{
//							dadosCadastro.streetName = linha.Replace(tagStreetName, "");
//						}
//						if (linha.Contains(tagHouseNum))
//						{
//							dadosCadastro.houseNum = Convert.ToUInt16(linha.Replace(tagHouseNum, ""));
//						}
//						if (linha.Contains(tagDoc))
//						{
//							dadosCadastro.numDoc = linha.Replace(tagDoc, "");
//						}
//					}

//				}
//			}
//			catch (Exception e)
//			{
//				Console.WriteLine("EXCEÇÂO: " + e.Message);

//			}
//		}

//		public static void SearchUser(List<userData_Struct> UserDataSearch)
//		{



//			Console.WriteLine("Digite o Numero do Documento para buscar um usuario, ou digite S para sair");
//			string temp = Console.ReadLine();
//			if (temp.ToLower() == "s")
//			{
//				return;
//			}
//			else
//			{

//				foreach (string line in FileContent)
//				{

//					userData_Struct userData = new userData_Struct();

//					if (line.Contains(StartTag))
//					{
//						continue;
//					}
//					if (line.Contains(EndTag))
//					{
//						UserDataSearch.Add(userData);
//					}
//					if (line.Contains(tagName))
//					{
//						userData.fullName = line;
//					}
//					if (line.Contains(tagBirth))
//					{
//						userData.birthday = Convert.ToDateTime(line.Replace(tagBirth, ""));
//					}
//					if (line.Contains(tagStreetName))
//					{
//						userData.streetName = line.Replace(tagStreetName, "");
//					}
//					if (line.Contains(tagHouseNum))
//					{
//						userData.houseNum = Convert.ToUInt16(line.Replace(tagHouseNum, ""));
//					}
//					if (line.Contains(tagDoc))
//					{
//						userData.numDoc = line.Replace(tagDoc, "");
//					}
//				}

//				List<userData_Struct> userDataTemp = UserDataSearch.Where(x => x.numDoc.Contains(temp)).ToList();
//				if (userDataTemp.Count > 0)
//				{
//					foreach (userData_Struct user in userDataTemp)
//					{
//						Console.WriteLine(tagDoc + user.numDoc);
//						Console.WriteLine(tagName + user.fullName);
//						Console.WriteLine(tagBirth + user.birthday.ToString("dd/MM/yyyy"));
//						Console.WriteLine(tagStreetName + user.streetName);
//						Console.WriteLine(tagHouseNum + user.houseNum);
//						Console.WriteLine("");

//					}
//				}
//				else
//				{
//					Console.WriteLine("Nenhum Usuário possui o documento N°" + temp);

//				}
//				PrintMessage("");
//			}
//		}

//		public static void DeleteUser(ref List<userData_Struct> ListaUsuarios)
//		{
//			Console.WriteLine("Digite o N° do documento para excluir o usuário ou pressione S para sair");
//			string temp = Console.ReadLine();
//			bool userDeleted = false;
//			if (temp.ToLower() == "s")
//			{
//				return;
//			}
//			else
//			{
//				List<userData_Struct> ListaUsuariosTemp = ListaUsuarios.Where(x => x.numDoc == temp).ToList();
//				if (ListaUsuariosTemp.Count > 0)
//				{
//					foreach (userData_Struct user in ListaUsuariosTemp)
//					{
//						ListaUsuariosTemp.Remove(user);
//						userDeleted = true;
//					}
//				}
//				if (userDeleted)
//				{
//					GravaDados(FilePath, ListaUsuarios);
//					Console.WriteLine(ListaUsuariosTemp + " usuário(s) com documento " + temp + " excluido(s)");
//				}
//				else
//				{
//					Console.WriteLine("Nenhum Usuário possui o documento N°" + temp);
//				}
//			}
//			PrintMessage("");
//		}

//		static void Main(string[] args)
//		{


//			string opcao = "";

//			InitializeTags();



//			LoadData(FilePath, ref UserD);

//			do
//			{
//				Console.WriteLine("Digite C para cadastrar novo usuário, B para buscar um usuário, E para excluir um usuário ou digite S para sair");
//				opcao = Console.ReadKey(true).KeyChar.ToString().ToLower();

//				if (opcao == "c")
//				{
//					// Cadastrar Usuário

//					if (File.Exists(FilePath) == false)
//					{
//						FileStream database = File.Create(FilePath);
//						database.Close();

//					}
//					if (CadastraUsuário(ref UserList) == results_e.Success)
//					{
//						GravaDados(FilePath, UserList);
//					}


//				}
//				else if (opcao == "s")
//				{
//					//Exit
//					PrintMessage("Encerrando Programa");
//				}
//				else if (opcao == "b")
//				{
//					// Buscar usuario

//					SearchUser(UserList);
//				}
//				else if (opcao == "e")
//				{
//					//Excluir usuario
//					DeleteUser(ref UserList);
//				}

//				else
//				{
//					//Opção Inválida
//					PrintMessage("Opção Inválida");
//				}
//			} while (opcao != "s");
//		}
//	}
//}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SetimoProjeto
{
    internal class Program
    {
        private const string FilePath = @"Database.txt";
        private const string StartTag = "##### INICIO #####";
        private const string EndTag = "##### FIM #####\n";
        private const string TagName = "NOME: ";
        private const string TagBirth = "DATA_DE_NASCIMENTO: ";
        private const string TagStreetName = "NOME_DA_RUA: ";
        private const string TagHouseNum = "NUMERO_CASA: ";
        private const string TagDoc = "NÚMERO_DO_DOCUMENTO: ";
        private static List<UserData> UserList = new List<UserData>();

        private struct UserData
        {
            public string FullName;
            public DateTime? Birthday;
            public string StreetName;
            public ushort? HouseNum;
            public string NumDoc;

            internal static UserData TryParse(string data)
            {
                var lines = data.Split(new[] { "\n", "\r" }, StringSplitOptions.RemoveEmptyEntries);
                var newEntry = new UserData();

                foreach (var line in lines)
                {
                    if (line.Contains(TagName))
                    {
                        newEntry.FullName = line.Replace(TagName, "");
                    }

                    if (line.Contains(TagBirth))
                    {
                        newEntry.Birthday = Convert.ToDateTime(line.Replace(TagBirth, ""));
                    }

                    if (line.Contains(TagStreetName))
                    {
                        newEntry.StreetName = line.Replace(TagStreetName, "");
                    }

                    if (line.Contains(TagHouseNum))
                    {
                        var sanitized = line.Replace(TagHouseNum, "").Trim();
                        newEntry.HouseNum = ushort.Parse(sanitized);
                    }

                    if (line.Contains(TagDoc))
                    {
                        newEntry.NumDoc = line.Replace(TagDoc, "");
                    }
                }

                if (newEntry.NumDoc == null)
                {
                    throw new ArgumentException($"No document number for entry {data}!");
                }

                if (newEntry.FullName == null)
                {
                    throw new ArgumentException("No full name for entry!");
                }

                if (newEntry.Birthday == null)
                {
                    throw new ArgumentException("No date of birth for entry!");
                }

                if (newEntry.StreetName == null)
                {
                    throw new ArgumentException("No street name for entry!");
                }

                if (newEntry.HouseNum == null)
                {
                    throw new ArgumentException("No house number for entry!");
                }

                return newEntry;
            }

            public override string ToString()
            {
                var databaseContents = new StringBuilder();

                databaseContents.AppendLine(StartTag);
                databaseContents.AppendLine($"{TagName}{FullName}");
                databaseContents.AppendLine($"{TagBirth}{Birthday?.ToString("dd/MM/yyyy")}");
                databaseContents.AppendLine($"{TagStreetName}{StreetName}");
                databaseContents.AppendLine($"{TagHouseNum}{HouseNum}");
                databaseContents.AppendLine($"{TagDoc}{NumDoc}");
                databaseContents.AppendLine(EndTag);

                return databaseContents.ToString();
            }
        }

        private enum Result
        {
            Success = 0,
            Exit = 1,
            Exception = 2
        }

        private static void PrintMessage(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        private static Result CatchString(ref string myString, string message)
        {
            Result ReturnResult;
            Console.WriteLine(message);
            var temp = Console.ReadLine();
            if (temp == "s" || temp == "S")
            {
                ReturnResult = Result.Exit;
            }
            else
            {
                myString = temp;
                ReturnResult = Result.Success;
            }

            return ReturnResult;
        }

        private static Result CatchDate(ref DateTime? date, string message)
        {
            Result ReturnValue;
            do
            {
                try
                {
                    Console.WriteLine(message);
                    var temp = Console.ReadLine();
                    if (temp == "s" || temp == "S")
                    {
                        ReturnValue = Result.Exit;
                    }
                    else
                    {
                        date = Convert.ToDateTime(temp);
                        ReturnValue = Result.Success;
                    }
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine("ERROR: " + e.Message);
                    PrintMessage("Press any key to continue");
                    ReturnValue = Result.Exception;
                }
            } while (ReturnValue == Result.Exception);

            Console.Clear();
            return ReturnValue;
        }

        private static Result CatchNum(ref ushort? num, string message)
        {
            Result ReturnValue;
            do
            {
                try
                {
                    Console.WriteLine(message);
                    string temp = Console.ReadLine();
                    if (temp == "s" || temp == "S")
                    {
                        ReturnValue = Result.Exit;
                    }
                    else
                    {
                        num = Convert.ToUInt16(temp);
                        ReturnValue = Result.Success;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("EXCEÇÂO: " + e.Message);
                    PrintMessage("Pressione qualquer tecla para continuar");
                    ReturnValue = Result.Exception;
                }
            } while (ReturnValue == Result.Exception);

            Console.Clear();
            return ReturnValue;
        }

        private static Result CreateUser(ref List<UserData> userList)
        {
            UserData userData;
            userData.FullName = "";
            userData.Birthday = new DateTime();
            userData.StreetName = "";
            userData.HouseNum = 0;
            userData.NumDoc = "";

            if (CatchString(ref userData.FullName, "Digite o nome completo ou digite S para sair:") == Result.Exit)
            {
                return Result.Exit;
            }

            if (CatchDate(ref userData.Birthday, "Digite a date de nascimento (DD/MM/YYY) ou digite S para sair:") ==
                Result.Exit)
            {
                return Result.Exit;
            }

            if (CatchString(ref userData.StreetName, "Digite o nome da rua:") == Result.Exit)
            {
                return Result.Exit;
            }

            if (CatchNum(ref userData.HouseNum, "Digite o número do imóvel:") == Result.Exit)
            {
                return Result.Exit;
            }

            if (CatchString(ref userData.NumDoc, "Digite o número do documento:") == Result.Exit)
            {
                return Result.Exit;
            }

            userList.Add(userData);
            return Result.Success;
        }

        private static void StoreData(string path, IEnumerable<UserData> userList)
        {
            try
            {
                File.WriteAllText(path, userList.Aggregate("", (current, entry) => current + entry));
            }
            catch (Exception e)
            {
                Console.WriteLine("EXCEÇÂO: " + e.Message);
            }
        }

        private static void LoadData(string path, ref List<UserData> userList)
        {
            try
            {
                if (!File.Exists(path)) return;
                // Initialize
                var fileContentRaw = File.ReadAllText(path);
                string[] delimiters = { StartTag, EndTag };
                var splitFile = fileContentRaw.Split(delimiters, StringSplitOptions.RemoveEmptyEntries)
                    .Where(text => text.Trim().Length > 0);

                foreach (var data in splitFile)
                {
                    try
                    {
                        userList.Add(UserData.TryParse(data));
                    }
                    catch (Exception e)
                    {
                        Console.Error.WriteLine($"Failed to parse date: {e}; date: {data}");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }

        private static void SearchUser(IEnumerable<UserData> userDataSearch)
        {
            Console.Write(
                "Enter document number to find document, nothing to show the entire database, or s to cancel: ");
            var documentNumber = Console.ReadLine() ?? "s";
            if (documentNumber.ToLower() == "s")
            {
                return;
            }

            var userDataTemp = userDataSearch
                .Where(x => x.NumDoc.Contains(documentNumber))
                .ToList();
            if (userDataTemp.Count > 0)
            {
                foreach (var user in userDataTemp)
                {
                    Console.WriteLine(TagDoc + user.NumDoc);
                    Console.WriteLine(TagName + user.FullName);
                    Console.WriteLine(TagBirth + user.Birthday?.ToString("dd/MM/yyyy"));
                    Console.WriteLine(TagStreetName + user.StreetName);
                    Console.WriteLine(TagHouseNum + user.HouseNum);
                    Console.WriteLine("");
                }
            }
            else
            {
                Console.WriteLine($"No user with document number {documentNumber}");
            }

            PrintMessage("");
        }

        private static void DeleteUser(ref List<UserData> userList)
        {
            Console.Write("Enter document number or s to cancel: ");
            var documentNumber = Console.ReadLine();
            var userDeleted = false;
            if (documentNumber?.ToLower() == "s")
            {
                return;
            }

            var userListToDelete = userList.Where(user => user.NumDoc == documentNumber).ToList();
            userList = userList.Where(x => x.NumDoc != documentNumber).ToList();
            userDeleted = userListToDelete.Count != 0;

            if (userDeleted)
            {
                StoreData(FilePath, userList);
                Console.WriteLine($"{userListToDelete.Count} users with document number {documentNumber} deleted");
            }
            else
            {
                Console.WriteLine($"No user with document number ${documentNumber}");
            }

            PrintMessage("");
        }

        private static void Main()
        {
            string command;

            LoadData(FilePath, ref UserList);

            do
            {
                Console.WriteLine(
                    "Enter C to enter new date, B to search for date, E to remove date or S to exit");
                command = Console.ReadKey(true).KeyChar.ToString().ToLower();

                switch (command)
                {
                    case "c":
                        {
                            // Cadastrar Usuário

                            if (File.Exists(FilePath) == false)
                            {
                                var database = File.Create(FilePath);
                                database.Close();
                            }

                            if (CreateUser(ref UserList) == Result.Success)
                            {
                                StoreData(FilePath, UserList);
                            }

                            break;
                        }
                    case "s":
                        //Exit
                        PrintMessage("Exit program");
                        break;
                    case "b":
                        // Buscar usuario

                        SearchUser(UserList);
                        break;
                    case "e":
                        //Excluir usuario
                        DeleteUser(ref UserList);
                        break;
                    default:
                        //Opção Inválida
                        PrintMessage("Invalid command");
                        break;
                }
            } while (command != "s");
        }
    }
}
