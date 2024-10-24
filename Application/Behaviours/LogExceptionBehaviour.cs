using Application.Contracts.Infrastructure;
using MediatR;
using Newtonsoft.Json;
using System;
using System.Threading;
using System.Threading.Tasks;
namespace Application.Behaviours
{
    public class LogExceptionBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
    {
        private readonly IFLog<TRequest> _logger;

        public LogExceptionBehaviour(IFLog<TRequest> logger)
        {
            _logger = logger;
        }



        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            try
            {
                return await next();
            }
            catch (Exception exception)
            {



                _logger.WriteError(exception, JsonConvert.SerializeObject(exception));

                throw;
            }
        }
    }


}
