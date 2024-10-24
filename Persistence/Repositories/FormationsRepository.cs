using Application;
using Domain;
using LinqKit;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace InfrastructurePersistence
{
    public class FormationsRepository : BaseRepository<Formations>, IFormationsRepository
    {
    public FormationsRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
    #region Generated Custom

    public virtual async Task<IReadOnlyList<Formations>> SearchAsync(ReadFormationsQuery request)
    {
    return await GetMulipleAsync(request.GetPredicate());
    }

    #endregion

    }
    #region Generated Extension Methods

    public static class QueryExtensionFormations
    {
    private static ExpressionStarter<Formations> predicate { get; set; }
    #region Generated GetPredicate Method

    public static Expression<Func<Formations, bool>> GetPredicate(this ReadFormationsQuery request)
    {
     predicate = PredicateBuilder.New<Formations>(true);
    predicate
    .And_FormationID(request.FormationID)
    .And_CvId(request.CvId)
    .And_Etablissement(request.Etablissement)
    .And_Diplome(request.Diplome)
    .And_Specialisation(request.Specialisation)
    .And_AnneeObtention(request.AnneeObtention)
    ;

    return predicate;

    }


    #endregion

    #region Generated GetPredicate Method

    public static ExpressionStarter<Formations> And_FormationID(this ExpressionStarter<Formations> expression, int? formationID)
    {
    if (formationID.HasValue)
     predicate =  expression.And(q => q.FormationID == formationID);
    return expression;

    }


    public static ExpressionStarter<Formations> And_CvId(this ExpressionStarter<Formations> expression, int? cvId)
    {
    if (cvId.HasValue)
     predicate =  expression.And(q => q.CvId == cvId);
    return expression;

    }


    public static ExpressionStarter<Formations> And_Etablissement(this ExpressionStarter<Formations> expression, string etablissement)
    {
    if (!string.IsNullOrEmpty(etablissement))
     predicate =  expression.And(q => q.Etablissement == etablissement.Trim());
    return expression;

    }


    public static ExpressionStarter<Formations> And_Diplome(this ExpressionStarter<Formations> expression, string diplome)
    {
    if (!string.IsNullOrEmpty(diplome))
     predicate =  expression.And(q => q.Diplome == diplome.Trim());
    return expression;

    }


    public static ExpressionStarter<Formations> And_Specialisation(this ExpressionStarter<Formations> expression, string specialisation)
    {
    if (!string.IsNullOrEmpty(specialisation))
     predicate =  expression.And(q => q.Specialisation == specialisation.Trim());
    return expression;

    }


    public static ExpressionStarter<Formations> And_AnneeObtention(this ExpressionStarter<Formations> expression, DateTime? anneeObtention)
    {
    if (anneeObtention != null)
     predicate =  expression.And(q => q.AnneeObtention == anneeObtention);
    return expression;

    }



    #endregion

    }

    #endregion

}
