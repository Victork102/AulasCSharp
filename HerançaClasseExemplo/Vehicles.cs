using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerançaClasseExemplo
{
	internal class Vehicles
	{

		// Atributos
		private uint numWheels;
		private uint numDoors;
		private uint speed;
		private bool isOn;

		// Propriedades

		public uint NumWheels
		{
			get { return numWheels;}
		}
		public uint NumDoors
		{
			get { return numDoors; }
		}
		public uint Speed
		{
			get { return speed; }
			set { speed = value; }
		}
		public bool IsOn
		{
			get { return isOn; }
			//set { isOn = value; }
		}

		// Metodos

		public void TurnOn()
		{
			Console.WriteLine("Veículo Ligado!");
		}
		public void TurnOff()
		{
			Console.WriteLine("Veículo desigado!");
		}

		// Construtor

		public Vehicles(uint numWheels, uint numDoors)
		{
			this.numWheels = numWheels;
			this.numDoors = numDoors;
			speed = 0;
			isOn = false;

		}
	}
}
