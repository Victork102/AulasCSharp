using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaClasse
{

	
	class ParentClass
	{	
		
		public string ParentAttribute = "Atributo da classe mãe";

		public /*protected*/ string ParentProperty // modificador "protected" impede que o método/atributo seja acessado externamente, com exceção das classes filhas;
		{
			set;
			get;
		}
		public void ParentClassMethod()
		{
			Console.WriteLine("Método da classe mãe");
		}

		public ParentClass(string pParentProperty)
		{
			ParentProperty = pParentProperty;
		}
	}
}
