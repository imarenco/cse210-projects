public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        this._products = products;
        this._customer = customer;
    }


    public int CalculateTotalOrder()
    {
        int total = 0;

        foreach (Product product in this._products)
        {
            total = total + product.GetPrice();
        }

        if (this._customer.IsUs())
        {
            total = total + 5;
        }
        else
        {
            total = total + 35;
        }

        return total;
    }


    public string GetPackingLabel()
    {
        string str = System.Environment.NewLine;

        foreach (Product product in this._products)
        {
            str = str + ("Id: " + product.GetId() + ", Product: " + product.GetName() + System.Environment.NewLine);
        }

        return str;
    }

    public string GetPackingShipping()
    {
        return System.Environment.NewLine  + "Name: " + this._customer.GetName() + ", Address:" + this._customer.GetAddres().GetFullAddress();
    }
}