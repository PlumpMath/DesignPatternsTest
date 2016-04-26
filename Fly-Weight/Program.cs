using Fly_Weight.Pattern;
using System;

namespace Fly_Weight
{
    class Program
    {
        static void Main(string[] args)
        {
            VariableAddress address = new VariableAddress();
            address.Name = Console.ReadLine();

            Console.WriteLine($"{address.Name}");
            Console.WriteLine($"{address.Address.Country}");
            Console.WriteLine($"{address.Address.Number}");
            Console.WriteLine($"{address.Address.StreetName}");
        }
    }
}
