using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait
{
	class Program
	{
		public static string BuyCake(string pChildrenName)
		{
			Console.WriteLine(pChildrenName + " foi no mercado. A hora atual é "+DateTime.Now.ToString("HH:mm:ss tt"));
			Thread.Sleep(2000);
			Console.WriteLine(pChildrenName + " comprou o bolo. A hora atual é " + DateTime.Now.ToString("HH:mm:ss tt"));
			Thread.Sleep(2000);
			Console.WriteLine(pChildrenName + " voltou para casa. A hora atual é " + DateTime.Now.ToString("HH:mm:ss tt"));
			Thread.Sleep(2000);

			return "Abacaxi";
		}

		public static string BuyBaloon(string pChildrenName)
		{
			Console.WriteLine(pChildrenName + " foi no parque. A hora atual é " + DateTime.Now.ToString("HH:mm:ss tt"));
			Thread.Sleep(2000);
			Console.WriteLine(pChildrenName + " comprou balões. A hora atual é " + DateTime.Now.ToString("HH:mm:ss tt"));
			Thread.Sleep(2000);
			Console.WriteLine(pChildrenName + " voltou para casa. A hora atual é " + DateTime.Now.ToString("HH:mm:ss tt"));
			Thread.Sleep(2000);

			return "Azuis";
		}

		//------------------------------------------------------//

		public static async Task<string> ABuyCake(string pChildrenName)
		{
			Console.WriteLine(pChildrenName + " foi no mercado. A hora atual é " + DateTime.Now.ToString("HH:mm:ss tt"));
			await Task.Delay(2000);
			Console.WriteLine(pChildrenName + " comprou o bolo. A hora atual é " + DateTime.Now.ToString("HH:mm:ss tt"));
			await Task.Delay(2000);
			Console.WriteLine(pChildrenName + " voltou para casa. A hora atual é " + DateTime.Now.ToString("HH:mm:ss tt"));
			await Task.Delay(2000);

			return "Abacaxi";
		}

		public static async Task<string> ABuyBaloon(string pChildrenName)
		{
			Console.WriteLine(pChildrenName + " foi no parque. A hora atual é " + DateTime.Now.ToString("HH:mm:ss tt"));
			await Task.Delay(2000);
			Console.WriteLine(pChildrenName + " comprou balões. A hora atual é " + DateTime.Now.ToString("HH:mm:ss tt"));
			await Task.Delay(2000);
			Console.WriteLine(pChildrenName + " voltou para casa. A hora atual é " + DateTime.Now.ToString("HH:mm:ss tt"));
			await Task.Delay(2000);

			return "Azuis";
		}

		public static async void MakeParty()
		{
			Task<string> tkBuyCake = ABuyCake("Ana");
			Task<string> tkBuyBaloons = ABuyBaloon("Jorge");

			string cakeFlavor = await tkBuyCake;
			string baloonColor = await tkBuyBaloons;


			Console.WriteLine("O bolo é de " + cakeFlavor + ".");
			Console.WriteLine("Os balões são " + baloonColor+".");
		}




		static void Main(string[] args)
		{
			//string cakeFlavor = BuyCake("Juliana");
			//string baloonColor = BuyBaloon("Marcos");



			MakeParty();

			

			Console.ReadKey();
		}
	}
}
