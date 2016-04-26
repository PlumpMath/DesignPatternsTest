using Decorator.Pattern;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IOrder Order = new OrderBread();
            Console.WriteLine(Order.Prepare());
            Console.WriteLine(Order.CalculateCost().ToString());

            Order = new OrderDrinks(new OrderChicken(new OrderBread()));
            Console.WriteLine(Order.Prepare());
            Console.WriteLine(Order.CalculateCost().ToString());
        }
    }
}
