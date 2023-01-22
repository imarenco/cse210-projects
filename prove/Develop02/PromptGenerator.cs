using System;
using System.IO;
public class PromptGenetator
{

    public void SaveToFile(List<Entry> entries)
    {
        Console.WriteLine("What it's your filename:");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {

            for (int i = 0; i < entries.Count; i++)
            {
                Entry entry = entries[i];
                string line = entry.getDate() + "|" + entry.getQuestion() + "|" + entry.getResponse();
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
            entry.setDate(parts[0]);
            entry.setQuestion(parts[1]);
            entry.setResponse(parts[2]);
            list.Add(entry);
        }

        return list;
    }

}