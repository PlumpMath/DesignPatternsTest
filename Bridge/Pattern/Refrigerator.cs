using System;

namespace Bridge.Pattern
{
    public class Refrigerator : IEquipment
    {
        public void Start()
        {
            Console.WriteLine("Пускане на хладилника");
            Console.WriteLine("Охлаждане");
        }

        public void Stop()
        {
            Console.WriteLine("Спираве на хладилника");
            Console.WriteLine("Размразяване");
        }
    }
}
