﻿using DDD.Shared.Core.Shared.Contracts;
using DDD.Shared.Core.Shared.Notifications;
using Shared.Core.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Shared.Core.Shared.Events
{
    public record DomainEvent<TEntity>(TEntity Entity) : IDomainEvent where TEntity : IEvent
    {
        public DateTime OccorredOn => DateTime.Now;
        public Guid CorrelationId { get; init; } = Guid.NewGuid();

        public override string ToString()
        {
            return typeof(TEntity).Name;
        }
        internal ICollection<IDomainEvent> DomainEvents { get; } = new List<IDomainEvent>();
    }
}