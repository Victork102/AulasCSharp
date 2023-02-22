using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtributosClasse
{
	public class Car
	{
		// MODIFICADOR_DE_ACESSO TIPO_DO_ATRIBUTO NOME_DO_ATRIBUTO
		// public - Pode ser acessado externamente à classe
		// private - Apenas pode ser acessado internamente à classe

		public string brand;
		private double speed = 0;
		private bool carOn = false;

		//Propriedades
		//MODIFICADOR_DE_ACESSO TIPO NOME
		//{
		//	get { return ATRIBUTO; } - Retorna o conteúdo do Atributo
		//  set { ATRIBUTO = value; } - Altera o contaúdo do Atributo
		//}

		public bool CarOn
		{
			get { return carOn; }
			set { 
				if (speed == 0)
				{
				carOn = value;
				}
				else
				{
					return;
				}
				 
			}
		}
		public double CarSpeed
		{
			get { return speed; }
			set
			{
				if (carOn == true)
				{
					speed = value;
				}
				else
				{
					return;
				}

			}
		}
		public void SpeedSetting(double TargetSpeed)
		{
			speed = TargetSpeed;
		}

		public uint NumPortas
		{
			get;
			set;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{

			Car MyCar = new Car();
			MyCar.CarOn = true;
			MyCar.CarSpeed = 100;
			MyCar.CarOn = false;
			MyCar.NumPortas = 4;

		}
	}
}
