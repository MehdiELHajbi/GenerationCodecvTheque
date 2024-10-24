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

    public class UpdateCVLanguesCommandHandler : IRequestHandler<UpdateCVLanguesCommand, UpdateCVLanguesViewModel>{
     private readonly ICVLanguesRepository _CVLanguesRepository;
    private readonly IMapper _mapper;
     private readonly ICVsRepository _CVsRepository;
     private readonly ILanguesRepository _LanguesRepository;
     public UpdateCVLanguesCommandHandler(IMapper mapper, ICVLanguesRepository CVLanguesRepository , ICVsRepository CVsRepository  , ILanguesRepository LanguesRepository )
    {
     _mapper = mapper;
     _CVLanguesRepository = CVLanguesRepository;
    _CVsRepository = CVsRepository; 
    _LanguesRepository = LanguesRepository; 
     }
     public async Task<UpdateCVLanguesViewModel> Handle(UpdateCVLanguesCommand request, CancellationToken cancellationToken)
    {
    var entity = await _CVLanguesRepository.GetByIdsAsync(request.old_CvId,request.old_LangueID);
    if (entity == null)
    {
     throw new NotFoundException(nameof(CVLangues), request.old_CvId,request.old_LangueID);
    }
    var cvs = await _CVsRepository.GetByIdAsync(request.CvId);
    if (cvs == null)
    {
     throw new NotFoundException(nameof(CVs), request.CvId);
    }
    var langues = await _LanguesRepository.GetByIdAsync(request.LangueID);
    if (langues == null)
    {
     throw new NotFoundException(nameof(Langues), request.LangueID);
    }
    UpdateCVLanguesViewModel response = new UpdateCVLanguesViewModel();
    await _CVLanguesRepository.ExecuteTransactionAsync(async () =>
    {
    await _CVLanguesRepository.DeleteAsync(entity);
    entity = _mapper.Map(request, entity);
    entity =  await _CVLanguesRepository.AddAsync(entity, cancellationToken);
    });
    response = _mapper.Map<CVLangues, UpdateCVLanguesViewModel>(entity, response);
    return response;
     }
    }
}
