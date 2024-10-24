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

    public class CreateCompetencesCommandHandler : IRequestHandler<CreateCompetencesCommand, CreateCompetencesViewModel>
    {
        private readonly ICompetencesRepository _CompetencesRepository;
        private readonly IMapper _mapper;
        public CreateCompetencesCommandHandler(IMapper mapper, ICompetencesRepository CompetencesRepository)
        {
            _mapper = mapper;
            _CompetencesRepository = CompetencesRepository;
        }
        public async Task<CreateCompetencesViewModel> Handle(CreateCompetencesCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<Competences>(request);
            entity = await _CompetencesRepository.AddAsync(entity, cancellationToken);
            CreateCompetencesViewModel response = new CreateCompetencesViewModel();
            response = _mapper.Map<Competences, CreateCompetencesViewModel>(entity, response);
            return response;
        }
    }
}
