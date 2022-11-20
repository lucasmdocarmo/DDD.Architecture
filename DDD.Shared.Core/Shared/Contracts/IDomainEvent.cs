﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Shared.Core.Shared.Contracts
{
    public interface IDomainEvent
    {
        DateTime OccorredOn { get; }
    }
}
