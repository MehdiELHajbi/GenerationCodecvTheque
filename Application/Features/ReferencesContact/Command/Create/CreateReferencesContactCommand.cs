using MediatR;
using Domain;
using System;
using System.Collections.Generic;

namespace Application
{
    public class CreateReferencesContactCommand  : IRequest<CreateReferencesContactViewModel>
    {
    #region Generated Properties


    public int? CvId { get; set; }

    public string Nom { get; set; }

    public string Relation { get; set; }

    public string ContactInfo { get; set; }

    #endregion

    }
}
