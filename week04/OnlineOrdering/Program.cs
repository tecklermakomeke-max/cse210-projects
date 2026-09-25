using System;

class Program
{
    static void Main(string[] args)
    {
        // ORDER 1 - SOUTH AFRICA
        Address address1 = new Address("123 Church Street", "Pretoria", "Gauteng", "South Africa");
        Customer customer1 = new Customer("Nozi", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Mouse", "M001", 150.00, 2));
        order1.AddProduct(new Product("Keyboard", "K001", 350.00, 1));

        // ORDER 2 - ZIMBABWE
        Address address2 = new Address("45 Samora Ave", "Harare", "Harare", "Zimbabwe");
        Customer customer2 = new Customer("Teckler", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Motherboard", "MB001", 1200.00, 1));
        order2.AddProduct(new Product("CPU", "CPU001", 2500.00, 1));
        order2.AddProduct(new Product("Mouse", "M001", 150.00, 1));

        // DISPLAY
        Console.WriteLine("--- ORDER 1 : SOUTH AFRICA ---");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total: R{order1.GetTotalPrice():F2}\n");

        Console.WriteLine("--- ORDER 2 : ZIMBABWE ---");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total: R{order2.GetTotalPrice():F2}\n");
    }
}