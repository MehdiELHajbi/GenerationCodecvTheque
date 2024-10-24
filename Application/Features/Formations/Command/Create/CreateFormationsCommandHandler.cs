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

    public class CreateFormationsCommandHandler : IRequestHandler<CreateFormationsCommand, CreateFormationsViewModel>{
     private readonly IFormationsRepository _FormationsRepository;
    private readonly IMapper _mapper;
     private readonly ICVsRepository _CVsRepository;
     public CreateFormationsCommandHandler(IMapper mapper, IFormationsRepository FormationsRepository , ICVsRepository CVsRepository )
    {
     _mapper = mapper;
     _FormationsRepository = FormationsRepository;
    _CVsRepository = CVsRepository; 
     }
     public async Task<CreateFormationsViewModel> Handle(CreateFormationsCommand request, CancellationToken cancellationToken)
    {
    if (request.CvId.HasValue)
    {
    var cvs = await _CVsRepository.GetByIdAsync(request.CvId.Value);
    if (cvs == null)
    {
     throw new NotFoundException(nameof(CVs), request.CvId);
    }
    }
    var entity = _mapper.Map<Formations>(request);
    entity = await _FormationsRepository.AddAsync(entity, cancellationToken);
    CreateFormationsViewModel response = new CreateFormationsViewModel();
    response = _mapper.Map<Formations, CreateFormationsViewModel>(entity, response);
    return response;
     }
    }
}
