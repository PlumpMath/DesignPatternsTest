using Strategy.Strategies;
using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Maths math = new Maths();
            Console.WriteLine("Въведете число 1");
            math.Number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Въведете число 2");
            math.Number2 = int.Parse(Console.ReadLine());

            math.SetStrategy(new AddStrategy());
            Console.WriteLine($"+ {math.Calculate()}");

            math.SetStrategy(new SubstractStrategy());
            Console.WriteLine($"- {math.Calculate()}");
        }
    }
}
