using System;

namespace Factory.Invoices
{
    public class InvoiceWithoutHeaders : IInvoice
    {
        public void Print()
        {
            Console.WriteLine("Принтира без заглавна част");
        }
    }
}
