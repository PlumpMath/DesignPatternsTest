using System;

namespace Observer.Notification
{
    public class SmsNotification : INotification
    {
        public void Notify()
        {
            Console.WriteLine("I'm SMS notification");
        }
    }
}
