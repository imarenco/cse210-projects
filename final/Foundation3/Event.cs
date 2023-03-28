public class Event
{
    private string _title;

    private string _description;

    private string _date;


    private Address _address;

    private string _type;


    protected Event(string title, string description, string date, Address address, string type)
    {
        this._title = title;
        this._description = description;
        this._date = date;
        this._address = address;
        this._type = type;
    }
    public void ShowStandardDetails(Boolean isType)
    {
        if (isType)
        {
            Console.WriteLine(this._type + " - " + this._title);
        }
        else
        {
            Console.WriteLine(this._title);
        }
        Console.WriteLine(this._description);
        Console.WriteLine("Time: " + this._date + ", Address: " + this._address.GetFullAddress());
    }

    public void ShowShortDescription()
    {
        Console.WriteLine(this._type + " - " + this._title);
        Console.WriteLine("Date: " + this._date);
    }
}