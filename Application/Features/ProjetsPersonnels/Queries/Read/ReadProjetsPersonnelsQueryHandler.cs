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

    public class ReadProjetsPersonnelsQueryHandler : IRequestHandler<ReadProjetsPersonnelsQuery,IReadOnlyList<ReadProjetsPersonnelsViewModel>>{
     private readonly IProjetsPersonnelsRepository _ProjetsPersonnelsRepository;
    private readonly IMapper _mapper;
     public ReadProjetsPersonnelsQueryHandler(IMapper mapper, IProjetsPersonnelsRepository ProjetsPersonnelsRepository)
    {
     _mapper = mapper;
     _ProjetsPersonnelsRepository = ProjetsPersonnelsRepository;
     }
     public async Task<IReadOnlyList<ReadProjetsPersonnelsViewModel>> Handle(ReadProjetsPersonnelsQuery request, CancellationToken cancellationToken)
    {
    var entity = await _ProjetsPersonnelsRepository.SearchAsync(request);
    IReadOnlyList<ReadProjetsPersonnelsViewModel> response = null;
    response = _mapper.Map(entity, response);
    return response;
     }
    }
}
