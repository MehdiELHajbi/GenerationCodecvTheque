using MediatR;
using Domain;
using System;
using System.Collections.Generic;

namespace Application
{
    public class CreateCompetencesCommand  : IRequest<CreateCompetencesViewModel>
    {
    #region Generated Properties


    public string Nom { get; set; }

    #endregion

    }
}
