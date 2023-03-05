using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadorStatic
{

	// Modificador static (estático/fixo) - é utilizado apos modificador de acesso
	// pode ser usado em: atributos, métodos, classes, structs, classes etc

	public class Person
	{
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}


		// Para acessar parâmetros não-static através de método static, estes devem ser informados como parâmetro de entrada atraves de um objeto
		public static void PrintName(Person pPerson)
		{
			Console.WriteLine("O nome é: " + pPerson.name);
		}

		public Person(string pName)
		{
			name = pName;
		}
	}

	// todos os itens de uma classe static devem ser static
	public static class Calculator
	{

		// atributos static pertencem à classe, e não ao objeto

		public static double Pi = 3.1415;
		public static double CalculateCircleArea(double pRadius)
		{
			return Pi * Math.Pow(pRadius, 2);
		}
	}


	// this - é utilizado para referir-se àquilo que pertence a classe
	public class myPerson
	{
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public void PrintName()
		{
			Console.WriteLine("O nome é: " + name);
		}

		public myPerson(string name)
		{
			this.name = name;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{

			Person pessoa1 =new Person("Jonas");
			Person pessoa2 =new Person("Pedro");

			Console.WriteLine(Calculator.Pi);
			Console.WriteLine(Calculator.CalculateCircleArea(2));

			//Calculator calc1 = new Calculator();

			Console.WriteLine("========================");

			// Metodos static apenas podem ser chamados através da classe estando inacessivel através de instâncias de objeto
			//calc1.Pi();

			Person.PrintName(pessoa1);

		}
	}
}
