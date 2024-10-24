using Application;
using Domain;
using LinqKit;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace InfrastructurePersistence
{
    public class LoisirsRepository : BaseRepository<Loisirs>, ILoisirsRepository
    {
    public LoisirsRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
    #region Generated Custom

    public virtual async Task<IReadOnlyList<Loisirs>> SearchAsync(ReadLoisirsQuery request)
    {
    return await GetMulipleAsync(request.GetPredicate());
    }

    #endregion

    }
    #region Generated Extension Methods

    public static class QueryExtensionLoisirs
    {
    private static ExpressionStarter<Loisirs> predicate { get; set; }
    #region Generated GetPredicate Method

    public static Expression<Func<Loisirs, bool>> GetPredicate(this ReadLoisirsQuery request)
    {
     predicate = PredicateBuilder.New<Loisirs>(true);
    predicate
    .And_LoisirID(request.LoisirID)
    .And_CvId(request.CvId)
    .And_Description(request.Description)
    ;

    return predicate;

    }


    #endregion

    #region Generated GetPredicate Method

    public static ExpressionStarter<Loisirs> And_LoisirID(this ExpressionStarter<Loisirs> expression, int? loisirID)
    {
    if (loisirID.HasValue)
     predicate =  expression.And(q => q.LoisirID == loisirID);
    return expression;

    }


    public static ExpressionStarter<Loisirs> And_CvId(this ExpressionStarter<Loisirs> expression, int? cvId)
    {
    if (cvId.HasValue)
     predicate =  expression.And(q => q.CvId == cvId);
    return expression;

    }


    public static ExpressionStarter<Loisirs> And_Description(this ExpressionStarter<Loisirs> expression, string description)
    {
    if (!string.IsNullOrEmpty(description))
     predicate =  expression.And(q => q.Description == description.Trim());
    return expression;

    }



    #endregion

    }

    #endregion

}
