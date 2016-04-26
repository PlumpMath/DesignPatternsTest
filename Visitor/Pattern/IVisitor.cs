namespace Visitor.Pattern
{
    public interface IVisitor
    {
        void Visit(Phone phone);
        void Visit(Address address);
        void Visit(Customer customer);
    }
}
