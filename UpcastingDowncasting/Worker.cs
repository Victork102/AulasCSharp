using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingDowncasting
{
	class Worker:Person
	{
		private uint salary;

		public void PrintSalary()
		{
			Console.WriteLine("O salário de " + Name + " é de R$" + salary);
		}

		public Worker(string pName, uint pSalary) : base(pName)
		{
			salary = pSalary;;
		}
	}
}
