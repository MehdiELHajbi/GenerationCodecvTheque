using System;
using FluentValidation;

namespace Application
{
    public  class CreateExperiencesCommandValidator : AbstractValidator<CreateExperiencesCommand> 
    {
        public CreateExperiencesCommandValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Entreprise)
                   .MaximumLength(100).WithMessage("Entreprise must not exceed 100 characters.");
            RuleFor(p => p.Poste)
                   .MaximumLength(100).WithMessage("Poste must not exceed 100 characters.");
            #endregion
        }

    }
}
