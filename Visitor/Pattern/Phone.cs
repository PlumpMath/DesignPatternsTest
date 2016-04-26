namespace Visitor.Pattern
{
    public class Phone : ICustomerElements
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public string PhoneNumber { get; set; }
    }
}
