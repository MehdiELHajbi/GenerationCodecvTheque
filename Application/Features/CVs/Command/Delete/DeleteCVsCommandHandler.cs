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

    public class DeleteCVsCommandHandler : IRequestHandler<DeleteCVsCommand>{
     private readonly ICVsRepository _CVsRepository;
    private readonly IMapper _mapper;
     public DeleteCVsCommandHandler(IMapper mapper, ICVsRepository CVsRepository)
    {
     _mapper = mapper;
     _CVsRepository = CVsRepository;
     }
     public async Task<Unit> Handle(DeleteCVsCommand request, CancellationToken cancellationToken)
    {
    var entity = await _CVsRepository.GetByIdsAsync(request.CvId);
    if (entity == null)
    {
     throw new NotFoundException(nameof(CVs), request.CvId);
    }
      await _CVsRepository.DeleteAsync(entity);
    return Unit.Value;
     }
    }
}
