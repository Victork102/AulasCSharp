using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_Matematicos_Avançados
{
    class Program
    {
        static void Main(string[] args)
        {

            // Potenciação = .Pow(Numero,Potência)

            double potenciacao = Math.Pow(4, 2);
            Console.WriteLine("Potenciação 4²: "+potenciacao);

            // Radiciação = .Pow(Número,1/'raiz');

            double raiz = 3;
            double radiciacao = Math.Pow(27, 1 / raiz);

            Console.WriteLine("Radiciação √27:" + radiciacao);

            // Maximo e Minimo .Max(num1, num2) .Min(num1, num2)

            double max = Math.Max(4, 8);
            Console.WriteLine("Máximo entre 4 e 8: "+max);

            double min = Math.Min(4, 8);
            Console.WriteLine("Minimo entre 4 e 8: "+min);

            // Modulo = .Abs(num)

            double modulo = Math.Abs(-10);
            Console.WriteLine("Módulo de -10: "+modulo);

            //Operações Trigonométricas:

            // Angulo em Radian = angulo * (2 * Math.PI) / 360
            double angle = 30 * (2 * Math.PI) / 360;

            // Seno = .Sin(num)
            double seno = Math.Sin(angle);

            Console.WriteLine("O seno de 30° é: "+seno);

            // Coseno = .Cos(num)

            double coseno = Math.Cos(angle);
            Console.WriteLine("O coseno de 30° é: " + coseno);


            // Tangente = .Tan(num)

            double tan = Math.Tan(angle);
            Console.WriteLine("A tangente de 30° é: " + tan);

            // Arcseno = .Asin(num)

            double Aseno = Math.Asin(seno);
            double AsenoGraus = Aseno * 360 / (2 * Math.PI);
            Console.WriteLine("O arcseno de "+seno+" é: " + Aseno+", que equivale a: "+AsenoGraus+"°");

            // Arccoseno = .Acos(num)

            double Acos = Math.Acos(coseno);
            double AcosGraus = Acos * 360 / (2 * Math.PI);
            Console.WriteLine("O arccoseno de " + coseno + " é: " + Acos + ", que equivale a: " + AcosGraus + "°");

            // Arctangente = .Atan(num)

            double Atan = Math.Atan(tan);
            double AtanGraus = Atan * 360 / (2 * Math.PI);
            Console.WriteLine("A arctangente de " + tan + " é: " + Atan + ", que equivale a: " + AtanGraus + "°");

            // Arredondamento .Ceiling(num) .Floor(num)

            double num1 = 3.33;
            double arrenumup = Math.Ceiling(num1);

            Console.WriteLine("O arredondamento para cima de " + num1 + " é: " + arrenumup);

            double arrenumdown = Math.Floor(num1);

            Console.WriteLine("O arredondamento para baixo de " + num1 + " é: " + arrenumdown);

            // Logaritmo

            double base10 = Math.Log10(100);
            Console.WriteLine("O logaritmo de base 10 de 100 é: " + base10);

            double baseE = Math.Log(Math.E * Math.E * Math.E * Math.E);
            Console.WriteLine("O logaritmo de base E é: " + baseE);

            Console.ReadKey();
        }
    }
}
