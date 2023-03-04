using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Timers
{
	class Program
	{

		// função para evento timer

		static void TimerTick(object sender, EventArgs e)
		{
			Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
		}


		static void Main(string[] args)
		{
			// Criando Timer

			Timer timer = new Timer(1000);
			timer.AutoReset = true;
			// Cadastra evento
			timer.Elapsed += TimerTick;
			// Inicializa Timer
			timer.Start();




			Console.ReadKey();
			// Encerra timer
			timer.Stop();
		}
	}
}
