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

    public class DeleteProjetsPersonnelsCommandHandler : IRequestHandler<DeleteProjetsPersonnelsCommand>{
     private readonly IProjetsPersonnelsRepository _ProjetsPersonnelsRepository;
    private readonly IMapper _mapper;
     public DeleteProjetsPersonnelsCommandHandler(IMapper mapper, IProjetsPersonnelsRepository ProjetsPersonnelsRepository)
    {
     _mapper = mapper;
     _ProjetsPersonnelsRepository = ProjetsPersonnelsRepository;
     }
     public async Task<Unit> Handle(DeleteProjetsPersonnelsCommand request, CancellationToken cancellationToken)
    {
    var entity = await _ProjetsPersonnelsRepository.GetByIdsAsync(request.ProjetID);
    if (entity == null)
    {
     throw new NotFoundException(nameof(ProjetsPersonnels), request.ProjetID);
    }
      await _ProjetsPersonnelsRepository.DeleteAsync(entity);
    return Unit.Value;
     }
    }
}
