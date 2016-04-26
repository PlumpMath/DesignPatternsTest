namespace Visitor.Pattern
{
    public class VisitorXml : IVisitor
    {
        public string Return { get; set; }
        public void Visit(Customer customer)
        {
            Return = $"<customerName> - {customer.CustomerName} /n";
        }

        public void Visit(Address address)
        {
            Return += $"<customerAddress> {address.Address1} /n";
        }

        public void Visit(Phone phone)
        {
            Return += $"<customerPhone> {phone.PhoneNumber} /n";
        }
    }
}
