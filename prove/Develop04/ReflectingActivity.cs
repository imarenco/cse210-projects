
using System;

public class ReflectingActivity : Activity
{
    private string[] _prompts;
    private string[] _questions;
    public ReflectingActivity(string name, string startMessage, string endMessage, string[] prompts, string[] questions) : base(name, startMessage, endMessage)
    {
        this._prompts = prompts;
        this._questions = questions;
    }



    public void showRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Length);
        string prompt = _prompts[index];

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("");
        Console.WriteLine("--- " + prompt + " ---");
        Console.WriteLine("");
        Console.WriteLine("When you have something in mind, press enter or continue");
        Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
    }


    private int getRandomQuestion(List<int> missIndexes)
    {
        Random random = new Random();
        int index = random.Next(0, _questions.Length);
        if (missIndexes.Contains(index))
        {
            return this.getRandomQuestion(missIndexes);
        }

        return index;
    }

    public void DisplayQuestions()
    {
        List<int> missQuestions =  new List<int>();
        DateTime now = DateTime.Now;
        DateTime future = DateTime.Now.AddSeconds(this._duration);

        while (future > now)
        {
            int index = getRandomQuestion(missQuestions);
            string question = _questions[index];
            missQuestions.Append(index);

            Console.WriteLine(question);
            showLoading(false);

            now = DateTime.Now;
        }
    }
}