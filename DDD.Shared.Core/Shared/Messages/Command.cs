using DDD.Shared.Core.Shared.Validation.Notifications;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Core.Messages
{
    public abstract class Command : Message
    {
        public DateTime Timestamp { get; private set; }
        public ValidationResult ValidationResult { get; set; }

        protected Command()
        {
            Timestamp = DateTime.Now;
        }
    }
}
