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

    public class CreateCVCompetencesCommandHandler : IRequestHandler<CreateCVCompetencesCommand, CreateCVCompetencesViewModel>
    {
        private readonly ICVCompetencesRepository _CVCompetencesRepository;
        private readonly IMapper _mapper;
        private readonly ICompetencesRepository _CompetencesRepository;
        private readonly ICVsRepository _CVsRepository;
        public CreateCVCompetencesCommandHandler(IMapper mapper, ICVCompetencesRepository CVCompetencesRepository, ICompetencesRepository CompetencesRepository, ICVsRepository CVsRepository)
        {
            _mapper = mapper;
            _CVCompetencesRepository = CVCompetencesRepository;
            _CompetencesRepository = CompetencesRepository;
            _CVsRepository = CVsRepository;
        }
        public async Task<CreateCVCompetencesViewModel> Handle(CreateCVCompetencesCommand request, CancellationToken cancellationToken)
        {
            var competences = await _CompetencesRepository.GetByIdAsync(request.CompetenceID);
            if (competences == null)
            {
                throw new NotFoundException(nameof(Competences), request.CompetenceID);
            }

            var cvs = await _CVsRepository.GetByIdAsync(request.CvId);
            if (cvs == null)
            {
                throw new NotFoundException(nameof(CVs), request.CvId);
            }


            var entity = _mapper.Map<CVCompetences>(request);
            entity = await _CVCompetencesRepository.AddAsync(entity, cancellationToken);
            CreateCVCompetencesViewModel response = new CreateCVCompetencesViewModel();
            response = _mapper.Map<CVCompetences, CreateCVCompetencesViewModel>(entity, response);
            return response;


        }
    }
}
