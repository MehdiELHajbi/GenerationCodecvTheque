using MediatR;
using Domain;
using System;
using System.Collections.Generic;

namespace Application
{
    public class UpdateExperiencesCommand  : IRequest<UpdateExperiencesViewModel>
    {
    #region Generated Properties
    public int ExperienceID { get; set; }

    public int? CvId { get; set; }

    public string Entreprise { get; set; }

    public string Poste { get; set; }

    public string Description { get; set; }

    public DateTime? DateDebut { get; set; }

    public DateTime? DateFin { get; set; }

    #endregion

    }
}
