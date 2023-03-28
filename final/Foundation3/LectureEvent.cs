
using System;

public class LectureEvent : Event
{
    private string _speaker;
    private int _capacity;

    public LectureEvent(string title, string description, string date, Address address, string speaker, int capacity) : base(title, description, date, address, "Lecture Event")
    {
        this._capacity = capacity;
        this._speaker = speaker;
    }
    public void ShowFullDetails()
    {
        this.ShowStandardDetails(true);
        Console.WriteLine("Speaker: " + this._speaker);
        Console.WriteLine("Capacity: " + this._capacity);
    }
}