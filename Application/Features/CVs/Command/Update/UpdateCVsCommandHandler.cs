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

    public class UpdateCVsCommandHandler : IRequestHandler<UpdateCVsCommand, UpdateCVsViewModel>{
     private readonly ICVsRepository _CVsRepository;
    private readonly IMapper _mapper;
     public UpdateCVsCommandHandler(IMapper mapper, ICVsRepository CVsRepository)
    {
     _mapper = mapper;
     _CVsRepository = CVsRepository;
     }
     public async Task<UpdateCVsViewModel> Handle(UpdateCVsCommand request, CancellationToken cancellationToken)
    {
    var entity = await _CVsRepository.GetByIdsAsync(request.CvId);
    if (entity == null)
    {
     throw new NotFoundException(nameof(CVs), request.CvId);
    }
    UpdateCVsViewModel response = new UpdateCVsViewModel();
    entity = _mapper.Map(request, entity);
    await _CVsRepository.UpdateAsync(entity);
    response = _mapper.Map<CVs, UpdateCVsViewModel>(entity, response);
    return response;
     }
    }
}
