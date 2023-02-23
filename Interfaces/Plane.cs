using System;

namespace Interfaces
{
	class Plane : IVehicle
	{
		public void TurnOn()
		{
			Console.WriteLine("Avião está ligado;");
		}
		public void TurnOff()
		{
			Console.WriteLine("Avião está desligado;");
		}
		public void OpenDoor()
		{
			Console.WriteLine("A porta do Avião está aberta;");
		}
		public void CloseDoor()
		{
			Console.WriteLine("A porta do Avião está fechada;");
		}
		public void FlyOff()
		{
			Console.WriteLine("O avião decolou!");
		}
		public void Landing()
		{
			Console.WriteLine("O avião pousou!");
		}
	}
}
