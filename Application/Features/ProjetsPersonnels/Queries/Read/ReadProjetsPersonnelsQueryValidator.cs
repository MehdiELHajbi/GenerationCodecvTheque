using System;
using FluentValidation;

namespace Application
{
    public  class ReadProjetsPersonnelsQueryValidator : AbstractValidator<ReadProjetsPersonnelsQuery> 
    {
        public ReadProjetsPersonnelsQueryValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Nom)
                   .MaximumLength(100).WithMessage("Nom must not exceed 100 characters.");
            RuleFor(p => p.Lien)
                   .MaximumLength(255).WithMessage("Lien must not exceed 255 characters.");
            #endregion
        }

    }
}
