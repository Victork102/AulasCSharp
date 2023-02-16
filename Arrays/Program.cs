using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // array 1 dim
            int[] Array1 = new int[3];

            Array1[0] = 1;
            Array1[1] = 10;
            Array1[2] = 100;

            Console.WriteLine(Array1[0]);
            Console.WriteLine(Array1[1]);
            Console.WriteLine(Array1[2]);

            // Outras maneirar criar array

            int[] Array2 = { 1, 10, 100 };

            Console.WriteLine(Array2[0]);
            Console.WriteLine(Array2[1]);
            Console.WriteLine(Array2[2]);

            int[] Array3 = new int[] { 2, 4, 6 };

            Console.WriteLine(Array3[0]);
            Console.WriteLine(Array3[1]);
            Console.WriteLine(Array3[2]);

            // Array 2 dim

            string[,] array4 = new string[2, 3];

            array4[0, 0] = "1";
            array4[0, 1] = "2";
            array4[0, 2] = "3";
            array4[1, 0] = "4";
            array4[1, 1] = "5";
            array4[1, 2] = "6";


            Console.WriteLine(array4[0, 0]);
            Console.WriteLine(array4[0, 1]);
            Console.WriteLine(array4[0, 2]);
            Console.WriteLine(array4[1, 0]);
            Console.WriteLine(array4[1, 1]);
            Console.WriteLine(array4[1, 2]);

            // outras maneiras de criar

            string[,] array5 = { { "1", "2", "3" }, { "10", "11", "12" } };


            Console.WriteLine(array5[0, 0]);
            Console.WriteLine(array5[0, 1]);
            Console.WriteLine(array5[0, 2]);
            Console.WriteLine(array5[1, 0]);
            Console.WriteLine(array5[1, 1]);
            Console.WriteLine(array5[1, 2]);

            string[,] array6 = new string[,] { { "1", "2", "3" }, { "10", "11", "12" } };

            Console.WriteLine(array6[0, 0]);
            Console.WriteLine(array6[0, 1]);
            Console.WriteLine(array6[0, 2]);
            Console.WriteLine(array6[1, 0]);
            Console.WriteLine(array6[1, 1]);
            Console.WriteLine(array6[1, 2]);


            // numero de elementos de array

            int tamanho1 = array6.GetLength(0);
            int tamanho2 = array6.GetLength(1);

            Console.WriteLine("A primeira dimensão de Array6 possui " + tamanho1 + " elementos;");
            Console.WriteLine("A segunda dimensão de Array6 possui " + tamanho2 + " elementos;");

            // array N dim

            int[,,] array7 = new int[2, 2, 2];
            array7[0, 0, 0] = 10;

            Console.WriteLine(array7[0, 0, 0]);

            Console.ReadKey();
        }
    }
}
