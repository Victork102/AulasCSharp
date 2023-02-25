using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadorAbstract
{
	class Worker:Person
	{
		// atributos
		private UInt32 salary;
		// propriedade
		public UInt32 Salary
		{
			get { return salary; }
			set { salary = value; }
		}
		// metodo
		public void PrintSalary()
		{
			Console.WriteLine("O salario do funcionario " + Name + " é: R$" + Salary);
		}



			//Constructor
		public Worker(string pName, UInt32 pSalary) : base(pName)
		{
			salary = pSalary;
		}

	}
}
