namespace Composite.Pattern
{
    public interface IBusinessObject
    {
        void Update();
        bool isValid();
        void Add(IBusinessObject o);
    }
}
