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

    public class CreateCVLanguesCommandHandler : IRequestHandler<CreateCVLanguesCommand, CreateCVLanguesViewModel>
    {
        private readonly ICVLanguesRepository _CVLanguesRepository;
        private readonly IMapper _mapper;
        private readonly ICVsRepository _CVsRepository;
        private readonly ILanguesRepository _LanguesRepository;
        public CreateCVLanguesCommandHandler(IMapper mapper, ICVLanguesRepository CVLanguesRepository, ICVsRepository CVsRepository, ILanguesRepository LanguesRepository)
        {
            _mapper = mapper;
            _CVLanguesRepository = CVLanguesRepository;
            _CVsRepository = CVsRepository;
            _LanguesRepository = LanguesRepository;
        }
        public async Task<CreateCVLanguesViewModel> Handle(CreateCVLanguesCommand request, CancellationToken cancellationToken)
        {
            var cvs = await _CVsRepository.GetByIdAsync(request.CvId);
            if (cvs == null)
            {
                throw new NotFoundException(nameof(CVs), request.CvId);
            }
            var langues = await _LanguesRepository.GetByIdAsync(request.LangueID);
            if (langues == null)
            {
                throw new NotFoundException(nameof(Langues), request.LangueID);
            }
            var entity = _mapper.Map<CVLangues>(request);
            entity = await _CVLanguesRepository.AddAsync(entity, cancellationToken);
            CreateCVLanguesViewModel response = new CreateCVLanguesViewModel();
            response = _mapper.Map<CVLangues, CreateCVLanguesViewModel>(entity, response);
            return response;
        }
    }
}
