
using System;

public class OutdoorEvent : Event
{
    private string _email;

    public OutdoorEvent(string title, string description, string date, Address address, string email) : base(title, description, date, address, "Outdoor Event")
    {
        this._email = email;
    }
    public void ShowFullDetails()
    {
        this.ShowStandardDetails(true);
        Console.WriteLine("Email: " + this._email);
    }
}