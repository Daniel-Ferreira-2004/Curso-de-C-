namespace Aula04;

public class  Program
{
    public static void Main()
    {
        Console.WriteLine("------------------LOGIN------------------");

        Console.WriteLine("Digite seu nome:");
        string name = Console.ReadLine();

        Console.WriteLine("Digite sua idade");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("---------------------------------------");

        Console.WriteLine("Olá, seu nome é " + name + ", e sua idade é " + age + " Anos");
    }
}