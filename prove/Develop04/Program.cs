using System;

class Program
{
    static void Main(string[] args)
    {
        string read = "";

        Console.Clear();

        // breathing activity
        BreathingActivity breathingActivity = new BreathingActivity("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        // Reflecting activity
        string[] prompts = new[] { "Think of a time when you stood up for someone else", "Think of a time when you did something really difficult", "Think of a time when you helped someone in need", "Think of a time when you did something truly selfless" };
        string[] questions = new[] { "Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?" };
        ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspect of your life.", prompts, questions);
        // listing activity
        string[] listingPropmts = new[] { "Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?" };
        ListingActivity listingActivity = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", listingPropmts);

        // count perform activities
        int bcount = 0;
        int rcount = 0;
        int lcount = 0;

        while (read != "4")
        {
            read = GetChoice();
            Console.Clear();
            if (read == "4")
            {
                DisplayCountActivities(bcount, lcount, rcount);
                Thread.Sleep(3000);
                return;
            }
            else if (read == "1")
            {
                breathingActivity.DisplayStartMessage();
                breathingActivity.SetDuration();
                Console.Clear();
                breathingActivity.DisplayLoading(true);
                breathingActivity.DisplayCountdownUntilTheEnd();
                breathingActivity.DisplayEndText();
                Console.Clear();
                bcount++;
            }
            else if (read == "2")
            {
                reflectingActivity.DisplayStartMessage();
                reflectingActivity.SetDuration();
                Console.Clear();
                reflectingActivity.DisplayLoading(true);
                reflectingActivity.DisplayRandomPrompt();
                reflectingActivity.DisplayCountDown();
                Console.Clear();
                reflectingActivity.DisplayQuestions();
                reflectingActivity.DisplayEndText();
                Console.Clear();
                rcount++;
            }
            else if (read == "3")
            {
                listingActivity.DisplayStartMessage();
                listingActivity.SetDuration();
                Console.Clear();
                listingActivity.DisplayLoading(true);
                listingActivity.DisplayRandomPrompt();
                listingActivity.DisplayCountDown();
                listingActivity.ReadListAndDisplay();
                listingActivity.DisplayEndText();
                Console.Clear();
                lcount++;
            }
        }
    }

    static string GetChoice()
    {

        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");
        Console.WriteLine("Select a choice from the menu:");

        string read = Console.ReadLine();
        return read;
    }

    static void DisplayCountActivities(int bcount, int lcount, int rcount)
    {
        Console.WriteLine("You used:");
        Console.WriteLine("Breathing Activity: " + bcount + (bcount == 1 ? " time" : " times"));
        Console.WriteLine("Listing Activity: " + lcount + (lcount == 1 ? " time" : " times"));
        Console.WriteLine("Reflection Activity: " + rcount + (rcount == 1 ? " time" : " times"));

    }
}