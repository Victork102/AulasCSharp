using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// MODIFICADOR_DE_ACESSO class NOME_DA_CLASSE {}

// Modificadores de acesso
//internal - Classe pode ser acessada apenas pelo Assembly (Executável)
//public  -  Classe pode ser acessada por qualquer um
//private - Classe pode ser acessada apenas pelo bloco de código que o criou

namespace Classes
{

	internal class Car_Internal 
	{
		Car_Public CarPublic = new Car_Public();
	}

	public class Car_Public
	{
		Car_Internal CarInternal = new Car_Internal();
	}

	
	class Program
	{
		private class Car_Private    // Classes privadas só podem existir dentro de outras classes
	{

	}
		static void Main(string[] args)
		{

			//NOME_DA_CLASSE NOME_DO_OBJETO = NEW NOME_DA_CLASSE

			Car_Internal CarInternal = new Car_Internal();
			Car_Public CarPublic = new Car_Public();
			Car_Private CarPrivate = new Car_Private();
			Car_External CarExternal = new Car_External();


		}
	}
}
