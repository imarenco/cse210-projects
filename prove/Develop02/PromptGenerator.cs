using System;
using System.IO;
public class PromptGenetator

{

    public static String GetRandomPrompt()
    {
        string[] prompts = new[] { "Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?", "What time do you get up?", "Where do you eat breakfast?" };
        Random random = new Random();
        int index = random.Next(0, prompts.Length);
        return prompts[index];
    }

    public void SaveToFile(List<Entry> entries)
    {
        Console.WriteLine("What it's your filename:");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {

            for (int i = 0; i < entries.Count; i++)
            {
                Entry entry = entries[i];
                string line = entry.GetDate() + "|" + entry.GetQuestion() + "|" + entry.GetResponse();
                outputFile.WriteLine(line);
            }
        }
    }

    public List<Entry> LoadFromFile()
    {
        Console.WriteLine("What it's your filename:");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        List<Entry> list = new List<Entry>();
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            Entry entry = new Entry();
            entry.SetDate(parts[0]);
            entry.SetQuestion(parts[1]);
            entry.SetResponse(parts[2]);
            list.Add(entry);
        }

        return list;
    }

}