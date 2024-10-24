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

    public class ReadCVCompetencesQueryHandler : IRequestHandler<ReadCVCompetencesQuery,IReadOnlyList<ReadCVCompetencesViewModel>>{
     private readonly ICVCompetencesRepository _CVCompetencesRepository;
    private readonly IMapper _mapper;
     public ReadCVCompetencesQueryHandler(IMapper mapper, ICVCompetencesRepository CVCompetencesRepository)
    {
     _mapper = mapper;
     _CVCompetencesRepository = CVCompetencesRepository;
     }
     public async Task<IReadOnlyList<ReadCVCompetencesViewModel>> Handle(ReadCVCompetencesQuery request, CancellationToken cancellationToken)
    {
    var entity = await _CVCompetencesRepository.SearchAsync(request);
    IReadOnlyList<ReadCVCompetencesViewModel> response = null;
    response = _mapper.Map(entity, response);
    return response;
     }
    }
}
