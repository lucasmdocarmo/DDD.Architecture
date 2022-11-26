using DDD.Shared.Core.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.ValueObjects
{
    public sealed class Schedule : ValueObject
    {
        public Schedule(DayOfWeek dayOfWeek, int ocorrence)
        {
            DayOfWeek = dayOfWeek;
            Ocorrence = ocorrence;
        }

        public DayOfWeek DayOfWeek { get; set; }
        public int Ocorrence { get; set; }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return new object[] { DayOfWeek, Ocorrence };
        }
    }

}
