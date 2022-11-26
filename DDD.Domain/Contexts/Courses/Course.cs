using DDD.Shared.Core.Shared;
using DDD.Shared.Core.Shared.Contracts.Aggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Contexts.Courses
{
    public sealed class Course :BaseEntity,IAggregateRoot
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }

        public IList<Subjects> Subjects { get; private set; }

        public void AddSubjects(Subjects subjects)
        {
            //check
            Subjects.Add(subjects);
        }
    }
}
