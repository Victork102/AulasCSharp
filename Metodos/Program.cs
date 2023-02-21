using System;

namespace Metodos
{




    class Program
    {

        //Declarar método:  tipo_de_acesso modificador_de_instância tipo_de_retorno nome_do_metodo(parâmetros_de_entrada)

        public static double Soma(double a, double b)
        {
            double resSoma = a + b;
            return resSoma;
            // alternativa: return(a+b);
        }

        public static void PrintMessage()
        {
            Console.WriteLine("Este é um Método vazio!");
            Console.WriteLine("Ele não tem parâmetros de entrada ou saída");
        }

        // Modificadores de Parâmetros de Entrada

        /*
         * ref = parâmetro de entrada PODE ser modificado pelo Método
         * out = parâmetro de entrada DEVE ser modificado pelo Método
         */

        public static void Multiplica(double a, double b, ref double resOperacao)
        {
            double resMulti = a * b;
            resOperacao = resMulti;

        }

        static void Main(string[] args)
        {
            // Chamando Métodos

            string opcao;

            while (true)
            {

                Console.WriteLine("C para calcular, M para Método, S para sair");
                opcao = Convert.ToString(Console.ReadKey(true).KeyChar);
                opcao = opcao.ToLower();
                if (opcao == "c")
                {
                    Console.WriteLine("Digite o primeiro número:");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número:");
                    double b = Convert.ToDouble(Console.ReadLine());

                    double res = Soma(a, b);
                    Console.WriteLine(res);
                    Console.ReadKey(true);
                    Console.Clear();
                    continue;
                }
                else if (opcao == "m")
                {
                    PrintMessage();

                    Console.WriteLine("Digite o primeiro número:");
                    double c = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número:");
                    double d = Convert.ToDouble(Console.ReadLine());

                    double resMulti  = 0;
                    Multiplica(c, d, ref resMulti);
                    Console.WriteLine(resMulti);

                    Console.ReadKey();
                    Console.Clear();
                }

                else if (opcao == "s")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("opção Invalida!");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
            }
            
            



            
        }
    }
}
