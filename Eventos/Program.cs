using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
	class Program
	{
		static void Main(string[] args)
		{
			Kitchen kitchenBurger = new Kitchen();
			Kitchen kitchenAsian = new Kitchen();

			WaiterOS waiter01 = new WaiterOS("João", kitchenBurger);
			WaiterOS waiter02 = new WaiterOS("Pedro", kitchenBurger);
			WaiterOS waiter03 = new WaiterOS("Maria", kitchenBurger);

			WaiterOS waiter04 = new WaiterOS("Jorge", kitchenAsian);
			WaiterOS waiter05 = new WaiterOS("Mario", kitchenAsian);
			WaiterOS waiter06 = new WaiterOS("Ana", kitchenAsian);

			kitchenBurger.SendOrderReradyMessage(11);
			Console.WriteLine("======================");
			kitchenAsian.SendOrderReradyMessage(25);

			Console.ReadKey();
		}
	}
}
