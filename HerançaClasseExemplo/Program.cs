using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerançaClasseExemplo
{
	class Program
	{
		static void Main(string[] args)
		{

			Car Fusca = new Car(4, 4);
			Plane TecoTeco = new Plane(3, 2);

			Fusca.TurnOn();
			Fusca.SpeedUp(60);
			Fusca.Stop();
			Fusca.TurnOff();

			Console.WriteLine("===============");

			TecoTeco.TurnOn();
			TecoTeco.FlyOff(200, 100);
			TecoTeco.Landing();
			TecoTeco.TurnOff();


			Console.ReadKey();
		}
	}
}
