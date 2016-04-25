using Iterator.Iterators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("set index");
            int index = Convert.ToInt32(Console.ReadLine());
            Iterators.Iterator it = new Iterators.Iterator();
            it.FillList();
            Customer cust = it[index];
            Console.WriteLine(cust != null ? $"{cust.Id} - {cust.Name}" : "Not found");

            Console.WriteLine("1 - get by index");
            Console.WriteLine("2 - prev by this index");
            Console.WriteLine("3 - next by index");
            Console.WriteLine("4 - first element");
            Console.WriteLine("5 - last");
            Console.WriteLine("6 - exit");

            int command = 0;
            command = int.Parse(Console.ReadLine());
            while (command != 6)
            {
                switch (command)
                {
                    case 1:
                        Display(it[index]);
                        break;
                    case 2:
                        Display(it.Prev());
                        break;
                    case 3:
                        Display(it.Next());
                        break;
                    case 4:
                        Display(it.First());
                        break;
                    case 5:
                        Display(it.Last());
                        break;
                    default:
                        break;
                }
                command = int.Parse(Console.ReadLine());
            }
        }

        public static void Display(Customer cust)
        {
            Console.WriteLine(cust != null ? $"{cust.Id} - {cust.Name}" : "Not found");
        }
    }
}
