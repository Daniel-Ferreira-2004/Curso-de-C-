namespace Aula06;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("--------PAR ou IMPAR---------");
        Console.WriteLine("Digite um numero: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("O numero " + number + " é PAR");
        }
        else
        {
            Console.WriteLine("O numero " + number + " é IMPAR");
        }
    }
}