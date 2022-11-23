using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDD.Shared.Core.Shared.Contracts.Aggregate;
using DDD.Shared.Core.Shared.Contracts.Events;
using DDD.Shared.Core.Shared.Events;

namespace DDD.Shared.Core.Shared.Contracts.Events
{
    public interface IDomainEventPublisher<TEvent> where TEvent : IEvent
    {
        ValueTask Publish(TEvent @event, CancellationToken cancellationToken);
    }
}
//public class ClientServiceHandler : IEventHandler<DomainEvent<CreateClientEvent>, Client>
//{
//    private readonly IDomainEventPublisher<CreateClientEvent> _event;
//    public ClientServiceHandler(IDomainEventPublisher<CreateClientEvent> @event)
//    {
//        _event = @event;
//    }

//    public async ValueTask<Client> Execute(DomainEvent<CreateClientEvent> @event, CancellationToken ctx)
//    {
//        var model = @event.Entity;

//        Client.CreateClientEvent(@event, "");

//        await _event.Publish(@event.Entity, ctx);
//        throw new NotImplementedException();
//    }

//}