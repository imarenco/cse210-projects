using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = ScriptureGenerator.GetRandomScripture();
        string read = "";
        Console.Clear();

        while (read != "quit")
        {
            Console.WriteLine(scripture.GetReferenceInformation());
            Console.WriteLine(scripture.GetRendererText());
            read = GetChoice();
            if (read == "quit")
            {
                return;
            }

            scripture.HideWords();
            Console.Clear();
            if (scripture.IsAllHidden())
            {
                return;
            }
        }
    }

    static string GetChoice()
    {
        Console.WriteLine("");
        Console.WriteLine("Press enter to continue or type 'quit' to finish:");

        string read = Console.ReadLine();
        return read;
    }
}