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

    public class DeleteLanguesCommandHandler : IRequestHandler<DeleteLanguesCommand>{
     private readonly ILanguesRepository _LanguesRepository;
    private readonly IMapper _mapper;
     public DeleteLanguesCommandHandler(IMapper mapper, ILanguesRepository LanguesRepository)
    {
     _mapper = mapper;
     _LanguesRepository = LanguesRepository;
     }
     public async Task<Unit> Handle(DeleteLanguesCommand request, CancellationToken cancellationToken)
    {
    var entity = await _LanguesRepository.GetByIdsAsync(request.LangueID);
    if (entity == null)
    {
     throw new NotFoundException(nameof(Langues), request.LangueID);
    }
      await _LanguesRepository.DeleteAsync(entity);
    return Unit.Value;
     }
    }
}
