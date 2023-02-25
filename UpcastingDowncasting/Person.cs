using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingDowncasting
{
	class Person
	{
		private string name;

		public string Name
		{
			get { return name; }
		}

		public void PrintName()
		{
			Console.WriteLine("O nome da pessoa é: " + Name);
		}

		public Person(string pName)
		{
			name = pName;
		}
	}



}
