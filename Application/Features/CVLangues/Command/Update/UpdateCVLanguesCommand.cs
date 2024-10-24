using MediatR;
using Domain;
using System;
using System.Collections.Generic;

namespace Application
{
    public class UpdateCVLanguesCommand  : IRequest<UpdateCVLanguesViewModel>
    {
    #region Generated Properties
    public int CvId { get; set; }

    public int LangueID { get; set; }

    public string NiveauMaîtrise { get; set; }

    #endregion

    public int old_CvId { get; set; }
    public int old_LangueID { get; set; }
    }
}
