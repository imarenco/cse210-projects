using System;

class Program
{

    static Int32 GetMenuChoice()
    {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.WriteLine("6. Remove");

        Console.WriteLine("What would you like to do?:");
        string read = Console.ReadLine();
        return Int32.Parse(read);
    }

    static void Main(string[] args)
    {
        bool quit = false;
        Journal journal = new Journal();
        PromptGenetator prompt = new PromptGenetator();

        while (!quit)
        {

            Int32 action = GetMenuChoice();

            switch (action)
            {
                case 1:
                    // write
                    journal.AddEntry();
                    break;
                case 2:
                    // display
                    journal.DisplayAllEntries();
                    break;
                case 3:
                    // load
                    journal.SetEntries(prompt.LoadFromFile());
                    break;
                case 4:
                    // save
                    prompt.SaveToFile(journal.GetEntries());
                    break;
                case 6:
                    // remove
                    journal.RemoveEntry();
                    break;
                case 5:
                default:
                    quit = true;
                    break;
            }
        }
    }
}