using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadorAbstract
{
	// Modificador abstract
	// Classes abstract podem apenas ser herdadas, e não instanciadas (não podem ser objetos)
	abstract class Person
	{
		//Atributo
		private string name;

		//Propriedade
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		//Metodo
		public void PrintName()
		{
			Console.WriteLine("O nome da pessoa é: "+name);
		}

		public Person(string pName)
		{
			name = pName;
		}
	}
}
