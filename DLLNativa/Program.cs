using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace DLLNativa
{

	internal class NativeDLLShell
	{
		[DllImport(@"D:\Repo\AulasCSharp\DllLibrary\DLL_Nativa.dll")]
		public static extern double Soma(double a, double b);
	}
	class Program
	{
		static void Main(string[] args)
		{
		}
	}
}
