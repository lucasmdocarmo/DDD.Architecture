using DDD.Shared.Core.Shared;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DDD.Domain.ValueObjects
{
    public sealed class Document : ValueObject
    {
        public Document(string number, EDocumentType type)
        {
            
            Number = number;
            Type = type;
            new DocumentValidator().Validate(this);
        }

        public string Number { get; private set; }
        public EDocumentType Type { get; private set; }
        protected override IEnumerable<object> GetEqualityComponents()
        {
           yield return EDocumentType.CNPJ; 
           yield return EDocumentType.CPF;
        }
    }
    internal class DocumentValidator: AbstractValidator<Document>
    {
        public DocumentValidator()
        {
            RuleFor(x => x.Number).MaximumLength(14).NotNull().NotEmpty();
        }
    }
    public enum EDocumentType
    {
        CPF = 1,
        CNPJ = 2
    }
}
