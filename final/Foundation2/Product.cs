
using System;

public class Product
{
    private string _name;
    private string _id;
    private int _price;
    private int _quantity;
    public Product(string id, string name, int price, int quantity)
    {
        this._id = id;
        this._name = name;
        this._price = price;
        this._quantity = quantity;
    }


    public int GetPrice()
    {
        return this._price * this._quantity;
    }

    public string GetName()
    {
        return this._name;
    }

    public string GetId()
    {
        return this._id;
    }
}