using Application;
using Domain;
using LinqKit;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace InfrastructurePersistence
{
    public class CVLanguesRepository : BaseRepository<CVLangues>, ICVLanguesRepository
    {
    public CVLanguesRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
    #region Generated Custom

    public virtual async Task<IReadOnlyList<CVLangues>> SearchAsync(ReadCVLanguesQuery request)
    {
    return await GetMulipleAsync(request.GetPredicate());
    }

    #endregion

    }
    #region Generated Extension Methods

    public static class QueryExtensionCVLangues
    {
    private static ExpressionStarter<CVLangues> predicate { get; set; }
    #region Generated GetPredicate Method

    public static Expression<Func<CVLangues, bool>> GetPredicate(this ReadCVLanguesQuery request)
    {
     predicate = PredicateBuilder.New<CVLangues>(true);
    predicate
    .And_CvId(request.CvId)
    .And_LangueID(request.LangueID)
    .And_NiveauMaîtrise(request.NiveauMaîtrise)
    ;

    return predicate;

    }


    #endregion

    #region Generated GetPredicate Method

    public static ExpressionStarter<CVLangues> And_CvId(this ExpressionStarter<CVLangues> expression, int? cvId)
    {
    if (cvId.HasValue)
     predicate =  expression.And(q => q.CvId == cvId);
    return expression;

    }


    public static ExpressionStarter<CVLangues> And_LangueID(this ExpressionStarter<CVLangues> expression, int? langueID)
    {
    if (langueID.HasValue)
     predicate =  expression.And(q => q.LangueID == langueID);
    return expression;

    }


    public static ExpressionStarter<CVLangues> And_NiveauMaîtrise(this ExpressionStarter<CVLangues> expression, string niveauMaîtrise)
    {
    if (!string.IsNullOrEmpty(niveauMaîtrise))
     predicate =  expression.And(q => q.NiveauMaîtrise == niveauMaîtrise.Trim());
    return expression;

    }



    #endregion

    }

    #endregion

}
