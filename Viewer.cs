using System;

public class Viewer
{
    public static void Show(string text)
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine("MODO VISUALIZAÇÃO");
        Console.WriteLine("-------------");
        Replace(text);
        Console.WriteLine("-------------");
        Console.ReadKey();
        Menu.Show();

    }

    public static void Replace(string text)
    {
        var strong = "<strong>";
    }
}