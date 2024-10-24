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

    public class UpdateReferencesContactCommandHandler : IRequestHandler<UpdateReferencesContactCommand, UpdateReferencesContactViewModel>{
     private readonly IReferencesContactRepository _ReferencesContactRepository;
    private readonly IMapper _mapper;
     private readonly ICVsRepository _CVsRepository;
     public UpdateReferencesContactCommandHandler(IMapper mapper, IReferencesContactRepository ReferencesContactRepository , ICVsRepository CVsRepository )
    {
     _mapper = mapper;
     _ReferencesContactRepository = ReferencesContactRepository;
    _CVsRepository = CVsRepository; 
     }
     public async Task<UpdateReferencesContactViewModel> Handle(UpdateReferencesContactCommand request, CancellationToken cancellationToken)
    {
    if (request.CvId.HasValue)
    {
    var cvs = await _CVsRepository.GetByIdAsync(request.CvId.Value);
    if (cvs == null)
    {
     throw new NotFoundException(nameof(CVs), request.CvId);
    }
    }
    var entity = await _ReferencesContactRepository.GetByIdsAsync(request.ReferenceID);
    if (entity == null)
    {
     throw new NotFoundException(nameof(ReferencesContact), request.ReferenceID);
    }
    UpdateReferencesContactViewModel response = new UpdateReferencesContactViewModel();
    entity = _mapper.Map(request, entity);
    await _ReferencesContactRepository.UpdateAsync(entity);
    response = _mapper.Map<ReferencesContact, UpdateReferencesContactViewModel>(entity, response);
    return response;
     }
    }
}
