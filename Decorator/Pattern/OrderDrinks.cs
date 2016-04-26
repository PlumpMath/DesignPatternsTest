namespace Decorator.Pattern
{
    public class OrderDrinks : OrderDecorator
    {
        public OrderDrinks(IOrder oOrder)
            : base(oOrder)
        {

        }

        public override string Prepare()
        {
            return base.Prepare() + PrepareDrinks();
        }

        private string PrepareDrinks()
        {
            string strPrepare = "";
            strPrepare = "\nTake the drink from freezer\n";
            strPrepare = strPrepare + "Serve in glass";
            return strPrepare;
        }

        public override double CalculateCost()
        {
            return base.CalculateCost() + 10.12;
        }
    }
}
