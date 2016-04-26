namespace Decorator.Pattern
{
    public abstract class OrderDecorator : IOrder
    {
        protected IOrder Order;

        public OrderDecorator(IOrder oOrder)
        {
            Order = oOrder;
        }
        public virtual string Prepare()
        {
            return Order.Prepare();
        }

        public virtual double CalculateCost()
        {
            return Order.CalculateCost();
        }
    }
}
