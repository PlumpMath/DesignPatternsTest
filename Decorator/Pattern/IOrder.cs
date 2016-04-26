namespace Decorator.Pattern
{
    public interface IOrder
    {
        string Prepare();
        double CalculateCost();
    }
}
