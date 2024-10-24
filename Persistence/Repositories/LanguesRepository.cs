using Application;
using Domain;
using LinqKit;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace InfrastructurePersistence
{
    public class LanguesRepository : BaseRepository<Langues>, ILanguesRepository
    {
    public LanguesRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
    #region Generated Custom

    public virtual async Task<IReadOnlyList<Langues>> SearchAsync(ReadLanguesQuery request)
    {
    return await GetMulipleAsync(request.GetPredicate());
    }

    #endregion

    }
    #region Generated Extension Methods

    public static class QueryExtensionLangues
    {
    private static ExpressionStarter<Langues> predicate { get; set; }
    #region Generated GetPredicate Method

    public static Expression<Func<Langues, bool>> GetPredicate(this ReadLanguesQuery request)
    {
     predicate = PredicateBuilder.New<Langues>(true);
    predicate
    .And_LangueID(request.LangueID)
    .And_Nom(request.Nom)
    ;

    return predicate;

    }


    #endregion

    #region Generated GetPredicate Method

    public static ExpressionStarter<Langues> And_LangueID(this ExpressionStarter<Langues> expression, int? langueID)
    {
    if (langueID.HasValue)
     predicate =  expression.And(q => q.LangueID == langueID);
    return expression;

    }


    public static ExpressionStarter<Langues> And_Nom(this ExpressionStarter<Langues> expression, string nom)
    {
    if (!string.IsNullOrEmpty(nom))
     predicate =  expression.And(q => q.Nom == nom.Trim());
    return expression;

    }



    #endregion

    }

    #endregion

}
