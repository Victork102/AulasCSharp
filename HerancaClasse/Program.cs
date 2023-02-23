using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaClasse
{
	class Program
	{
		static void Main(string[] args)
		{

			ChildClass objChild = new ChildClass();
			objChild.ChildClassMethod();
			objChild.ParentClassMethod();
			Console.WriteLine("================");
			Console.WriteLine(objChild.ParentAttribute);
			Console.WriteLine(objChild.ParentProperty);
			



			Console.ReadKey();
		}
	}
}
