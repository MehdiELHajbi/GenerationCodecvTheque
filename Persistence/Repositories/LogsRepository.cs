using Application;
using Domain;
using LinqKit;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace InfrastructurePersistence
{
    public class LogsRepository : BaseRepository<Logs>, ILogsRepository
    {
    public LogsRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
    #region Generated Custom

    public virtual async Task<IReadOnlyList<Logs>> SearchAsync(ReadLogsQuery request)
    {
    return await GetMulipleAsync(request.GetPredicate());
    }

    #endregion

    }
    #region Generated Extension Methods

    public static class QueryExtensionLogs
    {
    private static ExpressionStarter<Logs> predicate { get; set; }
    #region Generated GetPredicate Method

    public static Expression<Func<Logs, bool>> GetPredicate(this ReadLogsQuery request)
    {
     predicate = PredicateBuilder.New<Logs>(true);
    predicate
    .And_Id(request.Id)
    .And_Message(request.Message)
    .And_MessageTemplate(request.MessageTemplate)
    .And_Level(request.Level)
    .And_TimeStamp(request.TimeStamp)
    .And_Exception(request.Exception)
    .And_Properties(request.Properties)
    ;

    return predicate;

    }


    #endregion

    #region Generated GetPredicate Method

    public static ExpressionStarter<Logs> And_Id(this ExpressionStarter<Logs> expression, int? id)
    {
    if (id.HasValue)
     predicate =  expression.And(q => q.Id == id);
    return expression;

    }


    public static ExpressionStarter<Logs> And_Message(this ExpressionStarter<Logs> expression, string message)
    {
    if (!string.IsNullOrEmpty(message))
     predicate =  expression.And(q => q.Message == message.Trim());
    return expression;

    }


    public static ExpressionStarter<Logs> And_MessageTemplate(this ExpressionStarter<Logs> expression, string messageTemplate)
    {
    if (!string.IsNullOrEmpty(messageTemplate))
     predicate =  expression.And(q => q.MessageTemplate == messageTemplate.Trim());
    return expression;

    }


    public static ExpressionStarter<Logs> And_Level(this ExpressionStarter<Logs> expression, string level)
    {
    if (!string.IsNullOrEmpty(level))
     predicate =  expression.And(q => q.Level == level.Trim());
    return expression;

    }


    public static ExpressionStarter<Logs> And_TimeStamp(this ExpressionStarter<Logs> expression, DateTime? timeStamp)
    {
    if (timeStamp != null)
     predicate =  expression.And(q => q.TimeStamp == timeStamp);
    return expression;

    }


    public static ExpressionStarter<Logs> And_Exception(this ExpressionStarter<Logs> expression, string exception)
    {
    if (!string.IsNullOrEmpty(exception))
     predicate =  expression.And(q => q.Exception == exception.Trim());
    return expression;

    }


    public static ExpressionStarter<Logs> And_Properties(this ExpressionStarter<Logs> expression, string properties)
    {
    if (!string.IsNullOrEmpty(properties))
     predicate =  expression.And(q => q.Properties == properties.Trim());
    return expression;

    }



    #endregion

    }

    #endregion

}
