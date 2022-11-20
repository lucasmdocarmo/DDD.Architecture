using FluentValidation;
using Shared.Core.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Shared.Core.Shared.Validation
{
    public interface IValidationHandler
    {
        bool ExecuteValidation<TV, TE>(TV validationObject, TE command) where TV : AbstractValidator<TE> where TE : Command;
    }
}
