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

    public class UpdateCompetencesCommandHandler : IRequestHandler<UpdateCompetencesCommand, UpdateCompetencesViewModel>{
     private readonly ICompetencesRepository _CompetencesRepository;
    private readonly IMapper _mapper;
     public UpdateCompetencesCommandHandler(IMapper mapper, ICompetencesRepository CompetencesRepository)
    {
     _mapper = mapper;
     _CompetencesRepository = CompetencesRepository;
     }
     public async Task<UpdateCompetencesViewModel> Handle(UpdateCompetencesCommand request, CancellationToken cancellationToken)
    {
    var entity = await _CompetencesRepository.GetByIdsAsync(request.CompetenceID);
    if (entity == null)
    {
     throw new NotFoundException(nameof(Competences), request.CompetenceID);
    }
    UpdateCompetencesViewModel response = new UpdateCompetencesViewModel();
    entity = _mapper.Map(request, entity);
    await _CompetencesRepository.UpdateAsync(entity);
    response = _mapper.Map<Competences, UpdateCompetencesViewModel>(entity, response);
    return response;
     }
    }
}
