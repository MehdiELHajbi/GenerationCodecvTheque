using System;
using FluentValidation;

namespace Application
{
    public  class UpdateCVsCommandValidator : AbstractValidator<UpdateCVsCommand> 
    {
        public UpdateCVsCommandValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Titre)
                   .MaximumLength(100).WithMessage("Titre must not exceed 100 characters.");
            #endregion
        }

    }
}
