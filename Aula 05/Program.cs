namespace Aula05;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite o primeiro numero");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o primeiro numero");
        int number2 = Convert.ToInt32(Console.ReadLine());

        int sum = number1 + number2;
        int subtraction = number1 - number2;
        int multiplication = number1 * number2;
        int division = number1 / number2;
        int modulo = number1 % number2;
        int increment = number1++;

        Console.WriteLine("Soma: " + sum);
        Console.WriteLine("Subtração: " + subtraction);
        Console.WriteLine("Multiplicação: " + multiplication);
        Console.WriteLine("Divisão: " + division);
        Console.WriteLine("Módulo: " + modulo);
        Console.WriteLine("Incremento: " + increment);
    }
}
