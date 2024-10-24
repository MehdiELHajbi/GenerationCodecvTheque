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

    public class UpdateLanguesCommandHandler : IRequestHandler<UpdateLanguesCommand, UpdateLanguesViewModel>{
     private readonly ILanguesRepository _LanguesRepository;
    private readonly IMapper _mapper;
     public UpdateLanguesCommandHandler(IMapper mapper, ILanguesRepository LanguesRepository)
    {
     _mapper = mapper;
     _LanguesRepository = LanguesRepository;
     }
     public async Task<UpdateLanguesViewModel> Handle(UpdateLanguesCommand request, CancellationToken cancellationToken)
    {
    var entity = await _LanguesRepository.GetByIdsAsync(request.LangueID);
    if (entity == null)
    {
     throw new NotFoundException(nameof(Langues), request.LangueID);
    }
    UpdateLanguesViewModel response = new UpdateLanguesViewModel();
    entity = _mapper.Map(request, entity);
    await _LanguesRepository.UpdateAsync(entity);
    response = _mapper.Map<Langues, UpdateLanguesViewModel>(entity, response);
    return response;
     }
    }
}
