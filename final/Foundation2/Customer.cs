
using System;

public class Customer
{
    private string _name;
    private Address _address;
    public Customer(string name, Address address)
    {
        this._name = name;
        this._address = address;
    }


    public bool IsUs()
    {
        return this._address.IsUs();
    }

    public string GetName()
    {
        return this._name;
    }

    public Address GetAddres()
    {
        return this._address;
    }
}