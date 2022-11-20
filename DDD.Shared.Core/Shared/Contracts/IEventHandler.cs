using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Shared.Core.Shared.Contracts
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
