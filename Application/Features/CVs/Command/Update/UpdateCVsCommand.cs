using MediatR;
using Domain;
using System;
using System.Collections.Generic;

namespace Application
{
    public class UpdateCVsCommand  : IRequest<UpdateCVsViewModel>
    {
    #region Generated Properties
    public int CvId { get; set; }

    public int? EmployeID { get; set; }

    public string Titre { get; set; }

    #endregion

    }
}
