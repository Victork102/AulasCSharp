using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosClasse
{

	public class BankAccount
	{
		// MODIFICADOR_DE_ACESSO TIPO_DE_SAIDA NOME_DO_MÉTODO(TIPO_PARÂMETRO NOME_PARÂMETRO)
		// {
		// CONTEUDO_DO_METODO
		// return VALOR_DE_SAIDA
		// }
		// 
		// public - todos podem acessar método
		// private - somente a classe pode acessar

		private double Balance;
		private string Password;
		private string ClientName;

		// Método Construtor; Primeiro Método a ser executado ao instanciar um objeto
		// Construtoe é sempre publico e não possui parâmetro de saida
		// realiza as configurações iniciais do objeto
		// podem ser declarados míltiplos construtores
		public BankAccount(string pPassword, string pClientName)
		{
			Balance = 0;
			Password = pPassword;
			ClientName = pClientName; 

		}

		public double Withdrawal(double pWhithdrawalValue, string pPassword)
		{
			if ( Password == pPassword)
			{
				if(Balance > pWhithdrawalValue)
				{
					Balance -= pWhithdrawalValue;
					Console.WriteLine("Foi sacado o valor de R$" + pWhithdrawalValue);
					return pWhithdrawalValue;
				}
				else
				{
					Console.WriteLine("Fundos Insuficientes!");
					return 0;
				}
			}else
			{
				Console.WriteLine("Senha Incorrete!");
				return 0;
			}
		}

		public void Deposit(double pDepositValue)
		{
			Balance += pDepositValue;
			Console.WriteLine("Foi depositado o valor de R$" + pDepositValue);
		}

		public void BalanceCheck(string pPassword)
		{
			if(Password == pPassword)
			{
				Console.WriteLine("o saldo da conta é: R$" + Balance);
			}
			else
			{
				Console.WriteLine("Senha Incorreta!");
			}
		}

	}
	class Program
	{
		static void Main(string[] args)
		{

			BankAccount PedroAccount = new BankAccount("1234","Pedro Santos");
			


			PedroAccount.Withdrawal(30000, "1234");
			PedroAccount.Deposit(1000);
			PedroAccount.BalanceCheck("1234");





		}
	}
}
