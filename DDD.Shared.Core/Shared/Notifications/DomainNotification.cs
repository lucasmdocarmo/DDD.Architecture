using DDD.Shared.Core.Shared.Contracts;
using Shared.Core.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Shared.Core.Shared.Notifications
{
    public class DomainNotification : Message, INotifiable
    {
        public DateTime Timestamp { get; private set; }
        public Guid DomainNotificationId { get; private set; }
        public string Key { get; private set; }
        public string Value { get; private set; }

        public DomainNotification(string key, string value)
        {
            Timestamp = DateTime.Now;
            DomainNotificationId = Guid.NewGuid();
            Key = key;
            Value = value;
        }
    }
}
