using MediatR;
using Domain;
using System;
using System.Collections.Generic;

namespace Application
{
    public class ReadCVLanguesQuery  : IRequest<IReadOnlyList<ReadCVLanguesViewModel>>
    {
    #region Generated Properties
    public int? CvId { get; set; }

    public int? LangueID { get; set; }

    public string NiveauMaîtrise { get; set; }

    #endregion

    }
}
