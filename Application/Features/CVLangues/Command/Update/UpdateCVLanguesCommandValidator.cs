using System;
using FluentValidation;

namespace Application
{
    public  class UpdateCVLanguesCommandValidator : AbstractValidator<UpdateCVLanguesCommand> 
    {
        public UpdateCVLanguesCommandValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.NiveauMaîtrise)
                   .MaximumLength(50).WithMessage("NiveauMaîtrise must not exceed 50 characters.");
            #endregion
        }

    }
}
