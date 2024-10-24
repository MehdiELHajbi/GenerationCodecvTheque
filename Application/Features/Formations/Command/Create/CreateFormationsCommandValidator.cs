using System;
using FluentValidation;

namespace Application
{
    public  class CreateFormationsCommandValidator : AbstractValidator<CreateFormationsCommand> 
    {
        public CreateFormationsCommandValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Etablissement)
                   .MaximumLength(100).WithMessage("Etablissement must not exceed 100 characters.");
            RuleFor(p => p.Diplome)
                   .MaximumLength(100).WithMessage("Diplome must not exceed 100 characters.");
            RuleFor(p => p.Specialisation)
                   .MaximumLength(100).WithMessage("Specialisation must not exceed 100 characters.");
            #endregion
        }

    }
}
