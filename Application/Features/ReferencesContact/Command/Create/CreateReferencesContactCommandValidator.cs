using System;
using FluentValidation;

namespace Application
{
    public  class CreateReferencesContactCommandValidator : AbstractValidator<CreateReferencesContactCommand> 
    {
        public CreateReferencesContactCommandValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Nom)
                   .MaximumLength(100).WithMessage("Nom must not exceed 100 characters.");
            RuleFor(p => p.Relation)
                   .MaximumLength(100).WithMessage("Relation must not exceed 100 characters.");
            RuleFor(p => p.ContactInfo)
                   .MaximumLength(255).WithMessage("ContactInfo must not exceed 255 characters.");
            #endregion
        }

    }
}
