using MyDLL;
using System;

namespace CarregarDLL
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(" A soma de 5 e 6 é " + Mathematics.Addition(5, 6));
			Console.WriteLine(" A multiplicação de 5 e 6 é " + Mathematics.Miltiply(5, 6));

			Console.ReadKey();
		}
	}
}
