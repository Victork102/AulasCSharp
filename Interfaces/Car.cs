using System;

namespace Interfaces
{
	class Car : IVehicle
	{
		public void TurnOn()
		{
			Console.WriteLine("Carro está ligado;");
		}
		public void TurnOff()
		{
			Console.WriteLine("Carro está desligado;");
		}
		public void OpenDoor()
		{
			Console.WriteLine("A porta do carro está aberta;");
		}
		public void CloseDoor()
		{
			Console.WriteLine("A porta do carro está fechada;");
		}
		public void SpeedUp()
		{
			Console.WriteLine("Vrooooommm!!!");
		}
	}
}
