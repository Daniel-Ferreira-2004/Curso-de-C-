using System.Reflection.PortableExecutable;

namespace Aula14;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("--------Tabuada---------");
        for (int i = 1; i <= 10; i++)
        {
            for (int c = 1; c <= 10; c++)
            {
                Console.WriteLine($"{i} x {c} = {i * c}");
            }
        }
    }
}
