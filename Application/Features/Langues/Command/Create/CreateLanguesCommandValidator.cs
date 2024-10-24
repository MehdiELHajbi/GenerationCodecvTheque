using System;
using FluentValidation;

namespace Application
{
    public  class CreateLanguesCommandValidator : AbstractValidator<CreateLanguesCommand> 
    {
        public CreateLanguesCommandValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Nom)
                   .MaximumLength(100).WithMessage("Nom must not exceed 100 characters.");
            #endregion
        }

    }
}
