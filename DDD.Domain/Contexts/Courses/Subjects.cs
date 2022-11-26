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
        public Guid Id { get; set; }
        
        public string Code { get; set; }
        public string Name { get; set; }    
        public string Description { get; set; }
        public Schedule Schedule { get; set; }

        public void SetSchedule(DayOfWeek _dayofweek, int ocourrence)
        {
            Schedule = new Schedule(_dayofweek, ocourrence);
        }

    }
}
