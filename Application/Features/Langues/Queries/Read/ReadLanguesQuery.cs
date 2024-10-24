using MediatR;
using Domain;
using System;
using System.Collections.Generic;

namespace Application
{
    public class ReadLanguesQuery  : IRequest<IReadOnlyList<ReadLanguesViewModel>>
    {
    #region Generated Properties
    public int? LangueID { get; set; }

    public string Nom { get; set; }

    #endregion

    }
}
