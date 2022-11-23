using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Shared.Core.Shared.Validation.Notifications
{
    public abstract class ValidableEntity
    {
        private readonly Dictionary<string,string> _errors = new();
        private ValidationResult _validationResult = new();

        public ValidationResult GetValidationResult() => _validationResult;
        public bool IsValid() => _errors.Any();

        public ISet<string> Errors => new HashSet<string>(_errors.Values);

        protected void ValidateThis<TEntity>(AbstractValidator<TEntity> validator,
                                            TEntity entity) where TEntity : ValidableEntity
        {
            _validationResult= validator.Validate(entity);

            if(!_validationResult.IsValid)
            {
                foreach (var item in _validationResult.Errors)
                {
                    _errors.Add(item.ErrorMessage,item.ErrorCode);
                }
            }
        }

    }
}
