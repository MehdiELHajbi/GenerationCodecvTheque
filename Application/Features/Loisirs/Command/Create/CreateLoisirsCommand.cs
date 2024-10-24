using MediatR;
using Domain;
using System;
using System.Collections.Generic;

namespace Application
{
    public class CreateLoisirsCommand  : IRequest<CreateLoisirsViewModel>
    {
    #region Generated Properties


    public int? CvId { get; set; }

    public string Description { get; set; }

    #endregion

    }
}
