using Composite.Pattern;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cust = new Customer();
            Address ad = new Address();
            Phone ph = new Phone();
            cust.Add(ad);
            ad.Add(ph);

            cust.Update();
            foreach (IBusinessObject ob in cust.ChildObjects)
            {
                ob.Update();
            }
            foreach (IBusinessObject ob in ad.ChildObjects)
            {
                ob.Update();
            }
        }
    }
}
