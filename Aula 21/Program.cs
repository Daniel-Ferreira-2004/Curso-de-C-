using Aula_21;

namespace Aula21;

public class Program
{
    public static void Main()
    {
        var cakeStrawberry = new cake();
        cakeStrawberry.Id = 472;
        cakeStrawberry.Name = "Bolo de Morango";
        cakeStrawberry.Description = "Bolo de morango com recheio de morango e cobertura de chantilly";
        cakeStrawberry.IsFilling = true;
        cakeStrawberry.Value = 30;

        Console.WriteLine($"Id: {cakeStrawberry.Id}");
        Console.WriteLine("Nome:" + cakeStrawberry.Name);
        Console.WriteLine("Descrição: " + cakeStrawberry.Description);
        Console.WriteLine("Valor: " + cakeStrawberry.Value);
        Console.WriteLine("Recheio: " + (cakeStrawberry.IsFilling ? "Sim" : "Não"));
        Console.WriteLine("=========================================");

        var cakeChocolate = new cake();

        cakeChocolate.Id = 473;
        cakeChocolate.Name = "Bolo de Chocolate";
        cakeChocolate.Description = "Bolo de chocolate com recheio de chocolate e cobertura de chocolate";
        cakeChocolate.IsFilling = true;
        cakeChocolate.Value = 35;

        Console.WriteLine("ID:" + cakeChocolate.Id);
        Console.WriteLine("Nome: " + cakeChocolate.Name);
        Console.WriteLine("Descrição: " + cakeChocolate.Description);
        Console.WriteLine("Valor: " + cakeChocolate.Value);
        Console.WriteLine("Recheio: " + (cakeChocolate.IsFilling ? "Sim" : "Não"));
        Console.WriteLine("Litas");

        List<cake> cakesList = new List<cake>();
        cakesList.Add(cakeStrawberry);
        cakesList.Add(cakeChocolate);

        foreach (cake cake in cakesList)
        {
            Console.WriteLine($"Id: {cake.Id}");
            Console.WriteLine("Nome:" + cake.Name);
            Console.WriteLine("Descrição: " + cake.Description);
            Console.WriteLine("Valor: " + cake.Value);
            Console.WriteLine("Recheio: " + (cake.IsFilling ? "Sim" : "Não"));
            Console.WriteLine("=========================================");
        }
    }
}