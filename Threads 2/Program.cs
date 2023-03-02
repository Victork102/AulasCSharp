using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threads_2
{
	internal class ThreadParameters
	{
		public  int StartingCounter
		{
			get;
			set;
		}
		public string Name
		{
			get;
			set;
		}

		public ThreadParameters(int pStartingCounter, string pName)
		{
			StartingCounter = pStartingCounter;
			Name = pName;
		}
	}
	class Program
	{	

		public static void MyThreadParameterless()
		{
			int counter = 10;
			do
			{
				Console.WriteLine(counter++);
				Thread.Sleep(250);
			} while (counter < 20);
		}

		public static void MyThread(object pStartingCounter)
		{
			int counter = (int)pStartingCounter;
			do
			{
				Console.WriteLine(counter++);
				Thread.Sleep(250);
			} while (counter <= 20);
		}

		public static void MyThread2(object pThreadParameters)
		{
			ThreadParameters tParameters = (ThreadParameters)pThreadParameters;
			int counter = tParameters.StartingCounter;
			Console.WriteLine(tParameters.Name);
			do
			{
				Console.WriteLine(counter++);
				Thread.Sleep(250);
			} while (counter <= 20);
		}

		static void Main(string[] args)
		{
			Thread t1 = new Thread(new ThreadStart(MyThreadParameterless));
			t1.Start();
			Console.ReadKey();
			Console.Clear();
					

			Thread t2 = new Thread(new ParameterizedThreadStart(MyThread));
			t2.Start(16);
			Console.ReadKey();
			Console.Clear();

			
			Thread t3 = new Thread(new ParameterizedThreadStart(MyThread2));
			ThreadParameters myTParamethers = new ThreadParameters(12, "Maria");
			t3.Start(myTParamethers);
			Console.ReadKey();
			Console.Clear();
		}
	}
}
