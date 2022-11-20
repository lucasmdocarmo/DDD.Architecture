using DDD.Shared.Core.Shared.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Core.Messages
{
    public abstract class Event : Message
    {
        public DateTime Timestamp { get; private set; }

        protected Event()
        {
            Timestamp = DateTime.Now;
        }
    }
}
