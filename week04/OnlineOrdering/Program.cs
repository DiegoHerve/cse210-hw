using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1
        Address address1 = new Address(
            "123 Main Street",
            "New York",
            "NY",
            "USA");

        Customer customer1 = new Customer("John Smith", address1);

        Product product1 = new Product("P001", "Laptop", 1000, 1);
        Product product2 = new Product("P002", "Mouse", 25, 2);
        Product product3 = new Product("P003", "Keyboard", 50, 1);

        Order order1 = new Order(customer1);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        // Order 2
        Address address2 = new Address(
            "45 Royal Road",
            "Vacoas",
            "Plaines Wilhems",
            "Mauritius");

        Customer customer2 = new Customer("Jean Dupont", address2);

        Product product4 = new Product("P004", "Headphones", 80, 1);
        Product product5 = new Product("P005", "USB Cable", 10, 3);

        Order order2 = new Order(customer2);

        order2.AddProduct(product4);
        order2.AddProduct(product5);

        // Display Order 1
        Console.WriteLine("ORDER 1");
        Console.WriteLine();

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();

        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine("Total Price: $" + order1.CalculateOrderPrice().ToString("0.00"));

        Console.WriteLine();
        Console.WriteLine("----------------------------");
        Console.WriteLine();

        // Display Order 2
        Console.WriteLine("ORDER 2");
        Console.WriteLine();

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();

        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine("Total Price: $" + order2.CalculateOrderPrice().ToString("0.00"));
    }
}
