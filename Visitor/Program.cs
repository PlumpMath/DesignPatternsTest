using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Pattern;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cust = new Customer()
            {
                CustomerName = "Pe6o"
            };
            cust.Addresses = new List<Address>()
            {
                new Address()
                {
                    Address1 = "Ba",
                    Phones = new List<Phone>()
                    {
                        new Phone()
                        {
                            PhoneNumber = "100000000"
                        }
                    }
                },
                 new Address()
                 {
                     Address1 = "Be",
                     Phones = new List<Phone>()
                     {
                        new Phone()
                        {
                            PhoneNumber = "100000000"
                        },
                        new Phone()
                        {
                            PhoneNumber = "2000000"
                        }
                     }
                 }
            };

            VisitorString str = new VisitorString();
            cust.Accept(str);
            Console.WriteLine(str.Return);

            VisitorXml xml = new VisitorXml();
            cust.Accept(xml);
            Console.WriteLine(xml.Return);
        }
    }
}
