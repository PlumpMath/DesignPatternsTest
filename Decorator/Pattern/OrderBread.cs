namespace Decorator.Pattern
{
    public class OrderBread : IOrder
    {
        public string Prepare()
        {
            string strPrepare = "";
            strPrepare = "Bake the bread in oven\n";
            strPrepare = strPrepare + "Serve the bread";
            return strPrepare;
        }

        public double CalculateCost()
        {
            return 200.30;
        }
    }
}
