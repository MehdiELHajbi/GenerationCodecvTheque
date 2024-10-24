using System;
using FluentValidation;

namespace Application
{
    public  class CreateLoisirsCommandValidator : AbstractValidator<CreateLoisirsCommand> 
    {
        public CreateLoisirsCommandValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Description)
                   .MaximumLength(255).WithMessage("Description must not exceed 255 characters.");
            #endregion
        }

    }
}
