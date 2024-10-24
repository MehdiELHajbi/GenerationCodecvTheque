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

    public class ReadCompetencesQueryHandler : IRequestHandler<ReadCompetencesQuery, IReadOnlyList<ReadCompetencesViewModel>>
    {
        private readonly ICompetencesRepository _CompetencesRepository;
        private readonly IMapper _mapper;
        public ReadCompetencesQueryHandler(IMapper mapper, ICompetencesRepository CompetencesRepository)
        {
            _mapper = mapper;
            _CompetencesRepository = CompetencesRepository;
        }
        public async Task<IReadOnlyList<ReadCompetencesViewModel>> Handle(ReadCompetencesQuery request, CancellationToken cancellationToken)
        {
            var entity = await _CompetencesRepository.SearchAsync(request);
            IReadOnlyList<ReadCompetencesViewModel> response = null;
            response = _mapper.Map(entity, response);
            return response;
        }
    }
}
