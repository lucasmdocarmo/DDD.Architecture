using DDD.Domain.Contexts.Courses;
using DDD.Domain.Contexts.Payments;
using DDD.Domain.ValueObjects;
using DDD.Shared.Core.Shared.Contracts.Aggregate;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Contexts.Students
{
    public class Student: IAggregateRoot
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public Address Address { get; private set; }

        public IReadOnlyCollection<Course> Course { get { return _courses.ToList(); } }

        private IList<Course> _courses;

        public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscriptions.ToList(); } }

        private IList<Subscription> _subscriptions;

        public void AddSubscription(Subscription subscription)
        {
            bool hasSubscriptionActive = false;
            foreach (var sub in _subscriptions)
            {
                if (sub.Active)
                    hasSubscriptionActive = true;
            }
            
            _subscriptions.Add(subscription);
        }

    }
}
