using System.Collections.Generic;

namespace Composite.Pattern
{
    public class Customer : IBusinessObject
    {

        private List<Address> Addresses = new List<Address>();
        public IEnumerable<Address> ChildObjects
        {
            get
            {
                return Addresses;
            }
        }
        public void Add(IBusinessObject objAdd)
        {
            Addresses.Add((Address)objAdd);
        }
        public void Update()
        {
            System.Console.WriteLine("Промених се клиент");
        }
        public bool isValid()
        {
            return true;
        }
    }
}
