using DDD.Shared.Core.Shared.Events;
using Shared.Core.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Shared.Core.Shared.Contracts.Events
{
    public interface IDomainEvent
    {
        DateTime OccorredOn { get; }
    }
    //public interface IMediatorHandler
    //{
    //    Task PublishEvent<T>(T events) where T : Event;
    //    Task<bool> SendCommand<T>(T command) where T : Command;
    //    Task PushNotifications<T>(T notificacao) where T : DomainNotification;
    //    Task PushDomainEvent<T>(T notificacao) where T : DomainEvent;
   // }
}
