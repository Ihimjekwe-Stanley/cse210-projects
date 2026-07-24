using System;

class Program
{
    static void Main(string[] args)
    {
        // First Customer (USA)
        Address address1 = new Address(
            "123 Main Street",
            "Dallas",
            "Texas",
            "USA");

        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Laptop", "P100", 850, 1));
        order1.AddProduct(new Product("Mouse", "P101", 25, 2));
        order1.AddProduct(new Product("Keyboard", "P102", 40, 1));

        // Second Customer (International)
        Address address2 = new Address(
            "15 King Road",
            "Toronto",
            "Ontario",
            "Canada");

        Customer customer2 = new Customer("Sarah Johnson", address2);

        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Phone", "P200", 600, 1));
        order2.AddProduct(new Product("Phone Case", "P201", 20, 3));

        // Display Order 1
        Console.WriteLine("========== ORDER 1 ==========");
        Console.WriteLine("\nPacking Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"\nTotal Cost: ${order1.CalculateTotalCost()}");

        // Display Order 2
        Console.WriteLine("\n==============================");

        Console.WriteLine("\n========== ORDER 2 ==========");

        Console.WriteLine("\nPacking Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"\nTotal Cost: ${order2.CalculateTotalCost()}");
    }
}