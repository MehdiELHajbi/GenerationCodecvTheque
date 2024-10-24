using MediatR;
using Domain;
using System;
using System.Collections.Generic;

namespace Application
{
    public class UpdateProjetsPersonnelsCommand  : IRequest<UpdateProjetsPersonnelsViewModel>
    {
    #region Generated Properties
    public int ProjetID { get; set; }

    public int? CvId { get; set; }

    public string Nom { get; set; }

    public string Description { get; set; }

    public string Lien { get; set; }

    public DateTime? DateDebut { get; set; }

    public DateTime? DateFin { get; set; }

    #endregion

    }
}
