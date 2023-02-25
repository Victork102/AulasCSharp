using System.Runtime.Serialization;

namespace SerializarDesserializarObjetos
{
	[DataContract]
	class Dog
	{
		[DataMember]
		public string name { get; set; }
		[DataMember]
		public string race;
		[DataMember]
		private string color;


		public Dog(string pName, string pRace, string pColor)
		{
			name = pName;
			race = pRace;
			color = pColor;
		}

		public Dog() { }

	}
}
