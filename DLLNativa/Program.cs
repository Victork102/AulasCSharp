using System;
using System.Runtime.InteropServices;

namespace DLLNativa
{

	internal class NativeDLLShell
	{
		[StructLayout(LayoutKind.Sequential)]
		public struct MinhaEstrutura
		{
			public int valor1;
			public double valor2;
			public char valor3;
		}
		
		
		
		
		[DllImport(@"..\..\..\DllLibrary\DLL_Nativa.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern double Soma(double a, double b);
		[DllImport(@"..\..\..\DllLibrary\DLL_Nativa.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern double Media(double[] e, int quantidade);

		[DllImport(@"..\..\..\DllLibrary\DLL_Nativa.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void RecebeVetor([In, Out] int[] Vetor, int Tamanho);

		[DllImport(@"..\..\..\DllLibrary\DLL_Nativa.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool EnviaFrase(char[] Frase);
		[DllImport(@"..\..\..\DllLibrary\DLL_Nativa.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void LimpaMemoria();
		[DllImport(@"..\..\..\DllLibrary\DLL_Nativa.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr RetornaString();
		[DllImport(@"..\..\..\DllLibrary\DLL_Nativa.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr RetornaArrayDeBytes();

		[DllImport(@"..\..\..\DllLibrary\DLL_Nativa.dll", CallingConvention = CallingConvention.Cdecl)]
		//public static extern void RecebeEstrutura(ref MinhaEstrutura minhaEstrutura);
		public static extern void RecebeEstrutura(IntPtr minhaEstrutura);

		[DllImport(@"..\..\..\DllLibrary\DLL_Nativa.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool EnviaEstrutura(ref MinhaEstrutura myStructure);

		[DllImport(@"..\..\..\DllLibrary\DLL_Nativa.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr RetornaEstrutura();


	}
	class Program
	{

		static void Main(string[] args)
		{
			double resultAdd = NativeDLLShell.Soma(10, 20);
			Console.WriteLine("add: " + resultAdd);

			double[] valuesMedia = { 10, 20, 30 };
			double resultMedia = NativeDLLShell.Media(valuesMedia, valuesMedia.Length);
			Console.WriteLine("Media: " + resultMedia);

			int[] meuVetorInt = new int[3];
			NativeDLLShell.RecebeVetor(meuVetorInt, meuVetorInt.Length);
			if (meuVetorInt[0] == 0 && meuVetorInt[1] == 1 && meuVetorInt[2] == 2)
			{
				Console.WriteLine("Sucesso");
			}
			else
			{
				Console.WriteLine("Failure");
			}

			char[] charEnviaFrase1 = ("EnviaFrase").ToCharArray();
			bool resEnviaFrase1 = NativeDLLShell.EnviaFrase(charEnviaFrase1);
			if (resEnviaFrase1)
			{
				Console.WriteLine("Sucesso");
			}
			else
			{
				Console.WriteLine("Failure");
			}

			Console.WriteLine("=======================");

			IntPtr ptrParaString = NativeDLLShell.RetornaString();
			string mystring = Marshal.PtrToStringAnsi(ptrParaString);
			NativeDLLShell.LimpaMemoria();
			Console.WriteLine(mystring);


			IntPtr ptrByteArray = NativeDLLShell.RetornaArrayDeBytes();
			byte[] myByteArray = new byte[3];
			Marshal.Copy(ptrByteArray, myByteArray,0,3);
			NativeDLLShell.LimpaMemoria();
			Console.WriteLine(myByteArray);

			if (myByteArray[0] == 0 && myByteArray[1] == 1 && myByteArray[2] == 2)
			{
				Console
					.WriteLine("Byte Array Sucesso");
			}
			else
			{
				Console.WriteLine("FAILURE!!!");
			}

			//NativeDLLShell.MinhaEstrutura myStructure = new NativeDLLShell.MinhaEstrutura();
			//NativeDLLShell.RecebeEstrutura(ref myStructure);

			IntPtr myStructurePointer = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(NativeDLLShell.MinhaEstrutura)));
			NativeDLLShell.RecebeEstrutura(myStructurePointer);
			NativeDLLShell.MinhaEstrutura minhaEstruturaConvertida = (NativeDLLShell.MinhaEstrutura)Marshal.PtrToStructure(myStructurePointer, typeof(NativeDLLShell.MinhaEstrutura));

			if (minhaEstruturaConvertida.valor1 == 10 && minhaEstruturaConvertida.valor2 == 20 && minhaEstruturaConvertida.valor3 == 30)
			{
				Console.WriteLine("Structure sucesso");
			}
			else Console.WriteLine("Structural FAILURE!!");

			NativeDLLShell.MinhaEstrutura myStructure2 = new NativeDLLShell.MinhaEstrutura();
			myStructure2.valor1 = 10;
			myStructure2.valor2 = 20;
			myStructure2.valor3 = 'a';
			bool returnSending = NativeDLLShell.EnviaEstrutura(ref myStructure2);

			if (returnSending == true)
			{
				Console.WriteLine("Structure DLL sucesso");
			}
			else Console.WriteLine("Structural DLL FAILURE!!");

			IntPtr prtStruct = NativeDLLShell.RetornaEstrutura();
			NativeDLLShell.MinhaEstrutura myStructure3 = new NativeDLLShell.MinhaEstrutura();
			myStructure3 = (NativeDLLShell.MinhaEstrutura)Marshal.PtrToStructure(prtStruct, typeof(NativeDLLShell.MinhaEstrutura));
			NativeDLLShell.LimpaMemoria();

			if (myStructure3.valor1 == 10 && myStructure3.valor2 == 20 && myStructure3.valor3 == 30)
			{
				Console.WriteLine("Structure DLL2 sucesso");
			}
			else Console.WriteLine("Structural DLL2 FAILURE!!");


			Console.ReadKey();
		}
	}
}
