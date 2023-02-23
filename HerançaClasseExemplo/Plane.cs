using System;

namespace HerançaClasseExemplo
{
	class Plane : Vehicles
	{
		//Atributos

		private uint altitude;



		// Properties

		public uint Altitude
		{
			get { return altitude; }
		}

		// Metodos

		public void FlyOff(uint pSpeed, uint pAltitude)
		{
			if (IsOn == true)
			{
				Console.WriteLine("Decolando...");
				altitude = pAltitude;
				Speed = pSpeed;
				Console.WriteLine("Velocidade do avião: " + Speed + " || Altitude do avião: " + altitude);
			}
			else
			{
				Console.WriteLine("Avião desligado!");
			}
		}

		public void Landing()
		{
			if (Speed != 0)
			{
				Console.WriteLine("Pousando...");
				altitude = 0;
				Speed = 0;
				Console.WriteLine("O Avião pousou");
					}
			else
			{
				Console.WriteLine("Avião já esta aterrissado");
			}
		}

		//Construtor

		public Plane(uint pNumWheels, uint pNumDoors):base(pNumWheels,pNumDoors)
		{
			altitude = 0;
		}
	}
}
