using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Shared.Core.Shared.Notifications
{
    public sealed class Notifiable<T> where T : Notification
    {
        private readonly List<T> _notifications;

        public IReadOnlyCollection<T> Notifications => _notifications;

        public bool IsValid => !_notifications.Any();

        protected Notifiable()
        {
            _notifications = new List<T>();
        }

        private T GetNotificationInstance(string key, string message) => (T)Activator.CreateInstance(typeof(T), key, message);

        public void AddNotification(string key, string message)
        {
            T notificationInstance = GetNotificationInstance(key, message);
            _notifications.Add(notificationInstance);
        }

        public void AddNotification(T notification)
        {
            _notifications.Add(notification);
        }

        public void AddNotification(Type property, string message)
        {
            T notificationInstance = GetNotificationInstance(property?.Name, message);
            _notifications.Add(notificationInstance);
        }

        public void AddNotifications(IReadOnlyCollection<T> notifications)
        {
            _notifications.AddRange(notifications);
        }

        public void AddNotifications(IList<T> notifications)
        {
            _notifications.AddRange(notifications);
        }

        public void AddNotifications(ICollection<T> notifications)
        {
            _notifications.AddRange(notifications);
        }

        public void AddNotifications(Notifiable<T> item)
        {
            AddNotifications(item.Notifications);
        }

        public void AddNotifications(params Notifiable<T>[] items)
        {
            foreach (Notifiable<T> item in items)
            {
                AddNotifications(item);
            }
        }

        public void Clear()
        {
            _notifications.Clear();
        }
    }
}