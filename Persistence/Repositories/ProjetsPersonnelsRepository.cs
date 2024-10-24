using Application;
using Domain;
using LinqKit;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace InfrastructurePersistence
{
    public class ProjetsPersonnelsRepository : BaseRepository<ProjetsPersonnels>, IProjetsPersonnelsRepository
    {
    public ProjetsPersonnelsRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
    #region Generated Custom

    public virtual async Task<IReadOnlyList<ProjetsPersonnels>> SearchAsync(ReadProjetsPersonnelsQuery request)
    {
    return await GetMulipleAsync(request.GetPredicate());
    }

    #endregion

    }
    #region Generated Extension Methods

    public static class QueryExtensionProjetsPersonnels
    {
    private static ExpressionStarter<ProjetsPersonnels> predicate { get; set; }
    #region Generated GetPredicate Method

    public static Expression<Func<ProjetsPersonnels, bool>> GetPredicate(this ReadProjetsPersonnelsQuery request)
    {
     predicate = PredicateBuilder.New<ProjetsPersonnels>(true);
    predicate
    .And_ProjetID(request.ProjetID)
    .And_CvId(request.CvId)
    .And_Nom(request.Nom)
    .And_Description(request.Description)
    .And_Lien(request.Lien)
    .And_DateDebut(request.DateDebut)
    .And_DateFin(request.DateFin)
    ;

    return predicate;

    }


    #endregion

    #region Generated GetPredicate Method

    public static ExpressionStarter<ProjetsPersonnels> And_ProjetID(this ExpressionStarter<ProjetsPersonnels> expression, int? projetID)
    {
    if (projetID.HasValue)
     predicate =  expression.And(q => q.ProjetID == projetID);
    return expression;

    }


    public static ExpressionStarter<ProjetsPersonnels> And_CvId(this ExpressionStarter<ProjetsPersonnels> expression, int? cvId)
    {
    if (cvId.HasValue)
     predicate =  expression.And(q => q.CvId == cvId);
    return expression;

    }


    public static ExpressionStarter<ProjetsPersonnels> And_Nom(this ExpressionStarter<ProjetsPersonnels> expression, string nom)
    {
    if (!string.IsNullOrEmpty(nom))
     predicate =  expression.And(q => q.Nom == nom.Trim());
    return expression;

    }


    public static ExpressionStarter<ProjetsPersonnels> And_Description(this ExpressionStarter<ProjetsPersonnels> expression, string description)
    {
    if (!string.IsNullOrEmpty(description))
     predicate =  expression.And(q => q.Description == description.Trim());
    return expression;

    }


    public static ExpressionStarter<ProjetsPersonnels> And_Lien(this ExpressionStarter<ProjetsPersonnels> expression, string lien)
    {
    if (!string.IsNullOrEmpty(lien))
     predicate =  expression.And(q => q.Lien == lien.Trim());
    return expression;

    }


    public static ExpressionStarter<ProjetsPersonnels> And_DateDebut(this ExpressionStarter<ProjetsPersonnels> expression, DateTime? dateDebut)
    {
    if (dateDebut != null)
     predicate =  expression.And(q => q.DateDebut == dateDebut);
    return expression;

    }


    public static ExpressionStarter<ProjetsPersonnels> And_DateFin(this ExpressionStarter<ProjetsPersonnels> expression, DateTime? dateFin)
    {
    if (dateFin != null)
     predicate =  expression.And(q => q.DateFin == dateFin);
    return expression;

    }



    #endregion

    }

    #endregion

}
