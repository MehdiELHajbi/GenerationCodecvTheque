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

    public class DeleteCVLanguesCommandHandler : IRequestHandler<DeleteCVLanguesCommand>{
     private readonly ICVLanguesRepository _CVLanguesRepository;
    private readonly IMapper _mapper;
     public DeleteCVLanguesCommandHandler(IMapper mapper, ICVLanguesRepository CVLanguesRepository)
    {
     _mapper = mapper;
     _CVLanguesRepository = CVLanguesRepository;
     }
     public async Task<Unit> Handle(DeleteCVLanguesCommand request, CancellationToken cancellationToken)
    {
    var entity = await _CVLanguesRepository.GetByIdsAsync(request.CvId,request.LangueID);
    if (entity == null)
    {
     throw new NotFoundException(nameof(CVLangues), request.CvId,request.LangueID);
    }
      await _CVLanguesRepository.DeleteAsync(entity);
    return Unit.Value;
     }
    }
}
