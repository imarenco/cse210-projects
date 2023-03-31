
using System;

public class ActivityGenerator
{
    public static List<Activity> GetActivities()
    {

        List<Activity> activities = new List<Activity>();

        activities.Add(new BicyclesActivity("1 Jan 2020", 50, 15));
        activities.Add(new RunningActivity("5 Apr 2022", 30, 4));
        activities.Add(new SwimmingActivity("10 Dec 2021", 20, 7));

        return activities;
    }
}