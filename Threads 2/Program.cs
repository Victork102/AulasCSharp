using System;
using System.Threading;

namespace Threads_2
{
	internal class ThreadParameters
	{
		public int StartingCounter
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

		public static void MyThread3(int pStartingCounter, string pName)
		{
			
			int counter = pStartingCounter;
			Console.WriteLine(pName);
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

			Thread t4 = new Thread(()=>MyThread3(13,"Valéria"));			
			t4.Start();
			Console.ReadKey();
			Console.Clear();

			int i = 14;
			string n = "Ana";

			Thread t5 = new Thread(() =>
			{
				
				int counter = i;
				Console.WriteLine(n);
				do
				{
					Console.WriteLine(counter++);
					Thread.Sleep(250);
				} while (counter <= 20);

			});
			t5.Start();
			Console.ReadKey();
			Console.Clear();
		}
	}
}
