using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_25
{
    internal class BankTerminal
    {
        BankOperations bank = new BankOperations();

        public void Start()
        {
            bool isRunning = true;
            while (isRunning)
            {
                DispplayMenu();
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        bank.ChecLkBalance();
                        break;

                    case 2:
                        bank.Deposit();
                        break;

                    case 3:
                        bank.WithDraw();
                        break;

                    case 4:
                        Console.WriteLine("Obrigado por usar o Terminal Bancário! Até logo!");
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Por favor, tente novamente.");
                        break;
                }
            }
        }

        public void DispplayMenu()
        {
            Console.WriteLine("========================Bem-vindo ao Terminal Bancário!========================");
            Console.WriteLine("1- Checar Saldo");
            Console.WriteLine("2- Deposito");
            Console.WriteLine("3- Saque");
            Console.WriteLine("4- Sair");

        }
    }
}
