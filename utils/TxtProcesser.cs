namespace AlphabeticalOrder;

public class TxtProcesser
{
    public static bool ValidatePath(string input)
    {
        if (!File.Exists(input))
        {
            Console.WriteLine($"There wasn't any file in the provided path: {input}");
            return false;
        }
        return true;
    }

}
