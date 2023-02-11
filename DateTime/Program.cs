using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //Date Time
            DateTime data = new DateTime(2023, 02, 11);
            DateTime dataHora = new DateTime(2023, 02, 11, 22, 05, 33);


            Console.WriteLine(data.ToString());
            Console.WriteLine(dataHora.ToString());

            Console.WriteLine("");

            //Para acessar cada campo individualmente

            Console.WriteLine("O ano é: " + dataHora.Year);
            Console.WriteLine("O mês é: " + dataHora.Month);
            Console.WriteLine("O dia é: " + dataHora.Day);
            Console.WriteLine("O horário é: " + dataHora.Hour +" horas,"+ dataHora.Minute +" minutos e "+ dataHora.Second + " segundos." );
            Console.WriteLine("Esse dia foi uma " + dataHora.DayOfWeek + ", e foi o " + dataHora.DayOfYear + "° dia do ano.");

            Console.WriteLine("");
            //Data e Hora Atual


            DateTime dataHoraNow = DateTime.Now;



            Console.WriteLine("A data e hora atual é: "+dataHoraNow);

            Console.WriteLine("");
            // String to Datetime

            DateTime dataConv = Convert.ToDateTime("22/11/2030 14:10:25");

            Console.WriteLine(dataConv);
            Console.WriteLine("O ano é: " + dataConv.Year);
            Console.WriteLine("O mês é: " + dataConv.Month);
            Console.WriteLine("O dia é: " + dataConv.Day);
            Console.WriteLine("O horário é: " + dataConv.Hour + " horas," + dataConv.Minute + " minutos e " + dataConv.Second + " segundos.");
            Console.WriteLine("Esse dia foi uma " + dataConv.DayOfWeek + ", e foi o " + dataConv.DayOfYear + "° dia do ano.");
            Console.WriteLine("");


            //Formatar Data e Hora

            Console.WriteLine(dataConv.ToString("yyyy/MM"));
            Console.WriteLine(dataConv.ToString("ddd dd/MM/yyy HH:mm:ss"));
            Console.WriteLine("");

            //Operações DateTime

            DateTime dataHora2 = new DateTime(2020,09,27,14,05,20);

            Console.WriteLine(dataHora2.ToString("dd/MM"));
            dataHora2 = dataHora2.AddDays(4);
            Console.WriteLine(dataHora2.ToString("dd/MM"));

            dataHora2 = dataHora2.Add(new TimeSpan(4,1, 55, 30));
            Console.WriteLine(dataHora2.ToString("dd/MM HH:mm:ss"));


            // Subtrair datas

            DateTime dataHora3 = new DateTime(2022, 3, 1, 14, 5, 20);
            dataHora3 = dataHora3.Subtract(new TimeSpan(1, 5, 20));
            Console.WriteLine(dataHora3);

            Console.WriteLine("--------------");

            TimeSpan difSpan = dataHora3.Subtract(dataHora2);
            DateTime subtractDate = dataHora3 - difSpan;
            Console.WriteLine(dataHora3);
            Console.WriteLine(difSpan);
            Console.WriteLine(subtractDate);

            Console.WriteLine("-------------");
            //ou

            dataHora3 = dataHora3.AddDays(-2);
            Console.WriteLine(dataHora3);




            Console.WriteLine("");
            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadKey(true);
        }
    }
}
