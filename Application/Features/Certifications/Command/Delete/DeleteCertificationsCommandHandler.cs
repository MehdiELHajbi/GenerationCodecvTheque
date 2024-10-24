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

    public class DeleteCertificationsCommandHandler : IRequestHandler<DeleteCertificationsCommand>{
     private readonly ICertificationsRepository _CertificationsRepository;
    private readonly IMapper _mapper;
     public DeleteCertificationsCommandHandler(IMapper mapper, ICertificationsRepository CertificationsRepository)
    {
     _mapper = mapper;
     _CertificationsRepository = CertificationsRepository;
     }
     public async Task<Unit> Handle(DeleteCertificationsCommand request, CancellationToken cancellationToken)
    {
    var entity = await _CertificationsRepository.GetByIdsAsync(request.CertificationID);
    if (entity == null)
    {
     throw new NotFoundException(nameof(Certifications), request.CertificationID);
    }
      await _CertificationsRepository.DeleteAsync(entity);
    return Unit.Value;
     }
    }
}
