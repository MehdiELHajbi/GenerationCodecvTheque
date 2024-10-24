using MediatR;
using Domain;
using System;
using System.Collections.Generic;

namespace Application
{
    public class DeleteCVLanguesCommand  : IRequest{
    #region Generated Properties
    public int CvId { get; set; }

    public int LangueID { get; set; }



    #endregion

    }
}
