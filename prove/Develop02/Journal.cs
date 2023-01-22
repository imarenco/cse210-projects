using System;

public class Journal
{
    private string[] _questions = new [] {"Who was the most interesting person I interacted with today?","What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?"};
    private List<Entry> _entries;


    public String getQuestion() {
        Random random = new Random();
        int index = random.Next(0, this._questions.Length);
        return this._questions[index];
    }

    public void AddEntry()
    {
        string question = this.getQuestion();
        Console.WriteLine(question);
        
        string response = Console.ReadLine();
        
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        
        Entry entry = new Entry();
        entry.setDate(dateText);
        entry.setQuestion(question);
        entry.setResponse(response);
        this._entries.Add(entry);
   
    }


    public void setEntries(List<Entry> entries) {
        this._entries = entries;
    }

    public void DisplayAllEntries() {
        for(int i=0; i < this._entries.Count ;i++)
        {
            Entry entry = this._entries[i];            
            string str = "Date:" + entry.getDate() + " - Prompt: " + entry.getQuestion();
            Console.WriteLine(str);
            Console.WriteLine(entry.getResponse());
        }

    }


    public List<Entry> getEntries() {
        return this._entries;
    }
 
}