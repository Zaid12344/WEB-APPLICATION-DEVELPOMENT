using System;
using System.Collections.Generic;

namespace LINQLab
{
    class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string City { get; set; }
    }

    class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public double OrderAmount { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>()
            {
                new Customer { CustomerId = 1, CustomerName = "Amit Shah", City = "Ahmedabad" },
                new Customer { CustomerId = 2, CustomerName = "Mukesh Ambani", City = "Vadodara" },
                new Customer { CustomerId = 3, CustomerName = "Manish Shah", City = "Nadiad" },
            };

            List<Order> orders = new List<Order>()
            {
                new Order { OrderId = 101, CustomerId = 1, ProductName = "Laptop", Category = "Electronics", OrderAmount = 65000 },
                new Order { OrderId = 102, CustomerId = 2, ProductName = "Mouse", Category = "Electronics", OrderAmount = 1000 },
                new Order { OrderId = 103, CustomerId = 3, ProductName = "Keyboard", Category = "Electronics", OrderAmount = 2000 },

            };

            var result1 = from customer in customers
                          join order in orders on customer.CustomerId equals order.CustomerId
                          select new
                          {
                              CustomerName = customer.CustomerName,
                              ProductName = order.ProductName
                          };
            Console.WriteLine(":: Result 1 ::");
            foreach (var customer in result1)
            {
                Console.WriteLine($"Customr Name : {customer.CustomerName} Product : {customer.ProductName}");
            }
            Console.WriteLine();

            var resul2 = (from o in orders
                         where o.OrderAmount > 20000
                         select o).First();
            
            Console.WriteLine(":: Result 2 ::");
            Console.WriteLine($"Product Name: {resul2.ProductName} Category: {resul2.Category}\nOrder Amount: {resul2.OrderAmount}");
            Console.WriteLine();

            var result3 = from customer in customers
                          join order in orders on customer.CustomerId equals order.CustomerId
                          where customer.City == "Ahmedabad"
                          group order by customer.CustomerName into g
                          select new
                          {
                              CustomerName = g.Key,
                              TotalAmount = g.Sum(o => o.OrderAmount)
                          };

            Console.WriteLine(":: Result 3 ::");
            foreach (var customer in result3) { Console.WriteLine($"Customer Name: {customer.CustomerName}, Total Amount Spent: {customer.TotalAmount}"); }
            Console.WriteLine();

            var result4 = from customer in customers
                          join order in orders on customer.CustomerId equals order.CustomerId
                          orderby order.OrderAmount descending
                          select new
                          {
                              CustomerName = customer.CustomerName,
                              ProductName = order.ProductName,
                              OrderAmount = order.OrderAmount
                          };

            Console.WriteLine(":: Result 4 ::");
            foreach (var customer in result4) { Console.WriteLine($"Customer Name: {customer.CustomerName}, Product Name: {customer.ProductName}, Order Amount: {customer.OrderAmount}"); }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
