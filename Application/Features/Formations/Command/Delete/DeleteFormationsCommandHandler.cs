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

    public class DeleteFormationsCommandHandler : IRequestHandler<DeleteFormationsCommand>{
     private readonly IFormationsRepository _FormationsRepository;
    private readonly IMapper _mapper;
     public DeleteFormationsCommandHandler(IMapper mapper, IFormationsRepository FormationsRepository)
    {
     _mapper = mapper;
     _FormationsRepository = FormationsRepository;
     }
     public async Task<Unit> Handle(DeleteFormationsCommand request, CancellationToken cancellationToken)
    {
    var entity = await _FormationsRepository.GetByIdsAsync(request.FormationID);
    if (entity == null)
    {
     throw new NotFoundException(nameof(Formations), request.FormationID);
    }
      await _FormationsRepository.DeleteAsync(entity);
    return Unit.Value;
     }
    }
}
