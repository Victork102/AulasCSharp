using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OitavoProjeto
{
	class UserData
	{
		// Atributos
		private string fullName;
		private string numDoc;
		private DateTime birthDay;
		private string streetName;
		private UInt16 numHouse;



		// Propriedades

		

		public string Name
		{
			get { return fullName; }
			set { fullName = value; }
		}
		public string NumDoc
		{
			get { return numDoc; }
			set { numDoc = value; }
		}
		public DateTime Birthday
		{
			get { return birthDay; }
			set { birthDay = value; }
		}
		public string StreetName
		{
			get { return streetName; }
			set { streetName = value; }
		}
		public UInt16 NumHouse
		{
			get { return numHouse; }
			set { numHouse = value; }
		}


		// Construtor
		public UserData(string pName, string pNumDoc, DateTime pBirthday, string pStreetName, ushort pNumHouse)
		{
			Name = pName;
			NumDoc = pNumDoc;
			Birthday = pBirthday;
			StreetName = pStreetName;
			NumHouse = pNumHouse;
		}

		





	}
}
