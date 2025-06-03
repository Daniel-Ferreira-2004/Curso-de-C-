using Aula_24;

namespace Aula24;

public class Program
{
    public static void Main()
    {
        Person person = new Person();
        person.Name = "Daniel";
        person.Age = 20;

        Console.WriteLine("Digite uma Idade: ");
        int age = Convert.ToInt32(Console.ReadLine());

        var response = person.IfLegalPerson(age, person.Name);

        Console.WriteLine(response);

    }
}