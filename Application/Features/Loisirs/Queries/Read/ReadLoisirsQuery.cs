using MediatR;
using Domain;
using System;
using System.Collections.Generic;

namespace Application
{
    public class ReadLoisirsQuery  : IRequest<IReadOnlyList<ReadLoisirsViewModel>>
    {
    #region Generated Properties
    public int? LoisirID { get; set; }

    public int? CvId { get; set; }

    public string Description { get; set; }

    #endregion

    }
}
