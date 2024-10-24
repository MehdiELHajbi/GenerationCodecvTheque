using Application;
using Domain;
using LinqKit;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace InfrastructurePersistence
{
    public class CertificationsRepository : BaseRepository<Certifications>, ICertificationsRepository
    {
    public CertificationsRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
    #region Generated Custom

    public virtual async Task<IReadOnlyList<Certifications>> SearchAsync(ReadCertificationsQuery request)
    {
    return await GetMulipleAsync(request.GetPredicate());
    }

    #endregion

    }
    #region Generated Extension Methods

    public static class QueryExtensionCertifications
    {
    private static ExpressionStarter<Certifications> predicate { get; set; }
    #region Generated GetPredicate Method

    public static Expression<Func<Certifications, bool>> GetPredicate(this ReadCertificationsQuery request)
    {
     predicate = PredicateBuilder.New<Certifications>(true);
    predicate
    .And_CertificationID(request.CertificationID)
    .And_CvId(request.CvId)
    .And_Titre(request.Titre)
    .And_Organisme(request.Organisme)
    .And_DateObtention(request.DateObtention)
    .And_DateExpiration(request.DateExpiration)
    ;

    return predicate;

    }


    #endregion

    #region Generated GetPredicate Method

    public static ExpressionStarter<Certifications> And_CertificationID(this ExpressionStarter<Certifications> expression, int? certificationID)
    {
    if (certificationID.HasValue)
     predicate =  expression.And(q => q.CertificationID == certificationID);
    return expression;

    }


    public static ExpressionStarter<Certifications> And_CvId(this ExpressionStarter<Certifications> expression, int? cvId)
    {
    if (cvId.HasValue)
     predicate =  expression.And(q => q.CvId == cvId);
    return expression;

    }


    public static ExpressionStarter<Certifications> And_Titre(this ExpressionStarter<Certifications> expression, string titre)
    {
    if (!string.IsNullOrEmpty(titre))
     predicate =  expression.And(q => q.Titre == titre.Trim());
    return expression;

    }


    public static ExpressionStarter<Certifications> And_Organisme(this ExpressionStarter<Certifications> expression, string organisme)
    {
    if (!string.IsNullOrEmpty(organisme))
     predicate =  expression.And(q => q.Organisme == organisme.Trim());
    return expression;

    }


    public static ExpressionStarter<Certifications> And_DateObtention(this ExpressionStarter<Certifications> expression, DateTime? dateObtention)
    {
    if (dateObtention != null)
     predicate =  expression.And(q => q.DateObtention == dateObtention);
    return expression;

    }


    public static ExpressionStarter<Certifications> And_DateExpiration(this ExpressionStarter<Certifications> expression, DateTime? dateExpiration)
    {
    if (dateExpiration != null)
     predicate =  expression.And(q => q.DateExpiration == dateExpiration);
    return expression;

    }



    #endregion

    }

    #endregion

}
