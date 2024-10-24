using MediatR;
using Domain;
using System;
using System.Collections.Generic;

namespace Application
{
    public class UpdateLanguesCommand  : IRequest<UpdateLanguesViewModel>
    {
    #region Generated Properties
    public int LangueID { get; set; }

    public string Nom { get; set; }

    #endregion

    }
}
