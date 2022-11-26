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
        public Guid Id { get; set; }
        public string Name { get; set; }    
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public IList<Subjects> Subjects { get; set; }

        public void AddSubjects(Subjects subjects)
        {
            //check
            Subjects.Add(subjects);
        }
    }
}
