using System;
using System.IO;

namespace ManipularArquivos
{
	class Program
	{
		static void Main(string[] args)
		{

			// Criando caminhos de arquivo

			// método 1

			string caminho1 = "D:\\C#\\Aulas\\teste1.txt";

			// método 2

			string caminho2 = @"D:\C#\Aulas\teste2.txt";

			// Criar arquivo

			FileStream meuArquivo1 = File.Create(caminho1);
			meuArquivo1.Close();

			FileStream meuArquivo2 = File.Create(caminho2);
			meuArquivo2.Close();

			// Verificar se arquivo existe

			bool arquivo1 = File.Exists(caminho1);
			bool arquivo2 = File.Exists(caminho2);


			Console.WriteLine("Arquivo 1 existe? " + arquivo1 + " || Arquivo 2 existe: " + arquivo2);

			// Deletando Arquivos

			File.Delete(caminho1);

			arquivo1 = File.Exists(caminho1);

			Console.WriteLine("Arquivo 1 existe? " + arquivo1 + " || Arquivo 2 existe: " + arquivo2);

			// Renomear/Mover Arquivos

			string caminho3 = "D:\\C#\\Aulas\\Nomes.txt";

			File.Delete(caminho3);
			File.Move(caminho2,caminho3);


			// Escrever em arquivo .txt

			FileStream meuArquivo3 = File.Create(caminho3);
			meuArquivo3.Close();

			string conteudo = "Marcos é um cara legal.\r\nPedro é um baita c**ão!";
			File.WriteAllText(caminho3,conteudo);

			// Escrever Array de Strings em arquivo .txt

			string[] conteudoArray = { "Guilherme","Marcos","Pedro","Maria" };

			File.WriteAllLines(caminho3, conteudoArray);

			// Lendo Conteúdo de um arquivo .txt

			string conteudoFile = File.ReadAllText(caminho3);

			Console.WriteLine(conteudoFile);


			//	Gravando conteúdo de arquivo em Array de Strings

			Console.WriteLine("===================");
			string[] conteudoLido = File.ReadAllLines(caminho3);

			foreach (string n in conteudoLido)
			{
				Console.WriteLine(n);
			}


			// Adicionando texto em arquivo .txt já criado

			string caminho4 = @"D:\C#\Aulas\Nomes2.txt";
			string[] apende = {"Jorge", "Matheus", "Pedro" };

			File.AppendAllLines(caminho4, apende);



			

			Console.ReadKey();
		}
	}
}
