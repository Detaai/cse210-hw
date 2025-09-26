using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Online Ordering System\n");
        
        // Create first customer (USA)
        Address address1 = new Address("123 Main Street", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("John Smith", address1);
        
        // Create first order
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "LAP001", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "MOU123", 25.50, 2));
        order1.AddProduct(new Product("Keyboard", "KEY456", 75.00, 1));
        
        // Create second customer (International)
        Address address2 = new Address("456 Maple Avenue", "Toronto", "Ontario", "Canada");
        Customer customer2 = new Customer("Sarah Johnson", address2);
        
        // Create second order
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Monitor", "MON789", 299.99, 2));
        order2.AddProduct(new Product("Webcam", "WEB012", 89.99, 1));
        
        // Display information for Order 1
        Console.WriteLine("=== ORDER 1 ===");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalCost():F2}\n");
        
        // Display information for Order 2
        Console.WriteLine("=== ORDER 2 ===");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalCost():F2}");
    }
}