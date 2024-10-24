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

    public class UpdateCVCompetencesCommandHandler : IRequestHandler<UpdateCVCompetencesCommand, UpdateCVCompetencesViewModel>
    {
        private readonly ICVCompetencesRepository _CVCompetencesRepository;
        private readonly IMapper _mapper;
        private readonly ICompetencesRepository _CompetencesRepository;
        private readonly ICVsRepository _CVsRepository;
        public UpdateCVCompetencesCommandHandler(IMapper mapper, ICVCompetencesRepository CVCompetencesRepository, ICompetencesRepository CompetencesRepository, ICVsRepository CVsRepository)
        {
            _mapper = mapper;
            _CVCompetencesRepository = CVCompetencesRepository;
            _CompetencesRepository = CompetencesRepository;
            _CVsRepository = CVsRepository;
        }
        public async Task<UpdateCVCompetencesViewModel> Handle(UpdateCVCompetencesCommand request, CancellationToken cancellationToken)
        {
            var entity = await _CVCompetencesRepository.GetByIdsAsync(request.old_CvId, request.old_CompetenceID);
            if (entity == null)
            {
                throw new NotFoundException(nameof(CVCompetences), request.old_CvId, request.old_CompetenceID);
            }
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
            UpdateCVCompetencesViewModel response = new UpdateCVCompetencesViewModel();
            await _CVCompetencesRepository.ExecuteTransactionAsync(async () =>
            {
                await _CVCompetencesRepository.DeleteAsync(entity);
                entity = _mapper.Map(request, entity);
                entity = await _CVCompetencesRepository.AddAsync(entity, cancellationToken);
            });
            response = _mapper.Map(entity, response);
            return response;
        }
    }
}
