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

    public class UpdateProjetsPersonnelsCommandHandler : IRequestHandler<UpdateProjetsPersonnelsCommand, UpdateProjetsPersonnelsViewModel>{
     private readonly IProjetsPersonnelsRepository _ProjetsPersonnelsRepository;
    private readonly IMapper _mapper;
     private readonly ICVsRepository _CVsRepository;
     public UpdateProjetsPersonnelsCommandHandler(IMapper mapper, IProjetsPersonnelsRepository ProjetsPersonnelsRepository , ICVsRepository CVsRepository )
    {
     _mapper = mapper;
     _ProjetsPersonnelsRepository = ProjetsPersonnelsRepository;
    _CVsRepository = CVsRepository; 
     }
     public async Task<UpdateProjetsPersonnelsViewModel> Handle(UpdateProjetsPersonnelsCommand request, CancellationToken cancellationToken)
    {
    if (request.CvId.HasValue)
    {
    var cvs = await _CVsRepository.GetByIdAsync(request.CvId.Value);
    if (cvs == null)
    {
     throw new NotFoundException(nameof(CVs), request.CvId);
    }
    }
    var entity = await _ProjetsPersonnelsRepository.GetByIdsAsync(request.ProjetID);
    if (entity == null)
    {
     throw new NotFoundException(nameof(ProjetsPersonnels), request.ProjetID);
    }
    UpdateProjetsPersonnelsViewModel response = new UpdateProjetsPersonnelsViewModel();
    entity = _mapper.Map(request, entity);
    await _ProjetsPersonnelsRepository.UpdateAsync(entity);
    response = _mapper.Map<ProjetsPersonnels, UpdateProjetsPersonnelsViewModel>(entity, response);
    return response;
     }
    }
}
