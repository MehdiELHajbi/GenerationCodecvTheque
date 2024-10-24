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

    public class ReadLoisirsQueryHandler : IRequestHandler<ReadLoisirsQuery,IReadOnlyList<ReadLoisirsViewModel>>{
     private readonly ILoisirsRepository _LoisirsRepository;
    private readonly IMapper _mapper;
     public ReadLoisirsQueryHandler(IMapper mapper, ILoisirsRepository LoisirsRepository)
    {
     _mapper = mapper;
     _LoisirsRepository = LoisirsRepository;
     }
     public async Task<IReadOnlyList<ReadLoisirsViewModel>> Handle(ReadLoisirsQuery request, CancellationToken cancellationToken)
    {
    var entity = await _LoisirsRepository.SearchAsync(request);
    IReadOnlyList<ReadLoisirsViewModel> response = null;
    response = _mapper.Map(entity, response);
    return response;
     }
    }
}
