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

    public class DeleteExperiencesCommandHandler : IRequestHandler<DeleteExperiencesCommand>{
     private readonly IExperiencesRepository _ExperiencesRepository;
    private readonly IMapper _mapper;
     public DeleteExperiencesCommandHandler(IMapper mapper, IExperiencesRepository ExperiencesRepository)
    {
     _mapper = mapper;
     _ExperiencesRepository = ExperiencesRepository;
     }
     public async Task<Unit> Handle(DeleteExperiencesCommand request, CancellationToken cancellationToken)
    {
    var entity = await _ExperiencesRepository.GetByIdsAsync(request.ExperienceID);
    if (entity == null)
    {
     throw new NotFoundException(nameof(Experiences), request.ExperienceID);
    }
      await _ExperiencesRepository.DeleteAsync(entity);
    return Unit.Value;
     }
    }
}
