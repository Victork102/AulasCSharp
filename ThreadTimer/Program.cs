using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadTimer
{
	class Program
	{
		// metodo executado pelo timer
		static void TimerTick(object state)
		{
			Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
		}





		static void Main(string[] args)
		{
			//criando timer
			TimerCallback tcb = new TimerCallback(TimerTick);
			Timer myTimer = new Timer(tcb, null, 0, 1000);
			
			Console.ReadKey();

			// encerra timer
			myTimer.Dispose();
		}
	}
}
