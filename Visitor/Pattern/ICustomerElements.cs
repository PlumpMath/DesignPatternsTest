namespace Visitor.Pattern
{
    public interface ICustomerElements
    {
        void Accept(IVisitor visitor);
    }
}
