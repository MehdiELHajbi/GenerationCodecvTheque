using Application;
using Domain;
using LinqKit;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace InfrastructurePersistence
{
    public class CVCompetencesRepository : BaseRepository<CVCompetences>, ICVCompetencesRepository
    {
    public CVCompetencesRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
    #region Generated Custom

    public virtual async Task<IReadOnlyList<CVCompetences>> SearchAsync(ReadCVCompetencesQuery request)
    {
    return await GetMulipleAsync(request.GetPredicate());
    }

    #endregion

    }
    #region Generated Extension Methods

    public static class QueryExtensionCVCompetences
    {
    private static ExpressionStarter<CVCompetences> predicate { get; set; }
    #region Generated GetPredicate Method

    public static Expression<Func<CVCompetences, bool>> GetPredicate(this ReadCVCompetencesQuery request)
    {
     predicate = PredicateBuilder.New<CVCompetences>(true);
    predicate
    .And_CvId(request.CvId)
    .And_CompetenceID(request.CompetenceID)
    ;

    return predicate;

    }


    #endregion

    #region Generated GetPredicate Method

    public static ExpressionStarter<CVCompetences> And_CvId(this ExpressionStarter<CVCompetences> expression, int? cvId)
    {
    if (cvId.HasValue)
     predicate =  expression.And(q => q.CvId == cvId);
    return expression;

    }


    public static ExpressionStarter<CVCompetences> And_CompetenceID(this ExpressionStarter<CVCompetences> expression, int? competenceID)
    {
    if (competenceID.HasValue)
     predicate =  expression.And(q => q.CompetenceID == competenceID);
    return expression;

    }



    #endregion

    }

    #endregion

}
