namespace Aula18;
using System.IO;
public class Program
{
    public static void Main()
    {
        //1. Cirar um arquivo

        //System.IO.File.WriteAllText("file.txt", "Hello World");

        //Console.WriteLine("Arquivo criado com sucesso!");

        //2. Cirar um arquivo em um local específico
        //string path = @"C:\Users\daniel.ferreira\Documents\GitHub\C#\Curso de C#\Aula 18\";
        //string fileNmae = "MyDocument.Doc";
        //string fullPath = path + fileNmae;
        //string content = "Hello World from a specific path!";

        //File.WriteAllText(fullPath, content);

        //3. Inserir um paragráfo em um arquivo

        string path = @"C:\Users\daniel.ferreira\Documents\GitHub\C#\Curso de C#\Aula 18\";
        string fileName = "MyDocument.Doc";
        string fullPath = path + fileName;
        string content = "Hello World from a specific path!";
        string additionalContent = "Curso de C# e .NET";

        File.AppendAllText(fullPath, additionalContent);

        Console.WriteLine("Arquivo Atual criado com suscesso");

        //4. Ler o conteúdo de um arquivo

        string fileContent = File.ReadAllText(fullPath);
        Console.WriteLine("Conteúdo do arquivo:" + fileContent);


    }
}