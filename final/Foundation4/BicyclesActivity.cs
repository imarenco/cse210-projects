
using System;

public class BicyclesActivity : Activity
{

    private double _speed;

    public BicyclesActivity(string date, int length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    public override string GetSummary()
    {
        string date = this.GetDate();
        int length = this.GetLength();
        double distance = this.GetDistance();
        double speed = this.GetSpeed();
        double pace = this.GetPace();

        return date + " Biking (" + length + "min)- Distance " + distance + " km, Speed: " + speed + " kph, Pace: " + pace + " min per kilometer";
    }


    public override double GetSpeed()
    {
        return Math.Round(60 / GetPace(), 2);
    }

    public override double GetPace()
    {
        return Math.Round(GetLength() / GetDistance(), 2);
    }

    public override double GetDistance()
    {
        return Math.Round(GetLength() / _speed, 2);
    }



}