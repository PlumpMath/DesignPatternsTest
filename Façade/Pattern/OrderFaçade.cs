namespace Façade.Pattern
{
    public class OrderFaçade
    {
        public void PlaceOrder()
        {
            Product prod = new Product();
            Payment pay = new Payment();
            Invoice inv = new Invoice();

            prod.GetDetails();
            pay.Pay();
            inv.PrintInvoice();
        }
    }
}
