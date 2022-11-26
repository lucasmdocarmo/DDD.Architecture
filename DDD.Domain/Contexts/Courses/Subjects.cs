using DDD.Domain.ValueObjects;
using DDD.Shared.Core.Shared;
using DDD.Shared.Core.Shared.Contracts.Aggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Contexts.Courses
{
    public sealed class Subjects : BaseEntity,IAggregateRoot
    {
        public Guid Id { get; private set; }
        
        public string Code { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public Schedule Schedule { get; private set; }

        public void SetSchedule(DayOfWeek _dayofweek, int ocourrence)
        {
            Schedule = new Schedule(_dayofweek, ocourrence);
        }

    }
}
