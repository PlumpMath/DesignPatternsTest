using System.Collections;

namespace Observer.Notification
{
    public class Notifier
    {
        private ArrayList Notifications = new ArrayList();

        public void AddNotification(INotification not)
        {
            Notifications.Add(not);
        }

        public void RemoveNotification(INotification not)
        {
            Notifications.Remove(not);
        }

        public void NotifyAll()
        {
            foreach (INotification not in Notifications)
            {
                not.Notify();
            }
        }
    }
}
