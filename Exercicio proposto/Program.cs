using System;
using System.Globalization;
using Course.Entities;
using Course.Entities.Enums;


namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Client Information:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            
            Console.Write("Email: ");    
            string email = Console.ReadLine();
            
            Console.Write("Birth Day: ");
            DateTime birthDay = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDay);

            Console.WriteLine();
            Console.WriteLine("Enter Order information: ");
           
            Console.Write("Order Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            DateTime moment = DateTime.Now;

            Order order = new Order(moment, status, client);

            Console.Write("How many items to this order: ");
            
            int prodOnList = int.Parse(Console.ReadLine());

            

            for(int i = 1; i <= prodOnList; i++)
            {
                Console.WriteLine("Enter #" + i + " item data:");
                Console.Write("Product description: ");
                string prod = Console.ReadLine();
                
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                Product product = new Product(prod, price);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, price, product);

                order.AddOrderItem(orderItem);

            }

            Console.WriteLine(order);
        }

    }
}