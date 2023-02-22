using System;

namespace OrientaçãoAObjetos
{
	public class Car
	{
		// Atributos/Variaveis

		private string BrandName;
		private string ModelName;
		private UInt16 CarSpeed;
		private bool CarOn;

		// Propriedades

		public string Brand
		{
			get { return BrandName; }
			set { BrandName = value; }
		}
		public string Model
		{
			get { return ModelName; }
			set { ModelName = value; }
		}
		public UInt16 Speed
		{
			get { return CarSpeed; }
			set { CarSpeed = value; }
		}
		public bool IsOn
		{
			get { return CarOn; }
			set { CarOn = value; }
		}

		// Métodos

		public void TurnCarOn()
		{
			IsOn = true;
			Console.WriteLine("Ligando carro da marca " + BrandName + " e modelo " + ModelName);
		}
		public void TurnCarOff()
		{
			IsOn = false;
			Console.WriteLine("Desigando carro da marca " + BrandName + " e modelo " + ModelName);
		}
		public void SpeedUp(UInt16 TargetSpeed)
		{
			if (CarOn == true)
			{
				CarSpeed = TargetSpeed;
				Console.WriteLine("A velocidade do carro marca " + BrandName + " e modelo " + ModelName + " agora é de " + CarSpeed + " Km/h.");
			}
			else
			{
				Console.WriteLine("O carro está desligado. Ligue o carro primeiro.");
			}

		}
		public void StopCar()
		{
			if (CarSpeed == 0)
			{
				Console.WriteLine("O carro já está parado.");
			}
			else
			{
				CarSpeed = 0;
				Console.WriteLine("C carro marca " + BrandName + " e modelo " + BrandName + " agora está parado.");
			}
			
		}

	}
	class Program
	{
		static void Main(string[] args)
		{

			Car Fusca = new Car();
			Fusca.Brand = "Volkswagen";
			Fusca.Model = "Fusca 1300";

			Fusca.TurnCarOn();
			Fusca.SpeedUp(60);
			Fusca.StopCar();
			Fusca.TurnCarOff();

			Console.WriteLine("");

			Car HondaFit = new Car();
			HondaFit.Brand = "Honda";
			HondaFit.Model = "Fit 2014";

			HondaFit.SpeedUp(100);
			HondaFit.TurnCarOn();
			HondaFit.SpeedUp(100);
			HondaFit.StopCar();
			HondaFit.TurnCarOff();



			Console.ReadKey();


		}
	}
}
