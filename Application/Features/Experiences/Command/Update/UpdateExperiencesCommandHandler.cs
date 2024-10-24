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

    public class UpdateExperiencesCommandHandler : IRequestHandler<UpdateExperiencesCommand, UpdateExperiencesViewModel>{
     private readonly IExperiencesRepository _ExperiencesRepository;
    private readonly IMapper _mapper;
     private readonly ICVsRepository _CVsRepository;
     public UpdateExperiencesCommandHandler(IMapper mapper, IExperiencesRepository ExperiencesRepository , ICVsRepository CVsRepository )
    {
     _mapper = mapper;
     _ExperiencesRepository = ExperiencesRepository;
    _CVsRepository = CVsRepository; 
     }
     public async Task<UpdateExperiencesViewModel> Handle(UpdateExperiencesCommand request, CancellationToken cancellationToken)
    {
    if (request.CvId.HasValue)
    {
    var cvs = await _CVsRepository.GetByIdAsync(request.CvId.Value);
    if (cvs == null)
    {
     throw new NotFoundException(nameof(CVs), request.CvId);
    }
    }
    var entity = await _ExperiencesRepository.GetByIdsAsync(request.ExperienceID);
    if (entity == null)
    {
     throw new NotFoundException(nameof(Experiences), request.ExperienceID);
    }
    UpdateExperiencesViewModel response = new UpdateExperiencesViewModel();
    entity = _mapper.Map(request, entity);
    await _ExperiencesRepository.UpdateAsync(entity);
    response = _mapper.Map<Experiences, UpdateExperiencesViewModel>(entity, response);
    return response;
     }
    }
}
