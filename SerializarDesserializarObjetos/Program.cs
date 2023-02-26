using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Runtime.Serialization;

namespace SerializarDesserializarObjetos
{
	class Program
	{
		static void Main(string[] args)
		{
			Dog myDog = new Dog("Bilu", "Boxer", "Marrom");
			Dog myDogDeserial;

			DataContractSerializer serializer = new DataContractSerializer(typeof(Dog));

			// Serialização

				// configura xml
			XmlWriterSettings xmlConfig = new XmlWriterSettings { Indent = true };

				// converte xml em string
			StringBuilder stringBuilder = new StringBuilder();

				//escreve o xml
			XmlWriter xmlWriter = XmlWriter.Create(stringBuilder,xmlConfig);

			serializer.WriteObject(xmlWriter,myDog);

			xmlWriter.Flush(); // finaliza escrita de xml

			string objSerial = stringBuilder.ToString();


			// salvando conteudo em arquivo .xml

			string xmlFilePath = @"Dog.xml";
			FileStream myXML = File.Create(xmlFilePath);
			myXML.Close();

			File.WriteAllText(xmlFilePath, objSerial);


			// Deserialização

			string serialObjectContent = File.ReadAllText(xmlFilePath);
			StringReader stringReader = new StringReader(serialObjectContent);
			XmlReader xmlReader = XmlReader.Create(stringReader);
			myDogDeserial = (Dog)serializer.ReadObject(xmlReader);

			xmlWriter.Close();
			xmlReader.Close();






			Console.ReadKey();
		}
	}
}
