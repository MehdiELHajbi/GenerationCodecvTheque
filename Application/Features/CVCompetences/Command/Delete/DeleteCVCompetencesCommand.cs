using MediatR;
using Domain;
using System;
using System.Collections.Generic;

namespace Application
{
    public class DeleteCVCompetencesCommand  : IRequest{
    #region Generated Properties
    public int CvId { get; set; }

    public int CompetenceID { get; set; }

    #endregion

    }
}
