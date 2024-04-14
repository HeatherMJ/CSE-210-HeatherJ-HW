namespace OnlineOrdering
{
    public class Program
    {
        static void Main(string[] args)
        {
            Address address1 = new Address("2445 East Bakersfield Rd", "Enosburg Falls", "VT", "USA");
            Customer customer1 = new Customer("Dennis Jewett", address1);
            List<Product> products1 = new List<Product>
            {
                new Product("Socks", "1", 10, 10),
                new Product("Shoes", "2", 25, 1),
                new Product("Brush", "3", 5, 100)
            };
            Order order1 = new Order(products1, customer1);

            Address address2 = new Address("123 ABC Road", "Colchester", "VT", "USA");
            Customer customer2 = new Customer("Joe Brosseau", address2);
            List<Product> products2 = new List<Product>
            {
                new Product("Fishing Pole", "4", 100, 1),
                new Product("Fishing Line", "5", 10, 2),
                new Product("Fishing Hooks", "6", 7, 3)
            };
            Order order2 = new Order(products2, customer2);

            Console.WriteLine("Order 1: ");
            Console.WriteLine("Packing Label: ");
            Console.WriteLine(order1.GetPackLabel());
            Console.WriteLine("Shipping Label: ");
            Console.WriteLine(order1.GetShipLabel());
            Console.WriteLine($"Total Cost: ${order1.CaluculateTotalCost()}");

            Console.WriteLine();
            Console.WriteLine("Order 2: ");
            Console.WriteLine("Packing Label: ");
            Console.WriteLine(order2.GetPackLabel());
            Console.WriteLine("Shipping Label: ");
            Console.WriteLine(order2.GetShipLabel());
            Console.WriteLine($"Total Cost: ${order2.CaluculateTotalCost()}");
        }
    }
}