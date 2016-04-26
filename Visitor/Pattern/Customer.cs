using System.Collections.Generic;

namespace Visitor.Pattern
{
    public class Customer : ICustomerElements
    {
        public string CustomerName { get; set; }
        public List<Address> Addresses { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);

            foreach (Address address in Addresses)
            {
                address.Accept(visitor);
            }
        }
    }
}
