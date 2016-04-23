using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer.Customer cust1 = new Customer.Customer();
            cust1.Code = "Код1";
            cust1.Name = "Име1";
            cust1.Address.Addr = "Просто адрес1";

            Customer.Customer cust2 = cust1;
            cust2.Code = "Код2";

            Console.WriteLine("По референция");
            Console.WriteLine($"{cust1.Code} == {cust2.Code}");

            Customer.Customer cust3 = new Customer.Customer();
            cust3.Code = "Код3";
            cust3.Name = "Име3";
            cust3.Address.Addr = "Просто адрес3";

            Customer.Customer cust4 = cust3.GetClone();
            cust4.Code = "Код4";

            Console.WriteLine("Чрез копиране");
            Console.WriteLine($"{cust3.Code} != {cust4.Code}");
        }
    }
}
