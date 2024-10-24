using Application;
using Domain;
using LinqKit;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace InfrastructurePersistence
{
    public class CVsRepository : BaseRepository<CVs>, ICVsRepository
    {
    public CVsRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
    #region Generated Custom

    public virtual async Task<IReadOnlyList<CVs>> SearchAsync(ReadCVsQuery request)
    {
    return await GetMulipleAsync(request.GetPredicate());
    }

    #endregion

    }
    #region Generated Extension Methods

    public static class QueryExtensionCVs
    {
    private static ExpressionStarter<CVs> predicate { get; set; }
    #region Generated GetPredicate Method

    public static Expression<Func<CVs, bool>> GetPredicate(this ReadCVsQuery request)
    {
     predicate = PredicateBuilder.New<CVs>(true);
    predicate
    .And_CvId(request.CvId)
    .And_EmployeID(request.EmployeID)
    .And_Titre(request.Titre)
    ;

    return predicate;

    }


    #endregion

    #region Generated GetPredicate Method

    public static ExpressionStarter<CVs> And_CvId(this ExpressionStarter<CVs> expression, int? cvId)
    {
    if (cvId.HasValue)
     predicate =  expression.And(q => q.CvId == cvId);
    return expression;

    }


    public static ExpressionStarter<CVs> And_EmployeID(this ExpressionStarter<CVs> expression, int? employeID)
    {
    if (employeID.HasValue)
     predicate =  expression.And(q => q.EmployeID == employeID);
    return expression;

    }


    public static ExpressionStarter<CVs> And_Titre(this ExpressionStarter<CVs> expression, string titre)
    {
    if (!string.IsNullOrEmpty(titre))
     predicate =  expression.And(q => q.Titre == titre.Trim());
    return expression;

    }



    #endregion

    }

    #endregion

}
