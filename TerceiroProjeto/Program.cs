using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerceiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {


            while (true)
            {



                // Opções
                string opcao;


                Console.WriteLine("Cadastro de Usuário");
                Console.WriteLine("Pressione C para cadastrar novo usuário ou S para sair");
                Console.WriteLine("");

                opcao = Convert.ToString(Console.ReadKey(true).KeyChar);
                opcao = opcao.ToLower();


                if (opcao == "c")
                {


                    // Vars


                    string nomeCompleto = "";
                    string genero = "";
                    DateTime dataNasc = new DateTime();
                    string endRua = "";
                    int endNum = 0;
                    int idUser = 0;
                    string input = "";
                    List<string> cadastro = new List<string>();
                    




                    {
                        // Nome


                        Console.WriteLine("Digite o Nome Completo");

                        nomeCompleto = Console.ReadLine();


                        // Genero




                        while (genero != "M" && genero != "F")
                        {
                            Console.WriteLine("Selecione o gênero. M para Masculino e F para Feminino:");

                            genero = Console.ReadLine();
                            genero = genero.ToUpper();



                            if (genero == "M")
                            {


                                break;
                            }
                            else if (genero == "F")
                            {

                                break;
                            }
                            else
                            {
                                genero = null;
                                Console.WriteLine("Valor Inválido!");

                                continue;
                            }

                        }


                        // Data de Nascimento

                        Console.WriteLine("Digite a Data de Nascimento (DD/MM/YYY):");

                        dataNasc = Convert.ToDateTime(Console.ReadLine());


                        // Endereço: Rua

                        Console.WriteLine("Digite o nome rua do endereço:");
                        endRua = Console.ReadLine();

                        // Endereço: Número

                        Console.WriteLine("Digite o número do imóvel:");

                        endNum = Convert.ToInt32(Console.ReadLine());

                        // Cadastrar

                        
                        input = String.Concat("Id: ",idUser, " , ", nomeCompleto, " , ", genero, " , ", dataNasc.ToString("dd/MM/yyyy"), " , ", endRua, " , ", endNum);
                                                
                        

                        // Imprimir Itens Cadastrados
                        
                        Console.WriteLine("");

                        Console.WriteLine(input);
                        Console.ReadKey(true);
                        Console.Clear();



                    }

                }else if(opcao == "s")
                    {

                Console.WriteLine("Pressione qualquer tecla para sair");
                Console.ReadKey();
                    break;
                    }
                else
                {
                    Console.WriteLine("Opção Inválida!");
                    Console.ReadKey(true);
                    Console.Clear();
                    continue;
                }
            
                





            }




            



        }
    }
}
