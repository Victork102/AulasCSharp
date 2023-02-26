using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace CarregarDLLDinamicamente
{
	class Program
	{
		static void Main(string[] args)
		{

			// Loading DLL content
			Assembly myDLL = Assembly.LoadFile(@"D:\Repo\AulasCSharp\MyDLL\bin\Debug\MyDLL.dll"); // DLL location
			Type classMathematics = myDLL.GetType("MyDLL.Mathematics"); 
			dynamic objMathematics = Activator.CreateInstance(classMathematics);
			var additionMethod = classMathematics.GetMethod("Addition");


			// Using DLL methods

			double result = (double)additionMethod.Invoke(objMathematics, new object[] { 10, 20 });

			Console.WriteLine(result);

			Console.ReadKey();
		}
	}
}
