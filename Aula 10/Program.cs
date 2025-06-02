namespace Aula10;

public class  Program
{
    public static void Main()
    {
        bool varContinue = true;
        while (varContinue)
        {
            Console.WriteLine("--------Calculadora Simples---------");
            Console.WriteLine("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escolha uma operação: ");
            Console.WriteLine("1. Adição (+)");
            Console.WriteLine("2. Subtração (-)");
            Console.WriteLine("3. Multiplicação (*)");
            Console.WriteLine("4. Divisão (/)");
            Console.WriteLine("Digite o número da operação: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            double result = 0;

            if (choice == 1)
            {
                result = num1 + num2;
            }
            else if (choice == 2)
            {
                result = num1 - num2;
            }
            else if (choice == 3)
            {
                result = num1 * num2;
            }
            else if (choice == 4)
            {
                result = num1 / num2;
            }
            Console.WriteLine("O resultado da Operação é " + result);

            Console.WriteLine("Quer continuar ? [s/n]");
            string response = Console.ReadLine();

            if (response != "s")
            {
                varContinue = false;
            }

        }

        Console.WriteLine("Obrigado por usar nossa calculadora.");
       
    }
}