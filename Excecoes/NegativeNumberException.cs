using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excecoes
{
	public class NegativeNumberException : Exception
	{
		public NegativeNumberException(int pNum) : base("Número " + pNum + " não é positivo")
		{
			
		}
	}
}
