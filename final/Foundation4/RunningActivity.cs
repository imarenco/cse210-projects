
using System;

public class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity(string date, int length, double distance) : base(date, length)
    {
        _distance = distance;
    }

    public override string GetSummary()
    {
        string date = this.GetDate();
        int length = this.GetLength();
        double distance = this.GetDistance();
        double speed = this.GetSpeed();
        double pace = this.GetPace();

        return date + " Running (" + length + "min)- Distance " + distance + " km, Speed: " + speed + " kph, Pace: " + pace + " min per kilometer";
    }

    public override double GetSpeed()
    {
        return Math.Round(60 / GetPace(), 2);
    }

    public override double GetPace()
    {
        return Math.Round((GetLength() / _distance), 2);
    }

    public override double GetDistance()
    {
        return _distance;
    }


}