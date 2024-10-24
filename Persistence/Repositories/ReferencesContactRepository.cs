using Application;
using Domain;
using LinqKit;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace InfrastructurePersistence
{
    public class ReferencesContactRepository : BaseRepository<ReferencesContact>, IReferencesContactRepository
    {
    public ReferencesContactRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
    #region Generated Custom

    public virtual async Task<IReadOnlyList<ReferencesContact>> SearchAsync(ReadReferencesContactQuery request)
    {
    return await GetMulipleAsync(request.GetPredicate());
    }

    #endregion

    }
    #region Generated Extension Methods

    public static class QueryExtensionReferencesContact
    {
    private static ExpressionStarter<ReferencesContact> predicate { get; set; }
    #region Generated GetPredicate Method

    public static Expression<Func<ReferencesContact, bool>> GetPredicate(this ReadReferencesContactQuery request)
    {
     predicate = PredicateBuilder.New<ReferencesContact>(true);
    predicate
    .And_ReferenceID(request.ReferenceID)
    .And_CvId(request.CvId)
    .And_Nom(request.Nom)
    .And_Relation(request.Relation)
    .And_ContactInfo(request.ContactInfo)
    ;

    return predicate;

    }


    #endregion

    #region Generated GetPredicate Method

    public static ExpressionStarter<ReferencesContact> And_ReferenceID(this ExpressionStarter<ReferencesContact> expression, int? referenceID)
    {
    if (referenceID.HasValue)
     predicate =  expression.And(q => q.ReferenceID == referenceID);
    return expression;

    }


    public static ExpressionStarter<ReferencesContact> And_CvId(this ExpressionStarter<ReferencesContact> expression, int? cvId)
    {
    if (cvId.HasValue)
     predicate =  expression.And(q => q.CvId == cvId);
    return expression;

    }


    public static ExpressionStarter<ReferencesContact> And_Nom(this ExpressionStarter<ReferencesContact> expression, string nom)
    {
    if (!string.IsNullOrEmpty(nom))
     predicate =  expression.And(q => q.Nom == nom.Trim());
    return expression;

    }


    public static ExpressionStarter<ReferencesContact> And_Relation(this ExpressionStarter<ReferencesContact> expression, string relation)
    {
    if (!string.IsNullOrEmpty(relation))
     predicate =  expression.And(q => q.Relation == relation.Trim());
    return expression;

    }


    public static ExpressionStarter<ReferencesContact> And_ContactInfo(this ExpressionStarter<ReferencesContact> expression, string contactInfo)
    {
    if (!string.IsNullOrEmpty(contactInfo))
     predicate =  expression.And(q => q.ContactInfo == contactInfo.Trim());
    return expression;

    }



    #endregion

    }

    #endregion

}
