using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
	class Bike:Vehicle
	{
		public override void Run()
		{
			Console.WriteLine("The bike is running...");
		}
	}
}
