using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {

        struct dadosCadastrais
        {
            public string Nome;
            public string NomeRua;
            public UInt32 NumeroCasa;
            public DateTime DataNasc;
        }





        static void Main(string[] args)
        {

            dadosCadastrais meuCadastro;

            meuCadastro.Nome = "João";
            meuCadastro.NomeRua = "Av A";
            meuCadastro.NumeroCasa = 12;
            meuCadastro.DataNasc = Convert.ToDateTime("22 / 10 / 2021");

            Console.WriteLine(meuCadastro.Nome);
            Console.WriteLine(meuCadastro.NomeRua);
            Console.WriteLine(meuCadastro.NumeroCasa);
            Console.WriteLine(meuCadastro.DataNasc.Day+"/"+meuCadastro.DataNasc.Month+"/"+meuCadastro.DataNasc.Year);






            Console.ReadKey();

        }
    }
}
