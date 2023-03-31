
using System;

public abstract class Activity
{
    private string _date;
    private int _length;

    public Activity(string date, int length)
    {
        this._date = date;
        this._length = length;
    }

    public abstract double GetSpeed();
    public abstract double GetPace();
    public abstract double GetDistance();

    public string GetDate()
    {
        return this._date;
    }

    public int GetLength()
    {
        return this._length;
    }

    public abstract string GetSummary();

}