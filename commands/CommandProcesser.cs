using Microsoft.VisualBasic;

namespace AlphabeticalOrder;

public class CommandProcesser
{
    public static void CommandExecuter(string input)
    {

        switch (input)
        {
            case "help":
                ExecuteHelp();
                break;
            case "order":
                ConsolePersonalizator.ConsoleColorPrint("Please type or paste the absolute path to your file", ConsoleColor.DarkGreen);
                string absolutePath = Console.ReadLine() ?? "";
                ExecuteOrder(absolutePath);
                break;
            default:
                ConsolePersonalizator.ConsoleColorPrint("Please use help if you don't know what you are doing", ConsoleColor.DarkRed);
                return;
        }
    }

    private static void ExecuteOrder(string absolutePath)
    {


        if (!TxtProcesser.ValidatePath(absolutePath))
            return;

        // Leer todas las líneas del archivo
        string[] lines = File.ReadAllLines(absolutePath);

        // Filtrar solo las líneas que empiezan con '-'
        var itemsToOrder = lines.Where(line => line.Trim().StartsWith("-")).ToList();

        // Ordenar alfabéticamente
        var orderedItems = itemsToOrder.OrderBy(item => item).ToList();

        // Mostrar resultados ordenados
        Console.WriteLine("\nOrdered items:");
        foreach (var item in orderedItems)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("");
    }

    private static void ExecuteHelp()
    {
        ConsolePersonalizator.ConsoleColorPrint("""
                AlphabeticalOrder

                This program is used to order your information from txt files,
                the archive should have the next format:

                    - Ana María Lopez
                    - Lopez Ana María
                    - María Ana Lopez

                You just need to type '-' before every data that you want to order

                - To start to order a txt file just type 'order'
                - To exit just type 'exit'
                """, ConsoleColor.DarkBlue);
    }



}
