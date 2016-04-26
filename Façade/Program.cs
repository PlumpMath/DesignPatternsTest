using Façade.Pattern;

namespace Façade
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderFaçade order = new OrderFaçade();
            order.PlaceOrder();
        }
    }
}
