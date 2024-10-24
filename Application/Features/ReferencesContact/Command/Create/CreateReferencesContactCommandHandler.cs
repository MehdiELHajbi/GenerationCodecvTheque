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

    public class CreateReferencesContactCommandHandler : IRequestHandler<CreateReferencesContactCommand, CreateReferencesContactViewModel>{
     private readonly IReferencesContactRepository _ReferencesContactRepository;
    private readonly IMapper _mapper;
     private readonly ICVsRepository _CVsRepository;
     public CreateReferencesContactCommandHandler(IMapper mapper, IReferencesContactRepository ReferencesContactRepository , ICVsRepository CVsRepository )
    {
     _mapper = mapper;
     _ReferencesContactRepository = ReferencesContactRepository;
    _CVsRepository = CVsRepository; 
     }
     public async Task<CreateReferencesContactViewModel> Handle(CreateReferencesContactCommand request, CancellationToken cancellationToken)
    {
    if (request.CvId.HasValue)
    {
    var cvs = await _CVsRepository.GetByIdAsync(request.CvId.Value);
    if (cvs == null)
    {
     throw new NotFoundException(nameof(CVs), request.CvId);
    }
    }
    var entity = _mapper.Map<ReferencesContact>(request);
    entity = await _ReferencesContactRepository.AddAsync(entity, cancellationToken);
    CreateReferencesContactViewModel response = new CreateReferencesContactViewModel();
    response = _mapper.Map<ReferencesContact, CreateReferencesContactViewModel>(entity, response);
    return response;
     }
    }
}
