using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
	class Program
	{
		static void Main(string[] args)
		{

			Car objCar = new Car();
			Bike objBike = new Bike();


			objCar.Run();
			objBike.Run();




			Console.ReadKey();
		}
	}
}
