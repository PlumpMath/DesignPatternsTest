namespace Factory.Invoices
{
    public class InvoiceFactory
    {
        public static IInvoice GetInvoice(int type)
        {
            IInvoice inv;

            if (type == 1)
            {
                inv = new InvoiceWithHeaders();
            }
            else if (type == 2)
            {
                inv = new InvoiceWithoutHeaders();
            }
            else
            {
                inv = null;
            }

            return inv;
        }
    }
}
