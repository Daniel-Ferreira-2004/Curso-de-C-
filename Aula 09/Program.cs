namespace Aula09;

public class Progam
{
    public static void Main()
    {
        Console.WriteLine("Sistema de Login");

        bool isLogged = true;
        bool isAdmin = false;

        if (isLogged || isAdmin)
        {
            Console.WriteLine("Usuario Logado");
        }
        else
        {
            Console.WriteLine("Usuario não Logado");
        }

        if (isLogged && isAdmin)
        {
            Console.WriteLine("Usuario Logado");
        }
        else
        {
            Console.WriteLine("Usuario não Logado");
        }

        if (!isLogged)
        {
            Console.WriteLine("Usuario não Logado");
        }
        else
        {
            Console.WriteLine("Usuario Logado");

        }
    }
}