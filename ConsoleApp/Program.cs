using System;
using ConsoleApp.Entities;
using ConsoleApp.Entities.Enums;
using System.Globalization;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data :");
            Console.WriteLine("Name: ");
            string nameClient = Console.ReadLine();
            Console.WriteLine("Email: ");
            string emailClient = Console.ReadLine();
            Console.WriteLine("Birthdate (dd/MM/yyyy):");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Status : ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(nameClient, emailClient, birthDate);
            Order order = new Order(DateTime.Now, status, client);


            Console.WriteLine("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());
            
            for(int i = 1; i <= n; i++)
            {
                
                Console.WriteLine($"Enter #{i} item data :");
                Console.WriteLine("Name Product :");
                string productName = Console.ReadLine();
                Console.WriteLine("Product Price :");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
               
                Product product = new Product(productName, price);

                Console.WriteLine("Quantity : ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, price , product);

                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY");
            Console.WriteLine(order);
        }
    }
}
