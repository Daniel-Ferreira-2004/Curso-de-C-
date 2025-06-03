namespace Aula18;
using System.IO;
using System.Transactions;

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

        //string path = @"C:\Users\daniel.ferreira\Documents\GitHub\C#\Curso de C#\Aula 18\";
        //string fileName = "MyDocument.Doc";
        //string fullPath = path + fileName;
        //string content = "Hello World from a specific path!";
        //string additionalContent = "Curso de C# e .NET";

        //File.AppendAllText(fullPath, additionalContent);

        //Console.WriteLine("Arquivo Atual criado com suscesso");

        //4. Ler o conteúdo de um arquivo

        //string fileContent = File.ReadAllText(fullPath);
        //Console.WriteLine("Conteúdo do arquivo:" + fileContent);

        // testando um programa

        //string path = (@"C:\Users\daniel.ferreira\Documents\GitHub\C#\Curso de C#\Aula 18\Notas\");
        //string fileName = "Notas.txt";
        //string fullPath = path + fileName;
        //string content = "Notas dos alunos:\n";

        //File.WriteAllText(fullPath, content);
        string local = (@"C:\Users\daniel.ferreira\Documents\GitHub\C#\Curso de C#\Aula 18\Notas");
        Directory.CreateDirectory(local);

        while (true)
        {
             Console.WriteLine("----------------Criando um Bloco de notas Automatico---------------------");
   
            string path = (@"C:\Users\daniel.ferreira\Documents\GitHub\C#\Curso de C#\Aula 18\Notas\");
            Console.Write("Qual nome do arquivo ?");
            string fileName = Console.ReadLine();

            string fullPath = path + fileName + ".txt";
            Console.Write("Qual texto vai estar dentro do TXT ?");
            string content = Console.ReadLine();

            File.WriteAllText(fullPath, content);
            Console.WriteLine("Arquivo criado com sucesso!");

            Console.WriteLine("Deseja ler o conteudo dentro do arquivo ? (s/n)");
            string readChoice = Console.ReadLine().ToUpper();
            if (readChoice == "S")
            {
                string fileContent = File.ReadAllText(fullPath);
                Console.WriteLine("Conteúdo do arquivo: " + fileContent);
            }
            else
            {
                Console.WriteLine("Você escolheu não ler o conteúdo do arquivo.");
            }

            Console.WriteLine("Deseja Excluir algum arquivo ? (s/n)");
            string deleteChoice = Console.ReadLine().ToUpper();
            if (deleteChoice == "S")
            {
                Console.Write("Digite o nome do arquivo que deseja excluir (sem extensão): ");
                string deleteFileName = Console.ReadLine();
                string deleteFullPasth = path + deleteFileName + ".txt";
                if (File.Exists(deleteFullPasth))
                {
                    File.Delete(deleteFullPasth);
                    Console.WriteLine("Arquivo excluído com sucesso!");
                }
                else
                {
                    Console.WriteLine("Arquivo não encontrado.");
                }
            }
            else
            {
                Console.WriteLine("Você escolheu não excluir nenhum arquivo.");
            }

             Console.WriteLine("Deseja criar outro arquivo? (s/n)");
            string choice = Console.ReadLine().ToUpper();
            if (choice != "S")
            {
                Console.WriteLine("Programa encerrado.");
                break;
            }
            else
            {
                Console.Clear();
            }
            
        }

    }
}