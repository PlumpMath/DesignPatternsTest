using System.Collections.Generic;

namespace Visitor.Pattern
{
    public class Address : ICustomerElements
    {
        public string Address1 { get; set; }
        public List<Phone> Phones { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);

            foreach (Phone phone in Phones)
            {
                phone.Accept(visitor);
            }
        }
    }
}
