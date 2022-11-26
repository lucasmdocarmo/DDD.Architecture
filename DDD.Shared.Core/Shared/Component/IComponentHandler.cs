using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Shared.Core.Shared.Component
{
    public interface IComponentHandler
    {
        
    }
    public interface IComponentHandler<in TIn, TOut> : IComponentHandler
    {
        ValueTask ExecuteAsync<TOut>(TIn input, CancellationToken cancellationToken = default);
    }
    public interface IComponentHandler<in TIn>: IComponentHandler
    {
        ValueTask ExecuteAsync(TIn input, CancellationToken cancellationToken= default);
    }

}
