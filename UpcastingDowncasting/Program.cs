using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingDowncasting
{
	class Program
	{

		/*Upcasting = é a conversão de um objeto da classe filha para um onjeto da classe mãe;
		 *Downcasting = é a conversão de um objeto da classe mãe para um objeto da classe filha; 
		 */
		static void Main(string[] args)
		{

			//Upcasting

			Worker myWorker = new Worker("João", 10000);
			Person myPerson = myWorker;

			myPerson.PrintName();


			//Downcasting

			// Não funciona; partimos de um contexto que requer apenas Name para um que requer Name e Salary 
			/*Person myPerson2 = new Person("Manuel");
			Worker myWorker2 = (Worker)myPerson2;
			myWorker2.PrintSalary();			
			 */

			// Downcasting funciona apenas se estivermos retornando de um upcasting;
			Worker myWorker2 = new Worker("Alfredo", 10000);
			Person myPerson2 = myWorker2;
			Worker myWorker3 = (Worker)myPerson2;




			Console.ReadKey();
		}
	}
}
