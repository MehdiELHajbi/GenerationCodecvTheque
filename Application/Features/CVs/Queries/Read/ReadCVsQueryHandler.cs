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

    public class ReadCVsQueryHandler : IRequestHandler<ReadCVsQuery,IReadOnlyList<ReadCVsViewModel>>{
     private readonly ICVsRepository _CVsRepository;
    private readonly IMapper _mapper;
     public ReadCVsQueryHandler(IMapper mapper, ICVsRepository CVsRepository)
    {
     _mapper = mapper;
     _CVsRepository = CVsRepository;
     }
     public async Task<IReadOnlyList<ReadCVsViewModel>> Handle(ReadCVsQuery request, CancellationToken cancellationToken)
    {
    var entity = await _CVsRepository.SearchAsync(request);
    IReadOnlyList<ReadCVsViewModel> response = null;
    response = _mapper.Map(entity, response);
    return response;
     }
    }
}
