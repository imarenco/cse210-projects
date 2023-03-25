
using System;

public class OrderGenerator
{


    public static List<Order> GetListOrder()
    {

        List<Order> orderList = new List<Order>();

        // Order 1
        List<Product> products = new List<Product>();
        products.Add(new Product("1", "RADISH", 1, 3));
        products.Add(new Product("2", "ONION", 2, 1));
        products.Add(new Product("3", "CHARD", 3, 4));

        Address address = new Address("Carlos Calvo", "CABA", "Buenos Aires", "Argentina");
        Customer customer = new Customer("Ignacio Marenco", address);

        orderList.Add(new Order(products, customer));


        // Order 2
        List<Product> products1 = new List<Product>();
        products1.Add(new Product("4", "EGGPLANT", 2, 5));
        products1.Add(new Product("5", "PEPPERS", 2, 1));
        products1.Add(new Product("6", "STRAWBERRY", 7, 2));

        Address address1 = new Address("662 W Vine St", "Salt Lake City", "Utah", "United States");
        Customer customer1 = new Customer("Jacob Jones", address1);

        orderList.Add(new Order(products1, customer1));

        // Order 3
        List<Product> products2 = new List<Product>();
        products2.Add(new Product("7", "WATERMELON", 10, 1));
        products2.Add(new Product("8", "BLUEBERRY", 2, 2));
        products2.Add(new Product("9", "PEAR", 4, 2));

        Address address2 = new Address("W 5400 S", "Salt Lake City", "Utah", "United States");
        Customer customer2 = new Customer("Alex Berman", address2);

        orderList.Add(new Order(products2, customer2));



        return orderList;
    }
}