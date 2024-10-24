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

    public class UpdateCertificationsCommandHandler : IRequestHandler<UpdateCertificationsCommand, UpdateCertificationsViewModel>
    {
        private readonly ICertificationsRepository _CertificationsRepository;
        private readonly IMapper _mapper;
        private readonly ICVsRepository _CVsRepository;
        public UpdateCertificationsCommandHandler(IMapper mapper, ICertificationsRepository CertificationsRepository, ICVsRepository CVsRepository)
        {
            _mapper = mapper;
            _CertificationsRepository = CertificationsRepository;
            _CVsRepository = CVsRepository;
        }
        public async Task<UpdateCertificationsViewModel> Handle(UpdateCertificationsCommand request, CancellationToken cancellationToken)
        {
            if (request.CvId.HasValue)
            {
                var cvs = await _CVsRepository.GetByIdAsync(request.CvId.Value);
                if (cvs == null)
                {
                    throw new NotFoundException(nameof(CVs), request.CvId);
                }
            }
            var entity = await _CertificationsRepository.GetByIdsAsync(request.CertificationID);
            if (entity == null)
            {
                throw new NotFoundException(nameof(Certifications), request.CertificationID);
            }
            UpdateCertificationsViewModel response = new UpdateCertificationsViewModel();
            entity = _mapper.Map(request, entity);
            await _CertificationsRepository.UpdateAsync(entity);
            response = _mapper.Map<Certifications, UpdateCertificationsViewModel>(entity, response);
            return response;
        }
    }
}
