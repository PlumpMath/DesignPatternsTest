using System;

namespace Bridge.Pattern
{
    public class Bulb : IEquipment
    {
        public void Start()
        {
            Console.WriteLine("Крушката се пали");
            Console.WriteLine("Крушката свети");
        }

        public void Stop()
        {
            Console.WriteLine("Крушката се гаси");
        }
    }
}
