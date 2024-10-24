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

    public class DeleteReferencesContactCommandHandler : IRequestHandler<DeleteReferencesContactCommand>{
     private readonly IReferencesContactRepository _ReferencesContactRepository;
    private readonly IMapper _mapper;
     public DeleteReferencesContactCommandHandler(IMapper mapper, IReferencesContactRepository ReferencesContactRepository)
    {
     _mapper = mapper;
     _ReferencesContactRepository = ReferencesContactRepository;
     }
     public async Task<Unit> Handle(DeleteReferencesContactCommand request, CancellationToken cancellationToken)
    {
    var entity = await _ReferencesContactRepository.GetByIdsAsync(request.ReferenceID);
    if (entity == null)
    {
     throw new NotFoundException(nameof(ReferencesContact), request.ReferenceID);
    }
      await _ReferencesContactRepository.DeleteAsync(entity);
    return Unit.Value;
     }
    }
}
