using MediatR;
using Domain;
using System;
using System.Collections.Generic;

namespace Application
{
    public class CreateCVsCommand  : IRequest<CreateCVsViewModel>
    {
    #region Generated Properties


    public int? EmployeID { get; set; }

    public string Titre { get; set; }

    #endregion

    }
}
