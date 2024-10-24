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

    public class CreateExperiencesCommandHandler : IRequestHandler<CreateExperiencesCommand, CreateExperiencesViewModel>
    {
        private readonly IExperiencesRepository _ExperiencesRepository;
        private readonly IMapper _mapper;
        private readonly ICVsRepository _CVsRepository;
        public CreateExperiencesCommandHandler(IMapper mapper, IExperiencesRepository ExperiencesRepository, ICVsRepository CVsRepository)
        {
            _mapper = mapper;
            _ExperiencesRepository = ExperiencesRepository;
            _CVsRepository = CVsRepository;
        }
        public async Task<CreateExperiencesViewModel> Handle(CreateExperiencesCommand request, CancellationToken cancellationToken)
        {
            if (request.CvId.HasValue)
            {
                var cvs = await _CVsRepository.GetByIdAsync(request.CvId.Value);
                if (cvs == null)
                {
                    throw new NotFoundException(nameof(CVs), request.CvId);
                }
            }
            var entity = _mapper.Map<Experiences>(request);
            entity = await _ExperiencesRepository.AddAsync(entity, cancellationToken);
            CreateExperiencesViewModel response = new CreateExperiencesViewModel();
            response = _mapper.Map<Experiences, CreateExperiencesViewModel>(entity, response);
            return response;
        }
    }
}
