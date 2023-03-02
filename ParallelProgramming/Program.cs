using System;
using System.Threading;

namespace ParallelProgramming
{
	class Program
	{
		static Thread t1;
		static Thread t2;
		static bool canEnd;
		static UInt16 numThread;
		static object objLock;
		static Mutex myMutex;
		static void MyThread1()
		{
			try
			{
				while (canEnd == false)
				{
					//lock (objLock)

					//{
						myMutex.WaitOne();
						numThread = 1;
						Thread.Sleep(1000);
						Console.WriteLine("Thread 1:  passou 1 segundo. NumThread: " + numThread);
					myMutex.ReleaseMutex();
					//}
				}
				Console.WriteLine("Thread 1 finalizando...");
			}
			catch (ThreadAbortException)
			{
				Console.WriteLine("Thread 1 finalizada");
			}
		}


		static void MyThread2()
		{
			try
			{try
				{
					while (canEnd == false)
					{
						//lock (objLock)
						//{

						myMutex.WaitOne();
							numThread = 2;
							Thread.Sleep(1000);
							Console.WriteLine("Thread 2:  passou 1 segundo. NumThread: " + numThread);
						myMutex.ReleaseMutex();
						//}
					}
					Console.WriteLine("Thread 2 finalizando...");
				}
				catch (ThreadAbortException) { Console.WriteLine("Thread 1 finalizada"); }
			}
			catch (ThreadAbortException)
			{
				Console.WriteLine("Thread 2 finalizada");
			}
		}





		static void Main(string[] args)
		{
			// O método Sleep serve para pausar e execução por um tempo determinado em millisegundos

			/*for (int i = 0; i < 5; i++)
			{
				Thread.Sleep(1000);
				Console.WriteLine("Passou 1 segundo");
			}*/

			objLock = new object();
			myMutex = new Mutex();

			canEnd = false;

			t1 = new Thread(new ThreadStart(MyThread1));
			t1.Priority = ThreadPriority.Highest;
			t2 = new Thread(new ThreadStart(MyThread2));
			t2.Priority = ThreadPriority.BelowNormal;

			t1.Start();
			t2.Start();



			Console.ReadKey();
			canEnd = true;
			//t1.Abort();
			//t2.Abort();

			Console.WriteLine("Pressione Qualquer tecla para sair");
			Console.ReadKey();
		}
	}
}
