using System;

namespace Observer.Notification
{
    public class EmailNotification : INotification
    {
        public void Notify()
        {
            Console.WriteLine("I'm email notification");
        }
    }
}
