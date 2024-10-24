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

    public class CreateLanguesCommandHandler : IRequestHandler<CreateLanguesCommand, CreateLanguesViewModel>{
     private readonly ILanguesRepository _LanguesRepository;
    private readonly IMapper _mapper;
     public CreateLanguesCommandHandler(IMapper mapper, ILanguesRepository LanguesRepository)
    {
     _mapper = mapper;
     _LanguesRepository = LanguesRepository;
     }
     public async Task<CreateLanguesViewModel> Handle(CreateLanguesCommand request, CancellationToken cancellationToken)
    {
    var entity = _mapper.Map<Langues>(request);
    entity = await _LanguesRepository.AddAsync(entity, cancellationToken);
    CreateLanguesViewModel response = new CreateLanguesViewModel();
    response = _mapper.Map<Langues, CreateLanguesViewModel>(entity, response);
    return response;
     }
    }
}
