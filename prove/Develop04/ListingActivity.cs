
using System;

public class ListingActivity : Activity
{
    private string[] _prompts;
    public ListingActivity(string name, string description, string[] prompts) : base(name, description)
    {
        this._prompts = prompts;
    }

    public void DisplayRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Length);
        string prompt = _prompts[index];

        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine("");
        Console.WriteLine("--- " + prompt + " ---");
        Console.WriteLine("");
    }

    public void ReadListAndDisplay()
    {
        Console.Write("\rYou might begin in:        ");
        Console.WriteLine("");
        List<string> list = new List<string>();
        DateTime now = DateTime.Now;
        DateTime future = DateTime.Now.AddSeconds(this._duration);

        while (future > now)
        {
            string read = Console.ReadLine();
            list.Add(read);
            now = DateTime.Now;
        }

        Console.WriteLine("");
        int total = list.Count;
        Console.WriteLine("You listed " + total + " items!");
    }

}