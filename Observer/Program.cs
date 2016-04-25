using Observer.Notification;
using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Notifier notifier = new Notifier();
            notifier.AddNotification(new EmailNotification());
            notifier.AddNotification(new SmsNotification());

            Console.WriteLine("Enter a number");

            int number = int.Parse(Console.ReadLine());
            if (number > 10)
            {
                notifier.NotifyAll();
            }
        }
    }
}
