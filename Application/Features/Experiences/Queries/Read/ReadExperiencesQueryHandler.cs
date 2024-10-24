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

    public class ReadExperiencesQueryHandler : IRequestHandler<ReadExperiencesQuery,IReadOnlyList<ReadExperiencesViewModel>>{
     private readonly IExperiencesRepository _ExperiencesRepository;
    private readonly IMapper _mapper;
     public ReadExperiencesQueryHandler(IMapper mapper, IExperiencesRepository ExperiencesRepository)
    {
     _mapper = mapper;
     _ExperiencesRepository = ExperiencesRepository;
     }
     public async Task<IReadOnlyList<ReadExperiencesViewModel>> Handle(ReadExperiencesQuery request, CancellationToken cancellationToken)
    {
    var entity = await _ExperiencesRepository.SearchAsync(request);
    IReadOnlyList<ReadExperiencesViewModel> response = null;
    response = _mapper.Map(entity, response);
    return response;
     }
    }
}
