using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
	class WaiterOS
	{
		private string name;

		public void PrintMessageOrderReady(object source, EventArgsOrderReady e)
		{
			Console.WriteLine("Pedido Nº"+ e.OrderNum +" pronto para retirada, "+name );

		}

		public WaiterOS(string pName,Kitchen pKitchen)
		{
			name = pName;
			pKitchen.OrderReadyMessageEvent += PrintMessageOrderReady;
		}
	}
}
