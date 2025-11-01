namespace AlphabeticalOrder;

public class ConsolePersonalizator
{

    public static void ConsoleColorPrint(string text, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(text);
        Console.ResetColor();
        Console.WriteLine("");
    }
}
