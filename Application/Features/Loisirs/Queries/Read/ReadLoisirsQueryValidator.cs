using System;
using FluentValidation;

namespace Application
{
    public  class ReadLoisirsQueryValidator : AbstractValidator<ReadLoisirsQuery> 
    {
        public ReadLoisirsQueryValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Description)
                   .MaximumLength(255).WithMessage("Description must not exceed 255 characters.");
            #endregion
        }

    }
}
