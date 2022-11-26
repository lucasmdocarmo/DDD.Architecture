using DDD.Shared.Core.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        public string EmailAddress { get; set; }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            if (!string.IsNullOrEmpty(this.EmailAddress))
            {
                yield return EmailAddress;
            }
        }
    }
}