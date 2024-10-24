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

    public class CreateCertificationsCommandHandler : IRequestHandler<CreateCertificationsCommand, CreateCertificationsViewModel>
    {
        private readonly ICertificationsRepository _CertificationsRepository;
        private readonly IMapper _mapper;
        private readonly ICVsRepository _CVsRepository;
        public CreateCertificationsCommandHandler(IMapper mapper, ICertificationsRepository CertificationsRepository, ICVsRepository CVsRepository)
        {
            _mapper = mapper;
            _CertificationsRepository = CertificationsRepository;
            _CVsRepository = CVsRepository;
        }
        public async Task<CreateCertificationsViewModel> Handle(CreateCertificationsCommand request, CancellationToken cancellationToken)
        {
            if (request.CvId.HasValue)
            {
                var cvs = await _CVsRepository.GetByIdAsync(request.CvId.Value);
                if (cvs == null)
                {
                    throw new NotFoundException(nameof(CVs), request.CvId);
                }
            }
            var entity = _mapper.Map<Certifications>(request);
            entity = await _CertificationsRepository.AddAsync(entity, cancellationToken);
            CreateCertificationsViewModel response = new CreateCertificationsViewModel();
            response = _mapper.Map<Certifications, CreateCertificationsViewModel>(entity, response);
            return response;
        }
    }
}
