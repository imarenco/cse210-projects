
using System;

public class Activity
{
    private string _name;
    protected int _duration;
    private string _startMessage;


    public Activity(string name, string startMessage)
    {
        this._name = name;
        this._startMessage = startMessage;
    }

    public void DisplayStartMessage()
    {
        Console.WriteLine("Welcome to the " + this._name + " Activity.");
        Console.WriteLine("");
        Console.WriteLine(this._startMessage);
    }

    public void SetDuration()
    {
        Console.WriteLine("");
        Console.WriteLine("How long in senconds, would you like for your session?");
        string read = Console.ReadLine();
        int seconds = Int32.Parse(read);
        this._duration = seconds;
    }

    public void DisplayLoading(Boolean isWord)
    {
        if (isWord)
        {
            Console.WriteLine("Get ready...");
        }
        else
        {
            Console.WriteLine("");
        }

        int amount = 3;

        for (int x = 0; x < amount; x++)
        {
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b");
        }

        Console.WriteLine("");
    }

    public void DisplayCountDown()
    {
        Console.WriteLine("");
        int time = 5;
        for (int x = 0; x < time; x++)
        {

            Thread.Sleep(1000);
            Console.Write("\rYou might begin in..." + (time - x));
        }

        Thread.Sleep(1000);

        Console.Write("\rYou might begin in... ");
    }


    public void DisplayEndText()
    {
        Console.WriteLine("");
        Console.WriteLine("Well Done!!!");
        Console.WriteLine("You have completed another " + this._duration + " seconds of the " + this._name + " Activity");
        DisplayLoading(false);

    }

}