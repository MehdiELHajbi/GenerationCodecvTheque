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

    public class CreateProjetsPersonnelsCommandHandler : IRequestHandler<CreateProjetsPersonnelsCommand, CreateProjetsPersonnelsViewModel>{
     private readonly IProjetsPersonnelsRepository _ProjetsPersonnelsRepository;
    private readonly IMapper _mapper;
     private readonly ICVsRepository _CVsRepository;
     public CreateProjetsPersonnelsCommandHandler(IMapper mapper, IProjetsPersonnelsRepository ProjetsPersonnelsRepository , ICVsRepository CVsRepository )
    {
     _mapper = mapper;
     _ProjetsPersonnelsRepository = ProjetsPersonnelsRepository;
    _CVsRepository = CVsRepository; 
     }
     public async Task<CreateProjetsPersonnelsViewModel> Handle(CreateProjetsPersonnelsCommand request, CancellationToken cancellationToken)
    {
    if (request.CvId.HasValue)
    {
    var cvs = await _CVsRepository.GetByIdAsync(request.CvId.Value);
    if (cvs == null)
    {
     throw new NotFoundException(nameof(CVs), request.CvId);
    }
    }
    var entity = _mapper.Map<ProjetsPersonnels>(request);
    entity = await _ProjetsPersonnelsRepository.AddAsync(entity, cancellationToken);
    CreateProjetsPersonnelsViewModel response = new CreateProjetsPersonnelsViewModel();
    response = _mapper.Map<ProjetsPersonnels, CreateProjetsPersonnelsViewModel>(entity, response);
    return response;
     }
    }
}
