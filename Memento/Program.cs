using Memento.Entities;
using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cust = new Customer();
            Console.WriteLine($"{cust.Id}: {cust.Name}");
            cust.Name = Console.ReadLine();
            Console.WriteLine($"{cust.Id}: {cust.Name}");
            cust.Revert();
            Console.WriteLine($"{cust.Id}: {cust.Name}");
        }
    }
}
