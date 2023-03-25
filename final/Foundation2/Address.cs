public class Address
{
    private string _street;
    private string _city;
    private string _province;
    private string _country;
    public Address(string street, string city, string province, string country)
    {
        this._street = street;
        this._city = city;
        this._province = province;
        this._country = country;
    }

    public string GetFullAddress() {
        return this._street + ", " + this._city + ", " + this._province + ", " + this._country;
    }

    public bool IsUs()
    {
        return this._country == "United States";
    }
}