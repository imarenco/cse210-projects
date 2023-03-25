using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Clear();
        List<Order> list = OrderGenerator.GetListOrder();

        foreach (Order order in list)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Packing label: " + order.GetPackingLabel());
            Console.WriteLine("Shipping label: " + order.GetPackingShipping());
            Console.WriteLine("");
            Console.WriteLine("Total Price: " + order.CalculateTotalOrder());


        }
        Console.WriteLine("----------------------");



    }
}