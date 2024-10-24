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

    public class ReadLanguesQueryHandler : IRequestHandler<ReadLanguesQuery,IReadOnlyList<ReadLanguesViewModel>>{
     private readonly ILanguesRepository _LanguesRepository;
    private readonly IMapper _mapper;
     public ReadLanguesQueryHandler(IMapper mapper, ILanguesRepository LanguesRepository)
    {
     _mapper = mapper;
     _LanguesRepository = LanguesRepository;
     }
     public async Task<IReadOnlyList<ReadLanguesViewModel>> Handle(ReadLanguesQuery request, CancellationToken cancellationToken)
    {
    var entity = await _LanguesRepository.SearchAsync(request);
    IReadOnlyList<ReadLanguesViewModel> response = null;
    response = _mapper.Map(entity, response);
    return response;
     }
    }
}
