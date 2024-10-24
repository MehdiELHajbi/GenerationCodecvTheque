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

    public class CreateCVsCommandHandler : IRequestHandler<CreateCVsCommand, CreateCVsViewModel>{
     private readonly ICVsRepository _CVsRepository;
    private readonly IMapper _mapper;
     public CreateCVsCommandHandler(IMapper mapper, ICVsRepository CVsRepository)
    {
     _mapper = mapper;
     _CVsRepository = CVsRepository;
     }
     public async Task<CreateCVsViewModel> Handle(CreateCVsCommand request, CancellationToken cancellationToken)
    {
    var entity = _mapper.Map<CVs>(request);
    entity = await _CVsRepository.AddAsync(entity, cancellationToken);
    CreateCVsViewModel response = new CreateCVsViewModel();
    response = _mapper.Map<CVs, CreateCVsViewModel>(entity, response);
    return response;
     }
    }
}
