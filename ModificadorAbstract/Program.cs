using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadorAbstract
{
	class Program
	{
		static void Main(string[] args)
		{
			//Classes abstratas não podem ser instanciadas;
			// Person myPerson = new Person("João");

			Worker myWorker = new Worker("João", 10000);
			myWorker.PrintName();
			myWorker.PrintSalary();


			Console.ReadKey();
		}
	}
}
