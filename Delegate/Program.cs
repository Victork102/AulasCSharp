using System;

namespace Delegate
{
	class Program
	{

		// Declarando Delegate: tipo_de_acesso delegate tipo_de_dado nome(Parâmetros);
		public delegate double MeuDelegateOperacoes(double a, double b);
		public static double Soma(double a, double b)
		{
			double resSoma = a + b;
			Console.WriteLine("A soma de " + a + " mais " + b + " é igual a " + resSoma);
			return resSoma;
		}
		public static double Multiplicar(double a, double b)
		{
			double resMulti = a * b;
			Console.WriteLine("A multiplicação de " + a + " por " + b + " é igual a " + resMulti);
			return resMulti;
		}
		public static double Divisao(double a, double b)
		{
			double resDiv = a / b;
			Console.WriteLine("A divisão de " + a + " por " + b + " é igual a " + resDiv);
			return resDiv;
		}

		public static void ExecutaOperação(MeuDelegateOperacoes minhasOperacoes)
		{
			Console.WriteLine("Executamdo Metodo passado como Parâmetro de Entrada.");
			minhasOperacoes(50, 20);
		}
		static void Main(string[] args)
		{

			MeuDelegateOperacoes minhasOperacoes;

			minhasOperacoes = Soma;

			double resDelegate = minhasOperacoes(10, 20);

			Console.WriteLine("O resultado do Delegate é: " + resDelegate);

			Console.WriteLine("=============");

			minhasOperacoes += Multiplicar;
			minhasOperacoes += Divisao;

			resDelegate = minhasOperacoes(30, 5);
			Console.WriteLine("O resultado do Delegate é: " + resDelegate);

			Console.WriteLine("=============================");

			ExecutaOperação(Multiplicar);




			Console.ReadKey();
		}
	}
}
