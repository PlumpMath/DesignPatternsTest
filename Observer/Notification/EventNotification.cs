using System;

namespace Observer.Notification
{
    public class EventNotification : INotification
    {
        public void Notify()
        {
            Console.WriteLine("I'm event notification");
        }
    }
}
