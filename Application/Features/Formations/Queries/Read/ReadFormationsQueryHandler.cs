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

    public class ReadFormationsQueryHandler : IRequestHandler<ReadFormationsQuery,IReadOnlyList<ReadFormationsViewModel>>{
     private readonly IFormationsRepository _FormationsRepository;
    private readonly IMapper _mapper;
     public ReadFormationsQueryHandler(IMapper mapper, IFormationsRepository FormationsRepository)
    {
     _mapper = mapper;
     _FormationsRepository = FormationsRepository;
     }
     public async Task<IReadOnlyList<ReadFormationsViewModel>> Handle(ReadFormationsQuery request, CancellationToken cancellationToken)
    {
    var entity = await _FormationsRepository.SearchAsync(request);
    IReadOnlyList<ReadFormationsViewModel> response = null;
    response = _mapper.Map(entity, response);
    return response;
     }
    }
}
