using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml;
using System.IO;

namespace NonoProjeto
{
	static class Serializer
	{
		static private DataContractSerializer serializer = new DataContractSerializer(typeof(Database));


		public static void Serialize(string pXmlPath, Database pDatabase)
		{
			// serialize into string

			XmlWriterSettings xmlSettings = new XmlWriterSettings { Indent = true };
			StringBuilder stringBuilder = new StringBuilder();
			XmlWriter xmlWriter = XmlWriter.Create(stringBuilder, xmlSettings);
			serializer.WriteObject(xmlWriter, pDatabase);
			xmlWriter.Flush();
			string serializedObject = stringBuilder.ToString();
			xmlWriter.Close();

			// create xml file

			FileStream myXMLFile = File.Create(pXmlPath);
			myXMLFile.Close();
			File.WriteAllText(pXmlPath, serializedObject);



		}

		public static Database Deserialize(string pXmlPath)
		{
			try 
			{
				if (File.Exists(pXmlPath))
				{
					string serializedObjectContent = File.ReadAllText(pXmlPath);
					StringReader stringReader = new StringReader(serializedObjectContent);
					XmlReader xmlReader = XmlReader.Create(stringReader);
					Database tempDatabase = (Database)serializer.ReadObject(xmlReader);
					return tempDatabase;
				}
				else
					return null;
			}
			catch 
			{
				return null;
			}
		}
	}
}
