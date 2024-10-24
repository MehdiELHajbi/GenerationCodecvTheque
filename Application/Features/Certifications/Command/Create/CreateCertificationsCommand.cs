using MediatR;
using Domain;
using System;
using System.Collections.Generic;

namespace Application
{
    public class CreateCertificationsCommand  : IRequest<CreateCertificationsViewModel>
    {
    #region Generated Properties


    public int? CvId { get; set; }

    public string Titre { get; set; }

    public string Organisme { get; set; }

    public DateTime? DateObtention { get; set; }

    public DateTime? DateExpiration { get; set; }

    #endregion

    }
}
