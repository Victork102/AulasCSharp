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

		public string Brand;
		private double Speed;

		public void SpeedSetting(double TargetSpeed)
		{
			Speed = TargetSpeed;
		}

	}
	class Program
	{
		static void Main(string[] args)
		{

			Car MyCar = new Car();
			MyCar.Brand = "Honda";
			
		}
	}
}
