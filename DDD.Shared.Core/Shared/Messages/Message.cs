using DDD.Shared.Core.Shared.Validation.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Core.Messages
{
    public abstract class Message: ValidableEntity
    {
        public string Result { get; protected set; }
        public string MessageType { get; protected set; }
        public Guid AggregateId { get; protected set; }

        protected Message()
        {
            MessageType = GetType().Name;
        }
    }
}
