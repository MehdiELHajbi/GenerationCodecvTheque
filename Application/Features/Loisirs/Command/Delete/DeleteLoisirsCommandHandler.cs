using AutoMapper;
using MediatR;
using Newtonsoft.Json;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using Application;
using System.Collections.Generic;

namespace Application
{

    public class DeleteLoisirsCommandHandler : IRequestHandler<DeleteLoisirsCommand>{
     private readonly ILoisirsRepository _LoisirsRepository;
    private readonly IMapper _mapper;
     public DeleteLoisirsCommandHandler(IMapper mapper, ILoisirsRepository LoisirsRepository)
    {
     _mapper = mapper;
     _LoisirsRepository = LoisirsRepository;
     }
     public async Task<Unit> Handle(DeleteLoisirsCommand request, CancellationToken cancellationToken)
    {
    var entity = await _LoisirsRepository.GetByIdsAsync(request.LoisirID);
    if (entity == null)
    {
     throw new NotFoundException(nameof(Loisirs), request.LoisirID);
    }
      await _LoisirsRepository.DeleteAsync(entity);
    return Unit.Value;
     }
    }
}
