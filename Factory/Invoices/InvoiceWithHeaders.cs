using System;

namespace Factory.Invoices
{
    public class InvoiceWithHeaders : IInvoice
    {
        public void Print()
        {
            Console.WriteLine("Принтира със заглавна част");
        }
    }
}
