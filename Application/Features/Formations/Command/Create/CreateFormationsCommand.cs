using MediatR;
using Domain;
using System;
using System.Collections.Generic;

namespace Application
{
    public class CreateFormationsCommand  : IRequest<CreateFormationsViewModel>
    {
    #region Generated Properties


    public int? CvId { get; set; }

    public string Etablissement { get; set; }

    public string Diplome { get; set; }

    public string Specialisation { get; set; }

    public DateTime? AnneeObtention { get; set; }

    #endregion

    }
}
