using Bridge.Pattern;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Switch s = new Switch();
            s.SetEquipment(new Refrigerator());
            s.On();
            s.Off();

            s.SetEquipment(new Bulb());
            s.On();
            s.Off();
        }
    }
}
