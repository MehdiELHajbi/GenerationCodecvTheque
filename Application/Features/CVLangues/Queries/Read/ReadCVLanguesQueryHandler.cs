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

    public class ReadCVLanguesQueryHandler : IRequestHandler<ReadCVLanguesQuery,IReadOnlyList<ReadCVLanguesViewModel>>{
     private readonly ICVLanguesRepository _CVLanguesRepository;
    private readonly IMapper _mapper;
     public ReadCVLanguesQueryHandler(IMapper mapper, ICVLanguesRepository CVLanguesRepository)
    {
     _mapper = mapper;
     _CVLanguesRepository = CVLanguesRepository;
     }
     public async Task<IReadOnlyList<ReadCVLanguesViewModel>> Handle(ReadCVLanguesQuery request, CancellationToken cancellationToken)
    {
    var entity = await _CVLanguesRepository.SearchAsync(request);
    IReadOnlyList<ReadCVLanguesViewModel> response = null;
    response = _mapper.Map(entity, response);
    return response;
     }
    }
}
