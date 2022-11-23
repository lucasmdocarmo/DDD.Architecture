using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Shared.Core.Shared.Contracts.Aggregate
{
    public interface IAggregateRoot
    {
        Guid Id { get; }
    }
    public interface IAggregateRoot<out TType> where TType : new()
    {
        TType Id { get; }
    }
}
