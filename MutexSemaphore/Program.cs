using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MutexSemaphore
{
	class Program
	{
		//static Mutex mutexTask;

		static Semaphore semTask;

		static void PrintMessage(int numTask)
		{
			//mutexTask.WaitOne();
			semTask.WaitOne();
			for (int i = 0; i <=10; i++)
			{
				Console.WriteLine("Task: "+numTask+ ". Counter: "+i);
				Thread.Sleep(500);
			}
			semTask.Release();
			//mutexTask.ReleaseMutex();
		}

		static void Main(string[] args)
		{
			//mutexTask = new Mutex();
			semTask = new Semaphore(2,2);



			Task tk1 = Task.Run(() => PrintMessage(1));
			Task tk2 = Task.Run(() => PrintMessage(2));
			Task tk3 = Task.Run(() => PrintMessage(3));
			Task tk4 = Task.Run(() => PrintMessage(4));


			Console.ReadKey();
		}
	}
}
