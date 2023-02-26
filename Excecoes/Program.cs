using System;

namespace Excecoes
{
	internal class Joao
	{
		public void PrintName()
		{
			Console.WriteLine("João");
		}

	}
	class Program
	{
		static void PositiveCheck(int pNum)
		{
			if (pNum < 0)
			{
				throw new NegativeNumberException(pNum);
			}
		}

		static Joao joao;
		static void Main(string[] args)
		{


			try
			{
				Console.WriteLine("Digite numerador");
				int numerator = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Digite denominador");
				int denominator = Convert.ToInt32(Console.ReadLine());
				int result = numerator / denominator;
				PositiveCheck(result);
				Console.WriteLine("O resultado da divisão é: " + result);



				joao = new Joao();
				joao.PrintName();




			}
			catch (NegativeNumberException e)
			{
				Console.WriteLine(e.Message);
			}

			catch (DivideByZeroException)
			{
				Console.WriteLine("Não é possivel dividir por zero");
			}
			catch (NullReferenceException)
			{
				Console.WriteLine("Objeto não instanciado");
			}

			catch (Exception e)
			{
				Console.WriteLine("ERRO: " + e.Message);
			}
			finally // Opcional, porém sempre executado case exista
			{
				Console.WriteLine("Pressione qualquer tecla para retornar");
				Console.ReadKey();
			}
		}











	}
}
