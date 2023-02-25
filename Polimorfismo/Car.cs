using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
	class Car:Vehicle
	{
		override public void Run()
		{
			base.Run();
			Console.WriteLine("The car is running...");
		}
	}
}
