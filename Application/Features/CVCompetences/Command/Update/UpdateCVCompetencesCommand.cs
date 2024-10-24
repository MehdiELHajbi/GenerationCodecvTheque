using MediatR;
using Domain;
using System;
using System.Collections.Generic;

namespace Application
{
    public class UpdateCVCompetencesCommand  : IRequest<UpdateCVCompetencesViewModel>
    {
    #region Generated Properties
    public int CvId { get; set; }

    public int CompetenceID { get; set; }

    #endregion

    public int old_CvId { get; set; }
    public int old_CompetenceID { get; set; }
    }
}
