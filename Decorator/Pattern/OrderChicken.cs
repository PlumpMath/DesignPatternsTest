namespace Decorator.Pattern
{
    public class OrderChicken : OrderDecorator
    {
        public OrderChicken(IOrder oOrder) : base(oOrder)
        {
        }

        public override string Prepare()
        {
            return base.Prepare() + PrepareChicken();
        }

        private string PrepareChicken()
        {
            string strPrepare = "";
            strPrepare = "\nGrill the chicken\n";
            strPrepare = strPrepare + "Stuff in the bread";
            return strPrepare;
        }

        public override double CalculateCost()
        {
            return base.CalculateCost() + 300.12;
        }
    }
}
