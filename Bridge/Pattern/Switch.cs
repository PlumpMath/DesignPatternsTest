namespace Bridge.Pattern
{
    public class Switch : ISwitch
    {
        private IEquipment Eq;

        public void SetEquipment(IEquipment eq)
        {
            Eq = eq;
        }

        public void Off()
        {
            Eq.Stop();
        }

        public void On()
        {
            Eq.Start();
        }
    }
}
