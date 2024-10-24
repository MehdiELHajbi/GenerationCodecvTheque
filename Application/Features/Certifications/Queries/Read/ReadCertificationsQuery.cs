using MediatR;
using Domain;
using System;
using System.Collections.Generic;

namespace Application
{
    public class ReadCertificationsQuery  : IRequest<IReadOnlyList<ReadCertificationsViewModel>>
    {
    #region Generated Properties
    public int? CertificationID { get; set; }

    public int? CvId { get; set; }

    public string Titre { get; set; }

    public string Organisme { get; set; }

    public DateTime? DateObtention { get; set; }

    public DateTime? DateExpiration { get; set; }

    #endregion

    }
}
