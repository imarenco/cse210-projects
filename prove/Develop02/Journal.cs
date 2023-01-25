using System;

public class Journal
{    
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry()
    {
        string question = PromptGenetator.GetRandomPrompt();
        Console.WriteLine(question);

        string response = Console.ReadLine();

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        Entry entry = new Entry();
        entry.SetDate(dateText);
        entry.SetQuestion(question);
        entry.SetResponse(response);
        this._entries.Add(entry);
    }

    public void RemoveEntry()
    {
        Console.WriteLine("What would you like to remove?:");
        string read = Console.ReadLine();
        this._entries.RemoveAt(Int32.Parse(read));
    }


    public void SetEntries(List<Entry> entries)
    {
        this._entries = entries;
    }

    public void DisplayAllEntries()
    {
        for (int i = 0; i < this._entries.Count; i++)
        {
            Entry entry = this._entries[i];
            string str = "Date:" + entry.GetDate() + " - Prompt: " + entry.GetQuestion();
            Console.WriteLine(str);
            Console.WriteLine(entry.GetResponse());
        }

    }


    public List<Entry> GetEntries()
    {
        return this._entries;
    }

}