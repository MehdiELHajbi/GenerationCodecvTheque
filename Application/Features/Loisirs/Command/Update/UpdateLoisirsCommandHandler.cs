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

    public class UpdateLoisirsCommandHandler : IRequestHandler<UpdateLoisirsCommand, UpdateLoisirsViewModel>{
     private readonly ILoisirsRepository _LoisirsRepository;
    private readonly IMapper _mapper;
     private readonly ICVsRepository _CVsRepository;
     public UpdateLoisirsCommandHandler(IMapper mapper, ILoisirsRepository LoisirsRepository , ICVsRepository CVsRepository )
    {
     _mapper = mapper;
     _LoisirsRepository = LoisirsRepository;
    _CVsRepository = CVsRepository; 
     }
     public async Task<UpdateLoisirsViewModel> Handle(UpdateLoisirsCommand request, CancellationToken cancellationToken)
    {
    if (request.CvId.HasValue)
    {
    var cvs = await _CVsRepository.GetByIdAsync(request.CvId.Value);
    if (cvs == null)
    {
     throw new NotFoundException(nameof(CVs), request.CvId);
    }
    }
    var entity = await _LoisirsRepository.GetByIdsAsync(request.LoisirID);
    if (entity == null)
    {
     throw new NotFoundException(nameof(Loisirs), request.LoisirID);
    }
    UpdateLoisirsViewModel response = new UpdateLoisirsViewModel();
    entity = _mapper.Map(request, entity);
    await _LoisirsRepository.UpdateAsync(entity);
    response = _mapper.Map<Loisirs, UpdateLoisirsViewModel>(entity, response);
    return response;
     }
    }
}
