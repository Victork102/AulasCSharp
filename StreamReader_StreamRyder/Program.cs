using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamReader_StreamWriter
{
	class Program
	{
		static void Main(string[] args)
		{

			string caminho = "teste.txt";
			FileStream fs = File.Create(caminho);
			fs.Close();

			StreamWriter sw = new StreamWriter(caminho);
			sw.Write('a');
			sw.Write('-');
			sw.Write("Olá Mundo!\r\n");
			sw.Write("Como vai?\r\n");

			sw.WriteLine("Tudo em cima?");
			sw.WriteLine("Belezinha?");

			sw.Close();


			StreamReader sr1 = new StreamReader(caminho);

			char[] buffer = new char[128];
			sr1.Read(buffer,4,5);
			sr1.Read(buffer, 8, 7);
			sr1.Close();

			StreamReader sr2 = new StreamReader(caminho);

			string linha = sr2.ReadLine();
			linha = sr2.ReadLine();

			StreamReader sr3 = new StreamReader(caminho);

			string arquivoInteiro = sr3.ReadToEnd();

			sr1.Close();
		}
	}
}
