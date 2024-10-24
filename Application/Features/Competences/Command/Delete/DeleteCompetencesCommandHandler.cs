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

    public class DeleteCompetencesCommandHandler : IRequestHandler<DeleteCompetencesCommand>
    {
        private readonly ICompetencesRepository _CompetencesRepository;
        private readonly IMapper _mapper;
        public DeleteCompetencesCommandHandler(IMapper mapper, ICompetencesRepository CompetencesRepository)
        {
            _mapper = mapper;
            _CompetencesRepository = CompetencesRepository;
        }
        public async Task<Unit> Handle(DeleteCompetencesCommand request, CancellationToken cancellationToken)
        {
            var entity = await _CompetencesRepository.GetByIdsAsync(request.CompetenceID);
            if (entity == null)
            {
                throw new NotFoundException(nameof(Competences), request.CompetenceID);
            }
            await _CompetencesRepository.DeleteAsync(entity);
            return Unit.Value;
        }
    }
}
