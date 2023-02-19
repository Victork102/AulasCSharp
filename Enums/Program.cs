using System;

namespace Enums
{
    class Program
    {

        // Declarando Enum
        enum notasReal_e
        {
            Nota2 = 2,   // Valores Inteiros Apenas; 
            Nota5 = 5,
            Nota10 = 10,
            Nota20 = 20,
            Nota50 = 50,
            Nota100 = 100,
            Teste = 3 * 22,
            Nota200 = 200
        };

        enum NotaDaProva_e
        {
            Nota_1 = -1,
            NotaO,
            Nota1,
            Nota2,
            Nota3,
            Nota4,
            Nota5,
            Nota6,
            Nota7,
            Nota8,
            Nota9,
            Nota10
        }


        static void Main(string[] args)
        {




            notasReal_e minhasNotas = notasReal_e.Teste;

            Console.WriteLine(minhasNotas + " vale " + Convert.ToInt32(minhasNotas));


            NotaDaProva_e minhaNota = NotaDaProva_e.Nota4;
            Console.WriteLine(minhaNota + " vale " + Convert.ToInt32(minhaNota));


            Console.ReadKey();
        }
    }
}
