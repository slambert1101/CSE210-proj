using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Rolf st", "New York City", "New York", "USA");
        Customer bob = new Customer("Bob", address1);
        Address address2 = new Address("999 1st avenida", "Las Cruces", "Peten", "Guatemala");
        Customer carlos = new Customer("Carlos", address2);

        Order order1 = new Order(bob);
        Product apples = new Product("Apple", 00304, 2.49, 12);
        Product hat = new Product("Hat", 02381, 46.11, 1);
        order1.AddProduct(apples);
        order1.AddProduct(hat);

        Order order2 = new Order(carlos);
        Product chicken = new Product("Chicken", 00176, 25.99, 3);
        Product bricks = new Product("Brick", 01134, 1.00, 40);
        order2.AddProduct(chicken);
        order2.AddProduct(bricks);

        Console.Clear();
        Console.WriteLine($"Order 1:");
        Console.WriteLine($"{order1.PackingLabel()}");
        Console.WriteLine($"{order1.ShippingLabel()}");
        Console.WriteLine($"Total: ${order1.TotalPrice()}");

        Console.WriteLine();
        Console.WriteLine($"Order 2:");
        Console.WriteLine($"{order2.PackingLabel()}");
        Console.WriteLine($"{order2.ShippingLabel()}");
        Console.WriteLine($"Total: ${order2.TotalPrice()}");
        
    }
}