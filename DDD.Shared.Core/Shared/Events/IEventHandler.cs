using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDD.Shared.Core.Shared.Contracts;

namespace DDD.Shared.Core.Shared.Events
{
    public interface IEventHandler<T> where T : IDomainEvent
    {
        ValueTask Execute(T @event, CancellationToken ctx);
    }
    public interface IEventHandler<TIn, TOut> where TIn : IDomainEvent where TOut : BaseEntity
    {
        ValueTask<TOut> Execute(TIn @event, CancellationToken ctx);
    }
}
