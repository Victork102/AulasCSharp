using System;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks
{
	class Program
	{
		static int PrintMessage(int pStartingCounter)
		{
			for (int i = pStartingCounter; i <= 10; i++)
			{
				Console.WriteLine("Eu sou uma task: " + i + " Iterações;");
				Thread.Sleep(500);
			}
			return 10;
		}
		static void Main(string[] args)
		{
			int resTask = 0;
			Task tkPrintMessage = Task.Run(() => resTask = PrintMessage(2));
			Console.WriteLine(resTask);
			if (tkPrintMessage.Wait(500) == false)
			{
				Console.WriteLine("===================");
				Console.WriteLine("Task não finalizada");
				Console.WriteLine("===================");
			}
			else
			{
				Console.WriteLine(resTask);
			}

			for (int i = 1; i <= 10; i++)
			{
				Console.WriteLine("Eu sou a thread Main: " + i + " Iterações;");
				Thread.Sleep(500);
			}






			Console.ReadKey();
		}
	}
}
