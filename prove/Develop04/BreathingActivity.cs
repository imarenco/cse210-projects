
using System;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string startMessage) : base(name, startMessage)
    {
    }


    public void DisplayCountdownUntilTheEnd()
    {
        DateTime now = DateTime.Now;
        DateTime future = DateTime.Now.AddSeconds(this._duration);
        int inb = 4;
        int outb = 6;

        while (future > now)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            for (int x = 0; x < inb; x++)
            {

                Thread.Sleep(1000);
                Console.Write("\rBreathe in..." + (inb - x));

            }
            Thread.Sleep(1000);
            Console.Write("\rBreathe in... ");

            Console.WriteLine("");


            for (int x = 0; x < outb; x++)
            {

                Thread.Sleep(1000);
                Console.Write("\rNow Breathe out..." + (outb - x));

            }
            Thread.Sleep(1000);
            Console.Write("\rNow Breathe out... ");
            now = DateTime.Now;
        }
    }
}