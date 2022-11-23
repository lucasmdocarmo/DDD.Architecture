using DDD.Shared.Core.Shared.Contracts.Aggregate;
using DDD.Shared.Core.Shared.Contracts.Events;
using Shared.Core.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Shared.Core.Shared.Events
{
    //Class For Create Domain Events
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
