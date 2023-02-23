using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerançaClasseExemplo
{
	class Car : Vehicles
	{

		// Metodos
		public void SpeedUp(uint pSpeed)
		{
			if (IsOn == true)
			{
				Console.WriteLine("Carro acelerando...");
				Speed = pSpeed;
				Console.WriteLine("Velocidade do carro: " + Speed + "Km/h");

			}
			else
			{
				Console.WriteLine("Carro desligado!");
			}
		}
		public void Stop()
		{
			if (Speed != 0)
			{
				Console.WriteLine("Carro parando...");
				Speed = 0;
				Console.WriteLine("Velocidade do carro: " + Speed + "Km/h");

			}
			else
			{
				Console.WriteLine("Carro já está parado!");
			}
		}

		// Construtor

		public Car(uint pNumWheels, uint pNumDoors) : base(pNumWheels, pNumDoors)
		{

		}
	}
}
