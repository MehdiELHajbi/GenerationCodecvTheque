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

    public class UpdateFormationsCommandHandler : IRequestHandler<UpdateFormationsCommand, UpdateFormationsViewModel>{
     private readonly IFormationsRepository _FormationsRepository;
    private readonly IMapper _mapper;
     private readonly ICVsRepository _CVsRepository;
     public UpdateFormationsCommandHandler(IMapper mapper, IFormationsRepository FormationsRepository , ICVsRepository CVsRepository )
    {
     _mapper = mapper;
     _FormationsRepository = FormationsRepository;
    _CVsRepository = CVsRepository; 
     }
     public async Task<UpdateFormationsViewModel> Handle(UpdateFormationsCommand request, CancellationToken cancellationToken)
    {
    if (request.CvId.HasValue)
    {
    var cvs = await _CVsRepository.GetByIdAsync(request.CvId.Value);
    if (cvs == null)
    {
     throw new NotFoundException(nameof(CVs), request.CvId);
    }
    }
    var entity = await _FormationsRepository.GetByIdsAsync(request.FormationID);
    if (entity == null)
    {
     throw new NotFoundException(nameof(Formations), request.FormationID);
    }
    UpdateFormationsViewModel response = new UpdateFormationsViewModel();
    entity = _mapper.Map(request, entity);
    await _FormationsRepository.UpdateAsync(entity);
    response = _mapper.Map<Formations, UpdateFormationsViewModel>(entity, response);
    return response;
     }
    }
}
