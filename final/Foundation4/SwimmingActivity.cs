
using System;

public class SwimmingActivity : Activity
{
    private double _laps;
    public SwimmingActivity(string date, int length, double laps) : base(date, length)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return Math.Round(_laps * 50 / 1000, 2);
    }

    public override double GetSpeed()
    {
        return Math.Round(60 / GetPace(), 2);
    }

    public override double GetPace()
    {
        return Math.Round(GetLength() / GetDistance(), 2);
    }

    public override string GetSummary()
    {
        string date = this.GetDate();
        int length = this.GetLength();
        double distance = this.GetDistance();
        double speed = this.GetSpeed();
        double pace = this.GetPace();

        return date + " Swimming (" + length + "min)- Distance " + distance + " km, Speed: " + speed + " kph, Pace: " + pace + " min per kilometer";
    }

}