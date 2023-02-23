using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaClasse
{
	internal class ChildClass : ParentClass
	{
		public string ChildAttribute = "Atributo da classe filha";

		public string ChildProperty
		{
			set;
			get;
		}
		public void ChildClassMethod()
		{
			Console.WriteLine("Método da classe filha");
		}
		public ChildClass():base("ytytcvytvytvtvt")
		{
			ChildProperty = "Propriedade da classe filha";
		}
		
		
	}
}
