using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_25
{
    internal class BankOperations
    {
        decimal balance = 1000;

        public void ChecLkBalance()
        {
            Console.WriteLine($"\nO valor da sua conta é de: {balance:C}");
        }

        public void Deposit()
        {
            Console.WriteLine("Informe o valor a ser depositado: R$");

            if(decimal.TryParse(Console.ReadLine(), out decimal amount) && amount > 0)
            {
                balance += amount;
            }
            else
            {
                Console.WriteLine("Valor inválido. Tente novamente.");
            }
        }

        public void WithDraw()
        {
            Console.WriteLine("Informe o valor a ser Retirado");

            if (decimal.TryParse(Console.ReadLine(), out decimal amount) && amount > 0)
            {
                if (amount <= balance)
                {
                    Console.WriteLine($"Retirando: {amount:C}");
                    balance -= amount;
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente para a retirada.");
                }
            }
            else
            {
               Console.WriteLine("Valor inválido ou saldo insuficiente. Tente novamente.");
            }
        }
    }
}
