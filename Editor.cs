using System.Text;
using System;

public static class Editor
{
    public static void Show()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine("MODO EDITOR");
        Console.WriteLine("-------------");
        Start();
    }

    public static void Start()
    {
        var file = new StringBuilder();

        do
        {
            file.Append(Console.ReadLine());
            file.Append(Environment.NewLine);
        } while (Console.ReadKey().Key != ConsoleKey.Escape);

        Console.WriteLine("------------------");
        Console.WriteLine("Deseja salvar o arquivo? s = sim / n = não");
        var SalvarOuNao = Console.ReadLine().ToLower();

        if (SalvarOuNao == "n")
        {
            Console.WriteLine("OK");
            Environment.Exit(0);
        }
        else
        {
            using (var salvarNoDisco = new StreamWriter("arquivo.txt"))
            {
                salvarNoDisco.WriteLine(file);
                Console.WriteLine("Arquivo Salvo com sucesso!");
            }
        }

    }
}