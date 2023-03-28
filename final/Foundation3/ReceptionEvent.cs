
using System;

public class ReceptionEvent : Event
{
    private string _weather;

    public ReceptionEvent(string title, string description, string date, Address address, string weather) : base(title, description, date, address, "Reception Event")
    {
        this._weather = weather;
    }
    public void ShowFullDetails()
    {
        this.ShowStandardDetails(true);
        Console.WriteLine("Weather: " + this._weather);
    }
}