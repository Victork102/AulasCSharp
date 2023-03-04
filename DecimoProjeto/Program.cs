using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimoProjeto
{
	class Program
	{
		static void Main(string[] args)
		{
			Database database = new Database(@"Database.xml");
			UI ProgramUI = new UI(database);
			ProgramUI.InitializeUI();
		}
	}
}
