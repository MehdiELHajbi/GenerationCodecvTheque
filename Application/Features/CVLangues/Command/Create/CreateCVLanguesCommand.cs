using MediatR;
using Domain;
using System;
using System.Collections.Generic;

namespace Application
{
    public class CreateCVLanguesCommand  : IRequest<CreateCVLanguesViewModel>
    {
    #region Generated Properties
    public int CvId { get; set; }

    public int LangueID { get; set; }

    public string NiveauMaîtrise { get; set; }

    #endregion

    }
}
