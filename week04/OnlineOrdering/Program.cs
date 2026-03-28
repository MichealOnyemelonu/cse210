using System;

class Program
{
    static void Main(string[] args)
    {
        
        Address address1 = new Address(
            "123 Main Street",
            "Salt Lake City",
            "UT",
            "USA");

        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "LAP123", 999.99m, 1));
        order1.AddProduct(new Product("Mouse", "MSE456", 25.50m, 2));

        
        Address address2 = new Address(
            "45 High Street",
            "London",
            "London",
            "UK");

        Customer customer2 = new Customer("Emma Brown", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Headphones", "HDP789", 75.00m, 1));
        order2.AddProduct(new Product("USB-C Cable", "USB321", 10.00m, 3));

        
        Console.WriteLine("===== ORDER 1 =====");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():0.00}");
        Console.WriteLine();

        
        Console.WriteLine("===== ORDER 2 =====");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():0.00}");

        Console.WriteLine();
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}