using System;
using FluentValidation;

namespace Application
{
    public  class UpdateCertificationsCommandValidator : AbstractValidator<UpdateCertificationsCommand> 
    {
        public UpdateCertificationsCommandValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Titre)
                   .MaximumLength(100).WithMessage("Titre must not exceed 100 characters.");
            RuleFor(p => p.Organisme)
                   .MaximumLength(100).WithMessage("Organisme must not exceed 100 characters.");
            #endregion
        }

    }
}
