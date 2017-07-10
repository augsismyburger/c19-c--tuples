using System;
using System.Collections.Generic;

namespace tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>();

            transactions.Add(("Nails", 5.99, 5));
            transactions.Add(("Hammer", 25.99, 1));
            transactions.Add(("Caulk", 2.50, 3));
            transactions.Add(("Circular Saw", 99.99, 1));
            transactions.Add(("Tape Measure", 8.99, 1));

            int totalQuantitySold = 0;
            double totalSales = 0;

            foreach ((string product, double amount, int quantity) t in transactions)
            {
                totalSales += t.amount;
                totalQuantitySold += t.quantity;
            }
            
            Console.WriteLine($"The total amount of things sold is {totalQuantitySold}" );
            Console.WriteLine($"The total sales weres {totalSales}" );
        }
    }
}
