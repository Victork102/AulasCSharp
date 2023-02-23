using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{

	// interfaces são protítipos/esqueletos de classes
	// estas definem os métodos a serem implementados pela classe

	class Program
	{
		static void Main(string[] args)
		{

			Car myCar = new Car();

			myCar.TurnOn();
			myCar.TurnOff();
			myCar.OpenDoor();
			myCar.CloseDoor();
			myCar.SpeedUp();

			Plane myPlane = new Plane();

			myPlane.TurnOn();
			myPlane.TurnOff();
			myPlane.OpenDoor();
			myPlane.CloseDoor();
			myPlane.FlyOff();
			myPlane.Landing();

			IVehicle myVehicleCarro = new Car(); // desta forma, apenas as classes presentes na Interface estão disponíveis

			myVehicleCarro.TurnOn();
			myVehicleCarro.TurnOff();
			myVehicleCarro.OpenDoor();
			myVehicleCarro.CloseDoor();
			// myVehicleCarro.SpeedUp();

		}
	}
}
