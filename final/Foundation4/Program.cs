using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        List<Activity> activities = ActivityGenerator.GetActivities();

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine("---------------------------------------------------------------------------------");
        }


    }
}