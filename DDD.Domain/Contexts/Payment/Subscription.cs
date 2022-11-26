using DDD.Domain.Contexts.Courses;
using DDD.Shared.Core.Shared;
using DDD.Shared.Core.Shared.Contracts.Aggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Contexts.Payments
{
    public class Subscription : BaseEntity, IAggregateRoot
    {
        public DateOnly ExpirationDate { get; set; }
        public DateOnly SignedDate { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public bool Active { get; set; }
        private IList<Payment> _payments;
        private IList<Course> _course;

        public IReadOnlyCollection<Payment> Payments { get { return _payments.ToList(); } }
        public IReadOnlyCollection<Course> Course { get { return _course.ToList(); } }

        public Guid Id { get; set; }


        public void Activate()
        {
            Active = true;
            LastUpdatedDate = DateTime.Now;
        }

        public void Inactivate()
        {
            Active = false;
            LastUpdatedDate = DateTime.Now;
        }
    }
}
