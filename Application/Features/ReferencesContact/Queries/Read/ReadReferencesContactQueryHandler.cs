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

    public class ReadReferencesContactQueryHandler : IRequestHandler<ReadReferencesContactQuery,IReadOnlyList<ReadReferencesContactViewModel>>{
     private readonly IReferencesContactRepository _ReferencesContactRepository;
    private readonly IMapper _mapper;
     public ReadReferencesContactQueryHandler(IMapper mapper, IReferencesContactRepository ReferencesContactRepository)
    {
     _mapper = mapper;
     _ReferencesContactRepository = ReferencesContactRepository;
     }
     public async Task<IReadOnlyList<ReadReferencesContactViewModel>> Handle(ReadReferencesContactQuery request, CancellationToken cancellationToken)
    {
    var entity = await _ReferencesContactRepository.SearchAsync(request);
    IReadOnlyList<ReadReferencesContactViewModel> response = null;
    response = _mapper.Map(entity, response);
    return response;
     }
    }
}
