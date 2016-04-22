using Factory.Invoices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            IInvoice inv;
            Console.WriteLine("Моля, въведете тип на фактура");

            int type = Convert.ToInt32(Console.ReadLine());

            inv = InvoiceFactory.GetInvoice(type);

            inv.Print();
        }
    }
}
