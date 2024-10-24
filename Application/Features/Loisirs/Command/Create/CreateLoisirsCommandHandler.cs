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

    public class CreateLoisirsCommandHandler : IRequestHandler<CreateLoisirsCommand, CreateLoisirsViewModel>{
     private readonly ILoisirsRepository _LoisirsRepository;
    private readonly IMapper _mapper;
     private readonly ICVsRepository _CVsRepository;
     public CreateLoisirsCommandHandler(IMapper mapper, ILoisirsRepository LoisirsRepository , ICVsRepository CVsRepository )
    {
     _mapper = mapper;
     _LoisirsRepository = LoisirsRepository;
    _CVsRepository = CVsRepository; 
     }
     public async Task<CreateLoisirsViewModel> Handle(CreateLoisirsCommand request, CancellationToken cancellationToken)
    {
    if (request.CvId.HasValue)
    {
    var cvs = await _CVsRepository.GetByIdAsync(request.CvId.Value);
    if (cvs == null)
    {
     throw new NotFoundException(nameof(CVs), request.CvId);
    }
    }
    var entity = _mapper.Map<Loisirs>(request);
    entity = await _LoisirsRepository.AddAsync(entity, cancellationToken);
    CreateLoisirsViewModel response = new CreateLoisirsViewModel();
    response = _mapper.Map<Loisirs, CreateLoisirsViewModel>(entity, response);
    return response;
     }
    }
}
