namespace Visitor.Pattern
{
    public class VisitorString : IVisitor
    {
        public string Return { get; set; }
        public void Visit(Customer customer)
        {
            Return = $"Customer name - {customer.CustomerName} /n";
        }

        public void Visit(Address address)
        {
            Return += $"Customer address {address.Address1} /n";
        }

        public void Visit(Phone phone)
        {
            Return += $"Customer Phone {phone.PhoneNumber} /n";
        }
    }
}
