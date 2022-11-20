using DDD.Shared.Core.Shared.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Shared.Core.Shared.Events
{
    public interface IDomainEventPublisher<TEvent> where TEvent : IEvent
    {
        ValueTask Publish(TEvent @event, CancellationToken cancellationToken);
    }
}
