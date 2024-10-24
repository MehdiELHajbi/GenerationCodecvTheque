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

    public class DeleteCVCompetencesCommandHandler : IRequestHandler<DeleteCVCompetencesCommand>{
     private readonly ICVCompetencesRepository _CVCompetencesRepository;
    private readonly IMapper _mapper;
     public DeleteCVCompetencesCommandHandler(IMapper mapper, ICVCompetencesRepository CVCompetencesRepository)
    {
     _mapper = mapper;
     _CVCompetencesRepository = CVCompetencesRepository;
     }
     public async Task<Unit> Handle(DeleteCVCompetencesCommand request, CancellationToken cancellationToken)
    {
    var entity = await _CVCompetencesRepository.GetByIdsAsync(request.CvId,request.CompetenceID);
    if (entity == null)
    {
     throw new NotFoundException(nameof(CVCompetences), request.CvId,request.CompetenceID);
    }
      await _CVCompetencesRepository.DeleteAsync(entity);
    return Unit.Value;
     }
    }
}
