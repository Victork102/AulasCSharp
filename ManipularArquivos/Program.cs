using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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


			Console.ReadKey();
		}
	}
}
