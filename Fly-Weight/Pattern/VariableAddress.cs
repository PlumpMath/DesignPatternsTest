namespace Fly_Weight.Pattern
{
    public class VariableAddress
    {
        public string Name { get; set; }
        public StaticAddress Address = StaticFlyWeight.Address;
    }
}
