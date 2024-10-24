using MediatR;
using Domain;
using System;
using System.Collections.Generic;

namespace Application
{
    public class UpdateCompetencesCommand  : IRequest<UpdateCompetencesViewModel>
    {
    #region Generated Properties
    public int CompetenceID { get; set; }

    public string Nom { get; set; }

    #endregion

    }
}
