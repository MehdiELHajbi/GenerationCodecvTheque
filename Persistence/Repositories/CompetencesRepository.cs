using Application;
using Domain;
using LinqKit;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace InfrastructurePersistence
{
    public class CompetencesRepository : BaseRepository<Competences>, ICompetencesRepository
    {
    public CompetencesRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
    #region Generated Custom

    public virtual async Task<IReadOnlyList<Competences>> SearchAsync(ReadCompetencesQuery request)
    {
    return await GetMulipleAsync(request.GetPredicate());
    }

    #endregion

    }
    #region Generated Extension Methods

    public static class QueryExtensionCompetences
    {
    private static ExpressionStarter<Competences> predicate { get; set; }
    #region Generated GetPredicate Method

    public static Expression<Func<Competences, bool>> GetPredicate(this ReadCompetencesQuery request)
    {
     predicate = PredicateBuilder.New<Competences>(true);
    predicate
    .And_CompetenceID(request.CompetenceID)
    .And_Nom(request.Nom)
    ;

    return predicate;

    }


    #endregion

    #region Generated GetPredicate Method

    public static ExpressionStarter<Competences> And_CompetenceID(this ExpressionStarter<Competences> expression, int? competenceID)
    {
    if (competenceID.HasValue)
     predicate =  expression.And(q => q.CompetenceID == competenceID);
    return expression;

    }


    public static ExpressionStarter<Competences> And_Nom(this ExpressionStarter<Competences> expression, string nom)
    {
    if (!string.IsNullOrEmpty(nom))
     predicate =  expression.And(q => q.Nom == nom.Trim());
    return expression;

    }



    #endregion

    }

    #endregion

}
