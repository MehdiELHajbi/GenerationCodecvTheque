using Application;
using Domain;
using LinqKit;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace InfrastructurePersistence
{
    public class ExperiencesRepository : BaseRepository<Experiences>, IExperiencesRepository
    {
    public ExperiencesRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
    #region Generated Custom

    public virtual async Task<IReadOnlyList<Experiences>> SearchAsync(ReadExperiencesQuery request)
    {
    return await GetMulipleAsync(request.GetPredicate());
    }

    #endregion

    }
    #region Generated Extension Methods

    public static class QueryExtensionExperiences
    {
    private static ExpressionStarter<Experiences> predicate { get; set; }
    #region Generated GetPredicate Method

    public static Expression<Func<Experiences, bool>> GetPredicate(this ReadExperiencesQuery request)
    {
     predicate = PredicateBuilder.New<Experiences>(true);
    predicate
    .And_ExperienceID(request.ExperienceID)
    .And_CvId(request.CvId)
    .And_Entreprise(request.Entreprise)
    .And_Poste(request.Poste)
    .And_Description(request.Description)
    .And_DateDebut(request.DateDebut)
    .And_DateFin(request.DateFin)
    ;

    return predicate;

    }


    #endregion

    #region Generated GetPredicate Method

    public static ExpressionStarter<Experiences> And_ExperienceID(this ExpressionStarter<Experiences> expression, int? experienceID)
    {
    if (experienceID.HasValue)
     predicate =  expression.And(q => q.ExperienceID == experienceID);
    return expression;

    }


    public static ExpressionStarter<Experiences> And_CvId(this ExpressionStarter<Experiences> expression, int? cvId)
    {
    if (cvId.HasValue)
     predicate =  expression.And(q => q.CvId == cvId);
    return expression;

    }


    public static ExpressionStarter<Experiences> And_Entreprise(this ExpressionStarter<Experiences> expression, string entreprise)
    {
    if (!string.IsNullOrEmpty(entreprise))
     predicate =  expression.And(q => q.Entreprise == entreprise.Trim());
    return expression;

    }


    public static ExpressionStarter<Experiences> And_Poste(this ExpressionStarter<Experiences> expression, string poste)
    {
    if (!string.IsNullOrEmpty(poste))
     predicate =  expression.And(q => q.Poste == poste.Trim());
    return expression;

    }


    public static ExpressionStarter<Experiences> And_Description(this ExpressionStarter<Experiences> expression, string description)
    {
    if (!string.IsNullOrEmpty(description))
     predicate =  expression.And(q => q.Description == description.Trim());
    return expression;

    }


    public static ExpressionStarter<Experiences> And_DateDebut(this ExpressionStarter<Experiences> expression, DateTime? dateDebut)
    {
    if (dateDebut != null)
     predicate =  expression.And(q => q.DateDebut == dateDebut);
    return expression;

    }


    public static ExpressionStarter<Experiences> And_DateFin(this ExpressionStarter<Experiences> expression, DateTime? dateFin)
    {
    if (dateFin != null)
     predicate =  expression.And(q => q.DateFin == dateFin);
    return expression;

    }



    #endregion

    }

    #endregion

}
